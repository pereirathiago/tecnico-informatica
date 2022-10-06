using SistemaEmprestimo.bd;
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
    public partial class FormEmprestimo : Form
    {
        BdEmprestimos bdEmprestimos;
        public FormEmprestimo(Form parent)
        {
            InitializeComponent();
            bdEmprestimos = new BdEmprestimos();
            MdiParent = parent;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(MdiParent);
            f.Show();
            Close();
        }

        private void FormEmprestimo_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela("").Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
    }
}
