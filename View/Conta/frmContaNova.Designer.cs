namespace Controle_Financeiro_Pessoal.View
{
    partial class frmContaNova
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblNomeConta = new System.Windows.Forms.Label();
            this.txtNomeConta = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.chkTransferencia = new System.Windows.Forms.CheckBox();
            this.lblDadosTransferencia = new System.Windows.Forms.Label();
            this.lblIdTransferencia = new System.Windows.Forms.Label();
            this.grpTransferencia = new System.Windows.Forms.GroupBox();
            this.cmbIdContaTransf = new System.Windows.Forms.ComboBox();
            this.txtSaldoAtualTransf = new System.Windows.Forms.TextBox();
            this.txtNomeContaTransf = new System.Windows.Forms.TextBox();
            this.lblNomeContaTransf = new System.Windows.Forms.Label();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.grpTransferencia.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(247, 31);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 25);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNomeConta
            // 
            this.lblNomeConta.AutoSize = true;
            this.lblNomeConta.Location = new System.Drawing.Point(12, 9);
            this.lblNomeConta.Name = "lblNomeConta";
            this.lblNomeConta.Size = new System.Drawing.Size(79, 13);
            this.lblNomeConta.TabIndex = 2;
            this.lblNomeConta.Text = "NOME CONTA";
            // 
            // txtNomeConta
            // 
            this.txtNomeConta.Location = new System.Drawing.Point(101, 6);
            this.txtNomeConta.Name = "txtNomeConta";
            this.txtNomeConta.Size = new System.Drawing.Size(342, 20);
            this.txtNomeConta.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(353, 31);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 25);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 37);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(83, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "SALDO INICIAL";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(101, 34);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(124, 20);
            this.txtSaldoInicial.TabIndex = 1;
            this.txtSaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDouble_KeyPress);
            // 
            // chkTransferencia
            // 
            this.chkTransferencia.AutoSize = true;
            this.chkTransferencia.Location = new System.Drawing.Point(15, 62);
            this.chkTransferencia.Name = "chkTransferencia";
            this.chkTransferencia.Size = new System.Drawing.Size(163, 17);
            this.chkTransferencia.TabIndex = 2;
            this.chkTransferencia.Text = "Transferência de outra conta";
            this.chkTransferencia.UseVisualStyleBackColor = true;
            this.chkTransferencia.Click += new System.EventHandler(this.chkTransferencia_Click);
            // 
            // lblDadosTransferencia
            // 
            this.lblDadosTransferencia.AutoSize = true;
            this.lblDadosTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosTransferencia.Location = new System.Drawing.Point(105, 9);
            this.lblDadosTransferencia.Name = "lblDadosTransferencia";
            this.lblDadosTransferencia.Size = new System.Drawing.Size(245, 13);
            this.lblDadosTransferencia.TabIndex = 2;
            this.lblDadosTransferencia.Text = "DADOS DA CONTA DE TRANSFERÊNCIA";
            // 
            // lblIdTransferencia
            // 
            this.lblIdTransferencia.AutoSize = true;
            this.lblIdTransferencia.Location = new System.Drawing.Point(7, 32);
            this.lblIdTransferencia.Name = "lblIdTransferencia";
            this.lblIdTransferencia.Size = new System.Drawing.Size(58, 13);
            this.lblIdTransferencia.TabIndex = 2;
            this.lblIdTransferencia.Text = "ID CONTA";
            // 
            // grpTransferencia
            // 
            this.grpTransferencia.Controls.Add(this.cmbIdContaTransf);
            this.grpTransferencia.Controls.Add(this.lblIdTransferencia);
            this.grpTransferencia.Controls.Add(this.lblDadosTransferencia);
            this.grpTransferencia.Controls.Add(this.txtSaldoAtualTransf);
            this.grpTransferencia.Controls.Add(this.txtNomeContaTransf);
            this.grpTransferencia.Controls.Add(this.lblNomeContaTransf);
            this.grpTransferencia.Controls.Add(this.lblSaldoAtual);
            this.grpTransferencia.Location = new System.Drawing.Point(5, 83);
            this.grpTransferencia.Name = "grpTransferencia";
            this.grpTransferencia.Size = new System.Drawing.Size(450, 84);
            this.grpTransferencia.TabIndex = 8;
            this.grpTransferencia.TabStop = false;
            // 
            // cmbIdContaTransf
            // 
            this.cmbIdContaTransf.FormattingEnabled = true;
            this.cmbIdContaTransf.Location = new System.Drawing.Point(97, 28);
            this.cmbIdContaTransf.Name = "cmbIdContaTransf";
            this.cmbIdContaTransf.Size = new System.Drawing.Size(82, 21);
            this.cmbIdContaTransf.TabIndex = 3;
            this.cmbIdContaTransf.SelectedIndexChanged += new System.EventHandler(this.cmbIdContaTransf_SelectedIndexChanged);
            // 
            // txtSaldoAtualTransf
            // 
            this.txtSaldoAtualTransf.Location = new System.Drawing.Point(315, 29);
            this.txtSaldoAtualTransf.Name = "txtSaldoAtualTransf";
            this.txtSaldoAtualTransf.Size = new System.Drawing.Size(124, 20);
            this.txtSaldoAtualTransf.TabIndex = 4;
            // 
            // txtNomeContaTransf
            // 
            this.txtNomeContaTransf.Location = new System.Drawing.Point(97, 55);
            this.txtNomeContaTransf.Name = "txtNomeContaTransf";
            this.txtNomeContaTransf.Size = new System.Drawing.Size(342, 20);
            this.txtNomeContaTransf.TabIndex = 5;
            // 
            // lblNomeContaTransf
            // 
            this.lblNomeContaTransf.AutoSize = true;
            this.lblNomeContaTransf.Location = new System.Drawing.Point(7, 58);
            this.lblNomeContaTransf.Name = "lblNomeContaTransf";
            this.lblNomeContaTransf.Size = new System.Drawing.Size(79, 13);
            this.lblNomeContaTransf.TabIndex = 2;
            this.lblNomeContaTransf.Text = "NOME CONTA";
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.Location = new System.Drawing.Point(213, 32);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(81, 13);
            this.lblSaldoAtual.TabIndex = 2;
            this.lblSaldoAtual.Text = "SALDO ATUAL";
            // 
            // frmContaNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(456, 173);
            this.Controls.Add(this.grpTransferencia);
            this.Controls.Add(this.chkTransferencia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.txtNomeConta);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNomeConta);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmContaNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOVA CONTA";
            this.grpTransferencia.ResumeLayout(false);
            this.grpTransferencia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNomeConta;
        private System.Windows.Forms.TextBox txtNomeConta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Windows.Forms.CheckBox chkTransferencia;
        private System.Windows.Forms.Label lblDadosTransferencia;
        private System.Windows.Forms.Label lblIdTransferencia;
        private System.Windows.Forms.GroupBox grpTransferencia;
        private System.Windows.Forms.TextBox txtSaldoAtualTransf;
        private System.Windows.Forms.TextBox txtNomeContaTransf;
        private System.Windows.Forms.Label lblNomeContaTransf;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.ComboBox cmbIdContaTransf;
    }
}