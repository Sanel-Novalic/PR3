
namespace cSharpIntroWinForms.IspitIB190017
{
    partial class GlavnaIB190017
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
            this.btnGodineStudija = new System.Windows.Forms.Button();
            this.btnPolozeniPredmeti = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtThread = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGodineStudija
            // 
            this.btnGodineStudija.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGodineStudija.Location = new System.Drawing.Point(23, 35);
            this.btnGodineStudija.Name = "btnGodineStudija";
            this.btnGodineStudija.Size = new System.Drawing.Size(183, 96);
            this.btnGodineStudija.TabIndex = 0;
            this.btnGodineStudija.Text = "Godine studija";
            this.btnGodineStudija.UseVisualStyleBackColor = true;
            this.btnGodineStudija.Click += new System.EventHandler(this.btnGodineStudija_Click);
            // 
            // btnPolozeniPredmeti
            // 
            this.btnPolozeniPredmeti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolozeniPredmeti.Location = new System.Drawing.Point(261, 35);
            this.btnPolozeniPredmeti.Name = "btnPolozeniPredmeti";
            this.btnPolozeniPredmeti.Size = new System.Drawing.Size(203, 96);
            this.btnPolozeniPredmeti.TabIndex = 1;
            this.btnPolozeniPredmeti.Text = "Položeni predmeti";
            this.btnPolozeniPredmeti.UseVisualStyleBackColor = true;
            this.btnPolozeniPredmeti.Click += new System.EventHandler(this.btnPolozeniPredmeti_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(489, 71);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(119, 60);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "Izračunaj sumu:";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtThread
            // 
            this.txtThread.Location = new System.Drawing.Point(489, 35);
            this.txtThread.Name = "txtThread";
            this.txtThread.Size = new System.Drawing.Size(119, 20);
            this.txtThread.TabIndex = 3;
            // 
            // GlavnaIB190017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 175);
            this.Controls.Add(this.txtThread);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnPolozeniPredmeti);
            this.Controls.Add(this.btnGodineStudija);
            this.Name = "GlavnaIB190017";
            this.Text = "GlavnaIB190017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGodineStudija;
        private System.Windows.Forms.Button btnPolozeniPredmeti;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtThread;
    }
}