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
    public partial class FormProdutos : Form
    {
        public FormProdutos(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(MdiParent);
            f.Show();
            Close();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            FormNovoProduto f = new FormNovoProduto(MdiParent);
            f.Show();
            Close();
        }
    }
}
