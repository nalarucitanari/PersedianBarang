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
    public partial class FormNotaBeli : Form
    {
        public FormNotaBeli()
        {
            InitializeComponent();
            ikatTextBox();
            saveMode();
            txtTotal.TextAlign = HorizontalAlignment.Right;
            CalculateTotal();
        }

        Tabel masterBeli = new Tabel("viewMaster");
        Tabel detailBeli = new Tabel("view_detailBeli");
        Tabel barang = new Tabel("barang");
        Tabel supplier = new Tabel("supplier");

        void tampil()
        {
            detailBeli.getBS().Filter = "noNotaBeli=" + txtNotaBeli.Text;
        }


        private void ikatTextBox()
        {
            txtNotaBeli.DataBindings.Add("Text", masterBeli.getBS(), "noNotaBeli");
            txtKodeSupplier.DataBindings.Add("Text", masterBeli.getBS(), "kodeSupplier");
            txtNamaSupplier.DataBindings.Add("Text", masterBeli.getBS(), "namaSupplier");
            txtAlamat.DataBindings.Add("Text", masterBeli.getBS(), "alamat");
            txtTelepon.DataBindings.Add("Text", masterBeli.getBS(), "telepon");
            txtKota.DataBindings.Add("Text", masterBeli.getBS(), "kota");
            txtTgl.DataBindings.Add("Text", masterBeli.getBS(), "tgl");
        }

        private void lepasTextBox()
        {
            txtNotaBeli.DataBindings.Clear();
            txtKodeSupplier.DataBindings.Clear();
            txtNamaSupplier.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtTelepon.DataBindings.Clear();
            txtKota.DataBindings.Clear();
            txtTgl.DataBindings.Clear();
        }

        private void editMode()
        {
            txtKodeSupplier.Enabled = true;
            txtTgl.Enabled = true;

            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnEnd.Enabled = false;
            btnNext.Enabled = false;

            btnFind.Enabled = false;
            btnPrint.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnNew.Enabled = false;

            btnSave.Visible = true;
            btnUndo.Visible = true;

            btnClose.Enabled = false;
            //this.lepasTextBox();
            dgvNotaBeli.Height = 120;
            dgvNotaBeli.Top = 205;
            txtKodeBarang.Focus();
            txtKodeSupplier.Focus();
        }

        private void saveMode()
        {
            txtKodeSupplier.Enabled = false;
            txtTgl.Enabled = false;

            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnEnd.Enabled = true;
            btnNext.Enabled = true;

            btnFind.Enabled = true;
            btnPrint.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnNew.Enabled = true;

            btnSave.Visible = false;
            btnUndo.Visible = false;

            btnClose.Enabled = true;
            dgvNotaBeli.Height = 175;
            dgvNotaBeli.Top = 150;
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            masterBeli.getBS().MoveFirst();
            tampil();
            CalculateTotal();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            masterBeli.getBS().MovePrevious();
            tampil();
            CalculateTotal();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            masterBeli.getBS().MoveNext();
            tampil();
            CalculateTotal();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            masterBeli.getBS().MoveLast();
            tampil();
            CalculateTotal();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvNotaBeli.Rows)
            {
                if (row.Cells["Jumlah"].Value != null)
                {
                    decimal jumlah;
                    if (decimal.TryParse(row.Cells["Jumlah"].Value.ToString(), out jumlah))
                    {
                        total += jumlah;
                    }
                }
            }
            txtTotal.Text = total.ToString("N0");
        }

        private void txtKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text.Length == 5)
            {
                int noBrs = barang.getBS().Find("kodeBarang", txtKodeBarang.Text);
                if (noBrs == -1)
                {
                    MessageBox.Show("Kode " + txtKodeBarang.Text + " tidak ada!");
                    FormCariBarang fcb = new FormCariBarang();
                    fcb.ShowDialog();
                    txtKodeBarang.Text = fcb.kodeCari;
                }
                else
                {
                    barang.getBS().Position = noBrs;
                    txtNamaBarang.Text = ((DataRowView)barang.getBS().Current).Row["namaBarang"].ToString();
                    txtHarga.Text = ((DataRowView)barang.getBS().Current).Row["hargaBeli"].ToString();
                    txtQty.Focus();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveMode();
        }

        private void FormNotaBeli_Load(object sender, EventArgs e)
        {
            dgvNotaBeli.DataSource = detailBeli.getBS();
            tampil();
            CalculateTotal();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHarga.Focus();
            }
        }

        private void txtHarga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string noNotaBeli, kodeBarang, qty, harga, strSQL;
                noNotaBeli = txtNotaBeli.Text;
                kodeBarang = txtKodeBarang.Text;
                qty = txtQty.Text;
                harga = txtHarga.Text;
                strSQL = $"INSERT INTO itemNotaBeli(noNotaBeli, kodeBarang, qty, harga)" +
                    $"VALUES('{noNotaBeli}', '{kodeBarang}', '{qty}', '{harga}')";
                detailBeli.eksekusiSQL(strSQL);
                txtKodeBarang.Clear();
                txtNamaBarang.Clear();
                txtHarga.Clear();
                txtQty.Clear();
                txtKodeBarang.Focus();
            }
            CalculateTotal();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dgvNotaBeli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && btnSave.Visible) 
            {
                txtKodeBarang.Text = dgvNotaBeli.CurrentRow.Cells["kodeBarang"].Value.ToString();
                txtNamaBarang.Text = dgvNotaBeli.CurrentRow.Cells["namaBarang"].Value.ToString();
                txtQty.Text = dgvNotaBeli.CurrentRow.Cells["qty"].Value.ToString();
                txtHarga.Text = dgvNotaBeli.CurrentRow.Cells["harga"].Value.ToString();
                txtQty.Focus();
            }

            if ((e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) && btnSave.Visible)
            {
                DialogResult jwb = DialogResult.Yes;
                if (e.KeyCode == Keys.Delete)
                {
                    jwb = MessageBox.Show("Yakin mau hapus?", "Konfirmasi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if (jwb == DialogResult.Yes)
                {
                    string idHapus = dgvNotaBeli.CurrentRow.Cells[0].Value.ToString();
                    string strSQL = $"DELETE FROM itemNotaBeli WHERE idItemNotaBeli = '{idHapus}'";
                    //MessageBox.Show(strSQL);
                    detailBeli.eksekusiSQL(strSQL);
                }
                else
                {
                    MessageBox.Show("Penghapusan dibatalkan");
                }
            }

        }

        private void txtKodeSupplier_KeyUp(object sender, KeyEventArgs e)
        {
            string noSkrng = txtNotaBeli.Text;
            if (txtKodeSupplier.Text.Length == 3)
            {
                int noBrs = supplier.getBS().Find("kodeSupplier", txtKodeSupplier.Text);
                if (noBrs == -1)
                {
                    MessageBox.Show("Kode : " + txtKodeSupplier.Text + " tidak ada!");
                    FormCariSupplier fcs = new FormCariSupplier();
                    fcs.ShowDialog();
                    txtKodeSupplier.Text = fcs.kodeCari;
                }
                else
                {
                    string strSQL = $"UPDATE notaBeli SET kodeSupplier = '{txtKodeSupplier.Text}'" +
                        $"WHERE noNotaBeli = '{txtNotaBeli.Text}'";
                    masterBeli.eksekusiSQL(strSQL);
                    masterBeli.getBS().Position = masterBeli.getBS().Find("noNotaBeli", noSkrng);
                    txtKodeBarang.Focus();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult jwb = MessageBox.Show("Yakin hapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(jwb == DialogResult.Yes)
            {
                string strSQL = $"DELETE FROM notaBeli WHERE noNotaBeli = '{txtNotaBeli.Text}'";
                masterBeli.eksekusiSQL(strSQL);
                masterBeli.getBS().MoveLast();
                MessageBox.Show("Penghapusan berhasil");
            }
            else
            {
                MessageBox.Show("Penghapusan dibatalkan");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string tglSkrng = DateTime.Now.ToString("yyyy-MM-dd");
            string strSQL = $"INSERT INTO notaBeli(tgl) VALUES('{tglSkrng}')";
            long noNotanya = masterBeli.eksekusiSQL_getId(strSQL);
            masterBeli.getBS().Position = masterBeli.getBS().Find("noNotaBeli", noNotanya);
            tampil();
            CalculateTotal();
            editMode();
            txtKodeSupplier.Focus();
        }
    }
}
