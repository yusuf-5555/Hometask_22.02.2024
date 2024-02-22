public class User
{
    public string firstName;
    public string lastName;
    public string userName;
    public string password;
    public bool isLoggedIn;

    public void Login(string uname, string pass)
    {
        if(userName==uname && password==pass)
        {
        System.Console.WriteLine("User logged in successfully");
        isLoggedIn = true;
        }
        else System.Console.WriteLine("Your password or username is incorrect");
    }
    public void Logout()
    {
        isLoggedIn = false;
    }
    public string GetFullInfo()
    {
        return $"{firstName} {lastName} - {isLoggedIn}";
    }
}