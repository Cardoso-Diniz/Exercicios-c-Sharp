using System;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            for (int p = 0; p < numeros.Length; p++)
            {
                Console.Write("Digite um número:");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(numeros);
            Console.WriteLine("\n");
            Console.WriteLine($"O menor número digitado é: {numeros[0]}");
            Console.WriteLine($"O maior número digitado é: {numeros[9]}");
        }
    }
}