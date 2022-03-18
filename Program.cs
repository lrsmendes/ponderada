using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nome
{
    class Program
    {
        static void Main(string[] args)
        {   // Por L.R. Mendes, (c) 2022
            Console.WriteLine("(c)Raziel, 2022\n");

            Double a, b, c, med;
            Console.WriteLine("Escreva as três notas:");
            Console.Write("\n1ª: ");

            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n2ª: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n3ª: ");
            c = Convert.ToDouble(Console.ReadLine());


            med = (a * 2 + b * 3 + c * 5) / 10;
            Console.WriteLine("\n");
            Console.WriteLine("A sua média é igual a: " + med);

            Console.Write("\nAperte uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
