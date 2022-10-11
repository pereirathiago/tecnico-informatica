using SistemaEmprestimo.bd;
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
    public partial class FormEmprestimo : Form
    {
        BdEmprestimos bdEmprestimos;
        public FormEmprestimo(Form parent)
        {
            InitializeComponent();
            bdEmprestimos = new BdEmprestimos();
            MdiParent = parent;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(MdiParent);
            f.Show();
            Close();
        }

        private void FormEmprestimo_Load(object sender, EventArgs e)
        {
            cProdutosTable.Items.Add("Todos os produtos");
            foreach(DataRow dr in bdEmprestimos.PreencheComboBoxEquipamentos().Rows)
            {
                cProdutosTable.Items.Add(dr.ItemArray[0] + " - " +dr.ItemArray[1]);
            }

            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela("",0, bdEmprestimos.PreencheTabelaEmprstimos).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void noPrazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela("", 0, bdEmprestimos.localizaNoPrazo).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void atrasadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela("",0, bdEmprestimos.localizaAtrazados).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela("",0, bdEmprestimos.PreencheTabelaEmprstimos).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void devolvidosNoPrazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela("",0, bdEmprestimos.localizaDevolvidosNoPrazo).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void devolvidosDepoisDoPrazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela("",0, bdEmprestimos.localizaDevolvidosDepoisDoPrazo).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnOkCpf_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            int idProduto;
            try
            {
                int position = cProdutosTable.Text.IndexOf(" - ");
                idProduto = Convert.ToInt32(cProdutosTable.Text.Substring(0, position));
            }
            catch
            {
                idProduto = 0;
            }
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela(txtFiltroCpf.Text, idProduto, bdEmprestimos.PreencheTabelaEmprstimos).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnOkProduto_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            int idProduto;
            try
            {
                int position = cProdutosTable.Text.IndexOf(" - ");
                idProduto = Convert.ToInt32(cProdutosTable.Text.Substring(0, position));
            }
            catch
            {
                idProduto = 0;
            }
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela(txtFiltroCpf.Text, idProduto, bdEmprestimos.PreencheTabelaEmprstimos).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
    }
}
