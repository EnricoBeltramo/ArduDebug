namespace ArduDebugInterface
{
    partial class FormViewWatchVar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVarName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtForceValue = new System.Windows.Forms.TextBox();
            this.btnForce = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkUpdateChart = new System.Windows.Forms.CheckBox();
            this.display = new GraphLib.PlotterDisplayEx();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(67, 56);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(14, 17);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Size:";
            // 
            // lblVarName
            // 
            this.lblVarName.AutoSize = true;
            this.lblVarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarName.Location = new System.Drawing.Point(67, 25);
            this.lblVarName.Name = "lblVarName";
            this.lblVarName.Size = new System.Drawing.Size(14, 17);
            this.lblVarName.TabIndex = 6;
            this.lblVarName.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Variable:";
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.Location = new System.Drawing.Point(67, 87);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(14, 17);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Value:";
            // 
            // txtForceValue
            // 
            this.txtForceValue.Location = new System.Drawing.Point(338, 22);
            this.txtForceValue.Name = "txtForceValue";
            this.txtForceValue.Size = new System.Drawing.Size(354, 20);
            this.txtForceValue.TabIndex = 11;
            // 
            // btnForce
            // 
            this.btnForce.Location = new System.Drawing.Point(712, 20);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(56, 23);
            this.btnForce.TabIndex = 12;
            this.btnForce.Text = "Force it!";
            this.btnForce.UseVisualStyleBackColor = true;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Force Value:";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(693, 86);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveToFile.TabIndex = 14;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSaveToFile);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblVarName);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnForce);
            this.splitContainer1.Panel1.Controls.Add(this.lblSize);
            this.splitContainer1.Panel1.Controls.Add(this.txtForceValue);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.lblValue);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chkUpdateChart);
            this.splitContainer1.Panel2.Controls.Add(this.display);
            this.splitContainer1.Size = new System.Drawing.Size(790, 573);
            this.splitContainer1.SplitterDistance = 123;
            this.splitContainer1.TabIndex = 16;
            // 
            // chkUpdateChart
            // 
            this.chkUpdateChart.AutoSize = true;
            this.chkUpdateChart.Checked = true;
            this.chkUpdateChart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdateChart.Location = new System.Drawing.Point(707, 3);
            this.chkUpdateChart.Name = "chkUpdateChart";
            this.chkUpdateChart.Size = new System.Drawing.Size(61, 17);
            this.chkUpdateChart.TabIndex = 15;
            this.chkUpdateChart.Text = "Update";
            this.chkUpdateChart.UseVisualStyleBackColor = true;
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.Transparent;
            this.display.BackgroundColorBot = System.Drawing.Color.White;
            this.display.BackgroundColorTop = System.Drawing.Color.White;
            this.display.DashedGridColor = System.Drawing.Color.DarkGray;
            this.display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display.DoubleBuffering = true;
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.PlaySpeed = 0.5F;
            this.display.Size = new System.Drawing.Size(790, 446);
            this.display.SolidGridColor = System.Drawing.Color.DarkGray;
            this.display.TabIndex = 0;
            // 
            // FormViewWatchVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 573);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormViewWatchVar";
            this.Text = "View variable";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtForceValue;
        private System.Windows.Forms.Button btnForce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private GraphLib.PlotterDisplayEx display;
        private System.Windows.Forms.CheckBox chkUpdateChart;
    }
}