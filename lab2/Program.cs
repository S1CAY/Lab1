using System;

class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double ConvertToUSD(double uah)
    {
        return uah / usd;
    }

    public double ConvertToEUR(double uah)
    {
        return uah / eur;
    }

    public double ConvertToPLN(double uah)
    {
        return uah / pln;
    }

    public double ConvertFromUSD(double usd)
    {
        return usd * this.usd;
    }

    public double ConvertFromEUR(double eur)
    {
        return eur * this.eur;
    }

    public double ConvertFromPLN(double pln)
    {
        return pln * this.pln;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть курси валют (USD, EUR, PLN):");
        double usdRate = double.Parse(Console.ReadLine());
        double eurRate = double.Parse(Console.ReadLine());
        double plnRate = double.Parse(Console.ReadLine());

        Converter converter = new Converter(usdRate, eurRate, plnRate);

        Console.WriteLine("Оберіть тип операції (1 - з гривні в іноземну валюту, 2 - з іноземної валюти в гривню):");
        int operationType = int.Parse(Console.ReadLine());

        if (operationType == 1)
        {
            Console.WriteLine("Введіть суму в гривнях:");
            double uahAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Оберіть валюту (USD, EUR, PLN):");
            string currency = Console.ReadLine();

            double result = 0;

            if (currency == "USD")
                result = converter.ConvertToUSD(uahAmount);
            else if (currency == "EUR")
                result = converter.ConvertToEUR(uahAmount);
            else if (currency == "PLN")
                result = converter.ConvertToPLN(uahAmount);

            Console.WriteLine($"Результат: {result} {currency}");
        }
        else if (operationType == 2)
        {
            Console.WriteLine("Введіть суму в іноземній валюті:");
            double foreignAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Оберіть валюту (USD, EUR, PLN):");
            string currency = Console.ReadLine();

            double result = 0;

            if (currency == "USD")
                result = converter.ConvertFromUSD(foreignAmount);
            else if (currency == "EUR")
                result = converter.ConvertFromEUR(foreignAmount);
            else if (currency == "PLN")
                result = converter.ConvertFromPLN(foreignAmount);

            Console.WriteLine($"Результат: {result} UAH");
        }
        else
        {
            Console.WriteLine("Невірний тип операції.");
        }

        Console.ReadLine();
    }
}
