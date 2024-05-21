namespace progettoFinale_caslini
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnAggiorna1 = new System.Windows.Forms.Button();
            this.txtTitolo1 = new System.Windows.Forms.TextBox();
            this.txtAutore1 = new System.Windows.Forms.TextBox();
            this.txtPrezzo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtTitoloDaModificare = new System.Windows.Forms.TextBox();
            this.txtAutoreDaModificare = new System.Windows.Forms.TextBox();
            this.txtPrezzoDaModificare = new System.Windows.Forms.TextBox();
            this.txtNuovoTitolo = new System.Windows.Forms.TextBox();
            this.txtNuovoAutore = new System.Windows.Forms.TextBox();
            this.txtNuovoPrezzo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRicerca = new System.Windows.Forms.Button();
            this.txtPrezzoDaRicercare = new System.Windows.Forms.TextBox();
            this.txtAutoreDaRicercare = new System.Windows.Forms.TextBox();
            this.txtTitoloDaRicercare = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSommaPrezzi = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCancellaLibro = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.btnPulisciListview = new System.Windows.Forms.Button();
            this.btnPuliscilistview2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 278);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // btnAggiorna1
            // 
            this.btnAggiorna1.Location = new System.Drawing.Point(328, 39);
            this.btnAggiorna1.Name = "btnAggiorna1";
            this.btnAggiorna1.Size = new System.Drawing.Size(100, 48);
            this.btnAggiorna1.TabIndex = 1;
            this.btnAggiorna1.Text = "AGGIORNA";
            this.btnAggiorna1.UseVisualStyleBackColor = true;
            this.btnAggiorna1.Click += new System.EventHandler(this.btnAggiorna1_Click);
            // 
            // txtTitolo1
            // 
            this.txtTitolo1.Location = new System.Drawing.Point(328, 93);
            this.txtTitolo1.Name = "txtTitolo1";
            this.txtTitolo1.Size = new System.Drawing.Size(100, 20);
            this.txtTitolo1.TabIndex = 2;
            // 
            // txtAutore1
            // 
            this.txtAutore1.Location = new System.Drawing.Point(328, 119);
            this.txtAutore1.Name = "txtAutore1";
            this.txtAutore1.Size = new System.Drawing.Size(100, 20);
            this.txtAutore1.TabIndex = 3;
            // 
            // txtPrezzo1
            // 
            this.txtPrezzo1.Location = new System.Drawing.Point(328, 145);
            this.txtPrezzo1.Name = "txtPrezzo1";
            this.txtPrezzo1.Size = new System.Drawing.Size(100, 20);
            this.txtPrezzo1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titolo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezzo";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(762, 39);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(286, 293);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(27, 427);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(109, 100);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // txtTitoloDaModificare
            // 
            this.txtTitoloDaModificare.Location = new System.Drawing.Point(213, 427);
            this.txtTitoloDaModificare.Name = "txtTitoloDaModificare";
            this.txtTitoloDaModificare.Size = new System.Drawing.Size(100, 20);
            this.txtTitoloDaModificare.TabIndex = 10;
            // 
            // txtAutoreDaModificare
            // 
            this.txtAutoreDaModificare.Location = new System.Drawing.Point(213, 468);
            this.txtAutoreDaModificare.Name = "txtAutoreDaModificare";
            this.txtAutoreDaModificare.Size = new System.Drawing.Size(100, 20);
            this.txtAutoreDaModificare.TabIndex = 11;
            // 
            // txtPrezzoDaModificare
            // 
            this.txtPrezzoDaModificare.Location = new System.Drawing.Point(213, 507);
            this.txtPrezzoDaModificare.Name = "txtPrezzoDaModificare";
            this.txtPrezzoDaModificare.Size = new System.Drawing.Size(100, 20);
            this.txtPrezzoDaModificare.TabIndex = 12;
            // 
            // txtNuovoTitolo
            // 
            this.txtNuovoTitolo.Location = new System.Drawing.Point(387, 427);
            this.txtNuovoTitolo.Name = "txtNuovoTitolo";
            this.txtNuovoTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtNuovoTitolo.TabIndex = 13;
            // 
            // txtNuovoAutore
            // 
            this.txtNuovoAutore.Location = new System.Drawing.Point(387, 468);
            this.txtNuovoAutore.Name = "txtNuovoAutore";
            this.txtNuovoAutore.Size = new System.Drawing.Size(100, 20);
            this.txtNuovoAutore.TabIndex = 14;
            // 
            // txtNuovoPrezzo
            // 
            this.txtNuovoPrezzo.Location = new System.Drawing.Point(387, 507);
            this.txtNuovoPrezzo.Name = "txtNuovoPrezzo";
            this.txtNuovoPrezzo.Size = new System.Drawing.Size(100, 20);
            this.txtNuovoPrezzo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 475);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "vecchio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 434);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "vecchio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 514);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "vecchio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Titolo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Autore";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Prezzo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 434);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "nuovo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(505, 475);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "nuovo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(504, 514);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "nuovo";
            // 
            // btnRicerca
            // 
            this.btnRicerca.Location = new System.Drawing.Point(328, 183);
            this.btnRicerca.Margin = new System.Windows.Forms.Padding(2);
            this.btnRicerca.Name = "btnRicerca";
            this.btnRicerca.Size = new System.Drawing.Size(208, 51);
            this.btnRicerca.TabIndex = 25;
            this.btnRicerca.Text = "RICERCA LIBRO DA VENDERE";
            this.btnRicerca.UseVisualStyleBackColor = true;
            this.btnRicerca.Click += new System.EventHandler(this.btnRicerca_Click);
            // 
            // txtPrezzoDaRicercare
            // 
            this.txtPrezzoDaRicercare.Location = new System.Drawing.Point(328, 297);
            this.txtPrezzoDaRicercare.Name = "txtPrezzoDaRicercare";
            this.txtPrezzoDaRicercare.Size = new System.Drawing.Size(100, 20);
            this.txtPrezzoDaRicercare.TabIndex = 26;
            // 
            // txtAutoreDaRicercare
            // 
            this.txtAutoreDaRicercare.Location = new System.Drawing.Point(328, 272);
            this.txtAutoreDaRicercare.Name = "txtAutoreDaRicercare";
            this.txtAutoreDaRicercare.Size = new System.Drawing.Size(100, 20);
            this.txtAutoreDaRicercare.TabIndex = 27;
            // 
            // txtTitoloDaRicercare
            // 
            this.txtTitoloDaRicercare.Location = new System.Drawing.Point(328, 248);
            this.txtTitoloDaRicercare.Name = "txtTitoloDaRicercare";
            this.txtTitoloDaRicercare.Size = new System.Drawing.Size(100, 20);
            this.txtTitoloDaRicercare.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(448, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Titolo da ricercare";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(445, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Autore da ricercare";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(443, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Prezzo da ricercare";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(120, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "LIBRI DISPONIBILI";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(868, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "LIBRI VENDUTI";
            // 
            // txtSommaPrezzi
            // 
            this.txtSommaPrezzi.Location = new System.Drawing.Point(970, 371);
            this.txtSommaPrezzi.Name = "txtSommaPrezzi";
            this.txtSommaPrezzi.Size = new System.Drawing.Size(78, 20);
            this.txtSommaPrezzi.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(927, 378);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Saldo:";
            // 
            // btnCancellaLibro
            // 
            this.btnCancellaLibro.Location = new System.Drawing.Point(328, 356);
            this.btnCancellaLibro.Name = "btnCancellaLibro";
            this.btnCancellaLibro.Size = new System.Drawing.Size(212, 48);
            this.btnCancellaLibro.TabIndex = 36;
            this.btnCancellaLibro.Text = "CANCELLA";
            this.btnCancellaLibro.UseVisualStyleBackColor = true;
            this.btnCancellaLibro.Click += new System.EventHandler(this.btnCancellaLibro_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(363, 340);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 13);
            this.label19.TabIndex = 37;
            this.label19.Text = "Seleziona il libro da cancellare ";
            // 
            // btnPulisciListview
            // 
            this.btnPulisciListview.Location = new System.Drawing.Point(27, 340);
            this.btnPulisciListview.Name = "btnPulisciListview";
            this.btnPulisciListview.Size = new System.Drawing.Size(286, 52);
            this.btnPulisciListview.TabIndex = 38;
            this.btnPulisciListview.Text = "PULISCI LISTA ";
            this.btnPulisciListview.UseVisualStyleBackColor = true;
            this.btnPulisciListview.Click += new System.EventHandler(this.btnPulisciListview_Click);
            // 
            // btnPuliscilistview2
            // 
            this.btnPuliscilistview2.Location = new System.Drawing.Point(762, 338);
            this.btnPuliscilistview2.Name = "btnPuliscilistview2";
            this.btnPuliscilistview2.Size = new System.Drawing.Size(286, 23);
            this.btnPuliscilistview2.TabIndex = 39;
            this.btnPuliscilistview2.Text = "button1";
            this.btnPuliscilistview2.UseVisualStyleBackColor = true;
            this.btnPuliscilistview2.Click += new System.EventHandler(this.btnPuliscilistview2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 539);
            this.Controls.Add(this.btnPuliscilistview2);
            this.Controls.Add(this.btnPulisciListview);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnCancellaLibro);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSommaPrezzi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTitoloDaRicercare);
            this.Controls.Add(this.txtAutoreDaRicercare);
            this.Controls.Add(this.txtPrezzoDaRicercare);
            this.Controls.Add(this.btnRicerca);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNuovoPrezzo);
            this.Controls.Add(this.txtNuovoAutore);
            this.Controls.Add(this.txtNuovoTitolo);
            this.Controls.Add(this.txtPrezzoDaModificare);
            this.Controls.Add(this.txtAutoreDaModificare);
            this.Controls.Add(this.txtTitoloDaModificare);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezzo1);
            this.Controls.Add(this.txtAutore1);
            this.Controls.Add(this.txtTitolo1);
            this.Controls.Add(this.btnAggiorna1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnAggiorna1;
        private System.Windows.Forms.TextBox txtTitolo1;
        private System.Windows.Forms.TextBox txtAutore1;
        private System.Windows.Forms.TextBox txtPrezzo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.TextBox txtTitoloDaModificare;
        private System.Windows.Forms.TextBox txtAutoreDaModificare;
        private System.Windows.Forms.TextBox txtPrezzoDaModificare;
        private System.Windows.Forms.TextBox txtNuovoTitolo;
        private System.Windows.Forms.TextBox txtNuovoAutore;
        private System.Windows.Forms.TextBox txtNuovoPrezzo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnRicerca;
		private System.Windows.Forms.TextBox txtPrezzoDaRicercare;
		private System.Windows.Forms.TextBox txtAutoreDaRicercare;
		private System.Windows.Forms.TextBox txtTitoloDaRicercare;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSommaPrezzi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCancellaLibro;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnPulisciListview;
        private System.Windows.Forms.Button btnPuliscilistview2;
    }
}

