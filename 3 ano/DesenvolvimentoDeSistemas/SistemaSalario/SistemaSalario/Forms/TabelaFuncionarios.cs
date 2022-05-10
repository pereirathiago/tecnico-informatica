using SistemaSalario.bd;
using SistemaSalario.Forms;
using SistemaSalario.vo;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaSalario
{
    public partial class TabelaFuncionarios : Form
    {
        BdFuncionario bdFuncionario;
        private Funcionario funcionario = new Funcionario();
        public TabelaFuncionarios(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdFuncionario = new BdFuncionario();
        }

        private void TabelaFuncionarios_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bdFuncionario.calculaNovaTabela("").Rows)
            {
                dgFiltro.Rows.Add(dr.ItemArray);
                dgFiltro.Columns[5].DefaultCellStyle.Format = "0.#0";
                dgFiltro.Columns[6].DefaultCellStyle.Format = "0.#0";
                dgFiltro.Columns[7].DefaultCellStyle.Format = "0.#0";
                dgFiltro.Columns[8].DefaultCellStyle.Format = "0.#0";
                dgFiltro.Columns[9].DefaultCellStyle.Format = "0.#0";
                dgFiltro.Columns[10].DefaultCellStyle.Format = "0.#0";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dgFiltro.Rows.Clear();
            foreach (DataRow dr in bdFuncionario.calculaNovaTabela(txtFiltro.Text).Rows)
            {
                dgFiltro.Rows.Add(dr.ItemArray);
            }
        }

        private void btnNovoFunc_Click(object sender, EventArgs e)
        {
            CadastraFuncionario cf = new CadastraFuncionario(MdiParent);
            cf.Show();
            Close();
        }


        private void btnEditarFunc_Click(object sender, EventArgs e)
        { 
            int matricula = -1, linha;
            linha = dgFiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                matricula = int.Parse(dgFiltro.CurrentRow.Cells[0].Value.ToString());
                CadastraFuncionario cf = new CadastraFuncionario(MdiParent);
                cf.Funcionario = bdFuncionario.localiza(matricula);
                cf.Show();
                Close();
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
            int matricula = -1, linha;
            linha = dgFiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                matricula = int.Parse(dgFiltro.CurrentRow.Cells[0].Value.ToString());
                bdFuncionario.excluir(matricula);
                dgFiltro.Rows.Clear();
                foreach (DataRow dr in bdFuncionario.calculaNovaTabela(txtFiltro.Text).Rows)
                {
                    dgFiltro.Rows.Add(dr.ItemArray);
                    dgFiltro.Columns[5].DefaultCellStyle.Format = "0.#0";
                }
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void btnINSS_Click(object sender, EventArgs e)
        {
            TabelaInss inss = new TabelaInss(MdiParent);
            inss.Show();
            Close();
        }

        private void btnSalarioFamilia_Click(object sender, EventArgs e)
        {
            TabelaSalarioFamilia fsf = new TabelaSalarioFamilia(MdiParent);
            fsf.Show();
            Close();
        }

        private void btnIRRF_Click(object sender, EventArgs e)
        {
            TabelaIRRF fir = new TabelaIRRF(MdiParent);
            fir.Show();
            Close();
        }
    }
}
