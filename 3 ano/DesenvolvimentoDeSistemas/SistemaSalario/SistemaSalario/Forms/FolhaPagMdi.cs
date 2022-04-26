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
    public partial class FolhaPagMdi : Form
    {
        bool formActivated = true;
        public FolhaPagMdi()
        {
            InitializeComponent();
        }

        private void FolhaPagMdi_Activated(object sender, EventArgs e)
        {
            if (formActivated)
            {
                formActivated = false;
                TabelaFuncionarios fc = new TabelaFuncionarios(this);
                fc.StartPosition = FormStartPosition.CenterScreen;
                fc.Show();
            }
        }
    }
}
