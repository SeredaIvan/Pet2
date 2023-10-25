using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursova
{
    partial class Page_Info
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
            button2 = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBoxNight = new PictureBox();
            pictureBoxDay = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDay).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(1713, 738);
            button2.Name = "button2";
            button2.Size = new Size(177, 103);
            button2.TabIndex = 5;
            button2.Text = "Наступна сторінка";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonNext_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(12, 738);
            button1.Name = "button1";
            button1.Size = new Size(177, 103);
            button1.TabIndex = 4;
            button1.Text = "Попередня сторінка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonPreviev_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(12, 70);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1878, 662);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(64, 64);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ProgTech.Properties.Resources.icon_back_button2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(pictureBoxNight);
            panel2.Controls.Add(pictureBoxDay);
            panel2.Location = new Point(1838, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(64, 64);
            panel2.TabIndex = 6;
            // 
            // pictureBoxNight
            // 
            pictureBoxNight.BackColor = SystemColors.ButtonHighlight;
            pictureBoxNight.Image = ProgTech.Properties.Resources.moon;
            pictureBoxNight.Location = new Point(0, 0);
            pictureBoxNight.Name = "pictureBoxNight";
            pictureBoxNight.Size = new Size(64, 64);
            pictureBoxNight.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxNight.TabIndex = 1;
            pictureBoxNight.TabStop = false;
            pictureBoxNight.Click += pictureBox3_Click;
            // 
            // pictureBoxDay
            // 
            pictureBoxDay.BackColor = Color.Black;
            pictureBoxDay.Image = ProgTech.Properties.Resources.sun;
            pictureBoxDay.Location = new Point(0, 0);
            pictureBoxDay.Name = "pictureBoxDay";
            pictureBoxDay.Size = new Size(64, 64);
            pictureBoxDay.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDay.TabIndex = 0;
            pictureBoxDay.TabStop = false;
            pictureBoxDay.Visible = false;
            pictureBoxDay.Click += pictureBox2_Click;
            // 
            // Page_Info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 853);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Name = "Page_Info";
            StartPosition = FormStartPosition.Manual;
            Text = "s";
            FormClosing += Page_Info_FormClosing;
            Load += Page_Info_Loadd;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxNight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDay).EndInit();
            ResumeLayout(false);
        }

        private void Page_Info_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonPreviev_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button button2;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBoxNight;
        private PictureBox pictureBoxDay;
    }
}