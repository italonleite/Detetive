using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestDetetive
{
    public class Suspeito
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Suspeito(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Suspeito()
        {
        }
    }
}
