namespace PersedianBarang
{
    partial class FormCariSupplier
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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.txtCariSupplier = new System.Windows.Forms.TextBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.kodeSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeSupplier,
            this.namaSupplier,
            this.alamat,
            this.telepon,
            this.kota});
            this.dgvSupplier.Location = new System.Drawing.Point(42, 81);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(961, 451);
            this.dgvSupplier.TabIndex = 5;
            this.dgvSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSupplier_KeyDown);
            // 
            // txtCariSupplier
            // 
            this.txtCariSupplier.Location = new System.Drawing.Point(260, 21);
            this.txtCariSupplier.Name = "txtCariSupplier";
            this.txtCariSupplier.Size = new System.Drawing.Size(743, 26);
            this.txtCariSupplier.TabIndex = 4;
            this.txtCariSupplier.TextChanged += new System.EventHandler(this.txtCariSupplier_TextChanged);
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(38, 21);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(203, 20);
            this.lblCari.TabIndex = 3;
            this.lblCari.Text = "Nama Supplier Yang di Cari";
            // 
            // kodeSupplier
            // 
            this.kodeSupplier.DataPropertyName = "kodeSupplier";
            this.kodeSupplier.HeaderText = "Kode Supplier";
            this.kodeSupplier.MinimumWidth = 8;
            this.kodeSupplier.Name = "kodeSupplier";
            this.kodeSupplier.ReadOnly = true;
            this.kodeSupplier.Width = 50;
            // 
            // namaSupplier
            // 
            this.namaSupplier.DataPropertyName = "namaSupplier";
            this.namaSupplier.HeaderText = "Nama Supplier";
            this.namaSupplier.MinimumWidth = 8;
            this.namaSupplier.Name = "namaSupplier";
            this.namaSupplier.ReadOnly = true;
            this.namaSupplier.Width = 150;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 8;
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            this.alamat.Width = 200;
            // 
            // telepon
            // 
            this.telepon.DataPropertyName = "telepon";
            this.telepon.HeaderText = "Telpon";
            this.telepon.MinimumWidth = 8;
            this.telepon.Name = "telepon";
            this.telepon.ReadOnly = true;
            this.telepon.Width = 80;
            // 
            // kota
            // 
            this.kota.DataPropertyName = "kota";
            this.kota.HeaderText = "Kota";
            this.kota.MinimumWidth = 8;
            this.kota.Name = "kota";
            this.kota.ReadOnly = true;
            this.kota.Width = 80;
            // 
            // FormCariSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 564);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.txtCariSupplier);
            this.Controls.Add(this.lblCari);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCariSupplier";
            this.Text = "Form Cari Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TextBox txtCariSupplier;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn telepon;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
    }
}