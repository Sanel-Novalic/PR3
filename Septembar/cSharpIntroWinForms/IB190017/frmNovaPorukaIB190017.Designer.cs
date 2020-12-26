
namespace cSharpIntroWinForms.IB190017
{
    partial class frmNovaPorukaIB190017
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
            this.lblPrimalac = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.lblSadrzaj = new System.Windows.Forms.Label();
            this.txtSadrzaj = new System.Windows.Forms.TextBox();
            this.errPrimalac = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.errSadrzaj = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errPrimalac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSadrzaj)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrimalac
            // 
            this.lblPrimalac.AutoSize = true;
            this.lblPrimalac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimalac.Location = new System.Drawing.Point(12, 9);
            this.lblPrimalac.Name = "lblPrimalac";
            this.lblPrimalac.Size = new System.Drawing.Size(73, 20);
            this.lblPrimalac.TabIndex = 0;
            this.lblPrimalac.Text = "Primalac:";
            // 
            // txtKorisnik
            // 
            this.txtKorisnik.Location = new System.Drawing.Point(16, 43);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.ReadOnly = true;
            this.txtKorisnik.Size = new System.Drawing.Size(245, 20);
            this.txtKorisnik.TabIndex = 1;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(409, 235);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(75, 23);
            this.btnSpasi.TabIndex = 3;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // lblSadrzaj
            // 
            this.lblSadrzaj.AutoSize = true;
            this.lblSadrzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSadrzaj.Location = new System.Drawing.Point(12, 75);
            this.lblSadrzaj.Name = "lblSadrzaj";
            this.lblSadrzaj.Size = new System.Drawing.Size(77, 24);
            this.lblSadrzaj.TabIndex = 4;
            this.lblSadrzaj.Text = "Sadržaj:";
            // 
            // txtSadrzaj
            // 
            this.txtSadrzaj.Location = new System.Drawing.Point(16, 103);
            this.txtSadrzaj.Multiline = true;
            this.txtSadrzaj.Name = "txtSadrzaj";
            this.txtSadrzaj.Size = new System.Drawing.Size(245, 126);
            this.txtSadrzaj.TabIndex = 5;
            // 
            // errPrimalac
            // 
            this.errPrimalac.ContainerControl = this;
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(278, 43);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(206, 186);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 2;
            this.pbSlika.TabStop = false;
            this.pbSlika.Click += new System.EventHandler(this.pbSlika_Click);
            // 
            // errSadrzaj
            // 
            this.errSadrzaj.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Slika:";
            // 
            // frmNovaPorukaIB190017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSadrzaj);
            this.Controls.Add(this.lblSadrzaj);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.lblPrimalac);
            this.Name = "frmNovaPorukaIB190017";
            this.Text = "Nova poruka";
            this.Load += new System.EventHandler(this.frmNovaPorukaIB190017_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errPrimalac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSadrzaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimalac;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Label lblSadrzaj;
        private System.Windows.Forms.TextBox txtSadrzaj;
        private System.Windows.Forms.ErrorProvider errPrimalac;
        private System.Windows.Forms.ErrorProvider errSadrzaj;
        private System.Windows.Forms.Label label1;
    }
}