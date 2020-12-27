
namespace cSharpIntroWinForms.IB190017
{
    partial class frmPretragaBrojIndeksa_IB190017
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNazivPredmeta = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dgvKorisniciPredmeti = new System.Windows.Forms.DataGridView();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblThreading = new System.Windows.Forms.Label();
            this.txtThread = new System.Windows.Forms.TextBox();
            this.btnSumiraj = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poruke = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPredmeti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNazivPredmeta
            // 
            this.lblNazivPredmeta.AutoSize = true;
            this.lblNazivPredmeta.Location = new System.Drawing.Point(13, 13);
            this.lblNazivPredmeta.Name = "lblNazivPredmeta";
            this.lblNazivPredmeta.Size = new System.Drawing.Size(84, 13);
            this.lblNazivPredmeta.TabIndex = 0;
            this.lblNazivPredmeta.Text = "Naziv predmeta:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(104, 10);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(523, 20);
            this.txtNaziv.TabIndex = 1;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // dgvKorisniciPredmeti
            // 
            this.dgvKorisniciPredmeti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisniciPredmeti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.Predmet,
            this.Datum,
            this.Ocjena,
            this.Poruke});
            this.dgvKorisniciPredmeti.Location = new System.Drawing.Point(16, 48);
            this.dgvKorisniciPredmeti.Name = "dgvKorisniciPredmeti";
            this.dgvKorisniciPredmeti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisniciPredmeti.Size = new System.Drawing.Size(611, 138);
            this.dgvKorisniciPredmeti.TabIndex = 2;
            this.dgvKorisniciPredmeti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisniciPredmeti_CellContentClick);
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.Location = new System.Drawing.Point(30, 199);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(0, 13);
            this.lblProsjek.TabIndex = 3;
            // 
            // lblThreading
            // 
            this.lblThreading.AutoSize = true;
            this.lblThreading.Location = new System.Drawing.Point(356, 199);
            this.lblThreading.Name = "lblThreading";
            this.lblThreading.Size = new System.Drawing.Size(55, 13);
            this.lblThreading.TabIndex = 4;
            this.lblThreading.Text = "Threading";
            // 
            // txtThread
            // 
            this.txtThread.Location = new System.Drawing.Point(359, 215);
            this.txtThread.Name = "txtThread";
            this.txtThread.Size = new System.Drawing.Size(177, 20);
            this.txtThread.TabIndex = 5;
            // 
            // btnSumiraj
            // 
            this.btnSumiraj.Location = new System.Drawing.Point(552, 213);
            this.btnSumiraj.Name = "btnSumiraj";
            this.btnSumiraj.Size = new System.Drawing.Size(75, 23);
            this.btnSumiraj.TabIndex = 6;
            this.btnSumiraj.Text = "Sumiraj";
            this.btnSumiraj.UseVisualStyleBackColor = true;
            this.btnSumiraj.Click += new System.EventHandler(this.btnSumiraj_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Location = new System.Drawing.Point(356, 248);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(0, 13);
            this.lblSuma.TabIndex = 7;
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(359, 272);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(0, 13);
            this.lblRezultat.TabIndex = 8;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "Korisnik";
            this.ImePrezime.HeaderText = "Ime i prezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // Predmet
            // 
            this.Predmet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Predmet.DataPropertyName = "Predmet";
            this.Predmet.HeaderText = "Predmet";
            this.Predmet.Name = "Predmet";
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "Ocjena";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            // 
            // Poruke
            // 
            this.Poruke.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Poruke.HeaderText = "Poruke";
            this.Poruke.Name = "Poruke";
            this.Poruke.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Poruke.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmPretragaBrojIndeksa_IB190017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 315);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnSumiraj);
            this.Controls.Add(this.txtThread);
            this.Controls.Add(this.lblThreading);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.dgvKorisniciPredmeti);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNazivPredmeta);
            this.Name = "frmPretragaBrojIndeksa_IB190017";
            this.Text = "frmPretragaBrojIndeksa_IB190017";
            this.Load += new System.EventHandler(this.frmPretragaBrojIndeksa_IB190017_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisniciPredmeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNazivPredmeta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DataGridView dgvKorisniciPredmeti;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblThreading;
        private System.Windows.Forms.TextBox txtThread;
        private System.Windows.Forms.Button btnSumiraj;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.DataGridViewButtonColumn Poruke;
    }
}