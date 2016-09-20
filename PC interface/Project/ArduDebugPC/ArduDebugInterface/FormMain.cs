using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace ArduDebug
{
    public partial class FormMain : Form
    {
        const int TIMEOUT = 10000;

        private ToolTip toolTip1;

        clsArduinoReader ReaderArduino = new clsArduinoReader();
        clsParser Parser = new clsParser();

        string[] PrevportsList = new string[1];
        bool PrevComStatus = false;
        int countertimeout = 0;
        
        public FormMain()
        {
            InitializeComponent();
            InitControls();
            InitFolders();
            InitPortList();
            InitListView();
            InitArduinoConfig();
        }

        void InitControls()
        {
            toolTip1 = new ToolTip(components);
        }

        void InitArduinoConfig()
        {
            bool ValidPath = true;

            if (!clsConfiguration.CheckArduinoExePath())
            {
                ValidPath = false;
            }

            if (!clsConfiguration.CheckArduinoConfigurationPath())
            {
                ValidPath = false;
            }
            else
            {
                Parser.SetArduinoBuildFolder();
            }
            
            if (!ValidPath)
            {
                MessageBox.Show("Some configuration path are not valid, please configure them");

                OpenConfigurationForm();
            }
        }

        void InitListView()
        {
            listViewAllVars.Clear();

            listViewAllVars.Columns.Add("Id",50);
            listViewAllVars.Columns.Add("Name", 200);
            listViewAllVars.Columns.Add("Size", 100);
            listViewAllVars.Columns.Add("Addess", 100);

            listViewVarDebug.Clear();

            listViewVarDebug.Columns.Add("Id", 50);
            listViewVarDebug.Columns.Add("Name", 200);
            listViewVarDebug.Columns.Add("Size", 80);
            listViewVarDebug.Columns.Add("Addess", 80);
            listViewVarDebug.Columns.Add("Type", 80);
            listViewVarDebug.Columns.Add("value", 100);
        }

        void InitFolders()
        {
            clsConfiguration.InitWorkingFolders();
        }

        bool CheckPortList()
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            cmbSerialPorts.Items.Clear();

            // Display each port name to the console.
            foreach (string port in ports)
            {
                if (port == cmbSerialPorts.Text)
                {
                    return true;
                }
            }

            return false;
        }


        void InitPortList()
        {
            bool Update = false;

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            if (ports.Length != PrevportsList.Length)
            {
                Update = true;
            }
            else
            {
                // Display each port name to the console.
                for (int i = 0; i < ports.Length; i++ )
                {
                    if (!ports[i].Equals(PrevportsList[i]))
                    {
                        Update = true;
                        break;
                    }
                }
            }

            if (Update)
            {
                string SelectedCOM = clsConfiguration.COMValue;

                cmbSerialPorts.Items.Clear();

                // Display each port name to the console.
                foreach (string port in ports)
                {
                    cmbSerialPorts.Items.Add(port);

                    if (SelectedCOM == port)
                    {
                        cmbSerialPorts.SelectedItem = port;
                    }
                }

                if (cmbSerialPorts.Items.Count > 0)
                {
                    btnConnectSerial.Enabled = true;
                }
                else
                {
                    cmbSerialPorts.Items.Add("NO PORT");
                    btnConnectSerial.Enabled = false;
                }

                PrevportsList = ports;
            }
        }

        private void UpdateWatchView()
        {
            lock (ReaderArduino.lockobj)
            {
                foreach (ListViewItem item in listViewVarDebug.Items)
                {
                    clsVariableInfo ele = item.Tag as clsVariableInfo;

                    if (ele != null)
                    {
                        item.SubItems[5].Text = ele.GetStringValue();
                    }
                }
            }
            
        }

        private void SetSerialButtonText(bool Force = false)
        {
            if (PrevComStatus != ReaderArduino.IsOpen)
            {
                if (ReaderArduino.IsOpen)
                {
                    btnConnectSerial.Text = "Disconnect";
                    cmbSerialPorts.Enabled = false;
                    lblStatusSerial.Text = "ONLINE";

                    txtRate.Enabled = true;
                    btnSetRate.Enabled = true;
                }
                else
                {
                    btnConnectSerial.Text = "Connect";
                    cmbSerialPorts.Enabled = true;
                    lblStatusSerial.Text = "OFFLINE";
                    lblTimeout.Visible = false;

                    txtRate.Enabled = false;
                    btnSetRate.Enabled = false;
                }

                PrevComStatus = ReaderArduino.IsOpen;
            }

            if (!ReaderArduino.IsOpen)
            {
                InitPortList();
            }
        }

        private void ParseFile()
        {
            List<clsVariableInfo> VarList = Parser.ParseMapFile();

            lblFileName.Text = Parser.ParsedFile;

            FillListViewAllVars(VarList);
        }

        void FillListViewAllVars(List<clsVariableInfo> VarList)
        {
            int Counter = 0;
            listViewAllVars.Items.Clear();

            foreach(clsVariableInfo Var in VarList)
            {
                ListViewItem Item = new ListViewItem((++Counter).ToString());

                Item.Tag = Var;
                Item.SubItems.Add(Var.VarName);
                Item.SubItems.Add(Var.Size.ToString());
                Item.SubItems.Add("0x" + Var.Address.ToString("X"));

                listViewAllVars.Items.Add(Item);
            }
        }

        void AddListViewWatchVar(clsVariableInfo VarToAdd)
        {
            if (listViewVarDebug.Items.Count < 5)
            {
                ListViewItem Item = new ListViewItem((listViewVarDebug.Items.Count + 1).ToString());

                Item.Tag = VarToAdd;
                Item.SubItems.Add(VarToAdd.VarName);
                Item.SubItems.Add(VarToAdd.Size.ToString());
                Item.SubItems.Add("0x" + VarToAdd.Address.ToString("X"));
                Item.SubItems.Add(VarToAdd.TypeName);
                Item.SubItems.Add("");

                listViewVarDebug.Items.Add(Item);

                UpdateVarDebug();
                CheckEnableButtonRemove();
            }
            else
            {
                MessageBox.Show("Max 5 variables");
            }

        }


        void CheckEnableButtonRemove()
        {
            if (listViewVarDebug.SelectedItems != null && listViewVarDebug.SelectedItems.Count > 0)
            {
                btnRemovesSelect.Enabled = true;
            }
            else
            {
                btnRemovesSelect.Enabled = false;
            }
        }

        void UpdateVarDebug()
        {
            List<clsVariableInfo> VarList = new List<clsVariableInfo>();

            foreach (ListViewItem ele in listViewVarDebug.Items)
            {
                clsVariableInfo var = ele.Tag as clsVariableInfo;

                if (var != null)
                {
                    VarList.Add(var);
                }
            }

            ReaderArduino.SetVarList(VarList);
        }

        void OpenConfigurationForm()
        {
            FormConfiguration frm = new FormConfiguration();

            frm.ShowDialog();
        }

        #region EVENTS

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetSerialButtonText();

            if (ReaderArduino.IsRead)
            {
                lblTimeout.Visible = false;
                ReaderArduino.IsRead = false;
                countertimeout = 0;

                UpdateWatchView();
            }
            else
            {
                countertimeout++;
                if (countertimeout > TIMEOUT / timer1.Interval)
                {

                    if (ReaderArduino.IsOpen)
                    {
                        lblTimeout.Visible = true;
                    }
                }
            }
        }


        private void btnConnectSerial_Click(object sender, EventArgs e)
        {
            if (!ReaderArduino.IsOpen)
            {
                clsConfiguration.COMValue = cmbSerialPorts.Text;
                ParseFile();
                ReaderArduino.OpenSerial(cmbSerialPorts.Text);
            }
            else
            {
                ReaderArduino.CloseSerial();
                countertimeout = TIMEOUT + 1;
            }

            SetSerialButtonText();
        }
        private void configurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenConfigurationForm();
        }


        private void listViewAllVars_DoubleClick(object sender, EventArgs e)
        {
            if (listViewAllVars.SelectedItems != null && listViewAllVars.SelectedItems.Count > 0)
            {
                clsVariableInfo var = listViewAllVars.SelectedItems[0].Tag as clsVariableInfo;
                FormAddVarView frmAddVAr = new FormAddVarView();

                frmAddVAr.SetItem(var);
                frmAddVAr.ShowDialog();

                if (frmAddVAr.IsConfirmed)
                {
                    AddListViewWatchVar(var);
                }
            }
        }

        private void listViewVarDebug_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            CheckEnableButtonRemove();
        }

        private void btnRemovesSelect_Click(object sender, EventArgs e)
        {
            if (listViewVarDebug.SelectedItems != null && listViewVarDebug.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in listViewVarDebug.SelectedItems)
                {
                    listViewVarDebug.Items.Remove(item);
                }

                UpdateVarDebug();
                CheckEnableButtonRemove();
            } 
        }


        private void listViewAllVars_MouseEnter(object sender, EventArgs e)
        {
            Control rtb = (sender as Control);
            if (rtb != null)
            {
                if (listViewAllVars.Items.Count > 0)
                {
                    toolTip1.Show("Double Click to add a variable to watch", rtb);
                }  
            }
        }

        private void listViewAllVars_MouseLeave(object sender, EventArgs e)
        {
            Control rtb = (sender as Control);
            if (rtb != null)
            {
                toolTip1.Hide(rtb);
            }
        }

        private void btnSetRate_Click(object sender, EventArgs e)
        {
            UInt16 newRate = 0;

            if (UInt16.TryParse(txtRate.Text,out newRate) && newRate <= 32000)
            {
                ReaderArduino.SendMessageRateWatch(newRate);
            }
            else
            {
                MessageBox.Show("Set a valid Rate (range 0-32000 ms)","Error");
            }
        }

        private void listViewVarDebug_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewVarDebug.SelectedItems != null && listViewVarDebug.SelectedItems.Count > 0)
            {
                clsVariableInfo var = listViewVarDebug.SelectedItems[0].Tag as clsVariableInfo;
                FormViewWatchVar frmViewVar = new FormViewWatchVar();

                frmViewVar.SetItem(var, ReaderArduino);
                frmViewVar.Show();

            }
        }

        private void listViewVarDebug_MouseEnter(object sender, EventArgs e)
        {
            Control rtb = (sender as Control);
            if (rtb != null)
            {
                if (listViewAllVars.Items.Count > 0)
                {
                    toolTip1.Show("Double Click to watch or force variable", rtb);
                }
            }
        }

        private void listViewVarDebug_MouseLeave(object sender, EventArgs e)
        {
            Control rtb = (sender as Control);
            if (rtb != null)
            {
                toolTip1.Hide(rtb);
            }
        }
        #endregion
    }
}
