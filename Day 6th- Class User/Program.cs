User user1 = new User("Jacek", "Pass738");
User user2 = new User("Olga", "Pass738");
User user3 = new User("Daniel", "Pass738");
User user4 = new User("Julia", "Pass738");


user1.AddScore(5);

class User
{
    private int score;
   
   
    public User(String login, String password)
    {  
        this.Login = login;
        this.Password = password;
        this.score = 0;
    }
    public string Login { get; private set; }

    public string Password { get; private set; }

    

    public void AddScore(int number)
    {
        this.score += number; // this.score = this.score + number - to samo tylko skrócone.
    }






    private static void Main(string[] args)
    {
       
    }
}