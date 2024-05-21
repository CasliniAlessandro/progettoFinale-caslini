using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace progettoFinale_caslini
{
  public partial class Form1 : Form
  {
      public LibriDisponibili libridisp = new LibriDisponibili();
      public LibriDisponibili libriven = new LibriDisponibili();

      public Form1()
      {
         InitializeComponent();
      }
      private void Form1_Load(object sender, EventArgs e)
      {

         libridisp.CaricaLibrild("libri.json");
	     libriven.CaricaLibrild("librivenduti.json");
         AggiornaListView();


      }
      private void AggiornaListView()
      {
	      listView1.Items.Clear();
          listView2.Items.Clear();

          foreach (var libro in libridisp.GetLibri())
          {
             listView1.Items.Add("Titolo: " + libro.Titolo + "   Autore: " + libro.Autore + "   Prezzo: " + libro.Prezzo);
                
          }

          // Aggiorna la listView1 escludendo i libri presenti nella listView2
          foreach (var libro in libriven.GetLibri())
	      {

			listView2.Items.Add("Titolo: " + libro.Titolo + "   Autore: " + libro.Autore + "   Prezzo: " + libro.Prezzo);
				
	      }
	  }


      private void btnAggiorna1_Click(object sender, EventArgs e)
      {
            string titolo = txtTitolo1.Text;
            string autore = txtAutore1.Text;
            string prezzo = txtPrezzo1.Text;

            // Controlla se il prezzo è un numero valido
            if (!decimal.TryParse(prezzo, out decimal prezzoDecimal))
            {
                MessageBox.Show("Il prezzo deve essere un numero valido.");
                return;
            }

            // Controlla se l'autore contiene solo lettere
            if (!Regex.IsMatch(autore, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("L'autore deve contenere solo lettere.");
                return;
            }

            if (string.IsNullOrWhiteSpace(titolo) || string.IsNullOrWhiteSpace(autore))
            {
                MessageBox.Show("Inserire titolo e autore del libro.");
                return;
            }

            if (!libridisp.getLibroByTitolo(titolo))
            {
                libridisp.AggiungiLibro(titolo, autore, prezzo);
                AggiornaListView();
                libridisp.SalvaLibrild("libri.json");
            }
      }


	  private void btnModifica_Click(object sender, EventArgs e)
      {
			  string titoloDaModificare = txtTitoloDaModificare.Text;
			  string autoreDaModificare = txtAutoreDaModificare.Text;
			  string prezzoDaModificare = txtPrezzoDaModificare.Text;

			  string nuovoTitolo = txtNuovoTitolo.Text;
			  string nuovoAutore = txtNuovoAutore.Text;
			  string nuovoPrezzo = txtNuovoPrezzo.Text;

			  // Controlla se sono stati inseriti tutti i valori necessari per la modifica
			  if (string.IsNullOrWhiteSpace(titoloDaModificare) || string.IsNullOrWhiteSpace(autoreDaModificare) ||
					string.IsNullOrWhiteSpace(nuovoTitolo) || string.IsNullOrWhiteSpace(nuovoAutore) || string.IsNullOrWhiteSpace(nuovoPrezzo))
			  {
				   MessageBox.Show("Inserire tutti i valori per la modifica del libro.");
				   return;
			  }

			  // Controlla se il nuovo prezzo è un numero valido
			  if (!decimal.TryParse(nuovoPrezzo, out decimal nuovoPrezzoDecimal))
			  {
				   MessageBox.Show("Il prezzo deve essere un numero valido.");
				   return;
			  }

			  // Controlla se il nuovo autore contiene solo lettere
			  if (!Regex.IsMatch(nuovoAutore, @"^[a-zA-Z\s]+$"))
			  {
				   MessageBox.Show("Il nuovo autore deve contenere solo lettere.");
				   return;
			  }

			  // Carica i libri dal file JSON
			  ModificaLibri.CaricaLibrilm("libri.json");

			  // Chiamata al metodo per modificare il libro nella ListView1
			  ModificaLibri.Modifica(libridisp.GetLibri(), titoloDaModificare, autoreDaModificare, prezzoDaModificare, nuovoTitolo, nuovoAutore, nuovoPrezzo);

			  // Salva le modifiche sul file JSON
			  ModificaLibri.SalvaLibrilm(libridisp.GetLibri(), "libri.json");

			  // Aggiorna la ListView1
			  AggiornaListView();

			  // Visualizza un messaggio di conferma
			  MessageBox.Show("Libro modificato con successo.");
	  }
      private void btnRicerca_Click(object sender, EventArgs e)
      {
			string titoloDaRicercare = txtTitoloDaRicercare.Text;
			string autoreDaRicercare = txtAutoreDaRicercare.Text;
			string prezzoDaRicercare = txtPrezzoDaRicercare.Text;


			
			if(libridisp.getLibroByTitolo(titoloDaRicercare))
			{
				if (!libriven.getLibroByTitolo(titoloDaRicercare))
				{
					libridisp.RimuoviLibroPerTitolo(titoloDaRicercare);
                    libridisp.SalvaLibrild("libri.json");
					libriven.AggiungiLibro(titoloDaRicercare,autoreDaRicercare,prezzoDaRicercare);
                    AggiornaListView();
                    libriven.SalvaLibrild("librivenduti.json");
                }

               AggiornaListView();

            }

	  }


    }

}

