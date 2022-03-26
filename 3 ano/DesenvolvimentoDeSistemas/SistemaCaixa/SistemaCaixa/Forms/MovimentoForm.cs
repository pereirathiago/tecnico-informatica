using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaCaixa
{
    public partial class MovimentoForm : Form
    {
        BdMovimento bd = new BdMovimento();
        public MovimentoForm(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
        }

        private void btnVoltaMenu_Click(object sender, EventArgs e)
        {
            Menu f = new Menu(MdiParent);
            f.Show();
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Cadastra_Movimento cm = new Cadastra_Movimento(MdiParent);
            cm.Show();
            Close();
        }

        private void MovimentoForm_Activated(object sender, System.EventArgs e) 
        {

        }

        private void MovimentoForm_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bd.PreencheTabela("").Rows)
            {
                dgFiltro.Rows.Add(dr.ItemArray);
                dgFiltro.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgFiltro.Columns[3].DefaultCellStyle.Format = "0.#0";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            dgFiltro.Rows.Clear();
            foreach (DataRow dr in bd.PreencheTabela(txtFiltro.Text).Rows)
            {
                dgFiltro.Rows.Add(dr.ItemArray);
                dgFiltro.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgFiltro.Columns[3].DefaultCellStyle.Format = "0.#0";
            }
        }

    }
}
