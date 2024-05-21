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
			// Crea un nuovo libro
			Libro nuovoLibro = new Libro(titolo, autore, prezzo);

			// Aggiungi il nuovo libro alla lista
			libri.Add(nuovoLibro);
		}
		// Metodo per salvare la lista di libri su un file JSON
		public void SalvaLibrild(string filePath)
		{
			string jsonText = JsonConvert.SerializeObject(libri, Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText(filePath, jsonText);
		}
		// Metodo per caricare i libri da un file JSON
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
			return new List<Libro>(libri);
		}


        public bool getLibroByTitolo(string titoloDaRicercare)
        {
			foreach(Libro lib in libri)
			{
				if(lib.Titolo.Equals(titoloDaRicercare)) return true;
			}
			return false;
        }
        public void RimuoviLibroPerTitolo(string titolo)
        {
            Libro libroDaRimuovere = libri.FirstOrDefault(libro => libro.Titolo == titolo);
            if (libroDaRimuovere != null)
            {
                libri.Remove(libroDaRimuovere);
            }
        }
    }
}
