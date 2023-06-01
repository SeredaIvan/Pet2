using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;


namespace Kursova
{
    public partial class Info : Form
    {
        private MySqlCommand command;
        int[] arrSubdivisions = null;
        string[] lines;
        int numberPage = 1;
        PageInInfoForm[] pages = null;
        public Info()
        {
            InitializeComponent();

        }

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
        private void FillMainArr(out PageInInfoForm[] pages)
        {
            
            pages = new PageInInfoForm[arrSubdivisions.Length]; // Ініціалізація масиву

            for (int i = 0; i <= arrSubdivisions.Length; i++)//заповнення масиву
            {
                DataCollectionFromDB dataCollectionFromDB = new DataCollectionFromDB(command, arrSubdivisions[i]);//звернення до класу який бере потрібні дані
                if (dataCollectionFromDB.H1 != null && dataCollectionFromDB.P != null)//&& dataCollectionFromDB.pictureBox.Image != null)
                {
                    pages[i] = new PageInInfoForm(dataCollectionFromDB.H1, dataCollectionFromDB.P);//, dataCollectionFromDB.pictureBox);
                    MessageBox.Show("Створений елемент масиву ");

                }
                else if ((dataCollectionFromDB.H1 == null || dataCollectionFromDB.H1 == "") && (dataCollectionFromDB.P != null || dataCollectionFromDB.P != ""))//&& dataCollectionFromDB.pictureBox.Image != null)
                {
                    pages[i] = new PageInInfoForm(dataCollectionFromDB.P);//, dataCollectionFromDB.pictureBox);
                    MessageBox.Show("Створений елемент масиву ");

                }
                else if (dataCollectionFromDB.H1 != null && dataCollectionFromDB.P != null) //&& dataCollectionFromDB.pictureBox.Image == null)
                {
                    pages[i] = new PageInInfoForm(dataCollectionFromDB.H1, dataCollectionFromDB.P);
                    MessageBox.Show("Створений елемент масиву ");
                }
                else if (dataCollectionFromDB.H1 == null && dataCollectionFromDB.P != null )//&& dataCollectionFromDB.pictureBox.Image == null)
                {
                    pages[i] = new PageInInfoForm(dataCollectionFromDB.P);
                    MessageBox.Show("Створений елемент масиву ");
                }
                else
                {
                    MessageBox.Show("Екземпляр PageInInfoForm не вдалося створити");
                }
                
            }
            MessageBox.Show("Заповнено інформацією масив сторінок");
        }

        private void Label_Click(object sender, EventArgs e)
        {

            Label clickedLabel = (Label)sender;

            string labelText = clickedLabel.Text;

            if (CheckLabel(labelText, out arrSubdivisions))//заповнюємо масив з індексами і повернено значення trueабо fasle порівнюючи масив з null
            {
                
                FillMainArr(out pages);
                
            }
            else
            {
                MessageBox.Show("Масив arrSubdivisions не ініціализовано");
            }
        }

        private void PrintInfo(ref int[] arrSubdivisions)
        {
            if (arrSubdivisions == null)
            {
                MessageBox.Show("Subvision null");
            }
            else if (arrSubdivisions != null)
            {
                if (numberPage>0&&numberPage-1<=arrSubdivisions.Length)
                {
                    if (pages[numberPage-1].labelH1.Text != null& pages[numberPage - 1].labelH1.Text != "")
                    {
                        labelH1.Text = pages[numberPage - 1].labelH1.Text;
                    }
                    else
                    {
                        //Label labelH1_2 = labelH1;
                        //flowLayoutPanelInfo.Controls.Remove(labelH1);
                        //flowLayoutPanelInfo.Controls.Add(labelH1_2);

                        ////навпаки 
                        //Label labelH1_1 = labelH1_2;
                        //flowLayoutPanelInfo.Controls.Remove(labelH1_2);
                        //flowLayoutPanelInfo.Controls.SetChildIndex(labelH1_1, 0);

                        //labelH1.Hide();


                    }
                    if (pages[numberPage - 1].labelP != null && pages[numberPage - 1].labelP.Text != "")
                    {
                        labelP.Text = pages[numberPage - 1].labelP.Text;
                    }

                    else
                    {
                    }
                    //}
                    //if (pages[numberPage-1].pictureBox.Image != null)
                    //{
                    //    pictureBox.Image = pages[numberPage - 1].pictureBox.Image;
                    //}
                    //else
                    //{

                    //}
                }
            }
            //if (arrSubdivisions == null)
            //{
            //    MessageBox.Show("Subvision null");
            //}
            //else
            //{
            //    if (numberPage - 1 < arrSubdivisions.Length)
            //    {
            //        int verticalPosition = 0;
            //        if (pages[numberPage - 1].labelH1 != null)
            //        {

            //            labelH1.Text = pages[numberPage - 1].labelH1;
            //            labelH1.TextAlign = ContentAlignment.TopLeft;

            //            labelH1.Font = new Font(labelH1.Font.FontFamily, 34, FontStyle.Bold);




            //            labelH1.AutoSize = true;

            //        }
            //        if (pages[numberPage - 1].labelP != null)
            //        {

            //            labelP.Text = pages[numberPage - 1].labelP;
            //            labelP.Font = new Font(labelP.Font.FontFamily, 10);
            //            labelP.AutoSize = true;

            //        }

            //        if (pages[numberPage - 1].dataImg != null)
            //        {
            //            PictureBox pictureBox = new PictureBox();
            //            byte[] img = pages[numberPage - 1].dataImg;
            //            using (var stream = new System.IO.MemoryStream(img))
            //            {
            //                pictureBox.Image = System.Drawing.Image.FromStream(stream);
            //            }
            //            pictureBox.Location = new Point(0, verticalPosition);
            //            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            //            pictureBox.MaximumSize = new Size(600, 400);
            //            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            //            flowLayoutPanelInfo.Controls.Add(pictureBox);
            //            verticalPosition += pictureBox.Height + 20;
            //        }

            //        flowLayoutPanelInfo.AutoScroll = true;
            //    }

            //    buttonNext.Show();
            //    buttonPreviev.Show();
            //}
        }

        private bool CheckLabel(string labelText, out int[] arrSubdivisions)
        {
            arrSubdivisions = null;
            string subvisior = "";
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
                        subvisior = subdivisionsValue.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Не знайдено відповідного запису для значення " + labelText);
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Помилка при з'єднанні з базою даних: " + ex.Message);
                    return false;
                }

                if (!string.IsNullOrEmpty(subvisior))
                {
                    string[] numberStrings = subvisior.Split(','); // Розділення рядка по комах і отримання масиву рядків
                    arrSubdivisions = new int[numberStrings.Length]; // Створення масиву int для збереження чисел

                    for (int i = 0; i < numberStrings.Length; i++)
                    {
                        if (int.TryParse(numberStrings[i], out int number)) // Перетворення рядка в int
                        {
                            arrSubdivisions[i] = number; // Збереження числа у масиві
                        }
                        else
                        {
                            // Обробка помилки, якщо рядок не може бути перетворений в int
                            MessageBox.Show("Неправильний формат числа: " + numberStrings[i]);
                            return false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Не вдається створити сторінку CheckLabel");
                    return false;
                }
            }

            return true;
        }
        private void Info_Load(object sender, EventArgs e)
        {
            CreateTextBoxes();
            buttonNext.Hide();
            buttonPreviev.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (numberPage - 1 > 0)
            {
                numberPage--;
            }
            else numberPage = 1;

        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            if (numberPage - 1 < pages.Length & numberPage > 0)
            {
                numberPage++;
            }
            else numberPage = 1;
        }


    }
}

