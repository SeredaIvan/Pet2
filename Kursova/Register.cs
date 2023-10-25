using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
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
        string password = "";
        bool check;
        private void pictureBoxBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization aut = new Authorization();
            aut.Show();
        }




        private void Register_Load(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.PasswordChar = '●';
            textBoxPasswordCheck.UseSystemPasswordChar = true;
            textBoxPasswordCheck.PasswordChar = '●';
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                if (IsUserExist()) return;
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `success`) VALUES (@LOG, @PASS, @PROGR);");
                command.Parameters.Add("@LOG", MySqlDbType.VarChar).Value = textBoxLogin.Text;
                command.Parameters.Add("@PASS", MySqlDbType.VarChar).Value = textBoxPasswordCheck.Text;
                command.Parameters.Add("@PROGR", MySqlDbType.Int64).Value = 0;

                db.openConnection();

                command.Connection = db.getConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт створено!");
                }
                else
                {
                    MessageBox.Show("Аккаунт не створено!");
                }

                db.closeConnection();
            }
            else
            {
                MessageBox.Show("Введіть пароль ідентичний з попереднім");
            }

        }

        private void textBoxPasswordCheck_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != null && textBoxPassword != null && textBoxPasswordCheck.Text != null)
            {
                if (textBoxPassword.Text != textBoxPasswordCheck.Text)
                {
                    MessageBox.Show("Введіть пароль ідентичний з попереднім");
                    return;
                }
                else if (textBoxPassword.Text == textBoxPasswordCheck.Text)
                {
                    check = true;
                    return;
                }
            }

        }
        public bool IsUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@LOG ", db.getConnection());

            command.Parameters.Add("@LOG", MySqlDbType.VarChar).Value = textBoxLogin.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такий користувач вже зареєструвався,виберіть інший логін");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Authorization form1 = Application.OpenForms.OfType<Authorization>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Close();
            }
            e.Cancel = false;
        }

        private void label_Auth_Click(object sender, EventArgs e)
        {

        }
    }
}
