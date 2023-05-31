using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace TextPusher
{
    public partial class Form1 : Form
    {



        private string conString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uploader = new Uploader(conString);
            uploader.Upload(textBoxTEXT.Text, textBoxDB.Text, textBoxNUMB.Text, textBoxNUMB2.Text, textBoxTEXT2.Text, textBoxID.Text, pictureBox1, textBox1.Text);
            textBoxTEXT.Text = "";
            textBoxTEXT2.Text = "";
            string tmp = textBoxID.Text;
            int tnp = Convert.ToInt32(tmp);
            tnp++;
            textBoxID.Text = tnp.ToString();
            pictureBox1.Image = null;
        }

        private void buttonScanImg_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBoxDB.Text = "";
            textBoxID.Text = "";
            textBoxNUMB.Text = "";
            textBoxNUMB2.Text = "";
            textBoxTEXT.Text = "";
            textBoxTEXT2.Text = "";
            pictureBox1.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tmp = textBoxID.Text;
            int tnp = Convert.ToInt32(tmp);
            tnp++;
            textBoxID.Text = tnp.ToString();
        }
    }



    class Uploader : DB
    {
        public Uploader(string connectionString) : base(connectionString)
        {
        }

        public void Upload(string data, string tableName, string columnName, string columnName2, string data2, string ID, PictureBox pictureBox1, string database)
        {
            if (string.IsNullOrEmpty(database))
            {
                connectionString = $"server=localhost;port=3306;username=root;password=root;database={database}";
            }

            using (var connection = GetConnection())
            using (var command = connection.CreateCommand())
            {
                string forImage = "img";

                if (((columnName2 != "" & data2 != "" || columnName2 != null & data2 != null) & ID != "" || ID != null) & pictureBox1.Image != null)//коли в нас є всі дані
                {
                    command.CommandText = $"INSERT INTO {tableName} (id, {columnName}, {columnName2}, {forImage}) VALUES (@ID, @DataText, @DataText2, @Image)";
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.Add("@DataText", MySqlDbType.VarChar).Value = data;
                    command.Parameters.Add("@DataText2", MySqlDbType.VarChar).Value = data2; ;

                    var image = new System.Drawing.Bitmap(pictureBox1.Image);
                    using (var memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Jpeg);
                        memoryStream.Position = 0;

                        var sqlParameter = new MySqlParameter("@Image", MySqlDbType.Blob)
                        {
                            Value = memoryStream.ToArray()
                        };
                        command.Parameters.Add(sqlParameter);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Додано до бази даних");
                }
                else if (((columnName2 == "" & data2 == "" || columnName2 == null & data2 == null) & ID == "" || ID == null) & pictureBox1.Image == null)// коли в нас є тільки перша група
                {


                    command.CommandText = $"INSERT INTO {tableName} ({columnName}) VALUES ( @DataText)";
                    command.Parameters.Add("@DataText", MySqlDbType.VarChar).Value = data;


                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Додано до бази даних");
                }
                else if (((columnName2 != "" & data2 != "" || columnName2 != null & data2 != null) & ID == "" || ID == null) & pictureBox1.Image == null)//коли  внас є перша і друга групи 
                {

                    command.CommandText = $"INSERT INTO {tableName} ( {columnName}, {columnName2}) VALUES ( @DataText, @DataText2)";

                    command.Parameters.Add("@DataText", MySqlDbType.VarChar).Value = data;
                    command.Parameters.Add("@DataText2", MySqlDbType.VarChar).Value = data2;

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Додано до бази даних");
                }
                else if (((columnName2 != "" & data2 != "" || columnName2 != null & data2 != null) & ID != "" || ID != null) & pictureBox1.Image == null)//коли в нас є всі дані окрім IMG
                {

                    command.CommandText = $"INSERT INTO {tableName} (id, {columnName}, {columnName2}) VALUES (@ID, @DataText, @DataText2)";
                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.Add("@DataText", MySqlDbType.VarChar).Value = data;
                    command.Parameters.Add("@DataText2", MySqlDbType.VarChar).Value = data2; ;

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Додано до бази даних");

                }
                else if ((((columnName != "" & data == "" || columnName != null & data == null) & columnName2 == "" & data2 == "" || columnName2 == null & data2 == null) & ID != "" || ID != null) & pictureBox1.Image != null)
                {

                    command.CommandText = $"INSERT INTO {tableName} ({columnName}, {forImage}) VALUES (@ID,  @Image)";
                    command.Parameters.AddWithValue("@ID", ID);


                    var image = new System.Drawing.Bitmap(pictureBox1.Image);
                    using (var memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Jpeg);
                        memoryStream.Position = 0;

                        var sqlParameter = new MySqlParameter("@Image", MySqlDbType.Blob)
                        {
                            Value = memoryStream.ToArray()
                        };
                        command.Parameters.Add(sqlParameter);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Додано до бази даних");
                }
                else if ((((columnName == "" & data == "" || columnName == null & data == null) & columnName2 == "" & data2 == "" || columnName2 == null & data2 == null) & ID == "" || ID == null) & pictureBox1.Image != null)
                {

                    command.CommandText = $"INSERT INTO {tableName} {columnName} VALUES (@Image)";


                    var image = new System.Drawing.Bitmap(pictureBox1.Image);
                    using (var memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, ImageFormat.Jpeg);
                        memoryStream.Position = 0;

                        var sqlParameter = new MySqlParameter("@Image", MySqlDbType.Blob)
                        {
                            Value = memoryStream.ToArray()
                        };
                        command.Parameters.Add(sqlParameter);
                    }

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Додано до бази даних");
                }
            }
        }


    }
}
