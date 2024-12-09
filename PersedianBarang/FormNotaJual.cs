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
    public partial class FormNotaJual : Form
    {
        public FormNotaJual()
        {
            InitializeComponent();
            saveMode();
        }
        Tabel master = new Tabel("notaJual");
        Tabel detail = new Tabel("viewItemJual");

        private void ikatTextBox()
        {
            txtNotaJual.DataBindings.Add("Text", master.getBS(), "noNotaJual");
            txtTgl.DataBindings.Add("Text", master.getBS(), "tgl");
        }

        private void FormNotaJual_Load(object sender, EventArgs e)
        {
            ikatTextBox();
            dgvDetailJual.DataSource = detail.getBS();
            tampil();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            master.getBS().MoveFirst();
            tampil();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            master.getBS().MovePrevious();
            tampil();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            master.getBS().MoveNext();
            tampil();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            master.getBS().MoveLast();
            tampil();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        void tampil()
        {
            detail.getBS().Filter = "noNotaJual=" + txtNotaJual.Text;
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetailJual.Rows)
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

        private void editMode()
        {
            txtKodeBarang.Enabled = true;
            txtTgl.Enabled = false;

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
            txtKodeBarang.Focus();
        }

        private void saveMode()
        {
            txtKodeBarang.Enabled = false;
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode();
        }
        Tabel barang = new Tabel("barang");
        private void txtKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if(txtKodeBarang.Text.Length == 5)
            {
                int noBrs = barang.getBS().Find("kodeBarang", txtKodeBarang.Text);
                if (noBrs == -1)
                {
                    //MessageBox.Show("Kode " + txtKodeBarang.Text + " tidak ada!");
                    FormCariBarang fcb = new FormCariBarang();
                    fcb.ShowDialog();
                    txtKodeBarang.Text = fcb.kodeCari;
                    fcb.Dispose();
                }
                else
                {
                    string qty, harga;
                    qty = "1";
                    barang.getBS().Position = noBrs;
                    harga = ((DataRowView)barang.getBS().Current).Row["hargaJual"].ToString();
                    string strSQL = "INSERT INTO itemNotaJual(noNotaJual, kodeBarang, qty, harga)" +
                        $"VALUES('{txtNotaJual.Text}', '{txtKodeBarang.Text}', '{qty}', '{harga}')";
                    detail.eksekusiSQL(strSQL);
                    txtKodeBarang.Clear();
                    txtKodeBarang.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveMode();
        }

        private void txtKodeBarang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &&  txtKodeBarang.Text.Length > 0)
            {
                string idNya = ((DataRowView)detail.getBS().Current).Row["idItemNotaJual"].ToString();
                if(txtKodeBarang.Text.Substring(0,1) == "+")
                {
                    int tambah = int.Parse(txtKodeBarang.Text.Substring(1));
                    string strSQL = $"UPDATE itemNotaJual SET qty = qty+'{tambah}' WHERE idItemNotaJual = '{idNya}'";
                    detail.eksekusiSQL(strSQL);
                    txtKodeBarang.Clear();
                    txtKodeBarang.Focus();
                }
                else if (txtKodeBarang.Text.Substring(0, 1) == "-")
                {
                    int kurang = int.Parse(txtKodeBarang.Text.Substring(1));
                    string strSQL = $"UPDATE itemNotaJual SET qty = qty-'{kurang}' WHERE idItemNotaJual = '{idNya}'";
                    detail.eksekusiSQL(strSQL);
                    txtKodeBarang.Clear();
                    txtKodeBarang.Focus();
                }
            }
        }

        private void dgvDetailJual_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && btnSave.Visible)
            {
                DialogResult jwb = MessageBox.Show("Yakin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (jwb == DialogResult.Yes)
                {
                    string idNya = dgvDetailJual.CurrentRow.Cells[0].Value.ToString();
                    string strSQL = $"DELETE FROM itemNotaJual WHERE idItemNotaJual = '{idNya}'";
                    detail.eksekusiSQL(strSQL);
                    txtKodeBarang.Focus();
                }
                
            }
        }
    }
}
