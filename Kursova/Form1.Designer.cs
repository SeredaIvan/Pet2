namespace Kursova
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
            panelMain = new Panel();
            menuStrip1 = new MenuStrip();
            adwToolStripMenuItem = new ToolStripMenuItem();
            wadaToolStripMenuItem = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelMain.BackColor = Color.Gray;
            panelMain.Location = new Point(177, 80);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(615, 358);
            panelMain.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(50, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adwToolStripMenuItem, wadaToolStripMenuItem, toolStripTextBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(156, 450);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // adwToolStripMenuItem
            // 
            adwToolStripMenuItem.Name = "adwToolStripMenuItem";
            adwToolStripMenuItem.Size = new Size(143, 4);
            // 
            // wadaToolStripMenuItem
            // 
            wadaToolStripMenuItem.Name = "wadaToolStripMenuItem";
            wadaToolStripMenuItem.Size = new Size(143, 4);
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BorderStyle = BorderStyle.None;
            toolStripTextBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.Size = new Size(141, 40);
            toolStripTextBox1.Text = "Меню";
            toolStripTextBox1.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMain);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelMain;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adwToolStripMenuItem;
        private ToolStripMenuItem wadaToolStripMenuItem;
        private ToolStripTextBox toolStripTextBox1;
    }
}