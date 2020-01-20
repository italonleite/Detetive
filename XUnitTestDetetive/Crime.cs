using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestDetetive
{
    public class Crime
    {
        

        public int SupeitoId { get; set; }
        public int LocalId { get; set; }
        public int ArmaId { get; set; }

        public Retorno Retorno { get; set; }

        public Crime(int supeitoId, int localId, int armaId)
        {
            SupeitoId = supeitoId;
            LocalId = localId;
            ArmaId = armaId;
        }

        public Crime()
        {

        }


        public List<Retorno> InvestigarCrime(List<Teoria> t, Crime c) {

            List<Retorno> retornos = new List<Retorno>();
            for (int i = 0; i < t.Count; i++) {
                if (t[i].Supeito.Id == c.SupeitoId && t[i].Local.Id == c.LocalId && t[i].Arma.Id == c.ArmaId) {
                  retornos.Add(Retorno.Acertou);
                }
            }
            return retornos;
            
        }
    }
}
