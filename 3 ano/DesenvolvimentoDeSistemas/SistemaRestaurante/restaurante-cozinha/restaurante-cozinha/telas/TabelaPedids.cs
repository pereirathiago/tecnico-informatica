using restaurante_cozinha.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurante_cozinha.telas
{
    public partial class TabelaPedids : Form
    {
        BdCozinha bd;

        public TabelaPedids(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bd = new BdCozinha();
        }

        private void mVoltar_Click(object sender, EventArgs e)
        {
            Login mf = new Login(MdiParent);
            mf.Show();
            Close();
        }

        private void TabelaPedids_Load(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            PreencheTabela();
        }

        private void andamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codigo = -1, linha;
            string status;
            linha = dgPedidos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                codigo = int.Parse(dgPedidos.CurrentRow.Cells[0].Value.ToString());
                status = dgPedidos.CurrentRow.Cells[4].Value.ToString();
                if (status == "Em andamento")
                    MessageBox.Show("Esse pedido já está sendo preparado");
                else if (status == "Pronto")
                    MessageBox.Show("Esse pedidojá está pronto");
                else
                {
                    bd.atualizaPrato(codigo, "Em andamento");
                    MessageBox.Show("Status atualizado com sucesso");
                    PreencheTabela();
                }
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }

        private void PreencheTabela()
        {
            dgPedidos.Rows.Clear();
            foreach (DataRow dr in bd.PreencheTabelaPedidos(txtNome.Text).Rows)
            {
                dgPedidos.Rows.Add(dr.ItemArray);
            }
        }

        private void finalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int codigo = -1, linha;
            string status;
            linha = dgPedidos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                codigo = int.Parse(dgPedidos.CurrentRow.Cells[0].Value.ToString());
                status = dgPedidos.CurrentRow.Cells[4].Value.ToString();
                if (status == "Pronto")
                    MessageBox.Show("Esse pedido já está pronto");
                else if (status == "Em espera")
                    MessageBox.Show("Esse pedido precisa estar em andamento para ser finalizado");
                else
                {
                    bd.atualizaPrato(codigo, "Pronto");
                    MessageBox.Show("Status atualizado com sucesso");
                    PreencheTabela();
                }
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");
        }
    }
}

