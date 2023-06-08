using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackLibrary;

namespace Kursova
{
    public partial class User_Panel : Form
    {
        public BackLibrary.User user { get; set; }
        public User_Panel(BackLibrary.User user)
        {
            InitializeComponent();
            this.user = user;

        }
        private void User_Panel_Load(object sender, EventArgs e)
        {
            label1.Text = user.GetLogin();
            label1.Text = user.GetLogin();
            label4.Text = user.GetID().ToString();
            label4.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            progressBar1.Value = user.GetProgress();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Main_Menu_Panel mainMenu = new Main_Menu_Panel(user);
            mainMenu.Show();
            this.Hide();

        }

        private void User_Panel_FormClosing(object sender, FormClosingEventArgs e)
        {

            Main_Menu_Panel form2 = Application.OpenForms.OfType<Main_Menu_Panel>().FirstOrDefault();
            if (form2 != null)
            {
                form2.Close();
            }
            Register form3 = Application.OpenForms.OfType<Register>().FirstOrDefault();
            if (form3 != null)
            {
                form3.Close();
            }
            Authorization form1 = Application.OpenForms.OfType<Authorization>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Close();

                e.Cancel = false;
            }
        }


    }
}
