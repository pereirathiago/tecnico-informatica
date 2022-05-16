using SistemaSalario.bd;
using SistemaSalario.Forms;
using SistemaSalario.vo;
using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;
using Xceed.Words.NET;

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
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir " + dgFiltro.CurrentRow.Cells[1].Value.ToString(), "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    bdFuncionario.excluir(matricula);
                    dgFiltro.Rows.Clear();
                    foreach (DataRow dr in bdFuncionario.calculaNovaTabela(txtFiltro.Text).Rows)
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

        private void verHoleriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string path = @"..\..\";
            int matricula = -1, linha;
            linha = dgFiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                matricula = int.Parse(dgFiltro.CurrentRow.Cells[0].Value.ToString());
                funcionario = bdFuncionario.localiza(matricula);
                funcionario.Inss = (double)dgFiltro.CurrentRow.Cells[6].Value;
                funcionario.Sf = (double)dgFiltro.CurrentRow.Cells[7].Value;
                funcionario.Vvt = (double)dgFiltro.CurrentRow.Cells[8].Value;
                funcionario.Irrf = (double)dgFiltro.CurrentRow.Cells[9].Value;
                funcionario.Salliq = (double)dgFiltro.CurrentRow.Cells[10].Value;
                try
                {
                    string pathdoc = Replace(path, funcionario);
                    MessageBox.Show("Arquivo criado");
                    Process.Start(pathdoc);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        static string Replace(string path, Funcionario funcionario)
        {
            using (var documento = DocX.Load(path + @"holerite.docx"))
            {
                documento.ReplaceText("#nome", funcionario.Nome);
                documento.ReplaceText("#matricula", funcionario.Matricula.ToString());
                documento.ReplaceText("#salarioBase", funcionario.Salario.ToString("N2", new CultureInfo("pt-BR")));
                documento.ReplaceText("#salarioFam", funcionario.Sf.ToString("N2", new CultureInfo("pt-BR")));
                documento.ReplaceText("#irrf", funcionario.Irrf.ToString("N2", new CultureInfo("pt-BR")));
                documento.ReplaceText("#inss", funcionario.Inss.ToString("N2", new CultureInfo("pt-BR")));
                documento.ReplaceText("#vt", funcionario.Vvt.ToString("N2", new CultureInfo("pt-BR")));
                documento.ReplaceText("#salliq", funcionario.Salliq.ToString("N2", new CultureInfo("pt-BR")));
                documento.ReplaceText("#totalVenc", (funcionario.Salario + funcionario.Sf).ToString("N2", new CultureInfo("pt-BR")));
                documento.ReplaceText("#totalDesc", (funcionario.Irrf + funcionario.Inss + funcionario.Vvt).ToString("N2", new CultureInfo("pt-BR")));

                string mes = DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("pt-br"));
                documento.ReplaceText("#mes", mes);

                documento.SaveAs(path + "holerite-"+funcionario.Nome+"-"+mes+".docx");

                return path + "holerite-" + funcionario.Nome + "-" + mes + ".docx";
            }
        }
    }
}
