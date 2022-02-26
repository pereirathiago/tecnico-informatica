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
    public partial class Cadastra_Movimento : Form
    {
        Movimento movimento = new Movimento();
        BdMovimento bd;


        public Cadastra_Movimento()
        {
            InitializeComponent();
            bd = new BdMovimento();
        }

         private void movimentoToTela()
         {
             txtId.Text = Convert.ToString(movimento.Id);
             txtData.Text = Convert.ToString(movimento.Data);
             txtDescricao.Text = movimento.Descricao;
             txtValor.Value = Convert.ToDecimal(movimento.Valor);
             txtTipo.Text = movimento.Tipo;
         }

         private void telaToMovimento()
         {
             movimento.Id = Convert.ToInt32(txtId.Text);
             movimento.Data = Convert.ToDateTime(txtData.Text);
             movimento.Descricao = txtDescricao.Text;
             movimento.Valor = Convert.ToDouble(txtValor.Value);
             movimento.Tipo = Convert.ToString(txtTipo.Text);
         }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            telaToMovimento();
            bd.salva(movimento);
            this.Dispose();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        internal Movimento Movimento
        {
            set 
            { 
                this.Movimento = movimento;
                movimentoToTela();
            }
        }
    }
}
