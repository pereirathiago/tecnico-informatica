namespace restaurante_cozinha.telas
{
    partial class TabelaPedids
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mVoltar = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(125, 20);
            this.txtNome.TabIndex = 24;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(246, 46);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 23;
            this.btnFiltro.Text = "Ok";
            this.btnFiltro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscar por nome:";
            // 
            // dgPedidos
            // 
            this.dgPedidos.AllowUserToAddRows = false;
            this.dgPedidos.AllowUserToDeleteRows = false;
            this.dgPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prato,
            this.mesa,
            this.status});
            this.dgPedidos.Location = new System.Drawing.Point(27, 92);
            this.dgPedidos.MultiSelect = false;
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.ReadOnly = true;
            this.dgPedidos.Size = new System.Drawing.Size(769, 415);
            this.dgPedidos.TabIndex = 20;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // prato
            // 
            this.prato.HeaderText = "Prato";
            this.prato.Name = "prato";
            this.prato.ReadOnly = true;
            // 
            // mesa
            // 
            this.mesa.HeaderText = "Mesa";
            this.mesa.Name = "mesa";
            this.mesa.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mVoltar,
            this.funcionarioToolStripMenuItem});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(61, 20);
            this.mArquivo.Text = "Arquivo";
            // 
            // mVoltar
            // 
            this.mVoltar.Name = "mVoltar";
            this.mVoltar.Size = new System.Drawing.Size(186, 22);
            this.mVoltar.Text = "Voltar";
            this.mVoltar.Click += new System.EventHandler(this.mVoltar_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.funcionarioToolStripMenuItem.Text = "Definir pedido como:";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.novoToolStripMenuItem.Text = "Em andamento";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editarToolStripMenuItem.Text = "Finalizado";
            // 
            // TabelaPedids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 522);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabelaPedids";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabelaPedids";
            this.Load += new System.EventHandler(this.TabelaPedids_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem mVoltar;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prato;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}