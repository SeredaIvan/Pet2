using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    public class DataCollectionFromDB
    {
        private string H1 { get; set; }
        private string P { get; set; }

        
        private Bitmap bitmapData {  get; set; }
        public DataCollectionFromDB(MySqlCommand command, int number)
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
                            bitmapData= bitmap;
                        }
                        else
                        {
                            bitmapData = null;
                        }
                        H1 = h1;
                        P = p;
                    }

                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Помилка при з'єднанні з базою даних: " + ex.Message);
                }
            }
        }


        public string GetH1()
        {
            return H1;
        }
        public string GetP()
        {
            return P;
        }
        public Bitmap GetImgData()
        {
            return bitmapData;
        }
    }
}