using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersedianBarang
{
    public partial class FormMenuUtama : Form
    {
        public FormMenuUtama(string user_name)
        {
            InitializeComponent();
            Tabel pemakai = new Tabel("pemakai");
            pemakai.getBS().Position = pemakai.getBS().Find("user_name", user_name);
            bool hsb, hss, hbeli, hjual;
            hsb = bool.Parse(((DataRowView)pemakai.getBS().Current).Row["setBrng"].ToString());
            hss = bool.Parse(((DataRowView)pemakai.getBS().Current).Row["setSupplier"].ToString());
            hbeli = bool.Parse(((DataRowView)pemakai.getBS().Current).Row["setBeli"].ToString());
            hjual = bool.Parse(((DataRowView)pemakai.getBS().Current).Row["setJual"].ToString());
            setBrng.Enabled = hsb;
            setSupplier.Enabled = hss;
            beli.Enabled = hbeli;
            jual.Enabled = hjual;
            
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setupDataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fb = new Form1();
            fb.ShowDialog();
            fb.Dispose();
        }

        private void setupDataSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.ShowDialog();
            fs.Dispose();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaBeli fnb = new FormNotaBeli();
            fnb.ShowDialog();
            fnb.Dispose();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Belum Dibuat");
        }
    }
}
