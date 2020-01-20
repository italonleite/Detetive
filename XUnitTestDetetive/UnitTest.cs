using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestDetetive
{
    public class UnitTest
    {
        [Fact]
        public void Deve_ter_5_suspeito()
        {
            List<Suspeito> Suspeitos = new List<Suspeito>();
            Suspeito s1 = new Suspeito();
            Suspeito s2 = new Suspeito();
            Suspeito s3 = new Suspeito();
            Suspeito s4 = new Suspeito();
            Suspeito s5 = new Suspeito();

            s1.Id = 1;
            s1.Nome = "italo";

            s2.Id = 2;
            s2.Nome = "Filipe";

            s3.Id = 3;
            s3.Nome = "Tiago";

            s4.Id = 4;
            s4.Nome = "Bernardo";

            s5.Id = 5;
            s5.Nome = "italo";

            Suspeitos.Add(s1);
            Suspeitos.Add(s2);
            Suspeitos.Add(s3);
            Suspeitos.Add(s4);
            Suspeitos.Add(s5);

            Assert.Equal(5, Suspeitos.Count);
        }

       [Fact]
        public void Deve_ter_5_local()
        {
            List<Local> localidades = new List<Local>();
            Local l1 = new Local();
            Local l2 = new Local();
            Local l3 = new Local();
            Local l4 = new Local();
            Local l5 = new Local();

            l1.Id = 1;
            l1.Nome = "Redmond";

            l2.Id = 2;
            l2.Nome = "Palo Alto";

            l3.Id = 3;
            l3.Nome = "San Francisco";

            l4.Id = 4;
            l4.Nome = "São Paulo";

            l5.Id = 5;
            l5.Nome = "Cupertino";

            localidades.Add(l1);
            localidades.Add(l2);
            localidades.Add(l3);
            localidades.Add(l4);
            localidades.Add(l5);

            Assert.Equal(5, localidades.Count);
        }

        [Fact]
        public void Deve_ter_5_arma()
        {
            List<Arma> armas = new List<Arma>();
            Arma a1 = new Arma();
            Arma a2 = new Arma();
            Arma a3 = new Arma();
            Arma a4 = new Arma();
            Arma a5 = new Arma();

            a1.Id = 1;
            a1.Nome = "Peixeira";

            a2.Id = 2;
            a2.Nome = "DynaTAC";

            a3.Id = 3;
            a3.Nome = "Trezoitão";

            a4.Id = 4;
            a4.Nome = "Trebuchet";

            a5.Id = 5;
            a5.Nome = "Maça";

            armas.Add(a1);
            armas.Add(a2);
            armas.Add(a3);
            armas.Add(a4);
            armas.Add(a5);

            Assert.Equal(5, armas.Count);
        }

        [Fact]
        public void Deve_ter_uma_ou_mais_teoria()
        {
            List<Teoria> teorias = new List<Teoria>();            
            Suspeito s1 = new Suspeito();
            Local l1 = new Local();
            Arma a1 = new Arma();

            s1.Id = 1;
            s1.Nome = "italo";

            l1.Id = 1;
            l1.Nome = "Redmond";

            a1.Id = 1;
            a1.Nome = "Peixeira";

           Teoria t1 = new Teoria(s1, l1, a1);

            teorias.Add(t1);
        }

        [Fact]
        public void Deve_investigar_crime_com_uma_Teoria()
        {
            List<Teoria> teorias = new List<Teoria>();
            Suspeito s1 = new Suspeito();
            Local l1 = new Local();
            Arma a1 = new Arma();
            Crime crime = new Crime();

            crime.SupeitoId = 1;
            crime.LocalId = 1;
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

            Assert.Equal(Retorno.Acertou, Resultado[0]);
                
                
        }

        //[Fact]
        //public void Deve_investigar_crime_com_n_Teorias()
        //{
        //    List<Teoria> teorias = new List<Teoria>();            
        //    Crime crime = new Crime();
        //    Suspeito s1 = new Suspeito();
        //    Suspeito s2 = new Suspeito();
        //    Suspeito s3 = new Suspeito();
        //    Suspeito s4 = new Suspeito();
        //    Suspeito s5 = new Suspeito();
        //    Local l1 = new Local();
        //    Local l2 = new Local();
        //    Local l3 = new Local();
        //    Local l4 = new Local();
        //    Local l5 = new Local();
        //    Arma a1 = new Arma();
        //    Arma a2 = new Arma();
        //    Arma a3 = new Arma();
        //    Arma a4 = new Arma();
        //    Arma a5 = new Arma();
            
        //    //Local do Crime
        //    crime.SupeitoId = 1;
        //    crime.LocalId = 2;
        //    crime.ArmaId = 3;

        //    //Suspeitos
        //    s1.Id = 1;
        //    s1.Nome = "italo";
        //    s2.Id = 2;
        //    s2.Nome = "Filipe";
        //    s3.Id = 3;
        //    s3.Nome = "Tiago";
        //    s4.Id = 4;
        //    s4.Nome = "Bernardo";
        //    s5.Id = 5;
        //    s5.Nome = "Peterson";

        //    //Local
        //    l1.Id = 1;
        //    l1.Nome = "Redmond";
        //    l2.Id = 2;
        //    l2.Nome = "Palo Alto";
        //    l3.Id = 3;
        //    l3.Nome = "San Francisco";
        //    l4.Id = 4;
        //    l4.Nome = "São Paulo";
        //    l5.Id = 5;
        //    l5.Nome = "Cupertino";

        //    a1.Id = 1;
        //    a1.Nome = "Peixeira";
        //    a2.Id = 2;
        //    a2.Nome = "DynaTAC";
        //    a3.Id = 3;
        //    a3.Nome = "Trezoitão";
        //    a4.Id = 4;
        //    a4.Nome = "Trebuchet";
        //    a5.Id = 5;
        //    a5.Nome = "Maça";

        //    Teoria t1 = new Teoria(s1, l1, a1);
        //    Teoria t2 = new Teoria(s2, l2, a2);
        //    Teoria t3 = new Teoria(s3, l3, a3);
        //    Teoria t4 = new Teoria(s4, l4, a4);
        //    Teoria t5 = new Teoria(s5, l5, a5);

        //    teorias.Add(t1);
        //    teorias.Add(t2);
        //    teorias.Add(t3);
        //    teorias.Add(t4);
        //    teorias.Add(t5);
                       
        //    var Resultado = crime.InvestigarCrime(teorias, crime);

        //    Assert.Equal(Retorno.Acertou, Resultado[0]);


        //}


    }
}
