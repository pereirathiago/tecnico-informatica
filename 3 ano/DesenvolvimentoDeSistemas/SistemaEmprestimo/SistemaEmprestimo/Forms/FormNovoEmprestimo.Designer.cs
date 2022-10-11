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
            this.cEquipamentos = new System.Windows.Forms.ComboBox();
            this.txtDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancela
            // 
            this.btnCancela.Location = new System.Drawing.Point(178, 162);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 35;
            this.btnCancela.Text = "Cancelar";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(85, 162);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 34;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Produto";
            // 
            // cEquipamentos
            // 
            this.cEquipamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cEquipamentos.FormattingEnabled = true;
            this.cEquipamentos.Location = new System.Drawing.Point(134, 67);
            this.cEquipamentos.Name = "cEquipamentos";
            this.cEquipamentos.Size = new System.Drawing.Size(167, 21);
            this.cEquipamentos.TabIndex = 37;
            this.cEquipamentos.Text = "-- Selecione o Equipamento --";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEntrega.Location = new System.Drawing.Point(192, 112);
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(109, 20);
            this.txtDataEntrega.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Data Prevista de entrega";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(134, 30);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(167, 20);
            this.txtCpf.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "CPF do Cliente";
            // 
            // FormNovoEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 215);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cEquipamentos);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNovoEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNovoEmprestimo";
            this.Load += new System.EventHandler(this.FormNovoEmprestimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cEquipamentos;
        private System.Windows.Forms.DateTimePicker txtDataEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label3;
    }
}