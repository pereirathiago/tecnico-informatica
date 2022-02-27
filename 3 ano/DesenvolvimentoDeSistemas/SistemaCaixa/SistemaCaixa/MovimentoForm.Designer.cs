namespace SistemaCaixa
{
    partial class MovimentoForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVoltaMenu = new System.Windows.Forms.Button();
            this.dgFiltro = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltaMenu
            // 
            this.btnVoltaMenu.Location = new System.Drawing.Point(12, 12);
            this.btnVoltaMenu.Name = "btnVoltaMenu";
            this.btnVoltaMenu.Size = new System.Drawing.Size(75, 23);
            this.btnVoltaMenu.TabIndex = 1;
            this.btnVoltaMenu.Text = "Voltar";
            this.btnVoltaMenu.UseVisualStyleBackColor = true;
            this.btnVoltaMenu.Click += new System.EventHandler(this.btnVoltaMenu_Click);
            // 
            // dgFiltro
            // 
            this.dgFiltro.AllowUserToAddRows = false;
            this.dgFiltro.AllowUserToDeleteRows = false;
            this.dgFiltro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiltro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.data,
            this.descricao,
            this.valor,
            this.tipo});
            this.dgFiltro.Location = new System.Drawing.Point(12, 52);
            this.dgFiltro.Name = "dgFiltro";
            this.dgFiltro.ReadOnly = true;
            this.dgFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgFiltro.Size = new System.Drawing.Size(612, 327);
            this.dgFiltro.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // data
            // 
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(93, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // MovimentoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 421);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgFiltro);
            this.Controls.Add(this.btnVoltaMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovimentoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentos";
            this.Load += new System.EventHandler(this.MovimentoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltaMenu;
        private System.Windows.Forms.DataGridView dgFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Button btnNovo;
    }
}

