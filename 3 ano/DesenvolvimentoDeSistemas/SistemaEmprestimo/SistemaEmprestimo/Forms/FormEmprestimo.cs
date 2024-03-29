﻿using SistemaEmprestimo.bd;
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
    public partial class FormEmprestimo : Form
    {
        BdEmprestimos bdEmprestimos;
        public FormEmprestimo(Form parent)
        {
            InitializeComponent();
            bdEmprestimos = new BdEmprestimos();
            MdiParent = parent;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuForm f = new MenuForm(MdiParent);
            f.Show();
            Close();
        }

        private void FormEmprestimo_Load(object sender, EventArgs e)
        {
            cProdutosTable.Items.Add("Todos os produtos");
            foreach (DataRow dr in bdEmprestimos.PreencheComboBoxEquipamentos().Rows)
            {
                cProdutosTable.Items.Add(dr.ItemArray[0] + " - " +dr.ItemArray[1]);
            }

            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela("",0, bdEmprestimos.PreencheTabelaEmprstimos).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void noPrazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            string cpf = verificaCpf();
            int idProduto = verificaProduto();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela(cpf, idProduto, bdEmprestimos.localizaNoPrazo).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void atrasadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            string cpf = verificaCpf();
            int idProduto = verificaProduto();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela(cpf, idProduto, bdEmprestimos.localizaAtrazados).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            string cpf = verificaCpf();
            int idProduto = verificaProduto();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela(cpf, idProduto, bdEmprestimos.PreencheTabelaEmprstimos).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void devolvidosNoPrazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            string cpf = verificaCpf();
            int idProduto = verificaProduto();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela(cpf, idProduto, bdEmprestimos.localizaDevolvidosNoPrazo).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void devolvidosDepoisDoPrazoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            string cpf = verificaCpf();
            int idProduto = verificaProduto();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela(cpf, idProduto, bdEmprestimos.localizaDevolvidosDepoisDoPrazo).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnOkCpf_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            string cpf = verificaCpf();
            int idProduto = verificaProduto();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela(cpf, idProduto, bdEmprestimos.PreencheTabelaEmprstimos).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnOkProduto_Click(object sender, EventArgs e)
        {
            dgEmprestimos.Rows.Clear();
            string cpf = verificaCpf();
            int idProduto = verificaProduto();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela(cpf, idProduto, bdEmprestimos.PreencheTabelaEmprstimos).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            int codigo = -1, linha;
            linha = dgEmprestimos.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            if (linha > -1)
            {
                if (dgEmprestimos.CurrentRow.Cells[8].Value.ToString() == "Não")
                {
                    codigo = int.Parse(dgEmprestimos.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show("Produto devolvido com sucesso!");
                }
                else
                    MessageBox.Show("Esse produto já foi devolvido");
                bdEmprestimos.devolverProduto(codigo);
            }
            else
                MessageBox.Show("Nenhuma linha selecionada");

            dgEmprestimos.Rows.Clear();
            foreach (DataRow dr in bdEmprestimos.calculaNovaTabela("", 0, bdEmprestimos.PreencheTabelaEmprstimos).Rows)
            {
                dgEmprestimos.Rows.Add(dr.ItemArray);
                dgEmprestimos.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgEmprestimos.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private string verificaCpf()
        {
            string cpf;
            if (txtFiltroCpf.MaskCompleted)
            {
                return cpf = Convert.ToUInt64(txtFiltroCpf.Text).ToString(@"000\.000\.000\-00");
            }
            else if (txtFiltroCpf.Text == String.Empty)
                return cpf = "";
            else
            {
                MessageBox.Show("Preencha corretamente o campo");
                return cpf = "";
            }
        }

        private int verificaProduto()
        {
            int idProduto;
            try
            {
                int position = cProdutosTable.Text.IndexOf(" - ");
                return idProduto = Convert.ToInt32(cProdutosTable.Text.Substring(0, position));
            }
            catch
            {
                return idProduto = 0;
            }
        }
    }
}
