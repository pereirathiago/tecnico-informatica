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
    public partial class FormProdutos : Form
    {
        BdEquipamentos bdEquipamentos;
        private Equipamentos equipamentos = new Equipamentos();

        public FormProdutos(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdEquipamentos = new BdEquipamentos();
        }

        private void mVoltar_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(MdiParent);
            f.Show();
            Close();
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            foreach (DataRow dr in bdEquipamentos.PreencheTabelaEquipamentos("").Rows)
            {
                dgClientes.Rows.Add(dr.ItemArray);
            }
        }

        private void btnNovoEquipamento_Click(object sender, EventArgs e)
        {
            FormNovoProduto f = new FormNovoProduto(MdiParent);
            f.Show();
            Close();
        }
    }
}
