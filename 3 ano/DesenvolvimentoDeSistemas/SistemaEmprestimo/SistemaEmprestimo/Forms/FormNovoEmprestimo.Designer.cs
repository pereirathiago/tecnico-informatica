namespace SistemaEmprestimo.Forms
{
    partial class FormNovoEmprestimo
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
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.txtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(173, 158);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 35;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(80, 158);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 34;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Produto";
            // 
            // txtTipo
            // 
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Location = new System.Drawing.Point(129, 63);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(148, 21);
            this.txtTipo.TabIndex = 37;
            this.txtTipo.Text = "-- Selecione o Produto --";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrega.Location = new System.Drawing.Point(174, 108);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(102, 20);
            this.txtDataEntrega.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Data Prevista de entrega";
            // 
            // FormNovoEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 233);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNovoEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNovoEmprestimo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.DateTimePicker txtDataEntrega;
        private System.Windows.Forms.Label label2;
    }
}