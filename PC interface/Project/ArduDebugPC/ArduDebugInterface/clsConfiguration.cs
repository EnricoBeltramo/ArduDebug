using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Management;


namespace ArduDebug
{
    public class clsConfiguration
    {
        const string ARDUDEBUGWORKPATH = "\\ArduDebug";
        const string BUILDPATH = "\\Build";
        const string XMLFILE = "\\Config.xml";

        const string CONFIGKEY_COMSET = "COMSelect";
        const string CONFIGKEY_ARDUINOFOLDER = "ArduinoFolder";
        const string CONFIGKEY_ARDUINOPREFFILE = "ArduinoPreferences";

        static public string ArduinoExePath
        {
            get
            {
                return ReadKeyValue(CONFIGKEY_ARDUINOFOLDER);
            }
            set
            {
                WriteKeyValue(CONFIGKEY_ARDUINOFOLDER, value);
            }
        }

        static public string ArduinoPrefFile
        {
            get
            {
                return ReadKeyValue(CONFIGKEY_ARDUINOPREFFILE);
            }
            set
            {
                WriteKeyValue(CONFIGKEY_ARDUINOPREFFILE, value);
            }
        }

        static public string COMValue
        {
            get
            {
                return ReadKeyValue(CONFIGKEY_COMSET);
            }
            set
            {
                WriteKeyValue(CONFIGKEY_COMSET,value);
            }
        }

        static private string ConfigFile
        {
            get
            {
                return  Path.GetDirectoryName(Application.ExecutablePath) + XMLFILE;
            }
        }

        static public string WorkingPath
        {
            get
            {
                return Environment.GetEnvironmentVariable("userprofile") + ARDUDEBUGWORKPATH;
            }
        }

        static public string BuildFolder
        {
            get
            {
                return WorkingPath + BUILDPATH;
            }
        }

        static public bool CheckArduinoExePath()
        {
            return File.Exists(ArduinoExePath);
        }

        static public bool CheckArduinoConfigurationPath()
        {
            return File.Exists(ArduinoPrefFile);
        }

        static public void InitWorkingFolders()
        {
            if (!Directory.Exists(WorkingPath))
            {
                Directory.CreateDirectory(WorkingPath);
            }

            if (!Directory.Exists(BuildFolder))
            {
                Directory.CreateDirectory(BuildFolder);
            }
        }

        static private string ReadKeyValue(string keyname)
        {
            try
            {
                // Read a particular key from the config file            
                //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigFile);
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                return (string)config.AppSettings.Settings[keyname].Value;
            }
            catch
            {
                return "";
            }
        }

        static private void WriteKeyValue(string keyname, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath); // ConfigurationManager.OpenExeConfiguration(ConfigFile);

                config.AppSettings.Settings[keyname].Value = value;
                config.Save(ConfigurationSaveMode.Modified, true);
            }
            catch
            {
            }
        }

    }
}
