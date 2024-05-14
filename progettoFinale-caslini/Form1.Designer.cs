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
            // 
            // btnAggiorna1
            // 
            this.btnAggiorna1.Location = new System.Drawing.Point(328, 39);
            this.btnAggiorna1.Name = "btnAggiorna1";
            this.btnAggiorna1.Size = new System.Drawing.Size(100, 48);
            this.btnAggiorna1.TabIndex = 1;
            this.btnAggiorna1.Text = "button1";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

