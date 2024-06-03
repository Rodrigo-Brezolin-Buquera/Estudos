using System;

// 1. Maior e menor em 10 inputs
class Program
{
    static void Main()
    {
        Console.WriteLine("Entre com dez números inteiros:");

        int maior = 0;
        int menor = 10000000;

        for (int i = 0; i < 10; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input > maior) maior = input;
            if (input < menor) menor = input;
        }

        Console.WriteLine($"Maior: {maior}, menor: {menor}");
    }
}
