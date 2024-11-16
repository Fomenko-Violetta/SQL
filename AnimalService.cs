using System;
using System.Collections.Generic;
using System.Globalization;

namespace ZooLab_1.Services
{
    public static class AnimalService
    {
        private static List<(string Name, string Type, decimal Price)> animals = new List<(string, string, decimal)>
        {
            ("Кіт", "Ссавець", 150.00M),
            ("Собака", "Ссавець", 300.00M),
            ("Папуга", "Птах", 500.00M)
        };

        public static void DisplayAnimals()
        {
            Console.WriteLine("Тварини в магазині:");
            CultureInfo culture = new CultureInfo("uk-UA");
            foreach (var animal in animals)
            {
                Console.WriteLine($"Назва: {animal.Name}, Тип: {animal.Type}, Ціна: {animal.Price.ToString("C", culture)}");
            }
        }

        public static void AddAnimal(string name, string type, decimal price)
        {
            animals.Add((name, type, price));
            Console.WriteLine($"Додано тварину: {name}, {type}, {price.ToString("C", new CultureInfo("uk-UA"))}");
        }

        public static void DisplayExpensiveAnimals(decimal minPrice)
        {
            Console.WriteLine($"Тварини дорожчі за {minPrice.ToString("C", new CultureInfo("uk-UA"))}:");
            foreach (var animal in animals)
            {
                if (animal.Price > minPrice)
                {
                    Console.WriteLine($"Назва: {animal.Name}, Тип: {animal.Type}, Ціна: {animal.Price.ToString("C", new CultureInfo("uk-UA"))}");
                }
            }
        }

        public static void DisplayAnimalStatistics()
        {
            Console.WriteLine($"Загальна кількість тварин: {animals.Count}");
            if (animals.Count > 0)
            {
                decimal averagePrice = 0;
                foreach (var animal in animals)
                {
                    averagePrice += animal.Price;
                }
                averagePrice /= animals.Count;
                Console.WriteLine($"Середня ціна: {averagePrice.ToString("C", new CultureInfo("uk-UA"))}");
            }
        }
    }
}

