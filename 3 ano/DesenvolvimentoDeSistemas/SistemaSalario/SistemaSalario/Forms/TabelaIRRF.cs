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

namespace SistemaSalario.Forms
{
    public partial class TabelaIRRF : Form
    {
        BdTabela bdTabela;
        Tabela tabela = new Tabela();
        public TabelaIRRF(Form parent)
        {
            InitializeComponent();
            MdiParent = parent;
            bdTabela = new BdTabela();
        }

        private void telaToTabela()
        {
            tabela.Tirrf1 = Convert.ToDouble(txtTirrf1.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Tirrf2 = Convert.ToDouble(txtTirrf2.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Tirrf3 = Convert.ToDouble(txtTirrf3.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Tirrf4 = Convert.ToDouble(txtTirrf4.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Airrf2 = Convert.ToDouble(txtAirrf2.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Airrf3 = Convert.ToDouble(txtAirrf3.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Airrf4 = Convert.ToDouble(txtAirrf4.Text.Replace("R$", "").Replace(".", "").Trim());
            tabela.Airrf5 = Convert.ToDouble(txtAirrf5.Text.Replace("R$", "").Replace(".", "").Trim());
        }

    }
}
