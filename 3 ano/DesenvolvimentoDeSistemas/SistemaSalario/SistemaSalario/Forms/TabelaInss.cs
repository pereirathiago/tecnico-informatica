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
    public partial class TabelaInss : Form
    {
        BdTabela bdTabela;
        Tabela tabela = new Tabela();

        public TabelaInss(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdTabela = new BdTabela();
        }

        private void telaToTabela()
        {
            tabela.Tinss1 = Convert.ToDouble(tTinss1.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Tinss2 = Convert.ToDouble(tTinss2.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Tinss3 = Convert.ToDouble(tTinss3.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Tinss4 = Convert.ToDouble(tTinss4.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Ainss1 = Convert.ToDouble(tAinss1.Text.Replace("%", "").Replace(".", "").Trim());
            tabela.Ainss2 = Convert.ToDouble(tAinss2.Text.Replace("%", "").Replace(".", "").Trim());
            tabela.Ainss3 = Convert.ToDouble(tAinss3.Text.Replace("%", "").Replace(".", "").Trim());
            tabela.Ainss4 = Convert.ToDouble(tAinss4.Text.Replace("%", "").Replace(".", "").Trim());
        }

        private void TabelaInss_Load(object sender, EventArgs e)
        {
            preencheTabela();
        }

        private void preencheTabela()
        {
            Tabela tabela = bdTabela.PreencheTabela();
            tTinss1.Text = tabela.Tinss1.ToString("C");
            tTinss1a.Text = (tabela.Tinss1 + 0.01).ToString("C");
            tTinss2.Text = tabela.Tinss2.ToString("C");
            tTinss2a.Text = (tabela.Tinss2 + 0.01).ToString("C");
            tTinss3.Text = tabela.Tinss3.ToString("C");
            tTinss3a.Text = (tabela.Tinss3 + 0.01).ToString("C");
            tTinss4.Text = tabela.Tinss4.ToString("C");
            tAinss1.Text = tabela.Ainss1.ToString() + "%";
            tAinss2.Text = tabela.Ainss2.ToString() + "%";
            tAinss3.Text = tabela.Ainss3.ToString() + "%";
            tAinss4.Text = tabela.Ainss4.ToString() + "%";
        }

        private void btnAtualizarInss_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                telaToTabela();
                try
                {
                    bdTabela.atualizaINSS(tabela);
                    MessageBox.Show("Tabela atualizado com sucesso");
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                preencheTabela();
            }
        }

        private bool verificaCampos()
        {
            if (TextNoFormatting(tTinss1) != 0 && TextNoFormatting(tTinss2) != 0 && TextNoFormatting(tTinss3) != 0 && TextNoFormatting(tTinss4) != 0)
            {
                if (TextNoFormatting(tAinss1) != 0 && TextNoFormatting(tAinss2) != 0 && TextNoFormatting(tAinss3) != 0 && TextNoFormatting(tAinss4) != 0)
                {
                    return true;
                }

            }  
            return false; 
        }

        private double TextNoFormatting(MaskedTextBox _mask)
        {
            String retString = _mask.Text.Replace("R$","").Trim();
            retString = retString.Replace(".", "");
            try
            {
                return double.Parse(retString);
            } catch {
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

        private void iRRFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaIRRF fir = new TabelaIRRF(MdiParent);
            fir.Show();
            Close();
        }
    }
}
