using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCaixa
{
    public partial class MovimentoForm : Form
    {
        BdMovimento bd = new BdMovimento();
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
            Cadastra_Movimento cm = new Cadastra_Movimento();
            cm.Show();
        }

        private void MovimentoForm_Activated(object sender, System.EventArgs e)
        {
            dgFiltro.DataSource = bd.pesquisa("");
        }

        private void MovimentoForm_Load(object sender, EventArgs e)
        {

        }

    }
}
