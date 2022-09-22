namespace SistemaEmprestimo.Forms
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
            this.txtFiltroCpf = new System.Windows.Forms.TextBox();
            this.btnOkCpf = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.idEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPrevisao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroProduto = new System.Windows.Forms.TextBox();
            this.btnOkProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
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
            // txtFiltroCpf
            // 
            this.txtFiltroCpf.Location = new System.Drawing.Point(116, 69);
            this.txtFiltroCpf.Name = "txtFiltroCpf";
            this.txtFiltroCpf.Size = new System.Drawing.Size(155, 20);
            this.txtFiltroCpf.TabIndex = 12;
            // 
            // btnOkCpf
            // 
            this.btnOkCpf.Location = new System.Drawing.Point(277, 67);
            this.btnOkCpf.Name = "btnOkCpf";
            this.btnOkCpf.Size = new System.Drawing.Size(41, 23);
            this.btnOkCpf.TabIndex = 13;
            this.btnOkCpf.Text = "Ok";
            this.btnOkCpf.UseVisualStyleBackColor = true;
            // 
            // dgClientes
            // 
            this.dgClientes.AllowUserToAddRows = false;
            this.dgClientes.AllowUserToDeleteRows = false;
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmprestimo,
            this.cpf,
            this.idProduto,
            this.nome,
            this.nomeProduto,
            this.dataEmprestimo,
            this.dataPrevisao,
            this.dataEntrega});
            this.dgClientes.Location = new System.Drawing.Point(28, 111);
            this.dgClientes.MultiSelect = false;
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.ReadOnly = true;
            this.dgClientes.Size = new System.Drawing.Size(769, 389);
            this.dgClientes.TabIndex = 11;
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
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(24, 23);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 26);
            this.btnVoltar.TabIndex = 10;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            // txtFiltroProduto
            // 
            this.txtFiltroProduto.Location = new System.Drawing.Point(589, 69);
            this.txtFiltroProduto.Name = "txtFiltroProduto";
            this.txtFiltroProduto.Size = new System.Drawing.Size(155, 20);
            this.txtFiltroProduto.TabIndex = 15;
            // 
            // btnOkProduto
            // 
            this.btnOkProduto.Location = new System.Drawing.Point(750, 67);
            this.btnOkProduto.Name = "btnOkProduto";
            this.btnOkProduto.Size = new System.Drawing.Size(41, 23);
            this.btnOkProduto.TabIndex = 16;
            this.btnOkProduto.Text = "Ok";
            this.btnOkProduto.UseVisualStyleBackColor = true;
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltroProduto);
            this.Controls.Add(this.btnOkProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltroCpf);
            this.Controls.Add(this.btnOkCpf);
            this.Controls.Add(this.dgClientes);
            this.Controls.Add(this.btnVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmprestimo";
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroCpf;
        private System.Windows.Forms.Button btnOkCpf;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroProduto;
        private System.Windows.Forms.Button btnOkProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPrevisao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntrega;
    }
}