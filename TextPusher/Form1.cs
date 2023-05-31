using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace TextPusher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBoxTEXT_Leave(object sender, EventArgs e)
        {

        }
        private string conString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";

        private void button1_Click(object sender, EventArgs e)
        {
            var uploader = new TextUploader(conString);
            uploader.Upload(textBoxTEXT.Text, textBoxDB.Text, textBoxNUMB.Text);
            textBoxTEXT.Text = "";
        }

        private void buttonScanImg_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void buttonPushImg_Click(object sender, EventArgs e)
        {
            conString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";
            var uploader = new ImageUploader(conString);
            uploader.Upload(pictureBox1, 1, textBoxDB, textBoxNUMB);
        }
    }

    class ImageUploader
    {
        private readonly string _connectionString;

        public ImageUploader(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Upload(PictureBox pictureBox, int id, TextBox textBoxDB, TextBox textBoxNUMB)
        {
            string tableName = textBoxDB.Text;
            string columnName = textBoxNUMB.Text;
            using (var connection = new MySqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = $"INSERT INTO {tableName}({columnName}) VALUES (@Image)";


                var image = new Bitmap(pictureBox.Image);
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
            }
        }
    }

    class TextUploader
    {
        private readonly string _connectionString;

        public TextUploader(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Upload(string data, string tableName, string columnName)
        {
            using (var connection = new MySqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = $"INSERT INTO {tableName} ({columnName}) VALUES (@Data)";
                command.Parameters.AddWithValue("@Data", data);

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Додано до бази даних");
            }
        }
    }
}
