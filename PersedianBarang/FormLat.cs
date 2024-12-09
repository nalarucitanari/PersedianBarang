using MySql.Data.MySqlClient;
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
    public partial class FormLat : Form
    {
        public FormLat()
        {
            InitializeComponent();
        }
        DataTable  dt = new DataTable();
        BindingSource bs = new BindingSource();
        private MySqlConnection sambungan;
        private void FormLat_Load(object sender, EventArgs e)
        {
            string parameterKoneksi = "server = localhost;user id=root;password = ''; database=inv";
            this.sambungan = new MySqlConnection(parameterKoneksi);
            sambungan.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang", this.sambungan);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dt.Clear(); // <-- kosongkan dulu DataTable
            da.Fill(dt);
            this.bs = new BindingSource();
            this.bs.DataSource = this.dt;// <-- sambungkan BindingSource dengan data
            dgvBarang.DataSource = bs;

        }
        void cari()
        {
            
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
           
            string cari = txtNamaBarang.Text;
            int baris = bs.Find("namaBarang", cari);
            //bs.Filter = $"namaBarang LIKE '%{cari}%'";
            if (baris != -1)
            {
                bs.Position = baris;
                dgvBarang.Rows[baris].Selected = true;
            }
            else
            {
                MessageBox.Show("kode tidak ditemukan");
            }
        }
    }
}
