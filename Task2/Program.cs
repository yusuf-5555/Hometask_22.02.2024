var user = new User();
user.firstName = "Yusuf";
user.lastName = "Rahmon";
user.userName = "yusuf5555";
user.password = "yusuf1234";
user.Login("yusuf5", "yusu");
user.Logout();
System.Console.WriteLine(user.GetFullInfo());
