using restaurant_admin.bd;
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
    public partial class TabelaPratos : Form
    {
        BdPratos bd;

        public TabelaPratos(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bd = new BdPratos();
        }

        private void mVoltar_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm(MdiParent);
            mf.Show();
            Close();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoPrato f = new FormNovoPrato(MdiParent);
            f.Show();
            Close();
        }

        private void TabelaPratos_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bd.PreencheTabelaPratos("").Rows)
            {
                dgPratos.Rows.Add(dr.ItemArray);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codigo = -1, linha;
            linha = dgPratos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                codigo = int.Parse(dgPratos.CurrentRow.Cells[0].Value.ToString());
                FormNovoPrato fnf = new FormNovoPrato(MdiParent);
                fnf.Prato = bd.localiza(codigo);
                fnf.Show();
                Close();
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codigo = -1, linha;
            linha = dgPratos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                codigo = int.Parse(dgPratos.CurrentRow.Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir " + dgPratos.CurrentRow.Cells[1].Value.ToString(), "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    bd.excluirPrato(codigo);
                    dgPratos.Rows.Clear();
                    foreach (DataRow dr in bd.PreencheTabelaPratos(txtPrato.Text).Rows)
                    {
                        dgPratos.Rows.Add(dr.ItemArray);
                    }
                }
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            dgPratos.Rows.Clear();
            foreach (DataRow dr in bd.PreencheTabelaPratos(txtPrato.Text).Rows)
            {
                dgPratos.Rows.Add(dr.ItemArray);
            }
        }
    }
}
