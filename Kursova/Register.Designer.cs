﻿namespace Kursova
{
    partial class Register

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
            label2 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            buttonRegistration = new Button();
            textBoxPasswordCheck = new TextBox();
            label1 = new Label();
            textBoxLogin = new TextBox();
            panel2 = new Panel();
            label_Auth = new Label();
            panel3 = new Panel();
            pictureBoxBackButton = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(buttonRegistration);
            panel1.Controls.Add(textBoxPasswordCheck);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxLogin);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(209, 78);
            panel1.Margin = new Padding(200, 69, 100, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 280);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(93, 118);
            label2.Margin = new Padding(95, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 6;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(93, 169);
            label3.Margin = new Padding(95, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 8;
            label3.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(93, 139);
            textBoxPassword.Margin = new Padding(3, 30, 3, 3);
            textBoxPassword.MaxLength = 10;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(230, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // buttonRegistration
            // 
            buttonRegistration.Anchor = AnchorStyles.None;
            buttonRegistration.Cursor = Cursors.Hand;
            buttonRegistration.Location = new Point(93, 235);
            buttonRegistration.Margin = new Padding(3, 30, 3, 30);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(230, 31);
            buttonRegistration.TabIndex = 5;
            buttonRegistration.Text = "Зареєструватись";
            buttonRegistration.UseVisualStyleBackColor = true;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // textBoxPasswordCheck
            // 
            textBoxPasswordCheck.Anchor = AnchorStyles.None;
            textBoxPasswordCheck.Location = new Point(93, 189);
            textBoxPasswordCheck.Margin = new Padding(3, 30, 3, 3);
            textBoxPasswordCheck.MaxLength = 10;
            textBoxPasswordCheck.Name = "textBoxPasswordCheck";
            textBoxPasswordCheck.Size = new Size(230, 27);
            textBoxPasswordCheck.TabIndex = 7;
            textBoxPasswordCheck.Leave += textBoxPasswordCheck_Leave;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(93, 71);
            label1.Margin = new Padding(95, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 1;
            label1.Text = "Ім'я";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Location = new Point(93, 91);
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
            label_Auth.Location = new Point(95, 10);
            label_Auth.Margin = new Padding(95, 0, 5, 0);
            label_Auth.Name = "label_Auth";
            label_Auth.Size = new Size(190, 46);
            label_Auth.TabIndex = 0;
            label_Auth.Text = "Регістрація";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(pictureBoxBackButton);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(50, 50);
            panel3.TabIndex = 1;
            // 
            // pictureBoxBackButton
            // 
            pictureBoxBackButton.Cursor = Cursors.Hand;
            pictureBoxBackButton.Image = Properties.Resources.icon_back_button1;
            pictureBoxBackButton.Location = new Point(0, 0);
            pictureBoxBackButton.Name = "pictureBoxBackButton";
            pictureBoxBackButton.Size = new Size(50, 50);
            pictureBoxBackButton.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBackButton.TabIndex = 0;
            pictureBoxBackButton.TabStop = false;
            pictureBoxBackButton.Click += pictureBoxBackButton_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 433);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            FormClosing += Register_FormClosing;
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label_Auth;
        private Button buttonRegistration;
        private Label label1;
        private TextBox textBoxLogin;
        private Panel panel3;
        private PictureBox pictureBoxBackButton;
        private Label label2;
        private Label label3;
        private TextBox textBoxPassword;
        private TextBox textBoxPasswordCheck;
    }
}