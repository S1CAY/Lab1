using System;
namespace lab1_2023
{
    class Program

    {
        static void Main(string[] args)
        {
            Address myAddress = new Address();
            myAddress.Index = "12345";
            myAddress.Country = "USA";
            myAddress.City = "New York";
            myAddress.Street = "Broadway";
            myAddress.House = "123";
            myAddress.Apartment = "456";

            Console.WriteLine("Поштова адреса:");
            Console.WriteLine($"Індекс: {myAddress.Index}");
            Console.WriteLine($"Країна: {myAddress.Country}");
            Console.WriteLine($"Місто: {myAddress.City}");
            Console.WriteLine($"Вулиця: {myAddress.Street}");
            Console.WriteLine($"Будинок: {myAddress.House}");
            Console.WriteLine($"Квартира: {myAddress.Apartment}");

            Console.ReadLine();
        }
    }

}
