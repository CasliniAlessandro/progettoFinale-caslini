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

		// Metodo per rimuovere i libri venduti dalla lista dei libri disponibili
		public void RimuoviLibriVenduti(List<Libro> libriVenduti)
		{
			foreach (var libroVenduto in libriVenduti)
			{
				libri.RemoveAll(libro => libro.Titolo == libroVenduto.Titolo && libro.Autore == libroVenduto.Autore && libro.Prezzo == libroVenduto.Prezzo);
			}
			SalvaLibrild("libri.json");
		}


		// Metodo per aggiungere i libri venduti al file librivenduti.json
		public void AggiungiLibriVenduti(List<Libro> libriVenduti)
		{
			List<Libro> libriVendutiEsistenti = RicercaLibri.CaricaLibriVenduti("librivenduti.json");

			// Aggiungi solo i libri che non sono già nella lista dei libri venduti
			foreach (var libro in libriVenduti)
			{
				if (!libriVendutiEsistenti.Any(l => l.Titolo == libro.Titolo && l.Autore == libro.Autore && l.Prezzo == libro.Prezzo))
				{
					libriVendutiEsistenti.Add(libro);
				}
			}

			RicercaLibri.SalvaLibriVenduti(libriVendutiEsistenti, "librivenduti.json");
		}
	}
}
