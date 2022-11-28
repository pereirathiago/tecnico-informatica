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
    public partial class BuscarMesa : Form
    {
        BdCaixa bd;

        public BuscarMesa(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bd = new BdCaixa();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TabelaCaixa tc = new TabelaCaixa(MdiParent);
            tc.mesaCaixa = txtMesa.Text;
            tc.Show();
            Close();
        }
    }
}
