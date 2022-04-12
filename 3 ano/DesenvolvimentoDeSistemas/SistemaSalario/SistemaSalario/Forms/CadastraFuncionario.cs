using SistemaSalario.bd;
using SistemaSalario.vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSalario
{
    public partial class CadastraFuncionario : Form
    {
        Funcionario funcionario = new Funcionario();
        BdFuncionario bdFuncionario;

        public CadastraFuncionario(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdFuncionario = new BdFuncionario();    
        }

        private void telaToFuncionario()
        {
            funcionario.Matricula = Convert.ToInt32(txtMatricula.Text);
            funcionario.Nome = txtNome.Text;
            funcionario.Vt = boxVt.Checked ? "S" : "N";
            MessageBox.Show(funcionario.Vt);
            funcionario.Dep14 = Convert.ToInt32(txtDep14.Text);
            funcionario.Depir = Convert.ToInt32(txtDepIr.Text);
            funcionario.Salario = Convert.ToDouble(txtSalario.Text);
        }

        private bool VerificaCampos()
        {
            if (txtNome.Text == "" || txtSalario = "")
            {
                MessageBox.Show("Preencha todos os campos");
                return false;
            }
            return true;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {

        }
    }
}
