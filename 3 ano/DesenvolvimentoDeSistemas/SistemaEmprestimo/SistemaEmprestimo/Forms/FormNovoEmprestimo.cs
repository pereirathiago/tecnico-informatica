using SistemaEmprestimo.bd;
using SistemaEmprestimo.vo;
using System;
using System.Data;
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

        private void telaToEmprestimo(int idEquipamento)
        {
            emprestimos.IdCliente = txtCpf.Text.Replace(',', '.');
            emprestimos.IdEquipamento = idEquipamento;
            emprestimos.DataPrevista = Convert.ToDateTime(txtDataEntrega.Text).Date;
            emprestimos.DataEmprestimo = DateTime.Now;
            emprestimos.IsEntregue = false;
            emprestimos.DataEntregue = null;
        }

        private void emprestimoToTela()
        {
            txtCpf.Text = Emprestimos.IdCliente.Replace(',', '.');
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente(MdiParent);
            f.Show();
            Close();
        }

        private void FormNovoEmprestimo_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bdEmprestimos.PreencheComboBoxEquipamentos().Rows)
            {
                cEquipamentos.Items.Add(dr.ItemArray[0] + " - " + dr.ItemArray[1]);
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                int idProduto;
                try
                {
                    int position = cEquipamentos.Text.IndexOf(" - ");
                    idProduto = Convert.ToInt32(cEquipamentos.Text.Substring(0, position));
                }
                catch
                {
                    idProduto = 0;
                }
                if(VerificaEmprstimo(idProduto)){
                    telaToEmprestimo(idProduto);
                    bdEmprestimos.realizarEmprestimo(emprestimos);
                    FormEmprestimo f = new FormEmprestimo(MdiParent);
                    f.Show();
                    Close();
                }
            }
        }

        private bool VerificaCampos()
        {
            if (cEquipamentos.Text == "Selecione o equipamento")
            {
                MessageBox.Show("Selecione um equipamento para emprestar");
                return false;
            }
            int result = DateTime.Compare(Convert.ToDateTime(txtDataEntrega.Text).Date, DateTime.Now.Date);
            if (result < 0)
            {
                MessageBox.Show("A data prevista para entrega não pode ser anterior a data de hoje");
                return false;
            }
            return true;
        }

        private bool VerificaEmprstimo(int idProduto)
        {
            if (bdEmprestimos.verificaEmprestimo(idProduto))
            {
                MessageBox.Show("Esse produto já está emprstado");
                return false;
            }
            return true;
        }
    }
}
