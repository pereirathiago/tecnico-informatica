﻿namespace SistemaEmprestimo.Forms
{
    partial class FormEmprestimo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnOkCpf = new System.Windows.Forms.Button();
            this.dgEmprestimos = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrevisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOkProduto = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noPrazoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atrasadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolvidosNoPrazoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolvidosDepoisDoPrazoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cProdutosTable = new System.Windows.Forms.ComboBox();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.txtFiltroCpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmprestimos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar por CPF:";
            // 
            // btnOkCpf
            // 
            this.btnOkCpf.Location = new System.Drawing.Point(277, 67);
            this.btnOkCpf.Name = "btnOkCpf";
            this.btnOkCpf.Size = new System.Drawing.Size(41, 23);
            this.btnOkCpf.TabIndex = 13;
            this.btnOkCpf.Text = "Ok";
            this.btnOkCpf.UseVisualStyleBackColor = true;
            this.btnOkCpf.Click += new System.EventHandler(this.btnOkCpf_Click);
            // 
            // dgEmprestimos
            // 
            this.dgEmprestimos.AllowUserToAddRows = false;
            this.dgEmprestimos.AllowUserToDeleteRows = false;
            this.dgEmprestimos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.cpf,
            this.idProduto,
            this.nome,
            this.nomeProduto,
            this.dataEmprestimo,
            this.dataPrevisao,
            this.dataEntrega,
            this.entregue});
            this.dgEmprestimos.Location = new System.Drawing.Point(28, 111);
            this.dgEmprestimos.MultiSelect = false;
            this.dgEmprestimos.Name = "dgEmprestimos";
            this.dgEmprestimos.ReadOnly = true;
            this.dgEmprestimos.Size = new System.Drawing.Size(769, 389);
            this.dgEmprestimos.TabIndex = 11;
            // 
            // idEmprestimo
            // 
            this.idEmprestimo.HeaderText = "Código";
            this.idEmprestimo.Name = "idEmprestimo";
            this.idEmprestimo.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "Código Produto";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // nomeProduto
            // 
            this.nomeProduto.HeaderText = "Produto";
            this.nomeProduto.Name = "nomeProduto";
            this.nomeProduto.ReadOnly = true;
            // 
            // dataEmprestimo
            // 
            this.dataEmprestimo.HeaderText = "Data Emprestimo";
            this.dataEmprestimo.Name = "dataEmprestimo";
            this.dataEmprestimo.ReadOnly = true;
            // 
            // dataPrevisao
            // 
            this.dataPrevisao.HeaderText = "Data prevista";
            this.dataPrevisao.Name = "dataPrevisao";
            this.dataPrevisao.ReadOnly = true;
            // 
            // dataEntrega
            // 
            this.dataEntrega.HeaderText = "Data Entrega";
            this.dataEntrega.Name = "dataEntrega";
            this.dataEntrega.ReadOnly = true;
            // 
            // entregue
            // 
            this.entregue.HeaderText = "Entregue";
            this.entregue.Name = "entregue";
            this.entregue.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Buscar por produto:";
            // 
            // btnOkProduto
            // 
            this.btnOkProduto.Location = new System.Drawing.Point(750, 67);
            this.btnOkProduto.Name = "btnOkProduto";
            this.btnOkProduto.Size = new System.Drawing.Size(41, 23);
            this.btnOkProduto.TabIndex = 16;
            this.btnOkProduto.Text = "Ok";
            this.btnOkProduto.UseVisualStyleBackColor = true;
            this.btnOkProduto.Click += new System.EventHandler(this.btnOkProduto_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.mostrarTodosToolStripMenuItem,
            this.noPrazoToolStripMenuItem,
            this.atrasadosToolStripMenuItem,
            this.devolvidosNoPrazoToolStripMenuItem,
            this.devolvidosDepoisDoPrazoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.arquivoToolStripMenuItem.Text = "Emprestimos";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.mostrarTodosToolStripMenuItem.Text = "Mostrar todos";
            this.mostrarTodosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosToolStripMenuItem_Click);
            // 
            // noPrazoToolStripMenuItem
            // 
            this.noPrazoToolStripMenuItem.Name = "noPrazoToolStripMenuItem";
            this.noPrazoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.noPrazoToolStripMenuItem.Text = "No prazo";
            this.noPrazoToolStripMenuItem.Click += new System.EventHandler(this.noPrazoToolStripMenuItem_Click);
            // 
            // atrasadosToolStripMenuItem
            // 
            this.atrasadosToolStripMenuItem.Name = "atrasadosToolStripMenuItem";
            this.atrasadosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.atrasadosToolStripMenuItem.Text = "Atrasados";
            this.atrasadosToolStripMenuItem.Click += new System.EventHandler(this.atrasadosToolStripMenuItem_Click);
            // 
            // devolvidosNoPrazoToolStripMenuItem
            // 
            this.devolvidosNoPrazoToolStripMenuItem.Name = "devolvidosNoPrazoToolStripMenuItem";
            this.devolvidosNoPrazoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.devolvidosNoPrazoToolStripMenuItem.Text = "Devolvidos no prazo";
            this.devolvidosNoPrazoToolStripMenuItem.Click += new System.EventHandler(this.devolvidosNoPrazoToolStripMenuItem_Click);
            // 
            // devolvidosDepoisDoPrazoToolStripMenuItem
            // 
            this.devolvidosDepoisDoPrazoToolStripMenuItem.Name = "devolvidosDepoisDoPrazoToolStripMenuItem";
            this.devolvidosDepoisDoPrazoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.devolvidosDepoisDoPrazoToolStripMenuItem.Text = "Devolvidos depois do prazo";
            this.devolvidosDepoisDoPrazoToolStripMenuItem.Click += new System.EventHandler(this.devolvidosDepoisDoPrazoToolStripMenuItem_Click);
            // 
            // cProdutosTable
            // 
            this.cProdutosTable.FormattingEnabled = true;
            this.cProdutosTable.Location = new System.Drawing.Point(589, 68);
            this.cProdutosTable.Name = "cProdutosTable";
            this.cProdutosTable.Size = new System.Drawing.Size(155, 21);
            this.cProdutosTable.TabIndex = 19;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(28, 36);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(115, 23);
            this.btnDevolver.TabIndex = 20;
            this.btnDevolver.Text = "Devolver item";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // txtFiltroCpf
            // 
            this.txtFiltroCpf.Location = new System.Drawing.Point(116, 69);
            this.txtFiltroCpf.Mask = "000.000.000-00";
            this.txtFiltroCpf.Name = "txtFiltroCpf";
            this.txtFiltroCpf.Size = new System.Drawing.Size(155, 20);
            this.txtFiltroCpf.TabIndex = 21;
            this.txtFiltroCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 522);
            this.Controls.Add(this.txtFiltroCpf);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.cProdutosTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOkProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkCpf);
            this.Controls.Add(this.dgEmprestimos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmprestimo";
            this.Load += new System.EventHandler(this.FormEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmprestimos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOkCpf;
        private System.Windows.Forms.DataGridView dgEmprestimos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOkProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noPrazoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atrasadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolvidosNoPrazoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolvidosDepoisDoPrazoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrevisao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn entregue;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private System.Windows.Forms.ComboBox cProdutosTable;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.MaskedTextBox txtFiltroCpf;
    }
}