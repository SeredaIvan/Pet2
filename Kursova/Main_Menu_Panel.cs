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
using Microsoft.VisualBasic.ApplicationServices;

namespace Kursova
{
    public partial class Main_Menu_Panel : Form
    {
        public BackLibrary.User user { get; set; }
        public Main_Menu_Panel(BackLibrary.User user)
        {
            InitializeComponent();
            this.user = user;

        }
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Page_Info info = new Page_Info(user);

            this.Hide();
            info.Show();

        }
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            user.PushInfoUser();
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

            User_Panel form3 = Application.OpenForms.OfType<User_Panel>().FirstOrDefault();
            if (form3 != null)
            {
                form3.Close();
            }
            e.Cancel = false;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            User_Panel user_Panel = new User_Panel(user);
            user_Panel.Show();
            this.Hide();

        }


    }
}
