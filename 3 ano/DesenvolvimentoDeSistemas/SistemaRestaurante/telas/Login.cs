using restaurante_cozinha.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurante_cozinha.telas
{
    public partial class Login : Form
    {
        BdCozinha bd;
        public Login(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bd = new BdCozinha();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(bd.VerificaLogin(txtUser.Text, txtSenha.Text))
            {
                TabelaPedids tf = new TabelaPedids(MdiParent);
                tf.Show();
                Close();
            } else
            {
                MessageBox.Show("Login incorreto");
            }
        }
    }
}
