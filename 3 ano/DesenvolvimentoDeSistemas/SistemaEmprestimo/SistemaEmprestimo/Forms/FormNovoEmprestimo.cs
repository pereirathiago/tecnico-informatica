using SistemaEmprestimo.bd;
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

        public FormNovoEmprestimo(Form parent)
        {
            InitializeComponent();
            bdEmprestimos = new BdEmprestimos();
            MdiParent = parent;
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
    }
}
