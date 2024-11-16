using System;
using ZooLab_1.Services;

namespace ZooLab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ласкаво просимо до системи управління зоомагазином!");

            // Виклик методів із сервісів
            AnimalService.DisplayAnimals();
            AnimalService.AddAnimal("Попугай", "Птах", 1500.00M);
            AnimalService.DisplayAnimals();

            OrderService.DisplayOrdersWithDetails();
            AnimalService.DisplayExpensiveAnimals(1000);
            AnimalService.DisplayAnimalStatistics();
        }
    }
}
