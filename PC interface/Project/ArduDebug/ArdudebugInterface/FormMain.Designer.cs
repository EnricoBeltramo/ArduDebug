namespace ArduDebugInterface
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStatusSerial = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnectSerial = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetRate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewAllVars = new System.Windows.Forms.ListView();
            this.listViewVarDebug = new System.Windows.Forms.ListView();
            this.btnRemovesSelect = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox9.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblStatusSerial
            // 
            this.lblStatusSerial.AutoSize = true;
            this.lblStatusSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusSerial.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblStatusSerial.Location = new System.Drawing.Point(779, 6);
            this.lblStatusSerial.Name = "lblStatusSerial";
            this.lblStatusSerial.Size = new System.Drawing.Size(27, 37);
            this.lblStatusSerial.TabIndex = 10;
            this.lblStatusSerial.Text = "-";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFileName.Location = new System.Drawing.Point(781, 91);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(19, 26);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.Text = "-";
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(180, 13);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(179, 33);
            this.cmbSerialPorts.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Serial Port";
            // 
            // btnConnectSerial
            // 
            this.btnConnectSerial.Enabled = false;
            this.btnConnectSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectSerial.Location = new System.Drawing.Point(425, 10);
            this.btnConnectSerial.Name = "btnConnectSerial";
            this.btnConnectSerial.Size = new System.Drawing.Size(184, 42);
            this.btnConnectSerial.TabIndex = 16;
            this.btnConnectSerial.Text = "Connect";
            this.btnConnectSerial.UseVisualStyleBackColor = true;
            this.btnConnectSerial.Click += new System.EventHandler(this.btnConnectSerial_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(699, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 26);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Status";
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeout.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTimeout.Location = new System.Drawing.Point(969, 6);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(200, 37);
            this.lblTimeout.TabIndex = 20;
            this.lblTimeout.Text = "( TIMEOUT )";
            this.lblTimeout.Visible = false;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label4);
            this.groupBox9.Controls.Add(this.txtRate);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.btnSetRate);
            this.groupBox9.Controls.Add(this.btnConnectSerial);
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.cmbSerialPorts);
            this.groupBox9.Location = new System.Drawing.Point(14, 7);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(659, 110);
            this.groupBox9.TabIndex = 21;
            this.groupBox9.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Rate:";
            // 
            // txtRate
            // 
            this.txtRate.Enabled = false;
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(96, 61);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 32);
            this.txtRate.TabIndex = 23;
            this.txtRate.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "ms";
            // 
            // btnSetRate
            // 
            this.btnSetRate.Enabled = false;
            this.btnSetRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetRate.Location = new System.Drawing.Point(268, 57);
            this.btnSetRate.Name = "btnSetRate";
            this.btnSetRate.Size = new System.Drawing.Size(113, 39);
            this.btnSetRate.TabIndex = 25;
            this.btnSetRate.Text = "Set Rate";
            this.btnSetRate.UseVisualStyleBackColor = true;
            this.btnSetRate.Click += new System.EventHandler(this.btnSetRate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem1});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.configurationToolStripMenuItem.Text = "File";
            // 
            // configurationToolStripMenuItem1
            // 
            this.configurationToolStripMenuItem1.Name = "configurationToolStripMenuItem1";
            this.configurationToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem1.Text = "Configuration";
            this.configurationToolStripMenuItem1.Click += new System.EventHandler(this.configurationToolStripMenuItem1_Click);
            // 
            // listViewAllVars
            // 
            this.listViewAllVars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAllVars.FullRowSelect = true;
            this.listViewAllVars.GridLines = true;
            this.listViewAllVars.Location = new System.Drawing.Point(0, 0);
            this.listViewAllVars.MultiSelect = false;
            this.listViewAllVars.Name = "listViewAllVars";
            this.listViewAllVars.Size = new System.Drawing.Size(517, 587);
            this.listViewAllVars.TabIndex = 23;
            this.listViewAllVars.UseCompatibleStateImageBehavior = false;
            this.listViewAllVars.View = System.Windows.Forms.View.Details;
            this.listViewAllVars.DoubleClick += new System.EventHandler(this.listViewAllVars_DoubleClick);
            this.listViewAllVars.MouseEnter += new System.EventHandler(this.listViewAllVars_MouseEnter);
            this.listViewAllVars.MouseLeave += new System.EventHandler(this.listViewAllVars_MouseLeave);
            // 
            // listViewVarDebug
            // 
            this.listViewVarDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewVarDebug.FullRowSelect = true;
            this.listViewVarDebug.GridLines = true;
            this.listViewVarDebug.Location = new System.Drawing.Point(0, 0);
            this.listViewVarDebug.MultiSelect = false;
            this.listViewVarDebug.Name = "listViewVarDebug";
            this.listViewVarDebug.Size = new System.Drawing.Size(647, 586);
            this.listViewVarDebug.TabIndex = 24;
            this.listViewVarDebug.UseCompatibleStateImageBehavior = false;
            this.listViewVarDebug.View = System.Windows.Forms.View.Details;
            this.listViewVarDebug.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewVarDebug_ItemSelectionChanged);
            this.listViewVarDebug.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewVarDebug_MouseDoubleClick);
            this.listViewVarDebug.MouseEnter += new System.EventHandler(this.listViewVarDebug_MouseEnter);
            this.listViewVarDebug.MouseLeave += new System.EventHandler(this.listViewVarDebug_MouseLeave);
            // 
            // btnRemovesSelect
            // 
            this.btnRemovesSelect.Enabled = false;
            this.btnRemovesSelect.Location = new System.Drawing.Point(355, 19);
            this.btnRemovesSelect.Name = "btnRemovesSelect";
            this.btnRemovesSelect.Size = new System.Drawing.Size(75, 23);
            this.btnRemovesSelect.TabIndex = 25;
            this.btnRemovesSelect.Text = "Remove select";
            this.btnRemovesSelect.UseVisualStyleBackColor = true;
            this.btnRemovesSelect.Click += new System.EventHandler(this.btnRemovesSelect_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.lblStatusSerial);
            this.splitContainer1.Panel1.Controls.Add(this.lblFileName);
            this.splitContainer1.Panel1.Controls.Add(this.lbl1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox9);
            this.splitContainer1.Panel1.Controls.Add(this.lblTimeout);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1172, 786);
            this.splitContainer1.SplitterDistance = 136;
            this.splitContainer1.TabIndex = 26;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1172, 646);
            this.splitContainer2.SplitterDistance = 519;
            this.splitContainer2.TabIndex = 26;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listViewAllVars);
            this.splitContainer3.Size = new System.Drawing.Size(517, 644);
            this.splitContainer3.SplitterDistance = 53;
            this.splitContainer3.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "All variables";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            this.splitContainer4.Panel1.Controls.Add(this.btnRemovesSelect);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.listViewVarDebug);
            this.splitContainer4.Size = new System.Drawing.Size(647, 644);
            this.splitContainer4.SplitterDistance = 54;
            this.splitContainer4.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 26);
            this.label2.TabIndex = 26;
            this.label2.Text = "Watch variables";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(699, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sketch";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 810);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Arduino Debugger";
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStatusSerial;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnectSerial;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem1;
        private System.Windows.Forms.ListView listViewAllVars;
        private System.Windows.Forms.ListView listViewVarDebug;
        private System.Windows.Forms.Button btnRemovesSelect;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetRate;
        private System.Windows.Forms.Label label6;
    }
}

