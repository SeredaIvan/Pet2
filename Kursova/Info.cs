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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }
        string[] lines;
        private void CreateTextBoxes()
        {
            flowLayoutPanelAside.Controls.Clear();
            string filePath = @"C:\a_ZDTU\OOP\Курсова\Kursova\media\aside.txt";
            lines = File.ReadAllLines(filePath);
            int lineCount = lines.Length;
            for (int i = 0; i < lineCount; i++)
            {
                Label label = new Label();
                label.Name = "textBox" + (i + 1);
                label.Width = 270;
                flowLayoutPanelAside.Controls.Add(label);
                label.Text = lines[i];
                label.Click += Label_Click;
                label.Cursor = Cursors.Hand;
                label.Margin = new Padding(0, 10, 0, 0);
                label.Font = new Font(label.Font.FontFamily, 10);
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(label, lines[i]);
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {

            Label clickedLabel = (Label)sender;

            string labelText = clickedLabel.Text;

            PrintInfo(labelText);
        }

        private void PrintInfo(string labelText)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT COUNT(*) FROM c_sharp_headers WHERE h1 = @labelText", db.getConnection());
            command.Parameters.AddWithValue("@labelText", labelText);

            int count = Convert.ToInt32(command.ExecuteScalar());

            db.closeConnection();

            if (count > 0)
            {

            }
            else
            {

            }
        }
        private void Info_Load(object sender, EventArgs e)
        {

            //string filePath = @"C:\a_ZDTU\OOP\Курсова\Kursova\media\aside.txt";
            //string[] lines = File.ReadAllLines(filePath);
            //int lineCount = lines.Length;
            CreateTextBoxes();
        }

        private void flowLayoutPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Info_FormClosing(object sender, FormClosingEventArgs e)
        {

            Authorization form3 = Application.OpenForms.OfType<Authorization>().FirstOrDefault();
            if (form3 != null)
            {
                form3.Close();
            }

            Register form2 = Application.OpenForms.OfType<Register>().FirstOrDefault();
            if (form2 != null)
            {
                form2.Close();
            }

            MainMenu form1 = Application.OpenForms.OfType<MainMenu>().FirstOrDefault();
            if (form1 != null)
            {
                form1.Close();
            }

            e.Cancel = false;

        }
    }
}

