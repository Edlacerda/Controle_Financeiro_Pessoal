namespace Controle_Financeiro_Pessoal.View
{
    partial class frmMovimentacaoNova
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
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblIDCategoria = new System.Windows.Forms.Label();
            this.txtNomeClasse = new System.Windows.Forms.TextBox();
            this.cmbIdCategoria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.lblIdClasse = new System.Windows.Forms.Label();
            this.cmbIdClasse = new System.Windows.Forms.ComboBox();
            this.lblIdConta = new System.Windows.Forms.Label();
            this.lblConta = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.cmbIdConta = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.lblSaldoConta = new System.Windows.Forms.Label();
            this.txtSaldoConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(172, 235);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 27);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(191, 53);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(48, 13);
            this.lblClasse.TabIndex = 2;
            this.lblClasse.Text = "CLASSE";
            // 
            // lblIDCategoria
            // 
            this.lblIDCategoria.AutoSize = true;
            this.lblIDCategoria.Location = new System.Drawing.Point(11, 19);
            this.lblIDCategoria.Name = "lblIDCategoria";
            this.lblIDCategoria.Size = new System.Drawing.Size(83, 13);
            this.lblIDCategoria.TabIndex = 2;
            this.lblIDCategoria.Text = "ID CATEGORIA";
            // 
            // txtNomeClasse
            // 
            this.txtNomeClasse.Location = new System.Drawing.Point(280, 49);
            this.txtNomeClasse.Name = "txtNomeClasse";
            this.txtNomeClasse.Size = new System.Drawing.Size(342, 20);
            this.txtNomeClasse.TabIndex = 9;
            // 
            // cmbIdCategoria
            // 
            this.cmbIdCategoria.FormattingEnabled = true;
            this.cmbIdCategoria.Location = new System.Drawing.Point(100, 12);
            this.cmbIdCategoria.Name = "cmbIdCategoria";
            this.cmbIdCategoria.Size = new System.Drawing.Size(82, 21);
            this.cmbIdCategoria.TabIndex = 0;
            this.cmbIdCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbIdCategoria_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(348, 235);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 27);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(191, 15);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(280, 12);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(342, 20);
            this.txtNomeCategoria.TabIndex = 9;
            // 
            // lblIdClasse
            // 
            this.lblIdClasse.AutoSize = true;
            this.lblIdClasse.Location = new System.Drawing.Point(11, 56);
            this.lblIdClasse.Name = "lblIdClasse";
            this.lblIdClasse.Size = new System.Drawing.Size(62, 13);
            this.lblIdClasse.TabIndex = 2;
            this.lblIdClasse.Text = "ID CLASSE";
            // 
            // cmbIdClasse
            // 
            this.cmbIdClasse.FormattingEnabled = true;
            this.cmbIdClasse.Location = new System.Drawing.Point(100, 49);
            this.cmbIdClasse.Name = "cmbIdClasse";
            this.cmbIdClasse.Size = new System.Drawing.Size(82, 21);
            this.cmbIdClasse.TabIndex = 1;
            this.cmbIdClasse.SelectedIndexChanged += new System.EventHandler(this.cmbIdClasse_SelectedIndexChanged);
            // 
            // lblIdConta
            // 
            this.lblIdConta.AutoSize = true;
            this.lblIdConta.Location = new System.Drawing.Point(11, 92);
            this.lblIdConta.Name = "lblIdConta";
            this.lblIdConta.Size = new System.Drawing.Size(58, 13);
            this.lblIdConta.TabIndex = 2;
            this.lblIdConta.Text = "ID CONTA";
            // 
            // lblConta
            // 
            this.lblConta.AutoSize = true;
            this.lblConta.Location = new System.Drawing.Point(191, 88);
            this.lblConta.Name = "lblConta";
            this.lblConta.Size = new System.Drawing.Size(44, 13);
            this.lblConta.TabIndex = 2;
            this.lblConta.Text = "CONTA";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(280, 85);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(342, 20);
            this.txtConta.TabIndex = 9;
            // 
            // cmbIdConta
            // 
            this.cmbIdConta.FormattingEnabled = true;
            this.cmbIdConta.Location = new System.Drawing.Point(100, 85);
            this.cmbIdConta.Name = "cmbIdConta";
            this.cmbIdConta.Size = new System.Drawing.Size(82, 21);
            this.cmbIdConta.TabIndex = 2;
            this.cmbIdConta.SelectedIndexChanged += new System.EventHandler(this.cmbIdConta_SelectedIndexChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(96, 121);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(139, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDouble_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(11, 127);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(43, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "VALOR";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(277, 124);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(36, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "DATA";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(11, 163);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(82, 13);
            this.lblFornecedor.TabIndex = 7;
            this.lblFornecedor.Text = "FORNECEDOR";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(100, 160);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(210, 20);
            this.txtFornecedor.TabIndex = 5;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(11, 203);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(69, 13);
            this.lblDescricao.TabIndex = 7;
            this.lblDescricao.Text = "DESCRIÇÃO";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(100, 200);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(522, 20);
            this.txtDescricao.TabIndex = 6;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(319, 120);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(82, 20);
            this.txtData.TabIndex = 4;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // lblSaldoConta
            // 
            this.lblSaldoConta.AutoSize = true;
            this.lblSaldoConta.Location = new System.Drawing.Point(423, 124);
            this.lblSaldoConta.Name = "lblSaldoConta";
            this.lblSaldoConta.Size = new System.Drawing.Size(83, 13);
            this.lblSaldoConta.TabIndex = 2;
            this.lblSaldoConta.Text = "SALDO CONTA";
            // 
            // txtSaldoConta
            // 
            this.txtSaldoConta.Location = new System.Drawing.Point(512, 120);
            this.txtSaldoConta.Name = "txtSaldoConta";
            this.txtSaldoConta.Size = new System.Drawing.Size(110, 20);
            this.txtSaldoConta.TabIndex = 9;
            // 
            // frmMovimentacaoNova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 275);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbIdClasse);
            this.Controls.Add(this.cmbIdConta);
            this.Controls.Add(this.cmbIdCategoria);
            this.Controls.Add(this.txtSaldoConta);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.txtNomeClasse);
            this.Controls.Add(this.lblSaldoConta);
            this.Controls.Add(this.lblIdClasse);
            this.Controls.Add(this.lblConta);
            this.Controls.Add(this.lblIdConta);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblIDCategoria);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmMovimentacaoNova";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOVA MOVIMENTAÇÃO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblIDCategoria;
        private System.Windows.Forms.TextBox txtNomeClasse;
        private System.Windows.Forms.ComboBox cmbIdCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label lblIdClasse;
        private System.Windows.Forms.ComboBox cmbIdClasse;
        private System.Windows.Forms.Label lblIdConta;
        private System.Windows.Forms.Label lblConta;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.ComboBox cmbIdConta;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label lblSaldoConta;
        private System.Windows.Forms.TextBox txtSaldoConta;
    }
}