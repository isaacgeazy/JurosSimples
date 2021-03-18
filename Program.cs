using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string ent1, ent2, ent3;
            int t;
            decimal c, m, j, i;

            Console.Write("Capital: ");
            ent1 = Console.ReadLine();
            Console.Write("Taxa de juros: ");
            ent2 = Console.ReadLine();
            Console.Write("Tempo (meses): ");
            ent3 = Console.ReadLine();

            c = Convert.ToDecimal(ent1);
            i = Convert.ToDecimal(ent2);
            t = Convert.ToInt16(ent3);

            j = c * i * t;
            m = (c + j);
            
            Console.WriteLine();
            Console.WriteLine($"Juros simples.: {j}");
            Console.WriteLine($"Montante.: {m}");


        }
    }
}
