using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progettoFinale_caslini
{
    public class Saldo
    {
        private decimal sommaPrezzi;

        public decimal SommaPrezzi
        {
            get { return sommaPrezzi; }
        }

        public void AggiungiPrezzo(decimal prezzo)
        {
            sommaPrezzi += prezzo;
        }

        public void Reset()
        {
            sommaPrezzi = 0;
        }
    }
}
