using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BackLibrary;
using Microsoft.VisualBasic.ApplicationServices;

namespace Kursova
{
    public partial class Authorization : Form
    {
        public BackLibrary.User user { get; set; }
        public int IntParse(string str)
        {
            int result;
            bool ok;
            do
            {
                ok = int.TryParse(str, out result);
                if (!ok)
                    MessageBox.Show("Некоректне введення! Повторіть спробу.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } while (!ok);
            return result;

        }


        public Authorization()
        {
            InitializeComponent();
        }


        public Authorization(BackLibrary.User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.PasswordChar = '●';
        }



        private void toggleButton_Click(object sender, EventArgs e)
        {


            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register reg = new Register();
            reg.Show();


        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;


            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@LOG AND `password`=@PASS", db.getConnection());

            command.Parameters.Add("@LOG", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@PASS", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                user = new BackLibrary.User();
                MessageBox.Show("Авторизація пройшла успішно");
                this.Hide();
                user.SetLogin(textBoxLogin.Text);
                int success = Convert.ToInt32(table.Rows[0]["success"]);
                int Id = Convert.ToInt32(table.Rows[0]["id"]);
                user.SetId(Id);
                user.SetProgress(success);

                Main_Menu_Panel mainMenu = new Main_Menu_Panel(user);
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Не вдалося авторизуватись!");
                return;
            }
            
        }

        private void Authorization_FormClosing(object sender, FormClosingEventArgs e)
        {


            Register form2 = Application.OpenForms.OfType<Register>().FirstOrDefault();
            if (form2 != null)
            {
                form2.Close();
            }

            e.Cancel = false;
        }
    }
}
