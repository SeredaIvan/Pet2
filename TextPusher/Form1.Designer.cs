using System;
using System.Drawing;
using System.Windows.Forms;

namespace TextPusher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBoxTEXT = new TextBox();
            textBoxDB = new TextBox();
            textBoxNUMB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonScanImg = new Button();
            pictureBox1 = new PictureBox();
            textBoxID = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxNUMB2 = new TextBox();
            textBoxTEXT2 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 362);
            button1.Name = "button1";
            button1.Size = new Size(765, 76);
            button1.TabIndex = 0;
            button1.Text = "Присвоїти значення";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxTEXT
            // 
            textBoxTEXT.Location = new Point(23, 122);
            textBoxTEXT.Multiline = true;
            textBoxTEXT.Name = "textBoxTEXT";
            textBoxTEXT.ScrollBars = ScrollBars.Vertical;
            textBoxTEXT.Size = new Size(168, 234);
            textBoxTEXT.TabIndex = 2;
            // 
            // textBoxDB
            // 
            textBoxDB.Location = new Point(23, 89);
            textBoxDB.Name = "textBoxDB";
            textBoxDB.Size = new Size(125, 27);
            textBoxDB.TabIndex = 3;
            // 
            // textBoxNUMB
            // 
            textBoxNUMB.Location = new Point(167, 32);
            textBoxNUMB.Name = "textBoxNUMB";
            textBoxNUMB.Size = new Size(125, 27);
            textBoxNUMB.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 66);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 5;
            label1.Text = "Назва таблиці";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(167, 7);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "Стопець 1";
            // 
            // buttonScanImg
            // 
            buttonScanImg.Location = new Point(380, 32);
            buttonScanImg.Name = "buttonScanImg";
            buttonScanImg.Size = new Size(324, 29);
            buttonScanImg.TabIndex = 7;
            buttonScanImg.Text = "ScanImg";
            buttonScanImg.UseVisualStyleBackColor = true;
            buttonScanImg.Click += buttonScanImg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(382, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 290);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(298, 32);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(32, 27);
            textBoxID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(298, 7);
            label3.Name = "label3";
            label3.Size = new Size(22, 20);
            label3.TabIndex = 10;
            label3.Text = "id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(167, 66);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 11;
            label4.Text = "Стопець 2";
            // 
            // textBoxNUMB2
            // 
            textBoxNUMB2.Location = new Point(167, 89);
            textBoxNUMB2.Name = "textBoxNUMB2";
            textBoxNUMB2.Size = new Size(125, 27);
            textBoxNUMB2.TabIndex = 12;
            // 
            // textBoxTEXT2
            // 
            textBoxTEXT2.Location = new Point(197, 122);
            textBoxTEXT2.Multiline = true;
            textBoxTEXT2.Name = "textBoxTEXT2";
            textBoxTEXT2.ScrollBars = ScrollBars.Vertical;
            textBoxTEXT2.Size = new Size(179, 234);
            textBoxTEXT2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(23, 7);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 14;
            label5.Text = "Назва Бази данних";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(298, 87);
            button2.Name = "button2";
            button2.Size = new Size(78, 29);
            button2.TabIndex = 16;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(710, 32);
            button3.Name = "button3";
            button3.Size = new Size(78, 29);
            button3.TabIndex = 17;
            button3.Text = "ClearImg";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(336, 32);
            button4.Name = "button4";
            button4.Size = new Size(40, 29);
            button4.TabIndex = 18;
            button4.Text = "++";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(textBoxTEXT2);
            Controls.Add(textBoxNUMB2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxID);
            Controls.Add(pictureBox1);
            Controls.Add(buttonScanImg);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNUMB);
            Controls.Add(textBoxDB);
            Controls.Add(textBoxTEXT);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

       

        #endregion

        private Button button1;
        private TextBox textBoxTEXT;
        private TextBox textBoxDB;
        private TextBox textBoxNUMB;
        private Label label1;
        private Label label2;
        private Button buttonScanImg;
        private PictureBox pictureBox1;
        private TextBox textBoxID;
        private Label label3;
        private Label label4;
        private TextBox textBoxNUMB2;
        private TextBox textBoxTEXT2;
        private Label label5;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}