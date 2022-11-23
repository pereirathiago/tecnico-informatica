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
            foreach (DataRow dr in bd.PreencheTabelaPedidos("").Rows)
            {
                dgPedidos.Rows.Add(dr.ItemArray);
            }
        }
    }
}
