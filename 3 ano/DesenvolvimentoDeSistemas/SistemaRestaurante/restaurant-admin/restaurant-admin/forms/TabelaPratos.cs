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
        public TabelaPratos(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void mVoltar_Click(object sender, EventArgs e)
        {
            MenuForm mf = new MenuForm(MdiParent);
            mf.Show();
            Close();
        }
    }
}
