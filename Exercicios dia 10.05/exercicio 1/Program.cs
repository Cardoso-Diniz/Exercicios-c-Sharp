using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoAtual = DateTime.Now.Year;
            Console.WriteLine("Em que ano você nasceu?!");
            int anoNasc = int.Parse(Console.ReadLine());
            int idade = anoAtual - anoNasc;
            if (idade < 16)
            {
                Console.WriteLine(@"
Você não possui idade necessaria para votar!");
            }
            else if (idade >= 16 && idade < 18)
            {
                Console.WriteLine(@"
Você já pode votar, mas ainda não é obrigatório!");
            }
            else if (idade >= 18)
            {
                Console.WriteLine(@"
Você já possui mais de 18 anos e deve votar!");
            }




        }
    }
}
