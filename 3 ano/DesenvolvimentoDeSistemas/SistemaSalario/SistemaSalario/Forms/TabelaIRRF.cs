using SistemaSalario.bd;
using SistemaSalario.vo;
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
    public partial class TabelaIRRF : Form
    {
        BdTabela bdTabela;
        Tabela tabela = new Tabela();
        public TabelaIRRF(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdTabela = new BdTabela();
        }

        private void telaToTabela()
        {
            tabela.Tirrf1 = Convert.ToDouble(txtTirrf1.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Tirrf2 = Convert.ToDouble(txtTirrf2.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Tirrf3 = Convert.ToDouble(txtTirrf3.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Tirrf4 = Convert.ToDouble(txtTirrf4.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Airrf2 = Convert.ToDouble(txtAirrf2.Text.Replace("%", "").Replace(".", "").Trim());
            tabela.Airrf3 = Convert.ToDouble(txtAirrf3.Text.Replace("%", "").Replace(".", "").Trim());
            tabela.Airrf4 = Convert.ToDouble(txtAirrf4.Text.Replace("%", "").Replace(".", "").Trim());
            tabela.Airrf5 = Convert.ToDouble(txtAirrf5.Text.Replace("%", "").Replace(".", "").Trim());
            tabela.Dirrf2 = Convert.ToDouble(txtDirrf2.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Dirrf3 = Convert.ToDouble(txtDirrf3.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Dirrf4 = Convert.ToDouble(txtDirrf4.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Dirrf5 = Convert.ToDouble(txtDirrf5.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Dedpdep = Convert.ToDouble(txtDedpdep.Text.Replace("R$", "").Replace(".", "").Trim());
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaFuncionarios tf = new TabelaFuncionarios(MdiParent);
            tf.Show();
            Close();
        }

        private void salárioFamíliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaSalarioFamilia fsf = new TabelaSalarioFamilia(MdiParent);
            fsf.Show();
            Close();
        }

        private void iNSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaInss fin = new TabelaInss(MdiParent);
            fin.Show();
            Close();
        }

        private void TabelaIRRF_Load(object sender, EventArgs e)
        {
            preenchaTabela();
        }

        private void preenchaTabela()
        {
            Tabela tabela = bdTabela.PreencheTabela();
            txtTirrf1.Text = tabela.Tirrf1.ToString("C");
            txtTirrf1a.Text = (tabela.Tirrf1 + 0.01).ToString("C");
            txtTirrf2.Text = tabela.Tirrf2.ToString("C");
            txtTirrf2a.Text = (tabela.Tirrf2 + 0.01).ToString("C");
            txtTirrf3.Text = tabela.Tirrf3.ToString("C");
            txtTirrf3a.Text = (tabela.Tirrf3 + 0.01).ToString("C");
            txtTirrf4.Text = tabela.Tirrf4.ToString("C");
            txtTirrf5.Text = tabela.Tirrf4.ToString("C");
            txtAirrf1.Text = "-";
            txtAirrf2.Text = tabela.Airrf2.ToString() + "%";
            txtAirrf3.Text = tabela.Airrf3.ToString() + "%";
            txtAirrf4.Text = tabela.Airrf4.ToString() + "%";
            txtAirrf5.Text = tabela.Airrf5.ToString() + "%";
            txtDirrf1.Text = "-";
            txtDirrf2.Text = tabela.Dirrf2.ToString("C");
            txtDirrf3.Text = tabela.Dirrf3.ToString("C");
            txtDirrf4.Text = tabela.Dirrf4.ToString("C");
            txtDirrf5.Text = tabela.Dirrf5.ToString("C");
            txtDedpdep.Text = tabela.Dedpdep.ToString("C");
        }

        private void btnAtualizarInss_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                telaToTabela();
                try
                {
                    bdTabela.atualizaIRRF(tabela);
                    MessageBox.Show("Tabela atualizado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                preenchaTabela();
            }
        }

        private bool verificaCampos()
        {
            if (TextNoFormatting(txtTirrf1) != 0 && TextNoFormatting(txtTirrf2) != 0 && TextNoFormatting(txtTirrf3) != 0 && TextNoFormatting(txtTirrf4) != 0)
            {
                if (TextNoFormatting(txtAirrf2) != 0 && TextNoFormatting(txtAirrf3) != 0 && TextNoFormatting(txtAirrf4) != 0 && TextNoFormatting(txtAirrf5) != 0)
                {
                    if (TextNoFormatting(txtDirrf2) != 0 && TextNoFormatting(txtDirrf3) != 0 && TextNoFormatting(txtDirrf4) != 0 && TextNoFormatting(txtDirrf5) != 0)
                    {
                        if (TextNoFormatting(txtDedpdep) != 0)
                            if (TextNoFormatting(txtTirrf1) < TextNoFormatting(txtTirrf2) && TextNoFormatting(txtTirrf2) < TextNoFormatting(txtTirrf3) && TextNoFormatting(txtTirrf3) < TextNoFormatting(txtTirrf4)
                                && TextNoFormatting(txtAirrf2) < TextNoFormatting(txtAirrf3) && TextNoFormatting(txtAirrf3) < TextNoFormatting(txtAirrf4)
                                && TextNoFormatting(txtDirrf2) < TextNoFormatting(txtDirrf3) && TextNoFormatting(txtDirrf3) < TextNoFormatting(txtDirrf4))
                                return true;
                            else
                                MessageBox.Show("Preencha os valores corretamente!");
                    }
                }

            }
            return false;
        }

        private double TextNoFormatting(MaskedTextBox _mask)
        {
            String retString = _mask.Text.Replace("R$", "").Trim();
            retString = retString.Replace(".", "");
            try
            {
                return double.Parse(retString);
            }
            catch
            {
                MessageBox.Show("Preencha os valores corretamente!");
                return 0;
            }
        }

        private double TextNoFormatting(TextBox _text)
        {
            String retString = _text.Text.Replace("%", "").Trim();
            retString = retString.Replace(".", "");
            try
            {
                return double.Parse(retString);
            }
            catch
            {
                MessageBox.Show("Preencha os valores corretamente!");
                return 0;
            }
        }
    }
}
