using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    public class PageClass
    {
        public Label labelH1=new Label();
        public Label labelP= new Label();



        public PageClass()
        {

        }
        public PageClass(string labelH1str, string labelstr)
        {
            labelH1.Text = labelH1str;
            labelP.Text = labelstr;
        
        }



        public PageClass(string labelstr)
        {
            labelP.Text = labelstr;

        }
       


        public void POPInfo(int ID)
        {
            MySqlCommand command = new MySqlCommand();
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                command = connection.CreateCommand();
                try
                {
                    connection.Open();

                    // Запит до бази даних для отримання даних
                    command.CommandText = "SELECT h1, p FROM c_sharp_info  WHERE id = @ID";
                    command.Parameters.AddWithValue("@ID", ID);
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string h1 = null;
                        h1 = reader.GetString("h1");
                        labelH1.Text = h1;

                        string p = null;
                        p = reader.GetString("p");
                        labelP.Text = p;

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
