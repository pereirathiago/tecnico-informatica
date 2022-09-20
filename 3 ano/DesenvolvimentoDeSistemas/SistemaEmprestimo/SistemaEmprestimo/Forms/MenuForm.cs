using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmprestimo.Forms
{
    public partial class MenuForm : Form
    {
        public MenuForm(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void btnEmprestimo_Click(object sender, EventArgs e)
        {
            FormEmprestimo f = new FormEmprestimo(MdiParent);
            f.Show();
            Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente(MdiParent);
            f.Show();
            Close();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FormProdutos f = new FormProdutos(MdiParent);
            f.Show();
            Close();
        }
    }
}
