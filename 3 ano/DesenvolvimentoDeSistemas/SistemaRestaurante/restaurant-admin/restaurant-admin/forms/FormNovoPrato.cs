using restaurant_admin.bd;
using restaurant_admin.vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_admin.forms
{
    public partial class FormNovoPrato : Form
    {
        Pratos prato = new Pratos();
        BdPratos bdPrato;

        internal Pratos Prato
        {
            get => prato;
            set
            {
                prato = value;
                pratoToTela();
            }
        }

        public FormNovoPrato(Form parent)
        {
            InitializeComponent();
            bdPrato = new BdPratos();
            MdiParent =  parent;
        }

        private void telaToPrato()
        {
            prato.Id = Convert.ToInt32(txtId.Text);
            prato.Nome = txtNome.Text;
            prato.Descricao = txtDescricao.Text;
            prato.Preco = Convert.ToDouble(txtPreco.Value);
        }

        private void pratoToTela()
        {
            txtId.Text = Prato.Id.ToString();
            txtNome.Text = Prato.Nome;
            txtDescricao.Text = Prato.Descricao;
            txtPreco.Value = Convert.ToDecimal(Prato.Preco);
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                telaToPrato();
                bdPrato.salva(prato);
                TabelaPratos f = new TabelaPratos(MdiParent);
                f.Show();
                Close();
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            TabelaPratos f = new TabelaPratos(MdiParent);
            f.Show();
            Close();
        }

        private bool VerificaCampos()
        {
            if (txtNome.Text == "" || txtDescricao.Text == "" || txtPreco.Value == 0)
            {
                MessageBox.Show("Preencha corretamente todos os campos");
                return false;
            }
            return true;
        }
    }
}
