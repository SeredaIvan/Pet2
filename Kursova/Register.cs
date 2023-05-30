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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void pictureBoxBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization aut = new Authorization();
            aut.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text!=null&&textBoxPassword!=null&&textBoxPasswordCheck.Text!=null)
            {
                if (textBoxPassword.Text != textBoxPasswordCheck.Text)
                    MessageBox.Show("Введіть пароль ідентичний з попереднім");
            }
             
                
        }

        private void Register_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.PasswordChar = '●';
            textBoxPasswordCheck.UseSystemPasswordChar = true;
            textBoxPasswordCheck.PasswordChar = '●';
        }


    }
}
