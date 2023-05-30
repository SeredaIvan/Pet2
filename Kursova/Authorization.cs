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

namespace Kursova
{
    public partial class Authorization : Form
    {
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

        private void Authorization_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.PasswordChar = '●';
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MessageBox.Show("Авторизація пройшла успішно");
            }
            else
            {
                MessageBox.Show("Не вдалося авторизуватись!");
            }

        }
    }
}
