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
    public partial class FormCliente : Form
    {
        public FormCliente(Form parent)
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

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FormNovoCliente f = new FormNovoCliente(MdiParent);
            f.Show();
            Close();
        }

        private void btnNovoEmprestimo_Click(object sender, EventArgs e)
        {
            FormNovoEmprestimo f = new FormNovoEmprestimo(MdiParent);
            f.Show();
            Close();
        }
    }
}
