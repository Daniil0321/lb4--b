using System;
using System.Globalization;

namespace LB4
{
    class TV
    {
        public string Brand;
        public string Model;
        public double ScreenSize;
        public bool IsSmartTV;
        public int Channels;
        public string DisplayType;
        public double Price;

        public double GetPricePerInch()
        {
            return Price / ScreenSize;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Samsung: ");
            string brand = Console.ReadLine();

            Console.Write("QN65Q80AAFXZA: ");
            string model = Console.ReadLine();

            double screenSize;
            while (true)
            {
                Console.Write("65: ");
                string screenSizeInput = Console.ReadLine();
                if (double.TryParse(screenSizeInput, NumberStyles.Any, CultureInfo.InvariantCulture, out screenSize))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            }

            Console.Write("true? (y/n): ");
            bool isSmartTV = Console.ReadKey().Key == ConsoleKey.Y;
            Console.WriteLine();

            Console.Write("124: ");
            int channels;
            while (!int.TryParse(Console.ReadLine(), out channels))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                Console.Write("124: ");
            }

            Console.Write("QLED: ");
            string displayType = Console.ReadLine();

            double price;
            while (true)
            {
                Console.Write("1499.99: ");
                string priceInput = Console.ReadLine();
                if (double.TryParse(priceInput, NumberStyles.Any, CultureInfo.InvariantCulture, out price))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            }

            TV myTV = new TV();
            myTV.Brand = brand;
            myTV.Model = model;
            myTV.ScreenSize = screenSize;
            myTV.IsSmartTV = isSmartTV;
            myTV.Channels = channels;
            myTV.DisplayType = displayType;
            myTV.Price = price;

            double pricePerInch = myTV.GetPricePerInch();
            Console.WriteLine();
            Console.WriteLine("Информация о телевизоре:");
            Console.WriteLine($"Бренд: {myTV.Brand}");
            Console.WriteLine($"Модель: {myTV.Model}");
            Console.WriteLine($"Размер экрана: {myTV.ScreenSize} дюймов");
            Console.WriteLine($"Смарт ТВ: {(myTV.IsSmartTV ? "Да" : "Нет")}");
            Console.WriteLine($"Количество каналов: {myTV.Channels}");
            Console.WriteLine($"Тип дисплея: {myTV.DisplayType}");
            Console.WriteLine($"Цена: {myTV.Price:C}");
            Console.WriteLine($"Цена за дюйм: {pricePerInch:C}");

            Console.ReadLine();
        }
    }
}