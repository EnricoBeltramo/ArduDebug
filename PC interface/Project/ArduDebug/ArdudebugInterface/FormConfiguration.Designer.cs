namespace ArduDebugInterface
{
    partial class FormConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguration));
            this.lblArduinoFolder = new System.Windows.Forms.Label();
            this.btnBrowseArduinoPath = new System.Windows.Forms.Button();
            this.btnBrowseArduinoPreferencesPath = new System.Windows.Forms.Button();
            this.lblArduinoPreferences = new System.Windows.Forms.Label();
            this.lblArduinoConfigCaption = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblArduionexeCaption = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArduinoFolder
            // 
            this.lblArduinoFolder.AutoSize = true;
            this.lblArduinoFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArduinoFolder.Location = new System.Drawing.Point(226, 41);
            this.lblArduinoFolder.Name = "lblArduinoFolder";
            this.lblArduinoFolder.Size = new System.Drawing.Size(14, 17);
            this.lblArduinoFolder.TabIndex = 1;
            this.lblArduinoFolder.Text = "-";
            // 
            // btnBrowseArduinoPath
            // 
            this.btnBrowseArduinoPath.Location = new System.Drawing.Point(16, 37);
            this.btnBrowseArduinoPath.Name = "btnBrowseArduinoPath";
            this.btnBrowseArduinoPath.Size = new System.Drawing.Size(190, 34);
            this.btnBrowseArduinoPath.TabIndex = 2;
            this.btnBrowseArduinoPath.Text = "Select Arduino exe file";
            this.btnBrowseArduinoPath.UseVisualStyleBackColor = true;
            this.btnBrowseArduinoPath.Click += new System.EventHandler(this.btnBrowseArduinoPath_Click);
            // 
            // btnBrowseArduinoPreferencesPath
            // 
            this.btnBrowseArduinoPreferencesPath.Location = new System.Drawing.Point(16, 372);
            this.btnBrowseArduinoPreferencesPath.Name = "btnBrowseArduinoPreferencesPath";
            this.btnBrowseArduinoPreferencesPath.Size = new System.Drawing.Size(190, 37);
            this.btnBrowseArduinoPreferencesPath.TabIndex = 4;
            this.btnBrowseArduinoPreferencesPath.Text = "Select Arduino configuration file";
            this.btnBrowseArduinoPreferencesPath.UseVisualStyleBackColor = true;
            this.btnBrowseArduinoPreferencesPath.Click += new System.EventHandler(this.btnBrowseArduinoPreferencesPath_Click);
            // 
            // lblArduinoPreferences
            // 
            this.lblArduinoPreferences.AutoSize = true;
            this.lblArduinoPreferences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArduinoPreferences.Location = new System.Drawing.Point(226, 379);
            this.lblArduinoPreferences.Name = "lblArduinoPreferences";
            this.lblArduinoPreferences.Size = new System.Drawing.Size(14, 17);
            this.lblArduinoPreferences.TabIndex = 3;
            this.lblArduinoPreferences.Text = "-";
            // 
            // lblArduinoConfigCaption
            // 
            this.lblArduinoConfigCaption.AutoSize = true;
            this.lblArduinoConfigCaption.Location = new System.Drawing.Point(13, 349);
            this.lblArduinoConfigCaption.Name = "lblArduinoConfigCaption";
            this.lblArduinoConfigCaption.Size = new System.Drawing.Size(346, 13);
            this.lblArduinoConfigCaption.TabIndex = 5;
            this.lblArduinoConfigCaption.Text = "Arduino preference file path (ensure Arduino exe closed before change):";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(691, 622);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 42);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblArduionexeCaption
            // 
            this.lblArduionexeCaption.AutoSize = true;
            this.lblArduionexeCaption.Location = new System.Drawing.Point(13, 9);
            this.lblArduionexeCaption.Name = "lblArduionexeCaption";
            this.lblArduionexeCaption.Size = new System.Drawing.Size(94, 13);
            this.lblArduionexeCaption.TabIndex = 7;
            this.lblArduionexeCaption.Text = "Arduino EXE path:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(173, 564);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(279, 415);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(369, 221);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(16, 415);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 184);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(16, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 243);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 676);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblArduionexeCaption);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblArduinoConfigCaption);
            this.Controls.Add(this.btnBrowseArduinoPreferencesPath);
            this.Controls.Add(this.lblArduinoPreferences);
            this.Controls.Add(this.btnBrowseArduinoPath);
            this.Controls.Add(this.lblArduinoFolder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguration";
            this.Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblArduinoFolder;
        private System.Windows.Forms.Button btnBrowseArduinoPath;
        private System.Windows.Forms.Button btnBrowseArduinoPreferencesPath;
        private System.Windows.Forms.Label lblArduinoPreferences;
        private System.Windows.Forms.Label lblArduinoConfigCaption;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblArduionexeCaption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}