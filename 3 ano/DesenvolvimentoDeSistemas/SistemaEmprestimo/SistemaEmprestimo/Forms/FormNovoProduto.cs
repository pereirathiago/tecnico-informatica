using SistemaEmprestimo.bd;
using SistemaEmprestimo.vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmprestimo.Forms
{
    public partial class FormNovoProduto : Form
    {
        Equipamentos equipamentos = new Equipamentos();
        BdEquipamentos bdEquipamento;

        internal Equipamentos Equipamentos
        {
            get => equipamentos;
            set
            {
                equipamentos = value;
                equipamentoToTela();
            }
        }

        public FormNovoProduto(Form parent)
        {
            InitializeComponent();
            bdEquipamento = new BdEquipamentos();
            MdiParent = parent;
        }

        private void telaToEquipamento()
        {
            equipamentos.Id = Convert.ToInt32(txtId.Text);
            equipamentos.Nome = txtNome.Text;
            equipamentos.Descricao = txtDescricao.Text;
            equipamentos.Marca = txtMarca.Text;
            equipamentos.Voltagem = txtVoltagem.Text;
        }

        private void equipamentoToTela()
        {
            txtId.Text = Equipamentos.Id.ToString();
            txtNome.Text = Equipamentos.Nome;
            txtDescricao.Text = Equipamentos.Descricao;
            txtMarca.Text = Equipamentos.Marca;
            txtVoltagem.Text = Equipamentos.Voltagem;
        }

        private bool VerificaCampos()
        {
            if (txtDescricao.Text == "" || txtNome.Text == "" || txtMarca.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return false;
            }
            if (txtVoltagem.Text.Length > 5)
            {
                MessageBox.Show("Selecione uma Voltagem");
                return false;
            }
            return true;
        }


        private void btnCancela_Click(object sender, EventArgs e)
        {
            FormProdutos f = new FormProdutos(MdiParent);
            f.Show();
            Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                telaToEquipamento();
                bdEquipamento.salva(equipamentos);
                FormProdutos f = new FormProdutos(MdiParent);
                f.Show();
                Close();
            }
        }
    }
}
