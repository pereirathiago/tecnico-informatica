﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCaixa
{
    public partial class SistemaDeCaixa : Form
    {
        bool formActivated = true;
        public SistemaDeCaixa()
        {
            InitializeComponent();
            HorizontalScroll.Visible = false;
        }

        private void SistemaDeCaixa_Load(object sender, EventArgs e)
        {
            
        }

        private void SistemaDeCaixa_Activated(object sender, EventArgs e)
        {
            if (formActivated)
            {
                formActivated = false;
                Menu fm = new Menu(this);
                fm.StartPosition = FormStartPosition.CenterScreen;
                fm.Show();
            }
        }
    }
}
