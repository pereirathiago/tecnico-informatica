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
    public partial class FormNovoCliente : Form
    {
        Cliente cliente = new Cliente();
        BdCliente bdCliente;

        internal Cliente Cliente
        {
            get => cliente;
            set
            {
                cliente = value;
                clienteToTela();
            }
        }

        public FormNovoCliente(Form parent)
        {
            InitializeComponent();
            bdCliente = new BdCliente();
            MdiParent = parent;
        }

        private void telaToClientes()
        {
            cliente.Cpf = txtCpf.Text;
            cliente.Nome = txtNome.Text;
            cliente.DataNasc = Convert.ToDateTime(txtData.Text).Date;
            cliente.Endereco = txtEndereco.Text;
            cliente.Telefone = txtTelefone.Text;
        }

        private void clienteToTela()
        {
            txtCpf.Text = Cliente.Cpf;
            txtNome.Text = Cliente.Nome;
            txtData.Text = Cliente.DataNasc.ToString();
            txtEndereco.Text = Cliente.Endereco;
            txtTelefone.Text = Cliente.Telefone;
        }

        private bool VerificaCampos()
        {
            if (txtNome.Text == "" || txtEndereco.Text == "" || !txtCpf.MaskCompleted || !txtTelefone.MaskCompleted)
            {
                MessageBox.Show("Preencha corretamente todos os campos");
                return false;
            }
            return true;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente(MdiParent);
            f.Show();
            Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                telaToClientes();
                bdCliente.salva(cliente);
                FormCliente f = new FormCliente(MdiParent);
                f.Show();
                Close();
            }
        }
    }
}
