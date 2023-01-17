using System;
using System.Globalization;

namespace primeirosExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Informe o nome da primeira pessoa:");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da primeira pessoa:");
            pessoa1.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o nome da segunda pessoa:");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade da segunda pessoa:");
            pessoa2.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é " + pessoa1.Nome);
            }
            if (pessoa1.Idade < pessoa2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é " + pessoa2.Nome);
            }
            else
            {
                Console.WriteLine("As duas pessoas possuem a mesma idade.");
            }
        }
    }
}