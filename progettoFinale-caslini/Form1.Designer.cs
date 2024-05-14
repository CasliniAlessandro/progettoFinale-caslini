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
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(27, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 293);
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
            this.label1.Location = new System.Drawing.Point(434, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezzo";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(744, 39);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(286, 293);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(27, 338);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(109, 100);
            this.btnModifica.TabIndex = 9;
            this.btnModifica.Text = "MODIFICA";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // txtTitoloDaModificare
            // 
            this.txtTitoloDaModificare.Location = new System.Drawing.Point(213, 338);
            this.txtTitoloDaModificare.Name = "txtTitoloDaModificare";
            this.txtTitoloDaModificare.Size = new System.Drawing.Size(100, 20);
            this.txtTitoloDaModificare.TabIndex = 10;
            // 
            // txtAutoreDaModificare
            // 
            this.txtAutoreDaModificare.Location = new System.Drawing.Point(213, 379);
            this.txtAutoreDaModificare.Name = "txtAutoreDaModificare";
            this.txtAutoreDaModificare.Size = new System.Drawing.Size(100, 20);
            this.txtAutoreDaModificare.TabIndex = 11;
            // 
            // txtPrezzoDaModificare
            // 
            this.txtPrezzoDaModificare.Location = new System.Drawing.Point(213, 418);
            this.txtPrezzoDaModificare.Name = "txtPrezzoDaModificare";
            this.txtPrezzoDaModificare.Size = new System.Drawing.Size(100, 20);
            this.txtPrezzoDaModificare.TabIndex = 12;
            // 
            // txtNuovoTitolo
            // 
            this.txtNuovoTitolo.Location = new System.Drawing.Point(387, 338);
            this.txtNuovoTitolo.Name = "txtNuovoTitolo";
            this.txtNuovoTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtNuovoTitolo.TabIndex = 13;
            // 
            // txtNuovoAutore
            // 
            this.txtNuovoAutore.Location = new System.Drawing.Point(387, 379);
            this.txtNuovoAutore.Name = "txtNuovoAutore";
            this.txtNuovoAutore.Size = new System.Drawing.Size(100, 20);
            this.txtNuovoAutore.TabIndex = 14;
            // 
            // txtNuovoPrezzo
            // 
            this.txtNuovoPrezzo.Location = new System.Drawing.Point(387, 418);
            this.txtNuovoPrezzo.Name = "txtNuovoPrezzo";
            this.txtNuovoPrezzo.Size = new System.Drawing.Size(100, 20);
            this.txtNuovoPrezzo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 450);
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
    }
}

