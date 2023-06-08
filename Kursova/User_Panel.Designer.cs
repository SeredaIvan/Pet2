namespace Kursova
{
    partial class User_Panel
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel4 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(372, 216);
            progressBar1.Margin = new Padding(0);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(353, 40);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 43);
            label1.Name = "label1";
            label1.Size = new Size(130, 54);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ProgTech.Properties.Resources.user;
            pictureBox1.Location = new Point(67, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Silver;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(372, 170);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 4;
            label3.Text = "Прогресс";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(64, 64);
            panel1.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.DimGray;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = ProgTech.Properties.Resources.icon_back_button2;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 7;
            label2.Text = "Ім'я користувача";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(285, 105);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 8;
            label4.Text = "Id користувача";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(369, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 125);
            panel2.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(-1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(364, 453);
            panel3.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(-36, 382);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 94);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DimGray;
            panel6.Location = new Point(148, 55);
            panel6.Margin = new Padding(20, 3, 20, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(550, 14);
            panel6.TabIndex = 20;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DimGray;
            panel8.Location = new Point(228, 15);
            panel8.Margin = new Padding(20, 3, 20, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(518, 14);
            panel8.TabIndex = 19;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DimGray;
            panel7.Location = new Point(89, 35);
            panel7.Margin = new Padding(20, 3, 20, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(582, 14);
            panel7.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(panel15);
            panel4.Controls.Add(panel16);
            panel4.Controls.Add(panel17);
            panel4.Location = new Point(606, 289);
            panel4.Name = "panel4";
            panel4.Size = new Size(282, 125);
            panel4.TabIndex = 11;
            // 
            // panel15
            // 
            panel15.BackColor = Color.DimGray;
            panel15.Location = new Point(49, 75);
            panel15.Margin = new Padding(20, 3, 20, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(580, 14);
            panel15.TabIndex = 20;
            // 
            // panel16
            // 
            panel16.BackColor = Color.DimGray;
            panel16.Location = new Point(-186, 55);
            panel16.Margin = new Padding(20, 3, 20, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(580, 14);
            panel16.TabIndex = 18;
            // 
            // panel17
            // 
            panel17.BackColor = Color.DimGray;
            panel17.Location = new Point(97, 35);
            panel17.Margin = new Padding(20, 3, 20, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(580, 14);
            panel17.TabIndex = 19;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DimGray;
            panel9.Location = new Point(357, 296);
            panel9.Margin = new Padding(20, 3, 20, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(179, 14);
            panel9.TabIndex = 23;
            // 
            // panel10
            // 
            panel10.BackColor = Color.DimGray;
            panel10.Location = new Point(357, 276);
            panel10.Margin = new Padding(20, 3, 20, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(129, 14);
            panel10.TabIndex = 21;
            // 
            // panel11
            // 
            panel11.BackColor = Color.DimGray;
            panel11.Location = new Point(357, 256);
            panel11.Margin = new Padding(20, 0, 20, 3);
            panel11.Name = "panel11";
            panel11.Size = new Size(227, 14);
            panel11.TabIndex = 22;
            // 
            // User_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel9);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel10);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(panel11);
            Name = "User_Panel";
            Text = "User_Panel";
            FormClosing += User_Panel_FormClosing;
            Load += User_Panel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel8;
        private Panel panel7;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
    }
}