using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace ArduDebugInterface
{
    public delegate void EventNewData(float Read);

    public class clsArduinoReader
    {
        private const byte ESCAPE_CAR = 0xFF;
        private const byte INIT_CAR = 0x02;
        private const byte END_CAR = 0x03;

        private List<clsVariableInfo> VarList = new List<clsVariableInfo>();

        private SerialPort mySerialPort;
        private string Com;

        private bool m_Isopen = false;
        private bool m_IsRead = false;

        private byte[] MessbufferWrite = new byte[3000];
        private byte[] MessBufferRead = new byte[3000];
        private byte[] TempnewData = new byte[3000];

        private bool TrasmissionPending = false;
        private bool SpecialCar = false;
        private int index;

        private int SizeAllVarData = 0;

        public object lockobj = new object();

        public bool OpenSerial(string ComToConnect)
        {
            try
            {
                Com = ComToConnect;
                mySerialPort = new SerialPort(Com);

                mySerialPort.BaudRate = 57600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                mySerialPort.Handshake = Handshake.None;

                // uncomment for Arduino Leonardo
                //mySerialPort.RtsEnable = true;
                //mySerialPort.DtrEnable = true;

                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                mySerialPort.ErrorReceived += new SerialErrorReceivedEventHandler(mySerialPort_ErrorReceived);

                mySerialPort.ReadTimeout = 1000;
                mySerialPort.Open();

                IsOpen = true;

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public void CloseSerial()
        {
            try
            {
                if (mySerialPort != null)
                {
                    mySerialPort.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
                    mySerialPort.ErrorReceived -= new SerialErrorReceivedEventHandler(mySerialPort_ErrorReceived);

                    mySerialPort.Dispose();
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                mySerialPort = null;
                IsOpen = false;
            }
        }

        public void SetVarList(List<clsVariableInfo> VarListToSet)
        {
            VarList = VarListToSet;

            SendMessageVarWatch(VarList);
        }

        public void SendMessageRateWatch(UInt16 RateToSet)
        {
            int counter = 0;
            byte[] buffer = new byte[2 + 1];

            buffer[counter++] = (byte)('R');

            byte[] bufferdata = BitConverter.GetBytes(RateToSet);

            buffer[counter++] = bufferdata[0];
            buffer[counter++] = bufferdata[1];

            WriteSerial(buffer);
        }

        public void SendMessageForceVar(clsVariableInfo var, byte[] data)
        {
            int counter = 0;
            byte[] buffer = new byte[data.Length + 1 + 2];

            buffer[counter++] = (byte)('F');

            byte[] bufferaddress = BitConverter.GetBytes((UInt16)var.Address);
            buffer[counter++] = bufferaddress[0];
            buffer[counter++] = bufferaddress[1];

            for (int i = 0; i < data.Length; i++)
            {
                buffer[counter++] = data[i];
            }
            
            WriteSerial(buffer);
        }

        #region PRIVATE METHODS

        private void SendMessageVarWatch(List<clsVariableInfo> VarListToSet)
        {
            int counter = 0;
            byte[] buffer = new byte[VarListToSet.Count*3+1];

            SizeAllVarData = 0;

            buffer[counter++] = (byte)('V');

            foreach (clsVariableInfo ele in VarListToSet)
            {
                byte[] buffersize = BitConverter.GetBytes((byte)ele.Size);
                byte[] bufferaddress = BitConverter.GetBytes((UInt16)ele.Address);

                buffer[counter++] = buffersize[0];
                buffer[counter++] = bufferaddress[0];
                buffer[counter++] = bufferaddress[1];

                SizeAllVarData += ele.Size;
            }

            WriteSerial(buffer);
        }


        private void WriteSerial(byte[] bufferwrite)
        {
            if (IsOpen)
            {
                int i;
                int counter = 0;

                MessbufferWrite[counter++] = ESCAPE_CAR;
                MessbufferWrite[counter++] = INIT_CAR;

                for ( i = 0; i < bufferwrite.Length; i++)
                {
                    MessbufferWrite[counter++] = bufferwrite[i];

                    if (bufferwrite[i] == ESCAPE_CAR)
                    {
                        MessbufferWrite[counter++] = ESCAPE_CAR;
                    }
                }

                MessbufferWrite[counter++] = ESCAPE_CAR;
                MessbufferWrite[counter++] = END_CAR;

                mySerialPort.Write(MessbufferWrite, 0, counter);
            }
        }


        private void RebootSerial()
        {
            try
            {
                CloseSerial();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                OpenSerial(Com);
            }
        }

        private void mySerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            RebootSerial();
        }

        private static byte[] GetBytes(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }
    

        private void ParseMessage(byte[] MessBuffer, int size)
        {
            lock(lockobj)
            {
                if (SizeAllVarData == size)
                {
                    int indexbuffer = 0;
                    foreach(clsVariableInfo Var in VarList)
                    {
                        byte[] result = new byte[Var.Size];
                        Array.Copy(MessBuffer, indexbuffer, result, 0, Var.Size);

                        Var.UpdateValFromBytes(result);

                        indexbuffer += Var.Size;
                    }
                }     
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            int toread = sp.BytesToRead;

            try
            {
                int i;

                while((toread = sp.BytesToRead) > 0)
                {
                    if (toread > TempnewData.Length)
                    {
                        toread = TempnewData.Length;
                    }

                    int numread = sp.Read(TempnewData, 0, toread);

                    if (numread > 0)
                    {
                        for (i = 0; i < numread; i++)
                        {
                            if (SpecialCar)
                            {
                                switch(TempnewData[i])
                                {
                                    case END_CAR:
                                        if (index > 0)
                                        {
                                            ParseMessage(MessBufferRead, index);
                                        }
                                        m_IsRead = true;
                                        TrasmissionPending = false;
                                        break;

                                    case INIT_CAR:
                                        TrasmissionPending = true;
                                        index = 0;
                                        break;

                                    default:
                                        if (TrasmissionPending)
                                        {
                                            MessBufferRead[index++] = TempnewData[i];
                                        }
                                        break;
                                }

                                SpecialCar = false;
                            }
                            else
                            {
                                if (TempnewData[i] == ESCAPE_CAR)
                                {
                                    SpecialCar = true;
                                }
                                else
                                {
                                    if (TrasmissionPending)
                                    {
                                        MessBufferRead[index++] = TempnewData[i];
                                    }      
                                }
                            }

                        }
                    }

                }

            }
            catch(Exception ex)
            {
                RebootSerial();
            }
        }

        #endregion

        #region FIELDS
        public bool IsOpen
        {
            get
            {
                lock (this)
                {
                    return m_Isopen;
                }
            }
            set
            {
                lock (this)
                {
                    m_Isopen = value;
                }
            }
        }

        public bool IsRead
        {
            get
            {
                lock (this)
                {
                    return m_IsRead;
                }
            }
            set
            {
                lock (this)
                {
                    m_IsRead = value;
                }
            }            
        }

        #endregion

    }
}
