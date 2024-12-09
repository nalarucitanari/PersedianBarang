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
    public partial class FormCariSupplier : Form
    {
        public FormCariSupplier()
        {
            InitializeComponent();
            dgvSupplier.DataSource = supplier.getBS();
        }
        Tabel supplier = new Tabel("supplier");

        private void txtCariSupplier_TextChanged(object sender, EventArgs e)
        {
            supplier.getBS().Filter = $"namaSupplier LIKE '%{txtCariSupplier.Text}%'";
        }
        public string kodeCari;
        private void dgvSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                kodeCari = dgvSupplier.CurrentRow.Cells["kodeSupplier"].Value.ToString();
                Close();
            }

        }
    }
}
