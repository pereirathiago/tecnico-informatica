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
    public partial class SistemaDeCaixa : Form
    {
        public SistemaDeCaixa()
        {
            InitializeComponent();
            HorizontalScroll.Visible = false;
        }

        private void SistemaDeCaixa_Load(object sender, EventArgs e)
        {
            Menu fm = new Menu(this);
            fm.Show();
        }
    }
}
