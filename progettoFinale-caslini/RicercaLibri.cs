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

		public static void Ricerca(ListView listView1, ListView listView2, string titoloDaRicercare, string autoreDaRicercare, string prezzoDaRicercare)
		{
			List<Libro> libriVenduti = new List<Libro>();
			List<string> titoliListView2 = new List<string>();

			foreach (ListViewItem item in listView2.Items)
			{
				string[] libroInfo = item.Text.Split(new string[] { "   " }, StringSplitOptions.RemoveEmptyEntries);
				string titolo = libroInfo[0].Replace("Titolo: ", "");
				titoliListView2.Add(titolo);
			}

			for (int i = listView1.Items.Count - 1; i >= 0; i--)
			{
				ListViewItem item = listView1.Items[i];
				string[] libroInfo = item.Text.Split(new string[] { "   " }, StringSplitOptions.RemoveEmptyEntries);
				string titolo = libroInfo[0].Replace("Titolo: ", "");
				string autore = libroInfo[1].Replace("Autore: ", "");
				string prezzo = libroInfo[2].Replace("Prezzo: ", "");

				if ((string.IsNullOrEmpty(titoloDaRicercare) || titolo.Contains(titoloDaRicercare)) &&
						(string.IsNullOrEmpty(autoreDaRicercare) || autore.Contains(autoreDaRicercare)) &&
						(string.IsNullOrEmpty(prezzoDaRicercare) || prezzo.Contains(prezzoDaRicercare)))
				{
					if (!titoliListView2.Contains(titolo))
					{
						ListViewItem newItem = new ListViewItem(item.Text);
						listView1.Items.RemoveAt(i);
						listView2.Items.Add(newItem);

						Libro libroVenduto = new Libro(titolo, autore, prezzo);
						libriVenduti.Add(libroVenduto);
					}
				}
			}

			if (libriVenduti.Count > 0)
			{
				LibriDisponibili libridisp = new LibriDisponibili();
				libridisp.CaricaLibrild("libri.json");
				libridisp.RimuoviLibriVenduti(libriVenduti);
				libridisp.AggiungiLibriVenduti(libriVenduti);
			}

			if (listView2.Items.Count == 0)
			{
				MessageBox.Show("Nessun libro corrispondente trovato.");
			}
		}

		public static void SalvaLibriVenduti(List<Libro> libriVenduti, string filePath)
    {
        string jsonText = JsonConvert.SerializeObject(libriVenduti, Formatting.Indented);
        File.WriteAllText(filePath, jsonText);
    }

    public static List<Libro> CaricaLibriVenduti(string filePath)
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
