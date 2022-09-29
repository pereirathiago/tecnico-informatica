using SistemaEmprestimo.bd;
using SistemaEmprestimo.vo;
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
        BdCliente bdCliente;
        private Cliente cliente = new Cliente();
        public FormCliente(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdCliente = new BdCliente();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(MdiParent);
            f.Show();
            Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgClientes.Rows.Clear();
            foreach (DataRow dr in bdCliente.PreencheTabelaClientes(txtFiltro.Text).Rows)
            {
                dgClientes.Rows.Add(dr.ItemArray);
                dgClientes.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgClientes.Columns[3].DefaultCellStyle.Format = "0.#0";
            }
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

        private void FormCliente_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bdCliente.PreencheTabelaClientes("").Rows)
            {
                dgClientes.Rows.Add(dr.ItemArray);
                dgClientes.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
