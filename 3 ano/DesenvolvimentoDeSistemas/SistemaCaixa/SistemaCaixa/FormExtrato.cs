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
    public partial class FormExtrato : Form
    {
        BdMovimento bd;
        public FormExtrato(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bd = new BdMovimento();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Menu f = new Menu(MdiParent);
            f.Show();
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dgFiltro.Rows.Clear();
            foreach (DataRow dr in bd.PreencheTabelaDatas(Convert.ToDateTime(dataInicio.Text), Convert.ToDateTime(dataFinal.Text)).Rows)
            {
                dgFiltro.Rows.Add(dr.ItemArray);
                dgFiltro.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgFiltro.Columns[3].DefaultCellStyle.Format = "0.#0";
            }
            lSaldoInicio.Text = String.Format("{0:C}", bd.SaldoInicial(Convert.ToDateTime(dataInicio.Text)));
            lSaldoFin.Text = String.Format("{0:C}", bd.SaldoFinal(Convert.ToDateTime(dataFinal.Text)));

        }

        private void FormExtrato_Load(object sender, EventArgs e)
        {
            dgFiltro.Rows.Clear();
            foreach (DataRow dr in bd.PreencheTabelaDatas(Convert.ToDateTime(dataInicio.Text), Convert.ToDateTime(dataFinal.Text)).Rows)
            {
                dgFiltro.Rows.Add(dr.ItemArray);
                dgFiltro.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgFiltro.Columns[3].DefaultCellStyle.Format = "0.#0";
            }
            lSaldoInicio.Text = String.Format("{0:C}", bd.SaldoInicial(Convert.ToDateTime(dataInicio.Text)));
            lSaldoFin.Text = String.Format("{0:C}", bd.SaldoFinal(Convert.ToDateTime(dataFinal.Text)));
        }
    }
}
