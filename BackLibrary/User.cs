using MySql.Data.MySqlClient;

namespace BackLibrary
{
    public class User
    {
        private int Id { get; set; }
        private string Login { get; set; }
        private string Password { get; set; }
        private int Progress { get; set; }

        public User() { }

        public User(string login, string password, int progress, int id)
        {
            Login = login;
            Password = password;
            if (progress == 0)
                Progress = 1;
            else Progress = progress;
            Id = id;
        }

        public User(string login, string password, int id)
        {
            Login = login;
            Password = password;
            Progress = 1;
            Id = id;
        }

        public void PushInfoUser()
        {
            string connectionString = "server=localhost;port=3306;username=root;password=root;database=kursovadb";

            int index = Id;
            int newSuccesValue = Progress;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE users SET success = @SuccessValue WHERE id = @Id";

                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@SuccessValue", newSuccesValue);
                    command.Parameters.AddWithValue("@Id", index);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }

        public string GetLogin()
        {
            return Login;
        }
        public int GetID()
        {
            return Id;
        }
        public string GetPassword()
        {
            return Password;
        }

        public int GetProgress()
        {
            return Progress;
        }

        public void SetProgress(int progress)
        {
            Progress = progress;
        }
        public void SetLogin(string login)
        {
            Login = login;
        }

        public void SetId(int id)
        {
            Id = id;
        }
    }

}