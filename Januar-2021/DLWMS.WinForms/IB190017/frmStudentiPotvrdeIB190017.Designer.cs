
namespace DLWMS.WinForms.IB190017
{
    partial class frmStudentiPotvrdeIB190017
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
            this.txtGenerisi = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.dgvPotvrde = new System.Windows.Forms.DataGridView();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sadrzaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izdata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnFajl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenerisi
            // 
            this.txtGenerisi.Location = new System.Drawing.Point(13, 13);
            this.txtGenerisi.Name = "txtGenerisi";
            this.txtGenerisi.Size = new System.Drawing.Size(202, 20);
            this.txtGenerisi.TabIndex = 0;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(221, 11);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(75, 23);
            this.btnGenerisi.TabIndex = 1;
            this.btnGenerisi.Text = "Generiši";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Location = new System.Drawing.Point(385, 11);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(86, 23);
            this.btnBrisi.TabIndex = 2;
            this.btnBrisi.Text = "Briši potvrde";
            this.btnBrisi.UseVisualStyleBackColor = true;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // dgvPotvrde
            // 
            this.dgvPotvrde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPotvrde.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student,
            this.Svrha,
            this.Sadrzaj,
            this.Datum,
            this.Izdata});
            this.dgvPotvrde.Location = new System.Drawing.Point(13, 59);
            this.dgvPotvrde.Name = "dgvPotvrde";
            this.dgvPotvrde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPotvrde.Size = new System.Drawing.Size(775, 338);
            this.dgvPotvrde.TabIndex = 3;
            // 
            // Student
            // 
            this.Student.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            // 
            // Svrha
            // 
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.Name = "Svrha";
            // 
            // Sadrzaj
            // 
            this.Sadrzaj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sadrzaj.DataPropertyName = "Sadrzaj";
            this.Sadrzaj.HeaderText = "Sadrzaj";
            this.Sadrzaj.Name = "Sadrzaj";
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            // 
            // Izdata
            // 
            this.Izdata.DataPropertyName = "Izdata";
            this.Izdata.HeaderText = "Izdata";
            this.Izdata.Name = "Izdata";
            // 
            // btnFajl
            // 
            this.btnFajl.Location = new System.Drawing.Point(689, 12);
            this.btnFajl.Name = "btnFajl";
            this.btnFajl.Size = new System.Drawing.Size(99, 23);
            this.btnFajl.TabIndex = 4;
            this.btnFajl.Text = "Upiši u fajl";
            this.btnFajl.UseVisualStyleBackColor = true;
            this.btnFajl.Click += new System.EventHandler(this.btnFajl_Click);
            // 
            // frmStudentiPotvrdeIB190017
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFajl);
            this.Controls.Add(this.dgvPotvrde);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.txtGenerisi);
            this.Name = "frmStudentiPotvrdeIB190017";
            this.Text = "frmStudentiPotvrdeIB190017";
            this.Load += new System.EventHandler(this.frmStudentiPotvrdeIB190017_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPotvrde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGenerisi;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridView dgvPotvrde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn Svrha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sadrzaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Izdata;
        private System.Windows.Forms.Button btnFajl;
    }
}