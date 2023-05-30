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
            // Отримати розмір робочого столу
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Встановити розмір форми
            int width = workingArea.Width - 100;  // Зменшити ширину на 100 пікселів
            int height = workingArea.Height - 100; // Зменшити висоту на 100 пікселів
            this.Size = new Size(width, height);

            // Встановити позицію форми по центру робочого столу
            int left = workingArea.Left + (workingArea.Width - width) / 2;
            int top = workingArea.Top + (workingArea.Height - height) / 2;
            this.Location = new Point(left, top);
        }
    }
}
