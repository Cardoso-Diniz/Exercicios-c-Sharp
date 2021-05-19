using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite o nome do produto que você deseja: ");
            string nomeProduto = Console.ReadLine();
            Console.WriteLine($"Qual a quantidade de {nomeProduto} que você deseja? ");
            int qntProduto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o valor unitário de {nomeProduto}: (Se for um número decimal digite com . ) ");
            double valorProduto = double.Parse(Console.ReadLine());
            double valorTotal = qntProduto * valorProduto;
            if (qntProduto <= 5)
            {
                double vlrDesconto = valorTotal * 0.98;
                Console.WriteLine($"O valor a pagar com o desconto é: R$ {vlrDesconto}");
            }
            else if (qntProduto > 5 && qntProduto <=10)
            {
                double vlrDesconto = valorTotal * 0.97;
                Console.WriteLine($"O valor a pagar com o desconto é: R$ {vlrDesconto}");

            }
            else if (qntProduto > 10)
            {
                double vlrDesconto = valorTotal * 0.95;
                Console.WriteLine($"O valor a pagar com o desconto é: R$ {vlrDesconto}");

            }
        }
    }
}
