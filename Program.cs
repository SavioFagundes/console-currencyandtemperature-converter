namespace Program
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome! Please enter 'c' to use the currency converter or anything else to use the temperature converter.");
            string answer = Console.ReadLine();

            if (answer == "c")
            {
                System.Console.WriteLine("Currency Converter selected.");
                System.Console.WriteLine("Please enter 'a' to convert from pounds of anything else to convert from Euros.");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    System.Console.WriteLine("Please enter yout amount in British pounds:");
                    float pounds = float.Parse(Console.ReadLine());
                    float Euros = pounds * 1.16f; // Example conversion rate
                    System.Console.WriteLine($"Your amount in Euros is: {Euros.ToString("F2")}");
                }
                else
                {
                    System.Console.WriteLine("Please enter your amount in Euros:");
                    float Euros = float.Parse(Console.ReadLine());
                    float pounds = Euros * 0.86f; // Example conversion rate
                    System.Console.WriteLine($"Your amount in British pounds is: {pounds.ToString("F2")}");
                }
            }
            else
            {
                System.Console.WriteLine("Temperature Converter selected.");
                System.Console.WriteLine("Please enter 'c' to convert from Celsius or anything else to convert from Fahrenheit.");

                string choice = Console.ReadLine();

                if (choice == "c")
                {
                    System.Console.WriteLine("Please enter your temperature in Celsius:");
                    float celsius = float.Parse(Console.ReadLine());
                    float fahrenheit = (celsius * 9 / 5) + 32;
                    System.Console.WriteLine($"Your temperature in Fahrenheit is: {fahrenheit.ToString("F2")}");
                }
                else
                {
                    System.Console.WriteLine("Please enter your temperature in Fahrenheit:");
                    float fahrenheit = float.Parse(Console.ReadLine());
                    float celsius = (fahrenheit - 32) * 5 / 9;
                    System.Console.WriteLine($"Your temperature in Celsius is: {celsius.ToString("F2")}");
                }
            }
            System.Console.WriteLine("Thank you for using the converter!");
        }
    }
}