using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestDetetive
{
    public class Local
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Local(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Local()
        {
        }
    }
}
