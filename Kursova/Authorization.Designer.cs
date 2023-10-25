using System.Drawing;
using System.Windows.Forms;

namespace Kursova
{
    partial class Authorization
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
            panel1 = new Panel();
            buttonReestr = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            panel2 = new Panel();
            label_Auth = new Label();
            panel15 = new Panel();
            panel16 = new Panel();
            panel17 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(panel15);
            panel1.Controls.Add(buttonReestr);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(209, 78);
            panel1.Margin = new Padding(200, 69, 100, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 280);
            panel1.TabIndex = 0;
            // 
            // buttonReestr
            // 
            buttonReestr.Anchor = AnchorStyles.None;
            buttonReestr.Cursor = Cursors.Hand;
            buttonReestr.Location = new Point(204, 221);
            buttonReestr.Margin = new Padding(3, 30, 3, 30);
            buttonReestr.Name = "buttonReestr";
            buttonReestr.Size = new Size(116, 31);
            buttonReestr.TabIndex = 5;
            buttonReestr.Text = "Реєструватись";
            buttonReestr.UseVisualStyleBackColor = true;
            buttonReestr.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(93, 140);
            label2.Margin = new Padding(95, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 93);
            label1.Margin = new Padding(95, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Ім'я";
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Location = new Point(93, 221);
            buttonLogin.Margin = new Padding(3, 30, 3, 30);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(100, 31);
            buttonLogin.TabIndex = 3;
            buttonLogin.Text = "Ввійти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(93, 161);
            textBoxPassword.Margin = new Padding(3, 30, 3, 3);
            textBoxPassword.MaxLength = 10;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(230, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Location = new Point(93, 113);
            textBoxLogin.Margin = new Padding(110, 0, 0, 0);
            textBoxLogin.MaxLength = 10;
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(230, 27);
            textBoxLogin.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(label_Auth);
            panel2.Location = new Point(17, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 68);
            panel2.TabIndex = 0;
            // 
            // label_Auth
            // 
            label_Auth.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Auth.AutoSize = true;
            label_Auth.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label_Auth.ForeColor = Color.White;
            label_Auth.Location = new Point(95, 11);
            label_Auth.Margin = new Padding(95, 0, 5, 0);
            label_Auth.Name = "label_Auth";
            label_Auth.Size = new Size(211, 46);
            label_Auth.TabIndex = 0;
            label_Auth.Text = "Авторизація";
            // 
            // panel15
            // 
            panel15.BackColor = Color.DimGray;
            panel15.Location = new Point(358, 74);
            panel15.Margin = new Padding(20, 3, 20, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(558, 13);
            panel15.TabIndex = 14;
            // 
            // panel16
            // 
            panel16.BackColor = Color.DimGray;
            panel16.Location = new Point(500, 132);
            panel16.Margin = new Padding(20, 3, 20, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(160, 13);
            panel16.TabIndex = 12;
            // 
            // panel17
            // 
            panel17.BackColor = Color.DimGray;
            panel17.Location = new Point(541, 112);
            panel17.Margin = new Padding(20, 3, 20, 3);
            panel17.Name = "panel17";
            panel17.Size = new Size(172, 13);
            panel17.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Location = new Point(126, 320);
            panel3.Margin = new Padding(20, 3, 20, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(137, 13);
            panel3.TabIndex = 17;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Location = new Point(99, 300);
            panel4.Margin = new Padding(20, 3, 20, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(137, 13);
            panel4.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DimGray;
            panel5.Location = new Point(174, 280);
            panel5.Margin = new Padding(20, 3, 20, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(137, 13);
            panel5.TabIndex = 16;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(802, 433);
            Controls.Add(panel3);
            Controls.Add(panel17);
            Controls.Add(panel16);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authorization";
            FormClosing += Authorization_FormClosing;
            Load += Authorization_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label_Auth;
        private Button buttonReestr;
        private Label label2;
        private Label label1;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Panel panel15;
        private Panel panel16;
        private Panel panel17;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}