using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ArduDebug
{
    public partial class FormConfiguration : Form
    {
        clsParser Parser = new clsParser();
        public FormConfiguration()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            lblArduinoFolder.Text = clsConfiguration.ArduinoExePath;
            lblArduinoPreferences.Text = clsConfiguration.ArduinoPrefFile;

            HighlighNotValidPath();
        }

        void HighlighNotValidPath()
        {
            lblArduionexeCaption.ForeColor = lblArduinoFolder.ForeColor = clsConfiguration.CheckArduinoExePath() ? Color.Blue : Color.Red;
            lblArduinoConfigCaption.ForeColor = lblArduinoPreferences.ForeColor = clsConfiguration.CheckArduinoConfigurationPath() ? Color.Blue : Color.Red;
        }

        private void btnBrowseArduinoPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Arduino exe file (arduino.exe)|arduino.exe";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                clsConfiguration.ArduinoExePath = dlg.FileName;
                lblArduinoFolder.Text = clsConfiguration.ArduinoExePath;
            }

            HighlighNotValidPath();
        }

        private void btnBrowseArduinoPreferencesPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "Arduino preference (preferences.txt)|preferences.txt";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                clsConfiguration.ArduinoPrefFile = dlg.FileName;
                lblArduinoPreferences.Text = clsConfiguration.ArduinoPrefFile;
                Parser.SetArduinoBuildFolder();
            }

            HighlighNotValidPath();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
