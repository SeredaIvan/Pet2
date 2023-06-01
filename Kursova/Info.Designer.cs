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
            flowLayoutPanelAside = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanelInfo = new FlowLayoutPanel();
            labelH1 = new Label();
            labelP = new Label();
            pictureBox = new PictureBox();
            panel1 = new Panel();
            buttonPreviev = new Button();
            buttonNext = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanelAside);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1902, 1033);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanelAside
            // 
            flowLayoutPanelAside.BackColor = Color.DarkGray;
            flowLayoutPanelAside.Location = new Point(3, 3);
            flowLayoutPanelAside.Name = "flowLayoutPanelAside";
            flowLayoutPanelAside.Size = new Size(250, 1030);
            flowLayoutPanelAside.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Black;
            flowLayoutPanel2.Controls.Add(flowLayoutPanelInfo);
            flowLayoutPanel2.Controls.Add(panel1);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(259, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1631, 1018);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanelInfo
            // 
            flowLayoutPanelInfo.BackColor = Color.DarkGray;
            flowLayoutPanelInfo.Controls.Add(labelH1);
            flowLayoutPanelInfo.Controls.Add(labelP);
            flowLayoutPanelInfo.Controls.Add(pictureBox);
            flowLayoutPanelInfo.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelInfo.Location = new Point(3, 3);
            flowLayoutPanelInfo.Name = "flowLayoutPanelInfo";
            flowLayoutPanelInfo.Size = new Size(1628, 857);
            flowLayoutPanelInfo.TabIndex = 0;
            // 
            // labelH1
            // 
            labelH1.AutoSize = true;
            labelH1.BackColor = Color.Silver;
            labelH1.Location = new Point(50, 50);
            labelH1.Margin = new Padding(50);
            labelH1.Name = "labelH1";
            labelH1.Size = new Size(40, 20);
            labelH1.TabIndex = 0;
            labelH1.Text = "refer";
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.BackColor = Color.Silver;
            labelP.Location = new Point(50, 170);
            labelP.Margin = new Padding(50);
            labelP.Name = "labelP";
            labelP.Size = new Size(37, 20);
            labelP.TabIndex = 1;
            labelP.Text = "ewd";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(50, 290);
            pictureBox.Margin = new Padding(50);
            pictureBox.MaximumSize = new Size(600, 400);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(125, 125);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonPreviev);
            panel1.Controls.Add(buttonNext);
            panel1.Location = new Point(3, 866);
            panel1.Name = "panel1";
            panel1.Size = new Size(1628, 137);
            panel1.TabIndex = 1;
            // 
            // buttonPreviev
            // 
            buttonPreviev.BackColor = Color.Black;
            buttonPreviev.ForeColor = Color.White;
            buttonPreviev.Location = new Point(0, 44);
            buttonPreviev.Name = "buttonPreviev";
            buttonPreviev.Size = new Size(135, 55);
            buttonPreviev.TabIndex = 1;
            buttonPreviev.Text = "Previvev";
            buttonPreviev.UseVisualStyleBackColor = false;
            buttonPreviev.Click += button1_Click;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.Black;
            buttonNext.ForeColor = Color.White;
            buttonNext.Location = new Point(1490, 44);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(135, 55);
            buttonNext.TabIndex = 0;
            buttonNext.Text = "Next";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += buttonNext_Click_1;
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(flowLayoutPanel1);
            Name = "Info";
            Text = "Info";
            FormClosing += Info_FormClosing;
            Load += Info_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanelInfo.ResumeLayout(false);
            flowLayoutPanelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanelAside;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanelInfo;
        private Panel panel1;
        private Button buttonNext;
        private Button buttonPreviev;
        private Label labelH1;
        private Label labelP;
        private PictureBox pictureBox;
    }
}