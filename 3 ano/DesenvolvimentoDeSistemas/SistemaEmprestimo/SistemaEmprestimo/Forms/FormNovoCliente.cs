using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmprestimo.Forms
{
    public partial class FormNovoCliente : Form
    {
        public FormNovoCliente(Form parent)
        {
            InitializeComponent();

            MdiParent = parent;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente(MdiParent);
            f.Show();
            Close();
        }
    }
}
