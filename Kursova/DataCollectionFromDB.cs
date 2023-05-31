using MySql.Data.MySqlClient;
using System;
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

        private byte[]ImgData { get; set; }
        public DataCollectionFromDB(MySqlCommand command)
        {
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                command = connection.CreateCommand();
                try
                {
                    connection.Open();

                    // Запит до бази даних для отримання даних
                    command.CommandText = "SELECT h1, p, img FROM c_sharp_info";
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string h1 = reader.GetString("h1");
                        string p = reader.GetString("p");
                        byte[] imgData = (byte[])reader["img"];
                        H1 = h1;
                        P=p;
                        ImgData = imgData;
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
        public byte[] GetImgData()
        {
            return ImgData;
        }
    }
}
