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
            emprestimos.IdEquipamento = Convert.ToInt32(cEquipamentos.ValueMember);
            emprestimos.DataPrevista = Convert.ToDateTime(txtDataEntrega.Text).Date;
            emprestimos.DataEmprestimo = DateTime.Now;
            emprestimos.IsEntregue = false;
            emprestimos.DataEntregue = null;
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
            cEquipamentos.Text = "selecione o equipamento";
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            telaToEmprestimo();
            bdEmprestimos.realizarEmprestimo(emprestimos);
            FormEmprestimo f = new FormEmprestimo(MdiParent);
            f.Show();
            Close();
        }
    }
}
