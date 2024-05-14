using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progettoFinale_caslini
{
    public LibriDisponibili libridisp = new LibriDisponibili();
    public partial class Form1 : Form

    {
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
            string titolo = txtTitolo.Text;
            string autore = txtAutore.Text;
            string prezzo = txtPrezzo.Text;
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
    }
}
