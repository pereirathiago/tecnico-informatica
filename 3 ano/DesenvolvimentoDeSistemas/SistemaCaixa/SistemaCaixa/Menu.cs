using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCaixa
{
    public partial class Menu : Form
    {
        public Menu(Form parent)
        {
            InitializeComponent();

            MdiParent = parent;
        }

        private void btnMovimento_Click(object sender, EventArgs e)
        {
            MovimentoForm f = new MovimentoForm(MdiParent);
            f.Show();
            Close();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            Form_Saldo f = new Form_Saldo(MdiParent);
            f.Show();
            Close();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            FormExtrato f = new FormExtrato(MdiParent);
            f.Show();
            Close();
        }
    }
}
