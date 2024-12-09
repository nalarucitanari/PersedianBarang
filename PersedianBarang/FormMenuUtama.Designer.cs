namespace PersedianBarang
{
    partial class FormMenuUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setBrng = new System.Windows.Forms.ToolStripMenuItem();
            this.setupDataBarangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beli = new System.Windows.Forms.ToolStripMenuItem();
            this.jual = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setBrng,
            this.transaksiToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setBrng
            // 
            this.setBrng.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupDataBarangToolStripMenuItem,
            this.setSupplier});
            this.setBrng.Name = "setBrng";
            this.setBrng.Size = new System.Drawing.Size(74, 29);
            this.setBrng.Text = "Setup";
            // 
            // setupDataBarangToolStripMenuItem
            // 
            this.setupDataBarangToolStripMenuItem.Name = "setupDataBarangToolStripMenuItem";
            this.setupDataBarangToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.setupDataBarangToolStripMenuItem.Text = "Setup Data Barang";
            this.setupDataBarangToolStripMenuItem.Click += new System.EventHandler(this.setupDataBarangToolStripMenuItem_Click);
            // 
            // setSupplier
            // 
            this.setSupplier.Name = "setSupplier";
            this.setSupplier.Size = new System.Drawing.Size(272, 34);
            this.setSupplier.Text = "Setup Data Supplier";
            this.setSupplier.Click += new System.EventHandler(this.setupDataSupplierToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beli,
            this.jual});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // beli
            // 
            this.beli.Name = "beli";
            this.beli.Size = new System.Drawing.Size(195, 34);
            this.beli.Text = "Pembelian";
            this.beli.Click += new System.EventHandler(this.pembelianToolStripMenuItem_Click);
            // 
            // jual
            // 
            this.jual.Name = "jual";
            this.jual.Size = new System.Drawing.Size(195, 34);
            this.jual.Text = "Penjualan";
            this.jual.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PersedianBarang.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(930, 511);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenuUtama";
            this.Text = "Sistem Informasi Persediaan Barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setBrng;
        private System.Windows.Forms.ToolStripMenuItem setupDataBarangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSupplier;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beli;
        private System.Windows.Forms.ToolStripMenuItem jual;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
    }
}