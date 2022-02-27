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


        public Cadastra_Movimento(Form parent)
        {
            InitializeComponent();
            bd = new BdMovimento();
            MdiParent = parent;
        }

         private void telaToMovimento()
         {
            movimento.Id = Convert.ToInt32(txtId.Text);
            movimento.Data = Convert.ToDateTime(txtData.Text).Date;
            movimento.Descricao = txtDescricao.Text;
            movimento.Valor = Convert.ToDouble(txtValor.Value);
            movimento.Tipo = Convert.ToString(txtTipo.Text);
         }

        private bool VerificaCampos()
        {
            if (txtDescricao.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return false;
            }
            if (txtTipo.Text.Length > 1)
            {
                MessageBox.Show("Selecione um Tipo");
                return false;
            }
            return true;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                telaToMovimento();
                bd.inserir(movimento);
                MovimentoForm f = new MovimentoForm(MdiParent);
                f.Show();
                Close();
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            MovimentoForm f = new MovimentoForm(MdiParent);
            f.Show();
            Close();
        }
    }
}
