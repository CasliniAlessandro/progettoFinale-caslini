using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace progettoFinale_caslini
{
    public partial class Form1 : Form
    {
        public LibriDisponibili libridisp = new LibriDisponibili();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AggiornaListView()
        {
            listView1.Items.Clear();
            foreach (var libro in libridisp.GetLibri())
            {
                listView1.Items.Add("Titolo: " + libro.Titolo + "   Autore: " + libro.Autore + "   prezzo: " + libro.Prezzo);
            }
        }

        private void btnAggiorna1_Click(object sender, EventArgs e)
        {
            string titolo = txtTitolo1.Text;
            string autore = txtAutore1.Text;
            string prezzo = txtPrezzo1.Text;
            if (string.IsNullOrWhiteSpace(titolo) || string.IsNullOrWhiteSpace(autore))
            {
                MessageBox.Show("Inserire titolo e autore del libro.");
                return;
            }

            try
            {
                libridisp.AggiungiLibro(titolo, autore, prezzo);
                libridisp.SalvaLibrild("libri.json");
                libridisp.CaricaLibrild("libri.json");
                AggiornaListView();
                MessageBox.Show("Libro aggiunto con successo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'aggiunta del libro: " + ex.Message);
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
    }
}
