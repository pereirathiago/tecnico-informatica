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
        public Cadastra_Movimento()
        {
            InitializeComponent();
        }

        Movimento mMovimento;
        Boolean mNovo;

         private void movimentoToTela()
         {
             txtId.Text = Convert.ToString(mMovimento.Id);
             txtData.Text = Convert.ToString(mMovimento.Data);
             txtDescricao.Text = mMovimento.Descricao;
             txtValor.Value = Convert.ToDecimal(mMovimento.Valor);
             txtTipo.Text = mMovimento.Tipo;
         }

         private void telaToMovimento()
         {
             mMovimento.Id = Convert.ToInt32(txtId.Text);
             mMovimento.Data = Convert.ToDateTime(txtData.Text);
             mMovimento.Descricao = txtDescricao.Text;
             mMovimento.Valor = Convert.ToDouble(txtValor.Value);
             mMovimento.Tipo = Convert.ToString(txtTipo.Text);
         }

        internal Movimento movimento
        {
            get { return mMovimento; }
            set
            {
                mMovimento = value;
                movimentoToTela();
            }
        }
        public Boolean novo
        {
            get { return mNovo; }
            set { mNovo = value; }
        }
    }
}
