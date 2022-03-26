using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            #region Textos

            string datas = "Extrato - " + dataInicio.Text + " a " + dataFinal.Text;
            string saldoInicial = "Saldo Inicial " + lSaldoInicio.Text;
            string saldoFinal = "Saldo Final " + lSaldoFin.Text;
            Font letraDatas = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            Font letraSaldo = new Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);
            Point pontoInicial = new Point(100, 50);

            // desenhar o documento para ser impresso
            e.Graphics.DrawString(datas, letraDatas, pincel, pontoInicial);
            e.Graphics.DrawString(saldoInicial, letraSaldo, pincel, new Point(100, 100));
            e.Graphics.DrawString(saldoFinal, letraSaldo, pincel, new Point(100, 125));

            #endregion

            #region DataGridView

            Bitmap bmp;

            int height = dgFiltro.Height;
            dgFiltro.Height = dgFiltro.RowCount * dgFiltro.RowTemplate.Height * 2;
            bmp = new Bitmap(dgFiltro.Width, dgFiltro.Height);
            dgFiltro.DrawToBitmap(bmp, new Rectangle(0, 0, dgFiltro.Width, dgFiltro.Height));
            dgFiltro.Height = height;

            e.Graphics.DrawImage(bmp, 100, 175);

            #endregion
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            // printDocument1.DefaultPageSettings.Landscape = true; // paisagem
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            //printDocument1.Print();
        }
    }
}
