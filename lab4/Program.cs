using System;

class User
{
    public string Login { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Вік: {Age} років");
        Console.WriteLine($"Дата заповнення анкети: {RegistrationDate}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть логін:");
        string login = Console.ReadLine();

        Console.WriteLine("Введіть ім'я:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Введіть прізвище:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Введіть вік:");
        int age = int.Parse(Console.ReadLine());

        User user = new User(login, firstName, lastName, age);

        Console.WriteLine("Інформація про користувача:");
        user.DisplayInfo();

        Console.ReadLine();
    }
}
