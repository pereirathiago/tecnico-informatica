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
            string cpf = ""; int  linha;
            linha = dgClientes.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                cpf = dgClientes.CurrentRow.Cells[0].Value.ToString();
                FormNovoCliente cf = new FormNovoCliente(MdiParent);
                cf.Cliente = bdCliente.localiza(cpf);
                cf.Show();
                Close();
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            string cpf = ""; int linha;
            linha = dgClientes.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                cpf = (dgClientes.CurrentRow.Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir " + dgClientes.CurrentRow.Cells[1].Value.ToString() + ". CPF: " + dgClientes.CurrentRow.Cells[0].Value.ToString(), "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    bdCliente.excluir(cpf);
                    dgClientes.Rows.Clear();
                    foreach (DataRow dr in bdCliente.PreencheTabelaClientes(txtFiltro.Text).Rows)
                    {
                        dgClientes.Rows.Add(dr.ItemArray);
                        dgClientes.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                    }
                }
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void mVoltar_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(MdiParent);
            f.Show();
            Close();
        }
    }
}
