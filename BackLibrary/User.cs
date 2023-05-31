namespace BackLibrary
{
    public class User
    {
        private string Login { get; set; }
        private string Password { get; set; }
        private int Progress { get; set; }
        public User(string login, string password, int progress)
        {
            Login = login;
            Password = password;
            Progress = progress;
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
            Progress = 0;
        }

        public string GetLogin()
        {
            return Login;
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
        
    }

}