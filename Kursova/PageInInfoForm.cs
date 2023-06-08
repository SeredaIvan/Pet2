﻿using MySql.Data.MySqlClient;
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
        public Label labelH1=new Label();
        public Label labelP = new Label();
        public PictureBox pictureBox = new PictureBox();


        
        public PageInInfoForm()
        {
            
        }
        public PageInInfoForm(string labelH1str, string labelstr, Bitmap img)
        {
            

           

            labelH1.Text = labelH1str;
            labelP.Text = labelstr;

            pictureBox.Image = img;

        }

        

        public PageInInfoForm(string labelstr, Bitmap img)
        {

            labelP.Text = labelstr;

            pictureBox.Image = img;

        }
        public PageInInfoForm(string labelH1str, string labelstr)
        {

            labelH1.Text = labelH1str;
            labelP.Text = labelstr;

            

        }


        public void POPInfo(MySqlCommand command, int number)
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
                        labelH1.Text = h1;


                        string p = null;
                        p = reader.GetString("p");
                        labelP.Text = p;


                        
                        //byte[] imgData = (byte[])reader["img"];
                        //if (imgData != null)
                        //{
                        //    Bitmap bitmap;
                        //    using (MemoryStream memoryStream = new MemoryStream(imgData))
                        //    {
                        //        bitmap = new Bitmap(memoryStream);

                        //    }
                        //    pictureBox.Image = bitmap;
                        //}
                        //else
                        //{
                        //    pictureBox.Image = null;
                        //}


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