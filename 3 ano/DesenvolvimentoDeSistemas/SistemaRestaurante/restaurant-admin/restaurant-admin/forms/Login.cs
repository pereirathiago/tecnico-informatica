using restaurant_admin.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_admin.forms
{
    public partial class Login : Form
    {
        BdFuncionario bd;
        public Login(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bd = new BdFuncionario();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtSenha.Text == "1234")
            {
                MenuForm tf = new MenuForm(MdiParent);
                tf.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Login incorreto");
            }
        }
    }
}
