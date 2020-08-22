using System;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfFruit = "Banana";
            char startingLetterOfFruitName = 'B';
            int numberOfFruit = 3;
            double weightOfFruit = 60.5;
            decimal priceOfFruit = 0.85m;
            bool tasteOfFruit = true;

            Console.WriteLine($"Fruit Name: {nameOfFruit}\n" +
                              $"First Letter of Fruit Name: {startingLetterOfFruitName}\n" +
                              $"Number of {nameOfFruit}: {numberOfFruit}\n" +
                              $"Weight of {nameOfFruit}: {weightOfFruit}g\n" +
                              $"Price of {nameOfFruit}: ${priceOfFruit}\n" +
                              $"Taste of {nameOfFruit} is Good: {tasteOfFruit}");
        }
    }
}
