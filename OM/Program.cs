using System;

class Program
{
    static void Main()
    {
        double[] Z = new double[16];
        Random random = new Random();

        
        for (int i = 0; i < Z.Length; i++)
        {
            Z[i] = random.NextDouble() * 100;
        }

        double sumEvenIndex = 0;
        double sumIndexMultipleOfThree = 0;

        for (int i = 0; i < Z.Length; i++)
        {
            if (i % 2 == 0)
            {
                sumEvenIndex += Z[i];
            }

            if (i % 3 == 0)
            {
                sumIndexMultipleOfThree += Z[i];
            }
        }

        double difference = sumEvenIndex - sumIndexMultipleOfThree;

        Console.WriteLine("Массив Z:");
        foreach (var item in Z)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Сумма элементов с четными индексами: " + sumEvenIndex);
        Console.WriteLine("Сумма элементов, индексы которых кратны трем: " + sumIndexMultipleOfThree);
        Console.WriteLine("Разность: " + difference);
    }
}
