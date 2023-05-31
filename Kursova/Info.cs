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
using ToolTip = System.Windows.Forms.ToolTip;


namespace Kursova
{
    public partial class Info : Form
    {
        private MySqlCommand command;
        int[] numbers;
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

            CheckLabel(labelText,numbers);
            if (numbers != null)
            {
                    PageInInfoForm[] pagesInSection = new PageInInfoForm[numbers.Length];
                    FilWithInformation(numbers, pagesInSection);

            }
            else {
                MessageBox.Show("Не вдається створити сторінку  Label_Click");
                return; }

            
        }

       

        private void FilWithInformation(int[] numbers, PageInInfoForm[] pagesInSection)
        {
            for (int i = 0; i < pagesInSection.Length; i++)
            {
                DataCollectionFromDB infoPageInSection = new DataCollectionFromDB(command, numbers[i]);
                pagesInSection[i] = new PageInInfoForm(infoPageInSection.GetH1(), infoPageInSection.GetP(), infoPageInSection.GetImgData());
            }
        }
        private void CheckLabel(string labelText,int[] numbers)
        {
            string subdivisions="";
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();

                    // Запит до бази даних для перевірки значення label.Text
                    command.CommandText = "SELECT subdivisions FROM c_sharp_headers WHERE h1 = @h1";
                    command.Parameters.AddWithValue("@h1", labelText);

                    object subdivisionsValue = command.ExecuteScalar();

                    if (subdivisionsValue != null)
                    {
                         subdivisions = subdivisionsValue.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Не знайдено відповідного запису для значення " + labelText);
                    }
                   
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Помилка при з'єднанні з базою даних: " + ex.Message);
                }

                if (subdivisions != "")
                {
                    string[] numberStrings = subdivisions.Split(','); // Розділення рядка по комах і отримання масиву рядків
                    if (numbers == null)
                    {
                        numbers = new int[numberStrings.Length]; // Створення масиву int для збереження чисел
                    }
                    else
                    {
                        int[] resizedArray = new int[numberStrings.Length];

                        Array.Copy(numbers, resizedArray, Math.Min(numbers.Length, numberStrings.Length));

                        numbers = resizedArray;
                    }

                    for (int i = 0; i < numberStrings.Length; i++)
                    {
                        int number;
                        if (int.TryParse(numberStrings[i], out number)) // Перетворення рядка в int
                        {
                            numbers[i] = number; // Збереження числа у масиві
                        }
                        else
                        {
                            // Обробка помилки, якщо рядок не може бути перетворений в int
                            MessageBox.Show("Неправильний формат числа: " + numberStrings[i]);
                            // Або можна використати виключення: throw new FormatException("Неправильний формат числа: " + numberStrings[i]);
                        }
                    }



                    
                }
                else
                {
                    
                    MessageBox.Show("Не вдається створити сторінку CheckLabel");
                    return;
                }
            }
        }
        private void Info_Load(object sender, EventArgs e)
        {
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

