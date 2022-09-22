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
    public partial class FormNovoProduto : Form
    {
        public FormNovoProduto(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void FormNovoProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            FormProdutos f = new FormProdutos(MdiParent);
            f.Show();
            Close();
        }
    }
}
