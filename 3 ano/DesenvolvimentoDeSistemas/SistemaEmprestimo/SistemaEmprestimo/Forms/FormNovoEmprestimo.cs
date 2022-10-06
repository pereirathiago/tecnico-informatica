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
    public partial class FormNovoEmprestimo : Form
    {
        BdEmprestimos bdEmprestimos;
        Emprestimos emprestimos = new Emprestimos();

        internal Emprestimos Emprestimos
        {
            get => emprestimos;
            set
            {
                emprestimos = value;
                emprestimoToTela();
            }
        }

        public FormNovoEmprestimo(Form parent)
        {
            InitializeComponent();
            bdEmprestimos = new BdEmprestimos();
            MdiParent = parent;
        }

        private void telaToEmprestimo()
        {
            emprestimos.IdCliente = txtCpf.Text;
            emprestimos.IdEquipamento = Convert.ToInt32(cIdProduto.Text);
            emprestimos.DataPrevista = Convert.ToDateTime(txtDataEntrega.Text).Date;
            emprestimos.DataEmprestimo = DateTime.Now;
            emprestimos.IsEntregue = false;
            emprestimos.DataEntregue = null;
        }

        private void emprestimoToTela()
        {
            txtCpf.Text = Emprestimos.IdCliente;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente(MdiParent);
            f.Show();
            Close();
        }

        private void FormNovoEmprestimo_Load(object sender, EventArgs e)
        {
            cEquipamentos.DataSource = bdEmprestimos.PreencheComboBoxEquipamentos();
            cEquipamentos.ValueMember = "id";
            cEquipamentos.DisplayMember = "nome";
            cEquipamentos.Text = "Selecione o equipamento";

            cIdProduto.DataSource = bdEmprestimos.PreencheComboBoxEquipamentos();
            cIdProduto.ValueMember = "id";
            cIdProduto.DisplayMember = "id";
            cIdProduto.Text = "Código do equipamento";
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                telaToEmprestimo();
                bdEmprestimos.realizarEmprestimo(emprestimos);
                FormEmprestimo f = new FormEmprestimo(MdiParent);
                f.Show();
                Close();
            }
        }

        private void cEquipamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = cEquipamentos.SelectedIndex.ToString();
            try
            {
                if (index == "0")
                    cIdProduto.SelectedIndex = 1;
                cIdProduto.SelectedIndex = Convert.ToInt32(index);
            } catch
            {
              // nada
            }
        }

        private bool VerificaCampos()
        {
            if (cEquipamentos.Text == "Selecione o equipamento")
            {
                MessageBox.Show("Selecione um equipamento para emprestar");
                return false;
            }
            return true;
        }
    }
}
