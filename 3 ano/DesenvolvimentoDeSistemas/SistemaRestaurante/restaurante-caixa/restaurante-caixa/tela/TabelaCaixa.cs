using restaurante_caixa.bd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurante_caixa.tela
{
    public partial class TabelaCaixa : Form
    {
        public string mesaCaixa;
        BdCaixa bd;
        public TabelaCaixa(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bd = new BdCaixa();
        }

        private void mVoltar_Click(object sender, EventArgs e)
        {
            BuscarMesa mf = new BuscarMesa(MdiParent);
            mf.Show();
            Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (dgPedidos.RowCount == 0)
                MessageBox.Show("Nenhum há pedidos para fechar");
            else
            {
                bd.fechaPedido(mesaCaixa, "Fechado");
                MessageBox.Show("Pedido da mesa " + mesaCaixa + " fechado");
                BuscarMesa mf = new BuscarMesa(MdiParent);
                mf.Show();
                Close();
            }
        }

        private void TabelaCaixa_Load(object sender, EventArgs e)
        {
            dgPedidos.Rows.Clear();
            foreach (DataRow dr in bd.PreencheTabelaPedidos(mesaCaixa).Rows)
            {
                dgPedidos.Rows.Add(dr.ItemArray);
            }
            if (dgPedidos.RowCount == 0)
                MessageBox.Show("Nenhum pedido nessa mesa");
        }
    }
}
