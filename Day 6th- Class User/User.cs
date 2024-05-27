namespace Day_6th__Class_User
{
    public class User
    {
        private List<int> score = new List<int>();
        public User(String login, String password)
        {
            this.Login = login;
            this.Password = password;
        }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            // this.score += number; // this.score = this.score + number - to samo tylko skrócone.
            this.score.Add(number);            
        }
    }
}
