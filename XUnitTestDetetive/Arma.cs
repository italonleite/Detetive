using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestDetetive
{
    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Arma(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Arma()
        {
        }
    }
}
