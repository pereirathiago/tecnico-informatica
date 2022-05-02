using SistemaSalario.bd;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaSalario
{
    public partial class TabelaFuncionarios : Form
    {
        BdFuncionario bdFuncionario;
        public TabelaFuncionarios(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdFuncionario = new BdFuncionario();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CadastraFuncionario cf = new CadastraFuncionario(MdiParent);
            cf.Show();
            Close();
        }

        private void TabelaFuncionarios_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bdFuncionario.PreencheTabela("").Rows)
            {
                dgFiltro.Rows.Add(dr.ItemArray);
                dgFiltro.Columns[5].DefaultCellStyle.Format = "0.#0";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dgFiltro.Rows.Clear();
            foreach (DataRow dr in bdFuncionario.PreencheTabela(txtFiltro.Text).Rows)
            {
                dgFiltro.Rows.Add(dr.ItemArray);
            }
        }
    }
}
