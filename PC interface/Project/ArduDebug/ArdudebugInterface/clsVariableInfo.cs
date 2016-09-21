using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ArduDebugInterface
{
    public class clsVariableInfo
    {
        public string VarName;
        public UInt32 Address;
        public int Size;

        private List<object> BufferData = new List<object>();
        private bool m_IsByteArray = false;
        private bool m_IsString = false;
        private bool m_IsFloat = false;
        private object m_val = null;
        private string m_typename = "";

        private int m_BufferSize = 2000;

        public void Settype(object typetoset)
        {
            m_typename = typetoset.GetType().Name;
            m_val = typetoset;

            m_IsByteArray = false;
            m_IsString = false;
            m_IsFloat = false;

            if (m_typename == "Byte[]")
            {
                m_IsByteArray = true;
            }
            else
            {
                if (m_typename == "Single")
                {
                    m_IsFloat = true;
                }
                else
                {
                    if (m_typename == "String")
                    {
                        m_IsString = true;
                    }
                }
            }

            BufferData = new List<object>();
        }

        private void SetBufferSize()
        {
            if (BufferData.Count > m_BufferSize)
            {
                BufferData.RemoveRange(0, BufferData.Count - m_BufferSize);
            }
        }

        public int MaxBufferSize
        {
            get
            {
                return m_BufferSize;
            }
            set
            {
                m_BufferSize = value;
                SetBufferSize();
            }
        }

        public int ActBufferSize
        {
            get
            {
                return BufferData.Count;
            }
        }

        public string TypeName
        {
            get
            {
                return m_typename;
            }
        }

        public bool IsArray
        {
            get
            {
                return m_IsByteArray;
            }
        }

        public bool IsFloat
        {
            get
            {
                return m_IsFloat;
            }
        }

        public bool IsString
        {
            get
            {
                return m_IsString;
            }
        }

        private object lockobj = new object();

        public void UpdateValFromBytes(byte[] arraydata)
        {
            lock(lockobj)
            {
                if (m_IsByteArray)
                {
                    m_val = new byte[Size];
                    Array.Copy(arraydata, 0, (byte[])m_val, 0, Size);
                }
                else
                {
                    if (m_IsString)
                    {
                        m_val = Encoding.ASCII.GetString(arraydata);
                    }
                    else
                    {
                        m_val = fromBytes(arraydata, m_val);
                    }
                }

                BufferData.Add(m_val);
                SetBufferSize();
            }

        }

        public float GetFloatValue(int index)
        {
            try
            {
                return Convert.ToSingle(BufferData[index]);
            }
            catch
            {
                return 0;
            }
        }

        public string GetStringValue(int index = -1)
        {
            if (index < 0)
            {
                return GetStringValue(m_val);
            }
            else
            {
                return GetStringValue(BufferData[index]);
            }         
        }

        private string GetStringValue(object valueget)
        {
            if (m_IsByteArray)
            {
                string result = "";
                byte[] temp = (byte[])valueget;

                for (int i = 0; i < Size; i++)
                {
                    result += temp[i].ToString() + " ";
                }

                return result;
            }
            else
            {
                return valueget.ToString();
            }
        }


        public static byte[] getBytes(object str, int len = 0)
        {
            try
            {
                int size;
                if (len == 0)
                {
                    size = Marshal.SizeOf(str);
                }
                else
                {
                    size = len;
                }

                byte[] arr = new byte[size];

                IntPtr ptr = Marshal.AllocHGlobal(size);
                Marshal.StructureToPtr(str, ptr, true);
                Marshal.Copy(ptr, arr, 0, size);
                Marshal.FreeHGlobal(ptr);

                return arr;
            }
            catch
            {
                return null;
            }

            
        }

        public static object fromBytes(byte[] arr, object ele, int len = 0)
        {
            try
            {
                int size;

                if (len == 0)
                {
                    size = Marshal.SizeOf(ele);
                }
                else
                {
                    size = len;
                }

                IntPtr ptr = Marshal.AllocHGlobal(size);

                Marshal.Copy(arr, 0, ptr, size);

                ele = Marshal.PtrToStructure(ptr, ele.GetType());
                Marshal.FreeHGlobal(ptr);
            }
            catch
            {

            }


            return ele;
        }
    }
}
