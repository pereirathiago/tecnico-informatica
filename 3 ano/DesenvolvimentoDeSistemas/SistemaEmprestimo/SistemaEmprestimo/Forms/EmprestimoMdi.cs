using SistemaEmprestimo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmprestimo
{
    public partial class EmprestimoMdi : Form
    {
        bool formActivated = true;

        public EmprestimoMdi()
        {
            InitializeComponent();
        }

        private void EmprestimoMdi_Activated(object sender, EventArgs e)
        {
            if (formActivated)
            {
                formActivated = false;
                MenuForm fm = new MenuForm(this);
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
            }
        }
    }
}
