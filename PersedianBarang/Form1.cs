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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace PersedianBarang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sambungDataBase();
            isiDataTable(); // <--DataTable diisi
            saveMode(); // <-- metode ini sudah memanggil ikatTextBox()
            dgvBarang.DataSource = this.bs; // <--ganti sumber datanya menjadi BindingSource
            //tampilTextBoxManual(5); // <-- tampilkan baris yg ke 5
            //ikatTextBox(); // <- semua textbox diikatkan ke BindingSource (tidak perlu karena sudah ada di saveMode()
        }
        private DataTable dt = new DataTable(); // <-- struktur data bentuk tabel
        private BindingSource bs = new BindingSource(); // <-- objek bindingSource

        private void ikatTextBox()
        {
            txtKode.DataBindings.Add("Text", this.bs, "kodeBarang");
            txtNamaBarang.DataBindings.Add("Text", this.bs, "namaBarang");
            txtHargaBeli.DataBindings.Add("Text", this.bs, "hargaBeli");
            txtHargaJual.DataBindings.Add("Text", this.bs, "hargaJual");
            txtStok.DataBindings.Add("Text", this.bs, "stok");
            txtSatuan.DataBindings.Add("Text", this.bs, "satuan");
        }

        private void lepasTextBox()
        {
            txtKode.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtHargaBeli.DataBindings.Clear();
            txtHargaJual.DataBindings.Clear();
            txtStok.DataBindings.Clear();
            txtSatuan.DataBindings.Clear();
        }

        private void tampilTextBoxManual(int baris)
        {
            txtKode.Text = this.dt.Rows[baris]["kodeBarang"].ToString();
            txtNamaBarang.Text = this.dt.Rows[baris]["namaBarang"].ToString();
            txtHargaBeli.Text = this.dt.Rows[baris]["hargaBeli"].ToString();
            txtHargaJual.Text = this.dt.Rows[baris]["hargaJual"].ToString();
            txtStok.Text = this.dt.Rows[baris]["stok"].ToString();
            txtSatuan.Text = this.dt.Rows[baris]["satuan"].ToString();
        }

        private void isiDataTable()
        {
            this.sambungan.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang", this.sambungan);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dt.Clear(); // <-- kosongkan dulu DataTable
            da.Fill(dt);
            this.bs = new BindingSource();
            this.bs.DataSource = this.dt;// <-- sambungkan BindingSource dengan data
            dgvBarang.DataSource = bs;
            this.sambungan.Close();
        }
        
        private void sambungDataBase()
        {
            string parameterKoneksi = "server = localhost;user id=root;password = ''; database=inv";
            this.sambungan = new MySqlConnection(parameterKoneksi);
        }
        private Boolean baru = false;
        private String kodeLama = null;
        private MySqlConnection sambungan;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editMode()
        {
            dgvBarang.Enabled = false;
            //lakukan !boolean
            //textbox disable
            txtKode.Enabled = true;
            txtNamaBarang.Enabled = true;
            txtHargaBeli.Enabled = true;
            txtHargaJual.Enabled = true;
            txtSatuan.Enabled = true;

            //navigasi enable
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnEnd.Enabled = false;
            btnNext.Enabled = false;

            //controller
            btnFind.Enabled = false;
            btnPrint.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnNew.Enabled = false;

            //save dan undo disable --> gaada save dan undo saat liat tok
            btnSave.Visible = true;
            btnUndo.Visible = true;

            //mencegah user close saat edit
            btnClose.Enabled = false;
            this.lepasTextBox();
        }

        private void saveMode()
        {
            dgvBarang.Enabled = true;
            //textbox disable
            txtKode.Enabled = false;
            txtNamaBarang.Enabled = false;
            txtHargaBeli.Enabled = false;
            txtHargaJual.Enabled = false;
            txtSatuan.Enabled = false;

            //navigasi enable
            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnEnd.Enabled = true;
            btnNext.Enabled = true;

            //controller
            btnFind.Enabled = true;
            btnPrint.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnNew.Enabled = true;

            //save dan undo disable --> gaada save dan undo saat liat tok
            btnSave.Visible = false;
            btnUndo.Visible = false;

            //mencegah user close saat edit
            btnClose.Enabled = true;
            this.ikatTextBox();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode();
            baru = false;
            kodeLama = txtKode.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            editMode();
            baru = true;
            //tambah focus agar kursor lngsng ada di kode
            txtKode.Focus();
            txtKode.Clear();
            txtNamaBarang.Clear();
            txtHargaBeli.Text = "0";
            txtSatuan.Text = "pcs";
            txtHargaJual.Text = "0";
            txtStok.Text = "0";
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            saveMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string kode, nama, hargaBeli, hargaJual, satuan, querySQL;
            kode = txtKode.Text.Trim();
            hargaBeli = txtHargaBeli.Text.Trim();
            hargaJual = txtHargaJual.Text.Trim();
            nama = txtNamaBarang.Text;
            satuan = txtSatuan.Text.Trim();

            if(baru)
            {
                //insert query data baru
                querySQL = "INSERT INTO barang(kodeBarang, namaBarang, hargaBeli, hargaJual, satuan)" +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}')";
                querySQL = string.Format(querySQL, kode, nama, hargaBeli, hargaJual, satuan);
            }
            else
            {
                //update data barang lama
                querySQL = "UPDATE barang SET kodeBarang = '{0}', namaBarang = '{1}', hargaBeli = '{2}'," +
                    "hargaJual = '{3}', satuan = '{4}' WHERE kodeBarang = '{5}'";
                querySQL = string.Format(querySQL, kode, nama, hargaBeli, hargaJual, satuan, this.kodeLama);
            }
            MessageBox.Show("Query berikut akan dieksekusi " + querySQL);
            try
            {
                this.sambungan.Open();
                MySqlCommand cmd = new MySqlCommand(querySQL, this.sambungan);
                cmd.ExecuteNonQuery();
                if(baru)
                    MessageBox.Show("Penambahan Berhasil, Silahkan periksa di tabel barang");
                else
                    MessageBox.Show("Perubahan Berhasil");
            }
            catch(Exception ex)
            {
                if(ex.Message.Substring(0,15)=="Duplicate entry")
                {
                    MessageBox.Show("Kode Barang : " + kode + " sudah digunakan\n" +
                        "Silahkan gunakan kode yang lainnya");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show(ex.Message);
                txtKode.Focus(); // <-- memindahkan kursor ke tectbox kodeBarang
                return; // <-- keluar dari metode btnSave_Click
            }
            finally
            {
                this.sambungan.Close();
                this.isiDataTable();
            }
            saveMode();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //string kodeBarang = txtKode.Text;
            //string strSQL = $"DELETE FROM barang WHERE kodeBarang='{kodeBarang}'";
            DialogResult jawaban = MessageBox.Show("Yakin ngehapus?", "Konfirmasi Penghapusan",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(jawaban == DialogResult.Yes)
            {
                string querySQL = $"DELETE FROM barang WHERE kodeBarang = '{txtKode.Text.Trim()}'";
                //querySQL = string.Format(querySQL, txtKode.Text.Trim());
                try
                {
                    this.sambungan.Open();
                    MySqlCommand cmd = new MySqlCommand(querySQL, this.sambungan);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Penghapusan berhasil " + querySQL + "\nberhasil");
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Cannot delete"))
                    {
                        MessageBox.Show("Kode Barang : " + txtKode.Text.Trim() + " sudah digunakan\n" +
                            "Anda tidak bisa menghapus data ini");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show(ex.Message);
                    txtKode.Focus(); // <-- memindahkan kursor ke tectbox kodeBarang
                    return; // <-- keluar dari metode btnDel_Click
                }
                finally
                {
                    this.sambungan.Close();
                    this.isiDataTable();
                }
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan...");
            }

        }


        private void btnTop_Click(object sender, EventArgs e)
        {
            this.bs.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.bs.MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.bs.MoveLast();
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FormCariBarang frm = new FormCariBarang();
            frm.ShowDialog();
            //MessageBox.Show("Kodenya = " + frm.kodeCari);
            int baris = bs.Find("kodeBarang", frm.kodeCari);
            bs.Position = baris;
            frm.Dispose();
        }
    }
}
