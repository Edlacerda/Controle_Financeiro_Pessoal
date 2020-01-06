namespace Controle_Financeiro_Pessoal.View
{
    partial class frmContaExcluir
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.lblNomeConta = new System.Windows.Forms.Label();
            this.txtNomeConta = new System.Windows.Forms.TextBox();
            this.txtSaldoAtual = new System.Windows.Forms.TextBox();
            this.lblIdConta = new System.Windows.Forms.Label();
            this.cmbIdConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(258, 60);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 25);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(354, 60);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 25);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Location = new System.Drawing.Point(218, 11);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(81, 13);
            this.lblSaldoAtual.TabIndex = 2;
            this.lblSaldoAtual.Text = "SALDO ATUAL";
            // 
            // lblNomeConta
            // 
            this.lblNomeConta.AutoSize = true;
            this.lblNomeConta.Location = new System.Drawing.Point(12, 37);
            this.lblNomeConta.Name = "lblNomeConta";
            this.lblNomeConta.Size = new System.Drawing.Size(79, 13);
            this.lblNomeConta.TabIndex = 2;
            this.lblNomeConta.Text = "NOME CONTA";
            // 
            // txtNomeConta
            // 
            this.txtNomeConta.Location = new System.Drawing.Point(102, 34);
            this.txtNomeConta.Name = "txtNomeConta";
            this.txtNomeConta.Size = new System.Drawing.Size(342, 20);
            this.txtNomeConta.TabIndex = 2;
            // 
            // txtSaldoAtual
            // 
            this.txtSaldoAtual.Location = new System.Drawing.Point(320, 8);
            this.txtSaldoAtual.Name = "txtSaldoAtual";
            this.txtSaldoAtual.Size = new System.Drawing.Size(124, 20);
            this.txtSaldoAtual.TabIndex = 1;
            // 
            // lblIdConta
            // 
            this.lblIdConta.AutoSize = true;
            this.lblIdConta.Location = new System.Drawing.Point(12, 11);
            this.lblIdConta.Name = "lblIdConta";
            this.lblIdConta.Size = new System.Drawing.Size(58, 13);
            this.lblIdConta.TabIndex = 2;
            this.lblIdConta.Text = "ID CONTA";
            // 
            // cmbIdConta
            // 
            this.cmbIdConta.FormattingEnabled = true;
            this.cmbIdConta.Location = new System.Drawing.Point(102, 7);
            this.cmbIdConta.Name = "cmbIdConta";
            this.cmbIdConta.Size = new System.Drawing.Size(82, 21);
            this.cmbIdConta.TabIndex = 0;
            this.cmbIdConta.SelectedIndexChanged += new System.EventHandler(this.cmbIdConta_SelectedIndexChanged);
            // 
            // frmContaExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(456, 96);
            this.Controls.Add(this.cmbIdConta);
            this.Controls.Add(this.lblIdConta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSaldoAtual);
            this.Controls.Add(this.txtNomeConta);
            this.Controls.Add(this.lblNomeConta);
            this.Controls.Add(this.lblSaldoAtual);
            this.Controls.Add(this.btnExcluir);
            this.Name = "frmContaExcluir";
            this.Text = "EXCLUIR CONTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.Label lblNomeConta;
        private System.Windows.Forms.TextBox txtNomeConta;
        private System.Windows.Forms.TextBox txtSaldoAtual;
        private System.Windows.Forms.Label lblIdConta;
        private System.Windows.Forms.ComboBox cmbIdConta;
    }
}