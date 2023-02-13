using System;

namespace myParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("How many values do you want to generate? ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rand.Next(1, 11);
            }
            Console.WriteLine("The random numbers are:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            int totalAdd = Add(numbers);
            Console.WriteLine("The sum of the numbers is " + totalAdd);
            int totalMultiply = Multiply(numbers);
            Console.WriteLine("The product of the numbers is " + totalMultiply);
        }

        static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        static int Multiply(params int[] numbers)
        {
            int total = 1;
            foreach (int num in numbers)
            {
                total *= num;
            }
            return total;
        }
    }
}
