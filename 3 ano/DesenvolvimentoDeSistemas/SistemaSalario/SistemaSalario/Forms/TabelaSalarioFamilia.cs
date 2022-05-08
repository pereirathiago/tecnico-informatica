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
    public partial class TabelaSalarioFamilia : Form
    {
        BdTabela bdTabela;
        Tabela tabela = new Tabela();

        public TabelaSalarioFamilia(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdTabela = new BdTabela();
        }

        private void telaToTabela()
        {
            tabela.Tsf = Convert.ToDouble(txtTsf.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Vsf = Convert.ToDouble(txtVsf.Text);
        }

        private void preencheTabela()
        {
            Tabela tabela = bdTabela.PreencheTabela();
            txtTsf.Text = tabela.Tsf.ToString("C");
            txtVsf.Text = tabela.Vsf.ToString();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaFuncionarios tf = new TabelaFuncionarios(MdiParent);
            tf.Show();
            Close();
        }

        private void iNSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabelaInss ti = new TabelaInss(MdiParent);
            ti.Show();
            Close();
        }

        private void TabelaSalarioFamilia_Load(object sender, EventArgs e)
        {
            preencheTabela();
        }

        private void btnAtualizarSal_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                telaToTabela();
                try
                {
                    bdTabela.atualizaSalarioF(tabela);
                    MessageBox.Show("Tabela atualizado com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                preencheTabela();
            }
        }

        private bool verificaCampos()
        {
            if (TextNoFormatting(txtTsf) != 0 && txtVsf.Value != 0)
            {
                if(!txtVsf.Value.Equals(""))
                    return true;
                else
                { 
                    MessageBox.Show("Preencha todos os campos");
                    return false; 
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
    }
}
