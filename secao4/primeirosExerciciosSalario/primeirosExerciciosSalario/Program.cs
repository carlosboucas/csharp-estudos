using System;
using System.Globalization;

namespace primeirosExerciciosSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Informe o nome do primeiro funcionário:");
            funcionario1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salário do primeiro funcionário:");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o nome do segundo funcionário:");
            funcionario2.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salário do segundo funcionário:");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario) / 2.00;

            Console.WriteLine("Salário médio: " + media);
        }
    }
}