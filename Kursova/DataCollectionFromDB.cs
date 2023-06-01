using MySql.Data.MySqlClient;

public class DataCollectionFromDB
{
    public string H1 { get; set; }
    public string P { get; set; }
    public PictureBox pictureBox { get; set; }




    public DataCollectionFromDB(MySqlCommand command, int subvision)
    {
        string connectionString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            command = connection.CreateCommand();
            try
            {
                connection.Open();

                // Запит до бази даних для отримання даних
                command.CommandText = "SELECT h1, p, img FROM c_sharp_info WHERE id=@ID";
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = subvision;

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        string h1 = null;
                        if (!reader.IsDBNull(reader.GetOrdinal("h1")))
                            h1 = reader.GetString("h1");

                        string p = null;
                        if (!reader.IsDBNull(reader.GetOrdinal("p")))
                            p = reader.GetString("p");

                        byte[] imgData = null;
                        if (!reader.IsDBNull(reader.GetOrdinal("img")))
                            imgData = (byte[])reader["img"];
                        //byte[] img = (byte[])reader["img"];
                        //pictureBox = new PictureBox();
                        //using (var stream = new System.IO.MemoryStream(img))
                        //{
                        //    pictureBox.Image = System.Drawing.Image.FromStream(stream);

                        //}
                    }
                    reader.Close();
                }

                MessageBox.Show("Дані взято з c_sharp_info");
                command.Parameters.Clear();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Помилка при з'єднанні з базою даних: " + ex.Message);
            }
        }
    }

}
