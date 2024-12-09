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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        Tabel pemakai = new Tabel("pemakai");

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUserName.Text;
            password = txtPass.Text;
            if (pemakai.login(username, password))
            {
                MessageBox.Show("Welcome to Inventory Information System");
                FormMenuUtama fmn = new FormMenuUtama(username);
                fmn.ShowDialog();
                txtUserName.Clear();
                txtPass.Clear();
                txtUserName.Focus();

            }
            else
            {
                MessageBox.Show("Sorry, Access Denied");
            }
        }
    }
}
