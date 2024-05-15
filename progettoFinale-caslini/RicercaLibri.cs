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
        // Carica i libri venduti solo una volta
        List<Libro> libriVenduti = CaricaLibriVenduti("librivenduti.json");

        // Lista per memorizzare gli oggetti ListViewItem rimossi
        List<ListViewItem> itemsRimossi = new List<ListViewItem>();

        // Lista dei titoli dei libri nella listView2
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
                // Controlla se il titolo del libro è presente nella listView2
                if (!titoliListView2.Contains(titolo))
                {
                    // Crea un nuovo ListViewItem per il libro
                    ListViewItem newItem = new ListViewItem(item.Text);

                    // Rimuove il libro dalla ListView1 e lo aggiunge alla ListView2
                    listView1.Items.RemoveAt(i);
                    listView2.Items.Add(newItem);

                    // Aggiunge il ListViewItem alla lista degli elementi rimossi
                    itemsRimossi.Add(item);
                }
            }
        }

        // Rimuove definitivamente gli oggetti rimossi dalla listView1
        foreach (var item in itemsRimossi)
        {
            item.Remove();
        }

        // Salva i libri venduti solo alla fine della ricerca
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
