namespace GraficDisplay
{
    using GraphLib;

    partial class MainForm
    {
        PlotterDisplayEx display = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiAliasedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highQualityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalAutoscaledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticallyAlignedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticallyAlignedAutoscaledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledVerticalAutoscaledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiledHorizontalAutoscaledToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animatedGraphDemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSchemesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numGraphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.display = new GraphLib.PlotterDisplayEx();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.examplesToolStripMenuItem,
            this.colorSchemesToolStripMenuItem,
            this.numGraphsToolStripMenuItem});
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.layoutToolStripMenuItem.Text = "Settings";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.antiAliasedToolStripMenuItem,
            this.highQualityToolStripMenuItem,
            this.highSpeedToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // antiAliasedToolStripMenuItem
            // 
            this.antiAliasedToolStripMenuItem.Name = "antiAliasedToolStripMenuItem";
            this.antiAliasedToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.antiAliasedToolStripMenuItem.Text = "AntiAliased";
            this.antiAliasedToolStripMenuItem.Click += new System.EventHandler(this.antiAliasedToolStripMenuItem_Click);
            // 
            // highQualityToolStripMenuItem
            // 
            this.highQualityToolStripMenuItem.Name = "highQualityToolStripMenuItem";
            this.highQualityToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.highQualityToolStripMenuItem.Text = "High Quality";
            this.highQualityToolStripMenuItem.Click += new System.EventHandler(this.highQualityToolStripMenuItem_Click);
            // 
            // highSpeedToolStripMenuItem
            // 
            this.highSpeedToolStripMenuItem.Name = "highSpeedToolStripMenuItem";
            this.highSpeedToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.highSpeedToolStripMenuItem.Text = "High Speed";
            this.highSpeedToolStripMenuItem.Click += new System.EventHandler(this.highSpeedToolStripMenuItem_Click);
            // 
            // examplesToolStripMenuItem
            // 
            this.examplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.normalAutoscaledToolStripMenuItem,
            this.stackedToolStripMenuItem,
            this.verticallyAlignedToolStripMenuItem,
            this.verticallyAlignedAutoscaledToolStripMenuItem,
            this.tiledVerticalToolStripMenuItem,
            this.tiledVerticalAutoscaledToolStripMenuItem,
            this.tiledHorizontalToolStripMenuItem,
            this.tiledHorizontalAutoscaledToolStripMenuItem,
            this.animatedGraphDemoToolStripMenuItem});
            this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            this.examplesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.examplesToolStripMenuItem.Text = "Examples";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // normalAutoscaledToolStripMenuItem
            // 
            this.normalAutoscaledToolStripMenuItem.Name = "normalAutoscaledToolStripMenuItem";
            this.normalAutoscaledToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.normalAutoscaledToolStripMenuItem.Text = "Normal Autoscaled";
            this.normalAutoscaledToolStripMenuItem.Click += new System.EventHandler(this.normalAutoscaledToolStripMenuItem_Click);
            // 
            // stackedToolStripMenuItem
            // 
            this.stackedToolStripMenuItem.Name = "stackedToolStripMenuItem";
            this.stackedToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.stackedToolStripMenuItem.Text = "Stacked";
            this.stackedToolStripMenuItem.Click += new System.EventHandler(this.stackedToolStripMenuItem_Click_1);
            // 
            // verticallyAlignedToolStripMenuItem
            // 
            this.verticallyAlignedToolStripMenuItem.Name = "verticallyAlignedToolStripMenuItem";
            this.verticallyAlignedToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.verticallyAlignedToolStripMenuItem.Text = "Vertically Aligned";
            this.verticallyAlignedToolStripMenuItem.Click += new System.EventHandler(this.verticallyAlignedToolStripMenuItem_Click);
            // 
            // verticallyAlignedAutoscaledToolStripMenuItem
            // 
            this.verticallyAlignedAutoscaledToolStripMenuItem.Name = "verticallyAlignedAutoscaledToolStripMenuItem";
            this.verticallyAlignedAutoscaledToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.verticallyAlignedAutoscaledToolStripMenuItem.Text = "Vertically Aligned Autoscaled";
            this.verticallyAlignedAutoscaledToolStripMenuItem.Click += new System.EventHandler(this.verticallyAlignedAutoscaledToolStripMenuItem_Click);
            // 
            // tiledVerticalToolStripMenuItem
            // 
            this.tiledVerticalToolStripMenuItem.Name = "tiledVerticalToolStripMenuItem";
            this.tiledVerticalToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.tiledVerticalToolStripMenuItem.Text = "Tiled Vertical";
            this.tiledVerticalToolStripMenuItem.Click += new System.EventHandler(this.tiledVerticalToolStripMenuItem_Click);
            // 
            // tiledVerticalAutoscaledToolStripMenuItem
            // 
            this.tiledVerticalAutoscaledToolStripMenuItem.Name = "tiledVerticalAutoscaledToolStripMenuItem";
            this.tiledVerticalAutoscaledToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.tiledVerticalAutoscaledToolStripMenuItem.Text = "Tiled Vertical Autoscaled";
            this.tiledVerticalAutoscaledToolStripMenuItem.Click += new System.EventHandler(this.tiledVerticalAutoscaledToolStripMenuItem_Click);
            // 
            // tiledHorizontalToolStripMenuItem
            // 
            this.tiledHorizontalToolStripMenuItem.Name = "tiledHorizontalToolStripMenuItem";
            this.tiledHorizontalToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.tiledHorizontalToolStripMenuItem.Text = "Tiled Horizontal";
            this.tiledHorizontalToolStripMenuItem.Click += new System.EventHandler(this.tiledHorizontalToolStripMenuItem_Click);
            // 
            // tiledHorizontalAutoscaledToolStripMenuItem
            // 
            this.tiledHorizontalAutoscaledToolStripMenuItem.Name = "tiledHorizontalAutoscaledToolStripMenuItem";
            this.tiledHorizontalAutoscaledToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.tiledHorizontalAutoscaledToolStripMenuItem.Text = "Tiled Horizontal Autoscaled";
            this.tiledHorizontalAutoscaledToolStripMenuItem.Click += new System.EventHandler(this.tiledHorizontalAutoscaledToolStripMenuItem_Click);
            // 
            // animatedGraphDemoToolStripMenuItem
            // 
            this.animatedGraphDemoToolStripMenuItem.Name = "animatedGraphDemoToolStripMenuItem";
            this.animatedGraphDemoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.animatedGraphDemoToolStripMenuItem.Text = "Animated Graph Demo";
            this.animatedGraphDemoToolStripMenuItem.Click += new System.EventHandler(this.animatedGraphDemoToolStripMenuItem_Click);
            // 
            // colorSchemesToolStripMenuItem
            // 
            this.colorSchemesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.grayToolStripMenuItem,
            this.lightBlueToolStripMenuItem,
            this.blackToolStripMenuItem,
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.colorSchemesToolStripMenuItem.Name = "colorSchemesToolStripMenuItem";
            this.colorSchemesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.colorSchemesToolStripMenuItem.Text = "Color Schemes";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // grayToolStripMenuItem
            // 
            this.grayToolStripMenuItem.Name = "grayToolStripMenuItem";
            this.grayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grayToolStripMenuItem.Text = "Gray";
            this.grayToolStripMenuItem.Click += new System.EventHandler(this.grayToolStripMenuItem_Click);
            // 
            // lightBlueToolStripMenuItem
            // 
            this.lightBlueToolStripMenuItem.Name = "lightBlueToolStripMenuItem";
            this.lightBlueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lightBlueToolStripMenuItem.Text = "Light Blue";
            this.lightBlueToolStripMenuItem.Click += new System.EventHandler(this.lightBlueToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // numGraphsToolStripMenuItem
            // 
            this.numGraphsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.numGraphsToolStripMenuItem.Name = "numGraphsToolStripMenuItem";
            this.numGraphsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.numGraphsToolStripMenuItem.Text = "Num Graphs";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItem7.Text = "6";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.Color.White;
            this.display.BackgroundColorBot = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.display.BackgroundColorTop = System.Drawing.Color.Navy;
            this.display.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.display.DashedGridColor = System.Drawing.Color.Blue;
            this.display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display.DoubleBuffering = true;
            this.display.Location = new System.Drawing.Point(0, 24);
            this.display.Name = "display";
            this.display.PlaySpeed = 0.5F;
            this.display.Size = new System.Drawing.Size(620, 472);
            this.display.SolidGridColor = System.Drawing.Color.Blue;
            this.display.TabIndex = 1;
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 496);
            this.Controls.Add(this.display);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "GraphLib Demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiAliasedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highQualityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticallyAlignedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalAutoscaledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledVerticalAutoscaledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiledHorizontalAutoscaledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticallyAlignedAutoscaledToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSchemesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numGraphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem grayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animatedGraphDemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;

    }
}

