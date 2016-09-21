namespace ArduDebugInterface
{
    partial class FormAddVarView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioString = new System.Windows.Forms.RadioButton();
            this.radioByteArray = new System.Windows.Forms.RadioButton();
            this.radioFloat = new System.Windows.Forms.RadioButton();
            this.radioUlong = new System.Windows.Forms.RadioButton();
            this.radioLong = new System.Windows.Forms.RadioButton();
            this.radioShort = new System.Windows.Forms.RadioButton();
            this.radioUshort = new System.Windows.Forms.RadioButton();
            this.radioByte = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVarName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioString);
            this.groupBox1.Controls.Add(this.radioByteArray);
            this.groupBox1.Controls.Add(this.radioFloat);
            this.groupBox1.Controls.Add(this.radioUlong);
            this.groupBox1.Controls.Add(this.radioLong);
            this.groupBox1.Controls.Add(this.radioShort);
            this.groupBox1.Controls.Add(this.radioUshort);
            this.groupBox1.Controls.Add(this.radioByte);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Watch As:";
            // 
            // radioString
            // 
            this.radioString.AutoSize = true;
            this.radioString.Location = new System.Drawing.Point(16, 248);
            this.radioString.Name = "radioString";
            this.radioString.Size = new System.Drawing.Size(50, 17);
            this.radioString.TabIndex = 7;
            this.radioString.TabStop = true;
            this.radioString.Text = "string";
            this.radioString.UseVisualStyleBackColor = true;
            // 
            // radioByteArray
            // 
            this.radioByteArray.AutoSize = true;
            this.radioByteArray.Location = new System.Drawing.Point(16, 283);
            this.radioByteArray.Name = "radioByteArray";
            this.radioByteArray.Size = new System.Drawing.Size(71, 17);
            this.radioByteArray.TabIndex = 6;
            this.radioByteArray.TabStop = true;
            this.radioByteArray.Text = "byte array";
            this.radioByteArray.UseVisualStyleBackColor = true;
            // 
            // radioFloat
            // 
            this.radioFloat.AutoSize = true;
            this.radioFloat.Location = new System.Drawing.Point(16, 213);
            this.radioFloat.Name = "radioFloat";
            this.radioFloat.Size = new System.Drawing.Size(45, 17);
            this.radioFloat.TabIndex = 5;
            this.radioFloat.TabStop = true;
            this.radioFloat.Text = "float";
            this.radioFloat.UseVisualStyleBackColor = true;
            // 
            // radioUlong
            // 
            this.radioUlong.AutoSize = true;
            this.radioUlong.Location = new System.Drawing.Point(16, 178);
            this.radioUlong.Name = "radioUlong";
            this.radioUlong.Size = new System.Drawing.Size(91, 17);
            this.radioUlong.TabIndex = 4;
            this.radioUlong.TabStop = true;
            this.radioUlong.Text = "unsigned long";
            this.radioUlong.UseVisualStyleBackColor = true;
            // 
            // radioLong
            // 
            this.radioLong.AutoSize = true;
            this.radioLong.Location = new System.Drawing.Point(16, 143);
            this.radioLong.Name = "radioLong";
            this.radioLong.Size = new System.Drawing.Size(45, 17);
            this.radioLong.TabIndex = 3;
            this.radioLong.TabStop = true;
            this.radioLong.Text = "long";
            this.radioLong.UseVisualStyleBackColor = true;
            // 
            // radioShort
            // 
            this.radioShort.AutoSize = true;
            this.radioShort.Location = new System.Drawing.Point(16, 73);
            this.radioShort.Name = "radioShort";
            this.radioShort.Size = new System.Drawing.Size(36, 17);
            this.radioShort.TabIndex = 2;
            this.radioShort.TabStop = true;
            this.radioShort.Text = "int";
            this.radioShort.UseVisualStyleBackColor = true;
            // 
            // radioUshort
            // 
            this.radioUshort.AutoSize = true;
            this.radioUshort.Location = new System.Drawing.Point(16, 108);
            this.radioUshort.Name = "radioUshort";
            this.radioUshort.Size = new System.Drawing.Size(82, 17);
            this.radioUshort.TabIndex = 1;
            this.radioUshort.TabStop = true;
            this.radioUshort.Text = "unsigned int";
            this.radioUshort.UseVisualStyleBackColor = true;
            // 
            // radioByte
            // 
            this.radioByte.AutoSize = true;
            this.radioByte.Location = new System.Drawing.Point(16, 38);
            this.radioByte.Name = "radioByte";
            this.radioByte.Size = new System.Drawing.Size(45, 17);
            this.radioByte.TabIndex = 0;
            this.radioByte.TabStop = true;
            this.radioByte.Text = "byte";
            this.radioByte.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Variable";
            // 
            // lblVarName
            // 
            this.lblVarName.AutoSize = true;
            this.lblVarName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarName.Location = new System.Drawing.Point(74, 9);
            this.lblVarName.Name = "lblVarName";
            this.lblVarName.Size = new System.Drawing.Size(14, 17);
            this.lblVarName.TabIndex = 2;
            this.lblVarName.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(74, 37);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(14, 17);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "-";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(13, 422);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 36);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(198, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "bytes";
            // 
            // FormAddVarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 470);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVarName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddVarView";
            this.Text = "Add new variable";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioByteArray;
        private System.Windows.Forms.RadioButton radioFloat;
        private System.Windows.Forms.RadioButton radioUlong;
        private System.Windows.Forms.RadioButton radioLong;
        private System.Windows.Forms.RadioButton radioShort;
        private System.Windows.Forms.RadioButton radioUshort;
        private System.Windows.Forms.RadioButton radioByte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radioString;
        private System.Windows.Forms.Label label3;
    }
}