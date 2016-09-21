using System;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

using GraphLib;

namespace ArduDebugInterface
{
    public partial class FormViewWatchVar : Form
    {
        clsArduinoReader ReaderArduino;
        clsVariableInfo Item = null;
        string[] TempBuffer = new string[10000];
        bool AllowGraph = false;

        public FormViewWatchVar()
        {
            InitializeComponent();  
        }

        private void InitGraph()
        {
            SuspendLayout();

            display.DataSources.Clear();
            display.SetDisplayRangeX(0, 400);

            display.DataSources.Add(new DataSource());
            display.DataSources[0].Name = Item.VarName;
            display.DataSources[0].OnRenderXAxisLabel += RenderXLabel;

            display.PanelLayout = PlotterGraphPaneEx.LayoutMode.TILES_HOR;
            display.DataSources[0].Length = Item.ActBufferSize;        
            


            if (Item.ActBufferSize > 0)
            {
                float valueAct = float.Parse(Item.GetStringValue(Item.ActBufferSize -1));
                display.DataSources[0].SetDisplayRangeY(valueAct - 1, valueAct + 1);
            }
            else
            {
                display.DataSources[0].SetDisplayRangeY(-1, 1);
            }

            display.DataSources[0].AutoScaleY = false;
            display.DataSources[0].AutoScaleX = false;
            display.DataSources[0].XAutoScaleOffset = 50;
            FillGraph(display.DataSources[0]);
            display.DataSources[0].OnRenderYAxisLabel = RenderYLabel;

            timer1.Start();
        }

        protected void FillGraph(DataSource ds)
        {
            float min = float.MaxValue;
            float max = float.MinValue;
            float temp;

            int size = Item.ActBufferSize;
            ds.Length = size;
            cPoint[] src = ds.Samples;
            for (int i = 0; i < size; i++)
            {
                src[i].x = i;
                src[i].y = temp = Item.GetFloatValue(i);

                if (temp < min) min = temp;
                if (temp > max) max = temp;
            }

            display.DataSources[0].SetDisplayRangeY(min, max);
            display.DataSources[0].SetGridDistanceY((float)(max- min) / (float)10);

            display.SetDisplayRangeX(0,(float)size);
            display.SetGridDistanceX((float)size / (float)10);
        }

        private void SetDataGrid()
        {
            display.SetGridDistanceX((float)Item.ActBufferSize / (float)10);
        }

        private String RenderXLabel(DataSource s, int idx)
        {
            if (s.AutoScaleX)
            {
                int Value = (int)(s.Samples[idx].x);
                return "" + Value;
            }
            else
            {
                int Value = (int)(s.Samples[idx].x / 200);
                String Label = "" + Value + "\"";
                return Label;
            }
        }

        private String RenderYLabel(DataSource s, float value)
        {
            return String.Format("{0:0.0}", value);
        }

        public void SetItem(clsVariableInfo ItemToSet, clsArduinoReader ReaderArduinoToSet)
        {
            ReaderArduino = ReaderArduinoToSet;

            if (ItemToSet != null)
            {
                Item = ItemToSet;

                lblVarName.Text = Item.VarName;
                lblSize.Text = Item.Size.ToString();

                txtForceValue.Text = Item.GetStringValue();

                AllowGraph = !(Item.IsArray || Item.IsString);

                if (AllowGraph)
                {
                    InitGraph();
                }


                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (Item != null)
                {
                    lblValue.Text = Item.GetStringValue();

                    if (AllowGraph && chkUpdateChart.Checked)
                    {
                        FillGraph(display.DataSources[0]);
                    }
                }

                this.Invoke(new MethodInvoker(RefreshGraph));
            }
            catch (ObjectDisposedException ex)
            {
                // we get this on closing of form
            }
            catch (Exception ex)
            {
            } 
        }

        private void RefreshGraph()
        {
            display.Refresh();
        }

        private void btnForce_Click(object sender, EventArgs e)
        {
            long valuelong;
            float valuefloat;
            bool validvalue = false;

            if (Item.IsFloat)
            {
                if (float.TryParse(txtForceValue.Text,NumberStyles.Float, CultureInfo.CreateSpecificCulture("en-US"), out valuefloat))
                {
                    byte[] data = clsVariableInfo.getBytes(valuefloat, Item.Size);
                    ReaderArduino.SendMessageForceVar(Item, data);
                    validvalue = true;
                }
            }
            else
            {
                if (Item.IsArray)
                {
                    string[] elelist = txtForceValue.Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    byte[] newdata = new byte[elelist.Length];

                    validvalue = true;

                    for (int i = 0; i < newdata.Length; i++)
                    {
                        if (!byte.TryParse(elelist[i],out newdata[i]))
                        {
                            validvalue = false;
                            break;
                        }
                    }

                    if (validvalue)
                    {
                        ReaderArduino.SendMessageForceVar(Item, newdata);
                    }
                }
                else
                {
                    if (Item.IsString)
                    {
                        string temp = txtForceValue.Text.Substring(0, txtForceValue.Text.Length > Item.Size -1 ? Item.Size - 1 : txtForceValue.Text.Length);
                        byte[] toBytes = Encoding.ASCII.GetBytes(temp);
                        Array.Resize(ref toBytes, toBytes.Length + 1);
                        toBytes[toBytes.Length - 1] = 0;
                        ReaderArduino.SendMessageForceVar(Item, toBytes);
                        validvalue = true;
                    }
                    else
                    {
                        if (long.TryParse(txtForceValue.Text, out valuelong))
                        {
                            byte[] data = clsVariableInfo.getBytes(valuelong, Item.Size);
                            ReaderArduino.SendMessageForceVar(Item, data);
                            validvalue = true;
                        }
                    }

                }

            }

            if (!validvalue)
            {
                MessageBox.Show("Value not valid", "Error");
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            dlg.Filter = "csv data file (*.csv)|*.csv";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(dlg.FileName,false))
                {
                    for (int i = 0; i < Item.ActBufferSize; i++)
                    {
                        // If the line doesn't contain the word 'Second', write the line to the file.
                        file.WriteLine(Item.GetStringValue(i));
                    }
                }
            }

        }
    }
}
