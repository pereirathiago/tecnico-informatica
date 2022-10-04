namespace SistemaEmprestimo.Forms
{
    partial class FormProdutos
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
            this.dgProdutos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mVoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.equipamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNovoEquipamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarEquipamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcluirEquipamento = new System.Windows.Forms.ToolStripMenuItem();
            this.cVoltagem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar por Nome:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(123, 47);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(155, 20);
            this.txtFiltro.TabIndex = 12;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgProdutos
            // 
            this.dgProdutos.AllowUserToAddRows = false;
            this.dgProdutos.AllowUserToDeleteRows = false;
            this.dgProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.descricao,
            this.marca,
            this.voltagem});
            this.dgProdutos.Location = new System.Drawing.Point(27, 89);
            this.dgProdutos.MultiSelect = false;
            this.dgProdutos.Name = "dgProdutos";
            this.dgProdutos.ReadOnly = true;
            this.dgProdutos.Size = new System.Drawing.Size(769, 389);
            this.dgProdutos.TabIndex = 11;
            // 
            // id
            // 
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // voltagem
            // 
            this.voltagem.HeaderText = "Voltagem";
            this.voltagem.Name = "voltagem";
            this.voltagem.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mVoltar,
            this.equipamentosToolStripMenuItem});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(61, 20);
            this.mArquivo.Text = "Arquivo";
            // 
            // mVoltar
            // 
            this.mVoltar.Name = "mVoltar";
            this.mVoltar.Size = new System.Drawing.Size(150, 22);
            this.mVoltar.Text = "Voltar";
            this.mVoltar.Click += new System.EventHandler(this.mVoltar_Click);
            // 
            // equipamentosToolStripMenuItem
            // 
            this.equipamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovoEquipamento,
            this.btnEditarEquipamento,
            this.btnExcluirEquipamento});
            this.equipamentosToolStripMenuItem.Name = "equipamentosToolStripMenuItem";
            this.equipamentosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.equipamentosToolStripMenuItem.Text = "Equipamentos";
            // 
            // btnNovoEquipamento
            // 
            this.btnNovoEquipamento.Name = "btnNovoEquipamento";
            this.btnNovoEquipamento.Size = new System.Drawing.Size(109, 22);
            this.btnNovoEquipamento.Text = "Novo";
            this.btnNovoEquipamento.Click += new System.EventHandler(this.btnNovoEquipamento_Click);
            // 
            // btnEditarEquipamento
            // 
            this.btnEditarEquipamento.Name = "btnEditarEquipamento";
            this.btnEditarEquipamento.Size = new System.Drawing.Size(109, 22);
            this.btnEditarEquipamento.Text = "Editar";
            this.btnEditarEquipamento.Click += new System.EventHandler(this.btnEditarEquipamento_Click);
            // 
            // btnExcluirEquipamento
            // 
            this.btnExcluirEquipamento.Name = "btnExcluirEquipamento";
            this.btnExcluirEquipamento.Size = new System.Drawing.Size(109, 22);
            this.btnExcluirEquipamento.Text = "Excluir";
            this.btnExcluirEquipamento.Click += new System.EventHandler(this.btnExcluirEquipamento_Click);
            // 
            // cVoltagem
            // 
            this.cVoltagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cVoltagem.FormattingEnabled = true;
            this.cVoltagem.Items.AddRange(new object[] {
            "Todas as voltagens",
            "110 V",
            "220 V"});
            this.cVoltagem.Location = new System.Drawing.Point(641, 50);
            this.cVoltagem.Name = "cVoltagem";
            this.cVoltagem.Size = new System.Drawing.Size(155, 21);
            this.cVoltagem.TabIndex = 13;
            this.cVoltagem.SelectedIndexChanged += new System.EventHandler(this.cVoltagem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Filtro por Voltagem";
            // 
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cVoltagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.dgProdutos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProdutos";
            this.Load += new System.EventHandler(this.FormProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltagem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem mVoltar;
        private System.Windows.Forms.ToolStripMenuItem equipamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNovoEquipamento;
        private System.Windows.Forms.ToolStripMenuItem btnEditarEquipamento;
        private System.Windows.Forms.ToolStripMenuItem btnExcluirEquipamento;
        private System.Windows.Forms.ComboBox cVoltagem;
        private System.Windows.Forms.Label label2;
    }
}