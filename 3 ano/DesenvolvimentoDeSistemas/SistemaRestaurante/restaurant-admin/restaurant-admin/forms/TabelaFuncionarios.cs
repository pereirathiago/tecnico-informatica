using restaurant_admin.bd;
using restaurant_admin.vo;
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
    public partial class TabelaFuncionarios : Form
    {
        BdFuncionario bd;
        private Funcionarios funcionario = new Funcionarios();

        public TabelaFuncionarios(Form parent)
        {
            InitializeComponent();
            bd = new BdFuncionario();
            MdiParent = parent;
        }

        private void mVoltar_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm(MdiParent);
            mf.Show();
            Close();
        }

        private void TabelaFuncionarios_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bd.PreencheTabelaFuncionarios("").Rows)
            {
                dgFuncionarios.Rows.Add(dr.ItemArray);
            }
            foreach (DataGridViewRow item in dgFuncionarios.Rows)
            {
                switch(dgFuncionarios.Rows[item.Index].Cells[4].Value)
                {
                    case 0:
                        dgFuncionarios.Rows[item.Index].Cells[4].Value = "Administrador";
                        break;
                    case 1:
                        dgFuncionarios.Rows[item.Index].Cells[4].Value = "Atendimento";
                        break;
                    case 2:
                        dgFuncionarios.Rows[item.Index].Cells[4].Value = "Caixa";
                        break;
                    case 3:
                        dgFuncionarios.Rows[item.Index].Cells[4].Value = "Cozinha";
                        break;
                    default:
                        dgFuncionarios.Rows[item.Index].Cells[4].Value = "Função não encontrada";
                        break;
                }
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoFuncionario f = new FormNovoFuncionario(MdiParent);
            f.Show();
            Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codigo = -1, linha;
            linha = dgFuncionarios.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                codigo = int.Parse(dgFuncionarios.CurrentRow.Cells[0].Value.ToString());
                FormNovoFuncionario fnf = new FormNovoFuncionario(MdiParent);
                fnf.Funcionario = bd.localiza(codigo);
                fnf.Show();
                Close();
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codigo = -1, linha;
            linha = dgFuncionarios.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                codigo = int.Parse(dgFuncionarios.CurrentRow.Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir " + dgFuncionarios.CurrentRow.Cells[1].Value.ToString(), "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    bd.excluirFuncionario(codigo);
                    dgFuncionarios.Rows.Clear();
                    foreach (DataRow dr in bd.PreencheTabelaFuncionarios(txtNome.Text).Rows)
                    {
                        dgFuncionarios.Rows.Add(dr.ItemArray);
                    }
                }
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            dgFuncionarios.Rows.Clear();
            foreach (DataRow dr in bd.PreencheTabelaFuncionarios(txtNome.Text).Rows)
            {
                dgFuncionarios.Rows.Add(dr.ItemArray);
            }
        }
    }
}
