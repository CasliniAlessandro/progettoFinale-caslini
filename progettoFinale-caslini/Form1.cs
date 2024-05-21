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
        public Saldo saldo = new Saldo();

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
            saldo.Reset();

            foreach (var libro in libridisp.GetLibri())
            {
                listView1.Items.Add("Titolo: " + libro.Titolo + "   Autore: " + libro.Autore + "   Prezzo: " + libro.Prezzo);
            }

            // Aggiorna la listView1 escludendo i libri presenti nella listView2
            foreach (var libro in libriven.GetLibri())
            {

                listView2.Items.Add("Titolo: " + libro.Titolo + "   Autore: " + libro.Autore + "   Prezzo: " + libro.Prezzo);
                if (decimal.TryParse(libro.Prezzo, out decimal prezzoDecimal))
                {
                    saldo.AggiungiPrezzo(prezzoDecimal);
                }
            }
            txtSommaPrezzi.Text = saldo.SommaPrezzi.ToString("F2"); // Mostra la somma formattata con due decimali
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

            if (libridisp.getLibroByTitolo(titoloDaRicercare))
            {
                if (!libriven.getLibroByTitolo(titoloDaRicercare))
                {
                    libridisp.RimuoviLibroPerTitolo(titoloDaRicercare);
                    libridisp.SalvaLibrild("libri.json");
                    libriven.AggiungiLibro(titoloDaRicercare, autoreDaRicercare, prezzoDaRicercare);
                    AggiornaListView();
                    libriven.SalvaLibrild("librivenduti.json");
                }

                AggiornaListView();

            }

        }

        private void btnCancellaLibro_Click(object sender, EventArgs e)
        {
            // Controlla se un libro è selezionato nella listView1
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    // Estrai il titolo del libro selezionato
                    string libroInfo = selectedItem.Text;
                    string titolo = libroInfo.Split(new string[] { "   " }, StringSplitOptions.None)[0].Replace("Titolo: ", "");

                    // Rimuovi il libro dalla lista dei libri disponibili
                    libridisp.RimuoviLibroPerTitolo(titolo);

                    // Rimuovi l'elemento dalla listView1
                    listView1.Items.Remove(selectedItem);
                }

                // Salva la lista aggiornata dei libri nel file JSON
                libridisp.SalvaLibrild("libri.json");

                // Aggiorna la listView
                AggiornaListView();
            }
            else
            {
                MessageBox.Show("Seleziona un libro da cancellare.");
            }
        }

        private void btnPulisciListview_Click(object sender, EventArgs e)
        {
            // Conferma la cancellazione di tutti i libri
            var result = MessageBox.Show("Sei sicuro di voler cancellare tutti i libri?", "Conferma Cancellazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Cancella tutti gli elementi dalla listView1
                listView1.Items.Clear();

                // Cancella tutti gli elementi dalla lista dei libri disponibili
                libridisp.SvuotaLibri();

                // Salva la lista vuota dei libri nel file JSON
                libridisp.SalvaLibrild("libri.json");

                // Aggiorna la listView
                AggiornaListView();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPuliscilistview2_Click(object sender, EventArgs e)
        {
            // Conferma la cancellazione di tutti i libri
            var result = MessageBox.Show("Sei sicuro di voler cancellare tutti i libri?", "Conferma Cancellazione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                // Cancella tutti gli elementi dalla listView2
                listView2.Items.Clear();

                // Cancella tutti gli elementi dalla lista dei libri venduti
                libriven.SvuotaLibri();

                // Salva la lista vuota dei libri venduti nel file JSON
                libriven.SalvaLibrild("librivenduti.json");

                // Aggiorna il saldo
                saldo.Reset();
                txtSommaPrezzi.Text = saldo.SommaPrezzi.ToString("F2");

                // Aggiorna le listView
                AggiornaListView();
            }

        }
    }
}

