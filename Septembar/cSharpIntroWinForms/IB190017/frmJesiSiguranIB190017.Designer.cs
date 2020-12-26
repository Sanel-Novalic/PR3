
namespace cSharpIntroWinForms.IB190017
{
    partial class frmJesiSiguranIB190017
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDA = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Da li zaista želite izbrisati svoj sadržaj ?";
            // 
            // btnDA
            // 
            this.btnDA.Location = new System.Drawing.Point(58, 58);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(75, 23);
            this.btnDA.TabIndex = 1;
            this.btnDA.Text = "DA";
            this.btnDA.UseVisualStyleBackColor = true;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // btnNE
            // 
            this.btnNE.Location = new System.Drawing.Point(303, 58);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(75, 23);
            this.btnNE.TabIndex = 2;
            this.btnNE.Text = "NE";
            this.btnNE.UseVisualStyleBackColor = true;
            this.btnNE.Click += new System.EventHandler(this.btnNE_Click);
            // 
            // frmJesiSiguranIB190017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 102);
            this.Controls.Add(this.btnNE);
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.label1);
            this.Name = "frmJesiSiguranIB190017";
            this.Text = "frmJesiSiguranIB190017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btnNE;
    }
}