using System;

class Employee
{
    private string lastName;
    private string firstName;
    private string position;
    private int experience;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void SetPosition(string position)
    {
        this.position = position;
    }

    public void SetExperience(int experience)
    {
        this.experience = experience;
    }

    public double CalculateSalary()
    {
        double baseSalary = 1000; // Базовий оклад
        double salary = baseSalary;

        if (position == "Менеджер")
            salary += 500;
        else if (position == "Програміст")
            salary += 1000;
        else if (position == "Дизайнер")
            salary += 800;

        // Додатковий бонус за стаж
        salary += experience * 100;

        // Розрахунок податкового збору
        double tax = salary * 0.18;
        salary -= tax;

        return salary;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Зарплата: {CalculateSalary()} грн");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть прізвище співробітника:");
        string lastName = Console.ReadLine();

        Console.WriteLine("Введіть ім'я співробітника:");
        string firstName = Console.ReadLine();

        Employee employee = new Employee(lastName, firstName);

        Console.WriteLine("Введіть посаду співробітника:");
        string position = Console.ReadLine();
        employee.SetPosition(position);

        Console.WriteLine("Введіть стаж співробітника (в роках):");
        int experience = int.Parse(Console.ReadLine());
        employee.SetExperience(experience);

        Console.WriteLine("Інформація про співробітника:");
        employee.DisplayInfo();

        Console.ReadLine();
    }
}
