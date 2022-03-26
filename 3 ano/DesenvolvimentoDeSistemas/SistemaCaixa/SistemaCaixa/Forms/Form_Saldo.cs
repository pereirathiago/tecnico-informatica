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
    public partial class Form_Saldo : Form
    {
        BdSaldo bd = new BdSaldo();
        public Form_Saldo(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu f = new Menu(MdiParent);
            f.Show();
            Close();
        }

        private void Form_Saldo_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bd.PreencheTabela().Rows)
            {
                dgFiltro.Rows.Add(dr.ItemArray);
                dgFiltro.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgFiltro.Columns[2].DefaultCellStyle.Format = "0.#0";
            }
        }
    }
}
