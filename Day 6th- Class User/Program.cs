using Day_6th__Class_User;

User user1 = new User("Jacek", "Pass738");
User user2 = new User("Olga", "Pass738");
User user3 = new User("Daniel", "Pass738");
User user4 = new User("Julia", "Pass738");


user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
