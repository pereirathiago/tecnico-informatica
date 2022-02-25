using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCaixa
{
    public partial class MovimentoForm : Form
    {
        public MovimentoForm(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void btnVoltaMenu_Click(object sender, EventArgs e)
        {
            Menu f = new Menu(MdiParent);
            f.Show();
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cadastra_Movimento.movimento = new Movimento();
        }
    }
}
