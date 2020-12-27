
namespace cSharpIntroWinForms.IspitIB190017
{
    partial class GodineStudijaFormIB190017
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
            this.components = new System.ComponentModel.Container();
            this.txtGodina = new System.Windows.Forms.TextBox();
            this.cbAktivna = new System.Windows.Forms.CheckBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.dgvGodineStudija = new System.Windows.Forms.DataGridView();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aktivna = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodineStudija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGodina
            // 
            this.txtGodina.Location = new System.Drawing.Point(12, 14);
            this.txtGodina.Name = "txtGodina";
            this.txtGodina.Size = new System.Drawing.Size(272, 20);
            this.txtGodina.TabIndex = 0;
            // 
            // cbAktivna
            // 
            this.cbAktivna.AutoSize = true;
            this.cbAktivna.Location = new System.Drawing.Point(306, 16);
            this.cbAktivna.Name = "cbAktivna";
            this.cbAktivna.Size = new System.Drawing.Size(62, 17);
            this.cbAktivna.TabIndex = 1;
            this.cbAktivna.Text = "Aktivna";
            this.cbAktivna.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(374, 12);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 2;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // dgvGodineStudija
            // 
            this.dgvGodineStudija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGodineStudija.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Aktivna});
            this.dgvGodineStudija.Location = new System.Drawing.Point(13, 41);
            this.dgvGodineStudija.Name = "dgvGodineStudija";
            this.dgvGodineStudija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGodineStudija.Size = new System.Drawing.Size(436, 168);
            this.dgvGodineStudija.TabIndex = 3;
            this.dgvGodineStudija.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGodineStudija_CellDoubleClick);
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Aktivna
            // 
            this.Aktivna.DataPropertyName = "Aktivna";
            this.Aktivna.HeaderText = "Aktivna";
            this.Aktivna.Name = "Aktivna";
            // 
            // errNaziv
            // 
            this.errNaziv.ContainerControl = this;
            // 
            // GodineStudijaFormIB190017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 221);
            this.Controls.Add(this.dgvGodineStudija);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cbAktivna);
            this.Controls.Add(this.txtGodina);
            this.Name = "GodineStudijaFormIB190017";
            this.Text = "GodineStudijaFormIB190017";
            this.Load += new System.EventHandler(this.GodineStudijaFormIB190017_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGodineStudija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNaziv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGodina;
        private System.Windows.Forms.CheckBox cbAktivna;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.DataGridView dgvGodineStudija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aktivna;
        private System.Windows.Forms.ErrorProvider errNaziv;
    }
}