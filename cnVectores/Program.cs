using System;

class Program
{
    static void PoblarVector(int[] vector)
    {
        Random random = new Random();

        for (int i = 0; i < vector.Length; i++)
        {

            vector[i] = random.Next(1, 101);
            Console.WriteLine($"Poblar con: " + vector[i]);
        }
    }
    static void ImprimirVector(int[] vector)
    {
        Console.WriteLine("Imprimir");

        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine($"Posición {i + 1}: {vector[i]}");
        }
    }
    static void Main(string[] args)
    {
        int[] vector1 = new int[6];
        PoblarVector(vector1);
        ImprimirVector(vector1);
    }
}