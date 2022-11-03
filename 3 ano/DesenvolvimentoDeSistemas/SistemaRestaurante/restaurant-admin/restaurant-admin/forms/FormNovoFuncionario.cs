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
    public partial class FormNovoFuncionario : Form
    {
        Funcionarios funcionario = new Funcionarios();
        BdFuncionario bdFuncionario;

        internal Funcionarios Funcionario
        {
            get => funcionario;
            set
            {
                funcionario = value;
                funcionarioToTela();
            }
        }

        public FormNovoFuncionario(Form parent)
        {
            InitializeComponent();
            bdFuncionario = new BdFuncionario();
            MdiParent = parent;
        }

        private void telaToFuncionario()
        {
            funcionario.Id = Convert.ToInt32(txtId.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Username = txtUser.Text;
            funcionario.Funcao = cFuncao.SelectedIndex;
        }

        private void funcionarioToTela()
        {
            txtId.Text = Funcionario.Id.ToString();
            txtNome.Text = Funcionario.Nome;
            txtUser.Text = Funcionario.Username;
            txtSenha.Text = Funcionario.Senha;
            try
            {
                cFuncao.SelectedIndex = Funcionario.Funcao;
            }
            catch
            {
                cFuncao.SelectedIndex = -1;
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            TabelaFuncionarios f = new TabelaFuncionarios(MdiParent);
            f.Show();
            Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                telaToFuncionario();
                bdFuncionario.salva(funcionario);
                TabelaFuncionarios f = new TabelaFuncionarios(MdiParent);
                f.Show();
                Close();
            }
        }

        private bool VerificaCampos()
        {
            if (cFuncao.Text == "Selecione a função")
            {
                MessageBox.Show("Selecione uma função");
                return false;
            }
            if (txtNome.Text == "" || txtSenha.Text == "" || txtUser.Text != "")
            {
                MessageBox.Show("Preencha corretamente todos os campos");
                return false;
            }
            return true;
        }
    }
}
