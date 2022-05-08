using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSalario.Forms
{
    public partial class TabelaSalarioFamilia : Form
    {
        public TabelaSalarioFamilia(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaFuncionarios tf = new TabelaFuncionarios(MdiParent);
            tf.Show();
            Close();
        }

        private void iNSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaInss ti = new TabelaInss(MdiParent);
            ti.Show();
            Close();
        }
    }
}
