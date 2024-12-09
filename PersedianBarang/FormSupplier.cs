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
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
            dgvSupplier.DataSource = supplier.getBS();
            saveMode();
        }
        Tabel supplier = new Tabel("supplier");

        bool baru;
        string kodeLama;

        private void ikatTextBox()
        {
            txtKode.DataBindings.Add("Text", supplier.getBS(), "kodeSupplier");
            txtNama.DataBindings.Add("Text", supplier.getBS(), "namaSupplier");
            txtAlamat.DataBindings.Add("Text", supplier.getBS(), "alamat");
            txtTlp.DataBindings.Add("Text", supplier.getBS(), "telepon");
            txtKota.DataBindings.Add("Text", supplier.getBS(), "kota");
        }

        private void lepasTextBox()
        {
            txtKode.DataBindings.Clear();
            txtNama.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtTlp.DataBindings.Clear();
            txtKota.DataBindings.Clear();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            supplier.getBS().MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            supplier.getBS().MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            supplier.getBS().MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            supplier.getBS().MoveLast();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void editMode()
        {
            txtKode.Enabled = true;
            txtNama.Enabled = true;
            txtAlamat.Enabled = true;
            txtTlp.Enabled = true;
            txtKota.Enabled = true;

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
            this.lepasTextBox();
        }

        private void saveMode()
        {
            txtKode.Enabled = false;
            txtNama.Enabled = false;
            txtAlamat.Enabled = false;
            txtTlp.Enabled = false;
            txtKota.Enabled = false;

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
            this.ikatTextBox();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strSQL;
            if (baru)
            {
                strSQL = $"INSERT INTO supplier VALUES('{txtKode.Text}','{txtNama.Text}','{txtAlamat.Text}','{txtTlp.Text}','{txtKota.Text}')";
            }
            else
            {
                strSQL = $"UPDATE supplier SET kodeSupplier='{txtKode.Text}', namaSupplier='{txtNama.Text}', " +
                    $"alamat='{txtAlamat.Text}', telepon='{txtTlp.Text}', kota='{txtKota.Text}' WHERE kodeSupplier='{this.kodeLama}";
            }
            this.supplier.eksekusiSQL(strSQL);
            saveMode();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("Hapus nieh?", "Konfirmasi", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if(jawab == System.Windows.Forms.DialogResult.Yes)
            {
                string strSQL = $"DELETE FROM supplier WHERE kodeSupplier='{txtKode.Text}'";
                MessageBox.Show("Cek dulu : " + strSQL);
                this.supplier.eksekusiSQL(strSQL);
                MessageBox.Show("Penghapusan Berhasil");
            }
            else
            {
                MessageBox.Show("Penghapusan Gagal");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            editMode();
            baru = true;
            txtKode.Focus();
            txtKode.Clear();
            txtNama.Clear();
            txtAlamat.Clear();
            txtTlp.Clear();
            txtKota.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode();
            baru = false;
            kodeLama = txtKode.Text;
        }
    }
}
