using System;
using System.Collections.Generic;
using XUnitTestDetetive;

namespace ConsoleDetetive
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Teoria> teorias = new List<Teoria>();
            Suspeito s1 = new Suspeito();
            Local l1 = new Local();
            Arma a1 = new Arma();
            Crime crime = new Crime();

            crime.SupeitoId = 2;
            crime.LocalId = 3;
            crime.ArmaId = 1;

            s1.Id = 1;
            s1.Nome = "italo";

            l1.Id = 2;
            l1.Nome = "Redmond";

            a1.Id = 3;
            a1.Nome = "Peixeira";

            Teoria t1 = new Teoria(s1, l1, a1);
            teorias.Add(t1);



            var Resultado = crime.InvestigarCrime(teorias, crime);

            if (Resultado.Count == 1) {
                Console.WriteLine("Resutaldo: {0}", Resultado[0]);
            } else if (Resultado.Count == 2) {
                Console.WriteLine("Resutaldo: {0}, {1}", Resultado[0], Resultado[1]);
            } else if (Resultado.Count == 3) {
                Console.WriteLine("Resutaldo: {0}, {1}, {2}", Resultado[0], Resultado[1], Resultado[2]);

            }


            Console.ReadKey();
        }
    }
}
