public class Author
{
    string _name;
    int _age;
    string _nationality;
    public string GetName()
    {
        return _name;
    }
    public int GetAge()
    {
        return _age;
    }
    public string GetNationality()
    {
        return _nationality;
    }
    public void Introduce()
    {
        System.Console.WriteLine($"My name is {_name}. \nI am {_age} years old. \nI am {_nationality}.");
    }
    public void CelebrateBirthday()
    {
        _age++;
    }
    public Author()
{
    _name = "Yusuf"; 
    _age = 0;
    _nationality = "Tajik";
}
public Author(string name, int age)
{
    _name = name;
    _age = age;
}
public Author(string name, int age, string nationality)
{
    _name = name;
    _age = age;
    _nationality = nationality;
}
}