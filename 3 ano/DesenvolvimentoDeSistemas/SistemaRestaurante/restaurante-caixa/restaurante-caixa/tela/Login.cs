using restaurante_caixa.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurante_caixa.tela
{
    public partial class Login : Form
    {
        BdCaixa bd;

        public Login(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bd = new BdCaixa();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(bd.VerificaLogin(txtUser.Text, txtSenha.Text))
            {
                BuscarMesa tc = new BuscarMesa(MdiParent);
                tc.Show();
                Close();
                MessageBox.Show("login");
            }
            else
            {
                MessageBox.Show("Login incorreto");
            }
        }
    }
}
