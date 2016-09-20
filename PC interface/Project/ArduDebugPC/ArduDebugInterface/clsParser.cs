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
    public class clsParser
    {
        private List<clsVariableInfo> VarList = new List<clsVariableInfo>();
        private string m_sketchname = "";

        public void SetArduinoBuildFolder()
        {
            try
            {
                string FolderPref = Path.GetDirectoryName(clsConfiguration.ArduinoPrefFile);

                if (!File.Exists(FolderPref + "\\Preference.backup.txt"))
                {
                    File.Copy(clsConfiguration.ArduinoPrefFile, FolderPref + "\\Preference.backup.txt");
                }

                string[] lines = File.ReadAllLines(clsConfiguration.ArduinoPrefFile);
                bool toupdate = false;
                bool missing = true;

                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("build.path="))
                    {
                        if (lines[i] != "build.path=" + clsConfiguration.BuildFolder)
                        {
                            lines[i] = "build.path=" + clsConfiguration.BuildFolder;
                            toupdate = true;  
                        }
                        missing = false;
                        break;
                    }
                }

                if (missing)
                {
                    Array.Resize(ref lines, lines.Length + 1);
                    lines[lines.Length - 1] = "newvalue";
                    toupdate = true;
                }

                if (toupdate)
                {
                    
                    if (MessageBox.Show("Please ensure that Arduino Executable is closed before click \"OK\" ", "Error", MessageBoxButtons.OK) == DialogResult.Cancel)
                    {
                        return;
                    }
                    File.WriteAllLines(clsConfiguration.ArduinoPrefFile, lines);
                    MessageBox.Show("Arduino build folder configured");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        public List<clsVariableInfo> ParseMapFile()
        {
            string MapFile = CreateMapFile();

            VarList.Clear();

            try
            {
                if (File.Exists(MapFile))
                {  
                    bool SymboltableFound = false;
                    string line;

                    // Read the file and display it line by line.
                    System.IO.StreamReader file = new System.IO.StreamReader(MapFile);

                    while ((line = file.ReadLine()) != null)
                    {
                        if (SymboltableFound)
                        {
                            if (line.Contains(".bss"))
                            {
                                string[] Elements = line.Split(new string[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);

                                if (Elements[1].Trim() == "g" && Elements[2].Trim() == "O" && Elements[3].Trim() == ".bss")
                                {
                                    clsVariableInfo NewVar = new clsVariableInfo();

                                    if (UInt32.TryParse(Elements[0], NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat, out NewVar.Address) && int.TryParse(Elements[4], NumberStyles.HexNumber, CultureInfo.InvariantCulture.NumberFormat, out NewVar.Size))
                                    {
                                        NewVar.Address = NewVar.Address - 0x800000;
                                        NewVar.VarName = Elements[5];

                                        VarList.Add(NewVar);
                                    }
                                   
                                }
                            }     
                        }
                        else
                        {
                            if (line.Contains("SYMBOL TABLE:"))
                            {
                                SymboltableFound = true;
                            }
                        }
                    }

                    file.Close();
                }
            }
            catch
            {

            }

            return VarList;

        }

        #region PRIVATE METHODS
        private string CreateMapFile()
        {
            string BatchCommand = "";

            try
            {
                string[] ElffilesList = Directory.GetFiles(clsConfiguration.BuildFolder, "*.elf");

                if (ElffilesList.Length >= 1)
                {
                    m_sketchname = Path.GetFileName(ElffilesList[0]).Replace(".elf", "");

                    string batchfile = clsConfiguration.WorkingPath + "\\map.bat";
                    string elffilepath = ElffilesList[0];

                    BatchCommand = MapGenerateCommand(elffilepath);

                    File.Delete(MapFileName);
                    File.Delete(batchfile);
                    File.WriteAllText(batchfile, BatchCommand);

                    ProcessStartInfo ProcStartInfo = new ProcessStartInfo("cmd");
                    ProcStartInfo.UseShellExecute = false;
                    ProcStartInfo.CreateNoWindow = true;
                    Process MyProcess = new Process();
                    ProcStartInfo.Arguments = "/c " + PathCommand(batchfile);
                    MyProcess.StartInfo = ProcStartInfo;
                    MyProcess.Start();
                    MyProcess.WaitForExit();



                    return MapFileName;
                }
                else
                {
                    MessageBox.Show("Elf file not found: try to rebuild Arduino sketch or check configuration", "Error");
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private string MapGenerateCommand(string ElfFileName)
        {
            return PathCommand(ArvDump) + " -t " + PathCommand(ElfFileName) + ">> " + PathCommand(MapFileName);
        }

        private string PathCommand(string pathtoset)
        {
            return "\"" + pathtoset + "\"";
        }

        private string ArduinoFolder
        {
            get
            {
                return Path.GetDirectoryName(clsConfiguration.ArduinoExePath);
            }
        }
        #endregion

        #region FIELDS
        private string ArvDump
        {
            get
            {
                try
                {
                    return ArduinoFolder + "\\hardware\\tools\\avr\\bin\\avr-objdump.exe";
                }
                catch
                {
                    return "";
                }
            }
        }

        public string ParsedFile
        {
            get
            {
                return m_sketchname;
            }
        }


        private string MapFileName
        {
            get
            {
                return clsConfiguration.WorkingPath + "\\mapfile.txt";
            }
        }

        #endregion

    }


}
