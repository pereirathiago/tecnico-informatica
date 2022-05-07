using SistemaSalario.bd;
using SistemaSalario.vo;
using System;
using System.Windows.Forms;

namespace SistemaSalario
{
    public partial class CadastraFuncionario : Form
    {
        Funcionario funcionario = new Funcionario();
        BdFuncionario bdFuncionario;

        internal Funcionario Funcionario {
            get => funcionario; 
            set { 
                funcionario = value;
                funcionarioToTela();
            }
        }

        public CadastraFuncionario(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdFuncionario = new BdFuncionario();    
        }

        private void telaToFuncionario()
        {
            Funcionario.Matricula = Convert.ToInt32(txtMatricula.Text);
            Funcionario.Nome = txtNome.Text;
            Funcionario.Vt = boxVt.Checked ? "S" : "N";
            Funcionario.Dep14 = Convert.ToInt32(txtDep14.Text);
            Funcionario.Depir = Convert.ToInt32(txtDepIr.Text);
            Funcionario.Salario = Convert.ToDouble(txtSalario.Text);
        }

        private void funcionarioToTela()
        {
            txtMatricula.Text = Funcionario.Matricula.ToString();
            txtNome.Text = Funcionario.Nome;
            boxVt.Checked = Funcionario.Vt == "S" ? true : false;
            txtDep14.Text = Funcionario.Dep14.ToString();
            txtDepIr.Text = Funcionario.Depir.ToString();
            txtSalario.Text = Funcionario.Salario.ToString();
        }

        private bool VerificaCampos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return false;
            }
            if (txtSalario.Value == 0)
            {
                MessageBox.Show("Preencha um salario");
                return false;
            }
            return true;
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            TabelaFuncionarios fm = new TabelaFuncionarios(MdiParent);
            fm.Show();
            Close();
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            if (VerificaCampos())
            {
                telaToFuncionario();
                bdFuncionario.salva(Funcionario);
                TabelaFuncionarios fm = new TabelaFuncionarios(MdiParent);
                fm.Show();
                Close();
            }
        }
    }
}
