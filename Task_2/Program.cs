using System;

namespace Lab_1
{
    public class Converter
    {
        private double usd;
        private double eur;
        private double pln;

        public Converter(double usdRate, double eurRate,     double plnRate)
        {
            usd = usdRate;
            eur = eurRate;
            pln = plnRate;
        }

        public double ConvertToCurrency(double amount, string currency)
        {
            switch (currency)
            {
                case "USD":
                    return amount / usd;
                case "EUR":
                    return amount / eur;
                case "PLN":
                    return amount / pln;
                default:
                    throw new Exception("Невідома валюта.");
            }
        }

        public double ConvertToUAH(double amount, string currency)
        {
            switch (currency)
            {
                case "USD":
                    return amount * usd;
                case "EUR":
                    return amount * eur;
                case "PLN":
                    return amount * pln;
                default:
                    throw new Exception("Невідома валюта.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Converter converter = new Converter(41.3, 44.79, 10.4); // використовував числа від конвертації валют Google; 18.10

            Console.WriteLine("Введіть суму: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Оберіть операцію: 1 - Гривня в іноземну валюту, 2 - Іноземна валюта в гривню");
            int operation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть валюту (USD, EUR, PLN): ");
            string currency = Console.ReadLine();

            if (operation == 1)
            {
                double result = converter.ConvertToCurrency(amount, currency);
                Console.WriteLine($"{amount} грн дорівнює {result} {currency}");
            }
            else if (operation == 2)
            {
                double result = converter.ConvertToUAH(amount, currency);
                Console.WriteLine($"{amount} {currency} дорівнює {result} грн");
            }
            else
            {
                Console.WriteLine("Неправильна операція");
            }
        }
    }
}
