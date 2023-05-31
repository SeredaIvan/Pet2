using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void SetInitialSize()
        {

            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;


            int width = workingArea.Width - 100;
            int height = workingArea.Height - 100;
            this.Size = new Size(width, height);


            int left = workingArea.Left + (workingArea.Width - width) / 2;
            int top = workingArea.Top + (workingArea.Height - height) / 2;
            this.Location = new Point(left, top);
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Основний контент

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Authorization form1 = Application.OpenForms.OfType<Authorization>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Close();
            }

            Register form2 = Application.OpenForms.OfType<Register>().FirstOrDefault();
            if (form2 != null)
            {
                form2.Close();
            }

            e.Cancel = false;
        }

    }
}
