using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace progettoFinale_caslini
{
    public class ModificaLibri
    {
        // Metodo per modificare un libro nella ListView1
        public static void Modifica(List<Libro> libri, string titoloDaModificare, string autoreDaModificare, string prezzoDaModificare, string nuovoTitolo, string nuovoAutore, string nuovoPrezzo)
        {
            // Cerca il libro da modificare nella ListView1

            foreach (var libro in libri)
            {
                if (libro.Titolo == titoloDaModificare && libro.Autore == autoreDaModificare && libro.Prezzo== prezzoDaModificare)
                {
                    libro.Titolo = nuovoTitolo;
                    libro.Autore = nuovoAutore;
                    libro.Prezzo = nuovoPrezzo;
                    return;
                }
            }

            MessageBox.Show("Il libro da modificare non è stato trovato.");

        }

        // Metodo per salvare la lista di libri su un file JSON
        public static void SalvaLibrilm(List<Libro> libri, string filePath)
        {
            string jsonText = JsonConvert.SerializeObject(libri, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, jsonText);
        }

        // Metodo per caricare i libri da un file JSON
        public static List<Libro> CaricaLibrilm(string filePath)
        {
            List<Libro> libri = new List<Libro>();

            if (File.Exists(filePath))
            {
                string jsonText = File.ReadAllText(filePath);
                libri = JsonConvert.DeserializeObject<List<Libro>>(jsonText);
            }

            return libri;
        }
    }
}
