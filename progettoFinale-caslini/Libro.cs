using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progettoFinale_caslini
{
    public class Libro
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }

        public string Prezzo { get; set; }

        public Libro(string titolo, string autore, string prezzo)
        {
            Titolo = titolo; 
            Autore = autore;
            Prezzo = prezzo;

        }
    }
}
