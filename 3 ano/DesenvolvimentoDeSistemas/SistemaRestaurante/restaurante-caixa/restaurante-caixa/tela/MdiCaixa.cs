using restaurante_caixa.tela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurante_caixa
{
    public partial class MdiCaixa : Form
    {
        bool formActivated = true;

        public MdiCaixa()
        {
            InitializeComponent();
        }

        private void MdiCaixa_Activated(object sender, EventArgs e)
        {
            if (formActivated)
            {
                formActivated = false;
                Login fm = new Login(this);
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
            }
        }
    }
}
