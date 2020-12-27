
namespace cSharpIntroWinForms.IB190017
{
    partial class KorisnikSlikePregled
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
            this.btnManji = new System.Windows.Forms.Button();
            this.btnVeci = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManji
            // 
            this.btnManji.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManji.Location = new System.Drawing.Point(33, 125);
            this.btnManji.Name = "btnManji";
            this.btnManji.Size = new System.Drawing.Size(107, 151);
            this.btnManji.TabIndex = 0;
            this.btnManji.Text = "<";
            this.btnManji.UseVisualStyleBackColor = true;
            this.btnManji.Click += new System.EventHandler(this.btnManji_Click);
            // 
            // btnVeci
            // 
            this.btnVeci.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeci.Location = new System.Drawing.Point(512, 125);
            this.btnVeci.Name = "btnVeci";
            this.btnVeci.Size = new System.Drawing.Size(107, 151);
            this.btnVeci.TabIndex = 1;
            this.btnVeci.Text = ">";
            this.btnVeci.UseVisualStyleBackColor = true;
            this.btnVeci.Click += new System.EventHandler(this.btnVeci_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(146, 12);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(360, 419);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 2;
            this.pbSlika.TabStop = false;
            this.pbSlika.DoubleClick += new System.EventHandler(this.pbSlika_DoubleClick);
            // 
            // KorisnikSlikePregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 443);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnVeci);
            this.Controls.Add(this.btnManji);
            this.Name = "KorisnikSlikePregled";
            this.Text = "Slike korisnika";
            this.Load += new System.EventHandler(this.KorisnikSlikePregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManji;
        private System.Windows.Forms.Button btnVeci;
        private System.Windows.Forms.PictureBox pbSlika;
    }
}