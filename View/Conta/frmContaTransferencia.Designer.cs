namespace Controle_Financeiro_Pessoal.View
{
    partial class frmContaTransferencia
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
            this.btnTransferir = new System.Windows.Forms.Button();
            this.lblIDContaATransferir = new System.Windows.Forms.Label();
            this.cmbIDContaATransferir = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblContaATransferir = new System.Windows.Forms.Label();
            this.txtContaATransferir = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblSaldoContaATransferir = new System.Windows.Forms.Label();
            this.txtSaldoContaATransferir = new System.Windows.Forms.TextBox();
            this.txtSaldoContaTransfencia = new System.Windows.Forms.TextBox();
            this.lblSaldoContaTransfencia = new System.Windows.Forms.Label();
            this.cmbIDContaTransfencia = new System.Windows.Forms.ComboBox();
            this.txtContaTransfencia = new System.Windows.Forms.TextBox();
            this.lblContaTransferencia = new System.Windows.Forms.Label();
            this.lblIDContaTransfencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(53, 201);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(160, 27);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "TRANSFERIR";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // lblIDContaATransferir
            // 
            this.lblIDContaATransferir.AutoSize = true;
            this.lblIDContaATransferir.Location = new System.Drawing.Point(11, 20);
            this.lblIDContaATransferir.Name = "lblIDContaATransferir";
            this.lblIDContaATransferir.Size = new System.Drawing.Size(148, 13);
            this.lblIDContaATransferir.TabIndex = 2;
            this.lblIDContaATransferir.Text = "ID CONTRA A TRANSFERIR";
            // 
            // cmbIDContaATransferir
            // 
            this.cmbIDContaATransferir.FormattingEnabled = true;
            this.cmbIDContaATransferir.Location = new System.Drawing.Point(189, 13);
            this.cmbIDContaATransferir.Name = "cmbIDContaATransferir";
            this.cmbIDContaATransferir.Size = new System.Drawing.Size(82, 21);
            this.cmbIDContaATransferir.TabIndex = 0;
            this.cmbIDContaATransferir.SelectedIndexChanged += new System.EventHandler(this.cmbIDContaATransferir_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(257, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(160, 27);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblContaATransferir
            // 
            this.lblContaATransferir.AutoSize = true;
            this.lblContaATransferir.Location = new System.Drawing.Point(11, 51);
            this.lblContaATransferir.Name = "lblContaATransferir";
            this.lblContaATransferir.Size = new System.Drawing.Size(97, 13);
            this.lblContaATransferir.TabIndex = 2;
            this.lblContaATransferir.Text = "NOME DA CONTA";
            // 
            // txtContaATransferir
            // 
            this.txtContaATransferir.Location = new System.Drawing.Point(189, 48);
            this.txtContaATransferir.Name = "txtContaATransferir";
            this.txtContaATransferir.Size = new System.Drawing.Size(277, 20);
            this.txtContaATransferir.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(189, 165);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(139, 20);
            this.txtValor.TabIndex = 2;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(14, 168);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "VALOR";
            // 
            // lblSaldoContaATransferir
            // 
            this.lblSaldoContaATransferir.AutoSize = true;
            this.lblSaldoContaATransferir.Location = new System.Drawing.Point(278, 16);
            this.lblSaldoContaATransferir.Name = "lblSaldoContaATransferir";
            this.lblSaldoContaATransferir.Size = new System.Drawing.Size(43, 13);
            this.lblSaldoContaATransferir.TabIndex = 7;
            this.lblSaldoContaATransferir.Text = "SALDO";
            // 
            // txtSaldoContaATransferir
            // 
            this.txtSaldoContaATransferir.Location = new System.Drawing.Point(327, 13);
            this.txtSaldoContaATransferir.Name = "txtSaldoContaATransferir";
            this.txtSaldoContaATransferir.Size = new System.Drawing.Size(139, 20);
            this.txtSaldoContaATransferir.TabIndex = 5;
            // 
            // txtSaldoContaTransfencia
            // 
            this.txtSaldoContaTransfencia.Location = new System.Drawing.Point(327, 91);
            this.txtSaldoContaTransfencia.Name = "txtSaldoContaTransfencia";
            this.txtSaldoContaTransfencia.Size = new System.Drawing.Size(139, 20);
            this.txtSaldoContaTransfencia.TabIndex = 5;
            // 
            // lblSaldoContaTransfencia
            // 
            this.lblSaldoContaTransfencia.AutoSize = true;
            this.lblSaldoContaTransfencia.Location = new System.Drawing.Point(278, 94);
            this.lblSaldoContaTransfencia.Name = "lblSaldoContaTransfencia";
            this.lblSaldoContaTransfencia.Size = new System.Drawing.Size(43, 13);
            this.lblSaldoContaTransfencia.TabIndex = 14;
            this.lblSaldoContaTransfencia.Text = "SALDO";
            // 
            // cmbIDContaTransfencia
            // 
            this.cmbIDContaTransfencia.FormattingEnabled = true;
            this.cmbIDContaTransfencia.Location = new System.Drawing.Point(189, 91);
            this.cmbIDContaTransfencia.Name = "cmbIDContaTransfencia";
            this.cmbIDContaTransfencia.Size = new System.Drawing.Size(82, 21);
            this.cmbIDContaTransfencia.TabIndex = 1;
            this.cmbIDContaTransfencia.SelectedIndexChanged += new System.EventHandler(this.cmbIDContaTransfencia_SelectedIndexChanged);
            // 
            // txtContaTransfencia
            // 
            this.txtContaTransfencia.Location = new System.Drawing.Point(189, 126);
            this.txtContaTransfencia.Name = "txtContaTransfencia";
            this.txtContaTransfencia.Size = new System.Drawing.Size(277, 20);
            this.txtContaTransfencia.TabIndex = 5;
            // 
            // lblContaTransferencia
            // 
            this.lblContaTransferencia.AutoSize = true;
            this.lblContaTransferencia.Location = new System.Drawing.Point(11, 129);
            this.lblContaTransferencia.Name = "lblContaTransferencia";
            this.lblContaTransferencia.Size = new System.Drawing.Size(97, 13);
            this.lblContaTransferencia.TabIndex = 11;
            this.lblContaTransferencia.Text = "NOME DA CONTA";
            // 
            // lblIDContaTransfencia
            // 
            this.lblIDContaTransfencia.AutoSize = true;
            this.lblIDContaTransfencia.Location = new System.Drawing.Point(11, 98);
            this.lblIDContaTransfencia.Name = "lblIDContaTransfencia";
            this.lblIDContaTransfencia.Size = new System.Drawing.Size(177, 13);
            this.lblIDContaTransfencia.TabIndex = 12;
            this.lblIDContaTransfencia.Text = "ID CONTRA DE TRANSFERENCIA";
            // 
            // frmMovimentacaoTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 243);
            this.Controls.Add(this.txtSaldoContaTransfencia);
            this.Controls.Add(this.lblSaldoContaTransfencia);
            this.Controls.Add(this.cmbIDContaTransfencia);
            this.Controls.Add(this.txtContaTransfencia);
            this.Controls.Add(this.lblContaTransferencia);
            this.Controls.Add(this.lblIDContaTransfencia);
            this.Controls.Add(this.txtSaldoContaATransferir);
            this.Controls.Add(this.lblSaldoContaATransferir);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbIDContaATransferir);
            this.Controls.Add(this.txtContaATransferir);
            this.Controls.Add(this.lblContaATransferir);
            this.Controls.Add(this.lblIDContaATransferir);
            this.Controls.Add(this.btnTransferir);
            this.Name = "frmMovimentacaoTransferencia";
            this.Text = "TRANSFERÊNCIA ENTRE CONTAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Label lblIDContaATransferir;
        private System.Windows.Forms.ComboBox cmbIDContaATransferir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblContaATransferir;
        private System.Windows.Forms.TextBox txtContaATransferir;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblSaldoContaATransferir;
        private System.Windows.Forms.TextBox txtSaldoContaATransferir;
        private System.Windows.Forms.TextBox txtSaldoContaTransfencia;
        private System.Windows.Forms.Label lblSaldoContaTransfencia;
        private System.Windows.Forms.ComboBox cmbIDContaTransfencia;
        private System.Windows.Forms.TextBox txtContaTransfencia;
        private System.Windows.Forms.Label lblContaTransferencia;
        private System.Windows.Forms.Label lblIDContaTransfencia;
    }
}