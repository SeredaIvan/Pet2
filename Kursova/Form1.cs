using System.Windows.Forms;

namespace Kursova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

           


            string[] menuItems = File.ReadAllLines(@"C:\a_ZDTU\OOP\Курсова\Kursova\media\aside.txt");
            foreach (string menuItemText in menuItems)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(menuItemText);
                menuStrip1.Items.Add(menuItem);
            }


        }




    }
}