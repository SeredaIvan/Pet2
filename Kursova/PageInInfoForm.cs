using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    public class PageInInfoForm
    {
        public Label labelH1;
        public Label labelP;
        public PictureBox pictureBox;


        //в кожному конструкторі створюється елементи об'єктів ,але можливо вони не потрібні
        public PageInInfoForm()
        {
            labelH1 = null;
            labelP = null;
            pictureBox = null;
        }
        public PageInInfoForm(string labelH1str, string labelstr, Bitmap img)
        {
            Label labelH1 = new Label();
            Label labelP = new Label();
            PictureBox pictureBox = new PictureBox();

            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            labelH1.Text = labelH1str;
            labelP.Text = labelstr;
            
            pictureBox.Image = img;
            

            labelH1.Font = new Font(labelH1.Font.FontFamily, 30, FontStyle.Bold);
            labelP.Font = new Font(labelP.Font.FontFamily, 14);

        }

        public static bool operator ==(PageInInfoForm pg1, PageInInfoForm pg2)
        {
            if (pg1.pictureBox == pg2.pictureBox & pg1.labelH1 == pg2.labelH1 & pg1.labelP == pg2.labelP)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(PageInInfoForm pg1, PageInInfoForm pg2)
        {
            return !(pg1 == pg2);
        }

        public PageInInfoForm(string labelstr, Bitmap img)
        {

            Label labelP = new Label();
            PictureBox pictureBox = new PictureBox();

            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            labelP.Text = labelstr;
            
            pictureBox.Image = img;
            


            

        }
        public PageInInfoForm(string labelH1str, string labelstr)
        {
            Label labelH1 = new Label();
            Label labelP = new Label();



            labelH1.Text = labelH1str;
            labelP.Text = labelstr;

            labelH1.Font = new Font(labelH1.Font.FontFamily, 30, FontStyle.Bold);
            labelP.Font = new Font(labelP.Font.FontFamily, 14);

        }


        public void POPInfo(MySqlCommand command,int number)
        {
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                command = connection.CreateCommand();
                try
                {
                    connection.Open();

                    // Запит до бази даних для отримання даних
                    command.CommandText = "SELECT h1, p, img FROM c_sharp_info  WHERE id = @ID";
                    command.Parameters.AddWithValue("@ID", number);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string h1 = null;
                        h1 = reader.GetString("h1");

                        string p = null;
                        p = reader.GetString("p");

                        byte[] imgData = null;
                        imgData = (byte[])reader["img"];
                        if (imgData != null)
                        {
                            Bitmap bitmap;
                            using (MemoryStream memoryStream = new MemoryStream(imgData))
                            {
                                bitmap = new Bitmap(memoryStream);

                            }
                            pictureBox.Image = bitmap;
                        }
                        else
                        {
                            bitmapData = null;
                        }
                        this.labelH1 = h1;
                        this.labelP = p;
                    }

                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Помилка при з'єднанні з базою даних: " + ex.Message);
                }
            }
        }
    }
    }
}