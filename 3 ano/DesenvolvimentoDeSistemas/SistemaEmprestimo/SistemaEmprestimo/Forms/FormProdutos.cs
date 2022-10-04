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
    public partial class FormProdutos : Form
    {
        BdEquipamentos bdEquipamentos;
        private Equipamentos equipamentos = new Equipamentos();

        public FormProdutos(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdEquipamentos = new BdEquipamentos();
        }

        private void mVoltar_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(MdiParent);
            f.Show();
            Close();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bdEquipamentos.PreencheTabelaEquipamentos("").Rows)
            {
                dgProdutos.Rows.Add(dr.ItemArray);
            }
        }

        private void btnNovoEquipamento_Click(object sender, EventArgs e)
        {
            FormNovoProduto f = new FormNovoProduto(MdiParent);
            f.Show();
            Close();
        }

        private void btnEditarEquipamento_Click(object sender, EventArgs e)
        {
            int codigo = -1, linha;
            linha = dgProdutos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                codigo = int.Parse(dgProdutos.CurrentRow.Cells[0].Value.ToString());
                FormNovoProduto fnp = new FormNovoProduto(MdiParent);
                fnp.Equipamentos = bdEquipamentos.localiza(codigo);
                fnp.Show();
                Close();
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void btnExcluirEquipamento_Click(object sender, EventArgs e)
        {
            int codigo = -1, linha;
            linha = dgProdutos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                codigo = int.Parse(dgProdutos.CurrentRow.Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir " + dgProdutos.CurrentRow.Cells[1].Value.ToString() , "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    bdEquipamentos.excluir(codigo);
                    dgProdutos.Rows.Clear();
                    foreach (DataRow dr in bdEquipamentos.PreencheTabelaEquipamentos(txtFiltro.Text).Rows)
                    {
                        dgProdutos.Rows.Add(dr.ItemArray);
                    }
                }
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            dgProdutos.Rows.Clear();
            foreach (DataRow dr in bdEquipamentos.PreencheTabelaEquipamentos(txtFiltro.Text).Rows)
            {
                dgProdutos.Rows.Add(dr.ItemArray);
            }
        }

        private void cVoltagem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cVoltagem.SelectedIndex == 0)
            {
                dgProdutos.Rows.Clear();
                foreach (DataRow dr in bdEquipamentos.PreencheTabelaEquipamentos(txtFiltro.Text).Rows)
                {
                    dgProdutos.Rows.Add(dr.ItemArray);
                }
            }else
            {
                dgProdutos.Rows.Clear();
                foreach (DataRow dr in bdEquipamentos.PreencheTabelaEquipamentosVoltagem(cVoltagem.Text).Rows)
                {
                    dgProdutos.Rows.Add(dr.ItemArray);
                }
            }
        }
    }
}
