namespace Kursova
{
    partial class Info
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanelMain = new FlowLayoutPanel();
            flowLayoutPanelAside = new FlowLayoutPanel();
            panelInfo = new Panel();
            flowLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanelMain
            // 
            flowLayoutPanelMain.Controls.Add(flowLayoutPanelAside);
            flowLayoutPanelMain.Controls.Add(panelInfo);
            flowLayoutPanelMain.Location = new Point(12, 12);
            flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            flowLayoutPanelMain.Size = new Size(1878, 1009);
            flowLayoutPanelMain.TabIndex = 1;
            flowLayoutPanelMain.Paint += flowLayoutPanelMain_Paint;
            // 
            // flowLayoutPanelAside
            // 
            flowLayoutPanelAside.BackColor = SystemColors.ButtonShadow;
            flowLayoutPanelAside.Location = new Point(3, 3);
            flowLayoutPanelAside.Name = "flowLayoutPanelAside";
            flowLayoutPanelAside.Size = new Size(300, 1006);
            flowLayoutPanelAside.TabIndex = 0;
            // 
            // panelInfo
            // 
            panelInfo.Location = new Point(309, 3);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(1556, 1006);
            panelInfo.TabIndex = 1;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(flowLayoutPanelMain);
            Controls.Add(flowLayoutPanel1);
            Name = "Info";
            Text = "Info";
            FormClosing += Info_FormClosing;
            Load += Info_Load;
            flowLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanelMain;
        private FlowLayoutPanel flowLayoutPanelAside;
        private Panel panelInfo;
    }
}