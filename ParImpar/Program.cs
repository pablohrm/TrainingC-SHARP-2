using System;
using System.Collections.Generic;
using ParImpar.Entities;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Par> pars = new List<Par>();
            List<Impar> impars = new List<Impar>();

            Console.WriteLine("Digite 10 numeros: ");

            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Numero: ");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    pars.Add(new Par(n));
                } else
                {
                    impars.Add(new Impar(n));
                }
            }

            foreach(Par p in pars)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine();

            foreach(Impar i in impars)
            {
                Console.WriteLine(i.ToString());
            }
        }

    }
}
