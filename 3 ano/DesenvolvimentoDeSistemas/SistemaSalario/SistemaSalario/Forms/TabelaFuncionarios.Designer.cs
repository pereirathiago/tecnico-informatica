namespace SistemaSalario
{
    partial class TabelaFuncionarios
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgFiltro = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarValoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltro)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtrar descrição:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(104, 54);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(155, 20);
            this.txtFiltro.TabIndex = 9;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(265, 52);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(41, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgFiltro
            // 
            this.dgFiltro.AllowUserToAddRows = false;
            this.dgFiltro.AllowUserToDeleteRows = false;
            this.dgFiltro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgFiltro.Location = new System.Drawing.Point(12, 92);
            this.dgFiltro.Name = "dgFiltro";
            this.dgFiltro.ReadOnly = true;
            this.dgFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFiltro.Size = new System.Drawing.Size(857, 400);
            this.dgFiltro.TabIndex = 6;
            this.dgFiltro.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Matricula";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "VT";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Dep. Menores 14 anos";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Dep. para IR";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Salario Base";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "INSS";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Salário Família";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Vale Transporte";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "IRRF";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Salário Líquido";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(61, 20);
            this.mArquivo.Text = "Arquivo";
            // 
            // btnNovo
            // 
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(180, 22);
            this.btnNovo.Text = "Novo Funcionario";
            // 
            // editarFuncionarioToolStripMenuItem
            // 
            this.editarFuncionarioToolStripMenuItem.Name = "editarFuncionarioToolStripMenuItem";
            this.editarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarFuncionarioToolStripMenuItem.Text = "Editar Funcionario";
            // 
            // excluirFuncionarioToolStripMenuItem
            // 
            this.excluirFuncionarioToolStripMenuItem.Name = "excluirFuncionarioToolStripMenuItem";
            this.excluirFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirFuncionarioToolStripMenuItem.Text = "Excluir Funcionario";
            // 
            // editarValoresToolStripMenuItem
            // 
            this.editarValoresToolStripMenuItem.Name = "editarValoresToolStripMenuItem";
            this.editarValoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editarValoresToolStripMenuItem.Text = "Editar valores ";
            // 
            // TabelaFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.dgFiltro);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TabelaFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabelaFuncionarios";
            this.Load += new System.EventHandler(this.TabelaFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltro)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridView dgFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem btnNovo;
        private System.Windows.Forms.ToolStripMenuItem editarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarValoresToolStripMenuItem;
    }
}