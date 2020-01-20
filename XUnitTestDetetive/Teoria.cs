using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestDetetive
{
   public class Teoria
    {
        public Suspeito Supeito { get; set; }
        public Local Local { get; set; }
        public Arma Arma { get; set; }

        public Teoria(Suspeito supeito, Local local, Arma arma)
        {
            Supeito = supeito;
            Local = local;
            Arma = arma;
        }



    }
}
