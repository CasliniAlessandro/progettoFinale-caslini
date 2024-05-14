using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace progettoFinale_caslini
{
    public class LibriDisponibili
    {
        // Lista di libri
        private List<Libro> libri = new List<Libro>();

        // Metodo per aggiungere un nuovo libro alla lista
        public void AggiungiLibro(string titolo, string autore, string prezzo)
        {
            libri.Add(new Libro(titolo, autore, prezzo));
        }

        // Metodo per salvare la lista di libri su un file JSON--> Serializzazione 
        public void SalvaLibrild(string filePath)
        {
            string jsonText = JsonConvert.SerializeObject(libri, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, jsonText);
        }

        // Metodo per caricare i libri da un file JSON--> Deserializzazione
        public void CaricaLibrild(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonText = File.ReadAllText(filePath);
                libri = JsonConvert.DeserializeObject<List<Libro>>(jsonText);
            }
        }

        // Metodo per ottenere la lista di libri
        public List<Libro> GetLibri()
        {
            return libri;
        }


    }
}
