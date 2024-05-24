User user1 = new User("Jacek", "Pass738");
User user2 = new User("Olga", "Pass738");
User user3 = new User("Daniel", "Pass738");
User user4 = new User("Julia", "Pass738");


user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
var pi = Math.PI;


class User
{
    public static string GameName = "Lokomotive";
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






    private static void Main(string[] args)
    {
       
    }
}