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
    public partial class MenuForm : Form
    {
        public MenuForm(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            TabelaFuncionarios tf = new TabelaFuncionarios(MdiParent);
            tf.Show();
            Close();
        }

        private void btnPratos_Click(object sender, EventArgs e)
        {
            TabelaPratos tp = new TabelaPratos(MdiParent);
            tp.Show();
            Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login tp = new Login(MdiParent);
            tp.Show();
            Close();
        }
    }
}
