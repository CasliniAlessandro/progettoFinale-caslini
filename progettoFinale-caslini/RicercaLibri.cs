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
	public class RicercaLibri
	{

		public static void RimuoviLibroDaArchivioPrincipale(List<Libro> libri, string titolo, string autore, string prezzo, string filePath)
		{
			// Cerca il libro nella lista
			Libro libroDaRimuovere = libri.Find(libro =>
					libro.Titolo == titolo &&
					libro.Autore == autore &&
					libro.Prezzo == prezzo);

			// Se il libro esiste, rimuovilo dalla lista
			if (libroDaRimuovere != null)
			{
				libri.Remove(libroDaRimuovere);
				// Salva la lista aggiornata nel file JSON
				SalvaLibriPrincipale(libri, filePath);
			}
		}

		private static void SalvaLibriPrincipale(List<Libro> libri, string filePath)
		{
			string jsonText = JsonConvert.SerializeObject(libri, Formatting.Indented);
			File.WriteAllText(filePath, jsonText);
		}
		public static void Ricerca(ListView listView1, ListView listView2, string titoloDaRicercare, string autoreDaRicercare, string prezzoDaRicercare)
		{
			// Pulisce la ListView2
			listView2.Items.Clear();

			// Carica i libri venduti
			List<Libro> libriVenduti = CaricaLibriVenduti("librivenduti.json");

			// Cerca il libro nella ListView1 e aggiunge quelli corrispondenti alla ListView2
			foreach (ListViewItem item in listView1.Items)
			{
				string[] libroInfo = item.Text.Split(new string[] { "   " }, StringSplitOptions.RemoveEmptyEntries);
				string titolo = libroInfo[0].Replace("Titolo: ", "");
				string autore = libroInfo[1].Replace("Autore: ", "");
				string prezzo = libroInfo[2].Replace("Prezzo: ", "");

				if ((string.IsNullOrEmpty(titoloDaRicercare) || titolo.Contains(titoloDaRicercare)) &&
						(string.IsNullOrEmpty(autoreDaRicercare) || autore.Contains(autoreDaRicercare)) &&
						(string.IsNullOrEmpty(prezzoDaRicercare) || prezzo.Contains(prezzoDaRicercare)))
				{
					// Aggiunge il libro trovato alla ListView2
					listView2.Items.Add(item.Text);
					// Rimuove il libro dalla ListView1
					item.Remove();

					// Aggiunge il libro venduto alla lista dei libri venduti
					Libro libroVenduto = new Libro(titolo, autore, prezzo);
					libriVenduti.Add(libroVenduto);
					// Rimuove il libro dall'archivio principale
					RimuoviLibroDaArchivioPrincipale(libriVenduti, titolo, autore, prezzo, "libri.json");

					// Aggiunge il libro venduto alla lista dei libri venduti
					libriVenduti.Add(libroVenduto);

				}
			}

			// Salva i libri venduti
			SalvaLibriVenduti(libriVenduti, "librivenduti.json");

			// Se non viene trovato alcun libro, mostra un messaggio
			if (listView2.Items.Count == 0)
			{
				MessageBox.Show("Nessun libro corrispondente trovato.");
			}
		}

		private static void SalvaLibriVenduti(List<Libro> libriVenduti, string filePath)
		{
			string jsonText = JsonConvert.SerializeObject(libriVenduti, Formatting.Indented);
			File.WriteAllText(filePath, jsonText);
		}

		private static List<Libro> CaricaLibriVenduti(string filePath)
		{
			List<Libro> libriVenduti = new List<Libro>();

			if (File.Exists(filePath))
			{
				string jsonText = File.ReadAllText(filePath);
				libriVenduti = JsonConvert.DeserializeObject<List<Libro>>(jsonText);
			}

			return libriVenduti;
		}
	}
}
