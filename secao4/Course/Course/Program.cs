﻿using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));
            
            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área de X = " + areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4",CultureInfo.InvariantCulture));

            //if(areaX > areaY)
            //{
            //    Console.WriteLine("A área de X é a maior.");
            //}
            //if(areaY > areaX)
            //{
            //    Console.WriteLine("A área de Y é a maior.");
            //}
            //else
            //{
            //    Console.WriteLine("Os dois triânngulos possuem a mesma área.");
            //}

            string mensagem = areaX > areaY ? "A área de X é a maior." : "A área de Y é a maior.";
            Console.WriteLine(mensagem);

        }
    }
}