using MySql.Data.MySqlClient;
using System.Windows.Forms;
using BackLibrary;
using MySqlX.XDevAPI.Common;
using System.Drawing;
using System;
using System.Linq;

namespace Kursova
{
    public partial class Page_Info : Form
    {
        int numberPage = 1;
        int DBLength = 1;
        int Progress_ = 1;
        int OurProgress;
        Color LabelColor = Color.Black;

        PageClass page = new PageClass();
        public BackLibrary.User user { get; set; }


        public Page_Info(BackLibrary.User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void Paint_Page()
        {

            flowLayoutPanel1.Controls.Clear();
            page.POPInfo(numberPage);

            flowLayoutPanel1.AutoScroll = true;

            Label label1 = new Label();
            label1.Text = page.labelH1.Text;
            label1.ForeColor = LabelColor;
            label1.Visible = true;
            label1.Margin = new Padding(20, 0, 0, 0);
            label1.AutoSize = true;
            label1.Font = new Font(label1.Font.FontFamily, 34, FontStyle.Bold);

            flowLayoutPanel1.Controls.Add(label1);

            Label label2 = new Label();
            label2.Text = page.labelP.Text;
            label2.ForeColor = LabelColor;
            label2.Visible = true;
            label2.Margin = new Padding(20, 0, 0, 0);
            label2.AutoSize = true;
            label2.Font = new Font(label1.Font.FontFamily, 24);

            flowLayoutPanel1.Controls.Add(label2);


        }

        private void Load_Lenght_DB()
        {
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id FROM c_sharp_info ORDER BY id DESC LIMIT 1";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int lastId = Convert.ToInt32(reader["id"]);
                            DBLength = lastId;
                        }
                    }
                }
            }
        }

        private void buttonPreviev_Click(object sender, EventArgs e)
        {
            if (numberPage > 0)
            {
                numberPage--;
                page.POPInfo(numberPage);
                Paint_Page();

            }
            else numberPage = 1;
        }


        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (numberPage < DBLength & numberPage > 0)
            {
                numberPage++;
                page.POPInfo(numberPage);
                Paint_Page();
                OurProgress = (int)(((double)numberPage / DBLength) * 100);
                user.SetProgress(OurProgress);
            }
            else numberPage = 1;
        }


        private void Page_Info_Loadd(object sender, EventArgs e)
        {
            Load_Lenght_DB();
            numberPage = (user.GetProgress() * DBLength) / 100;
            page.POPInfo(numberPage);
            Paint_Page();
        }


        private void Page_Info_FormClosing(object sender, FormClosingEventArgs e)
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

            Main_Menu_Panel form3 = Application.OpenForms.OfType<Main_Menu_Panel>().FirstOrDefault();
            if (form3 != null)
            {
                form3.Close();
            }
            e.Cancel = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            page.POPInfo(numberPage);
            user.SetProgress(OurProgress);
            Main_Menu_Panel mainMenu = new Main_Menu_Panel(user);
            mainMenu.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            LabelColor = Color.White;
            panel1.BackColor = Color.Black;
            this.BackColor = Color.Black;
            InvertLabelColors(flowLayoutPanel1);
            button1.ForeColor = LabelColor;
            button2.ForeColor = LabelColor;
            button1.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            pictureBoxNight.Visible = false;
            pictureBoxDay.Visible = true;
        }
        private void InvertLabelColors(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is Label)
                {
                    Label label = (Label)childControl;
                    label.ForeColor = InvertColor(label.ForeColor);
                }
                else if (childControl.Controls.Count > 0)
                {
                    InvertLabelColors(childControl);
                }
            }
        }

        private Color InvertColor(Color color)
        {
            return Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            LabelColor = Color.Black;
            panel1.BackColor = Color.White;
            InvertLabelColors(flowLayoutPanel1);
            button1.ForeColor = LabelColor;
            button2.ForeColor = LabelColor;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            pictureBoxDay.Visible = false;
            pictureBoxNight.Visible = true;

        }
    }
}
