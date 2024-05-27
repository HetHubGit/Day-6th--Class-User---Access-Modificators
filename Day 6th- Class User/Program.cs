using Day_6th__Class_User;

User user1 = new User("Jacek", "Pass738");
User user2 = new User("Olga", "Pass738");
User user3 = new User("Daniel", "Pass738");



user1.AddScore(3);
user1.AddScore(7);
var result = user1.Result;
Console.WriteLine(result);

user2.AddScore(8);
user2.AddScore(10);
var result2 = user2.Result;
Console.WriteLine(result2);

user3.AddScore(9);
user3.AddScore(4);
var result3 = user3.Result;
Console.WriteLine(result3);
