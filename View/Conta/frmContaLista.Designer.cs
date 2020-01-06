namespace Controle_Financeiro_Pessoal.View
{
    partial class frmContaLista
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
            this.lvwContas = new System.Windows.Forms.ListView();
            this.column_IDConta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Conta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Saldo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNovaConta = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnTransferencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwContas
            // 
            this.lvwContas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_IDConta,
            this.column_Conta,
            this.column_Saldo});
            this.lvwContas.HideSelection = false;
            this.lvwContas.Location = new System.Drawing.Point(0, 0);
            this.lvwContas.Name = "lvwContas";
            this.lvwContas.Size = new System.Drawing.Size(384, 314);
            this.lvwContas.TabIndex = 0;
            this.lvwContas.UseCompatibleStateImageBehavior = false;
            this.lvwContas.View = System.Windows.Forms.View.Details;
            // 
            // column_IDConta
            // 
            this.column_IDConta.Text = "ID CONTA";
            this.column_IDConta.Width = 90;
            // 
            // column_Conta
            // 
            this.column_Conta.Text = "CONTA";
            this.column_Conta.Width = 190;
            // 
            // column_Saldo
            // 
            this.column_Saldo.Text = "SALDO";
            this.column_Saldo.Width = 100;
            // 
            // btnNovaConta
            // 
            this.btnNovaConta.Location = new System.Drawing.Point(4, 318);
            this.btnNovaConta.Name = "btnNovaConta";
            this.btnNovaConta.Size = new System.Drawing.Size(80, 22);
            this.btnNovaConta.TabIndex = 1;
            this.btnNovaConta.Text = "NOVA";
            this.btnNovaConta.UseVisualStyleBackColor = true;
            this.btnNovaConta.Click += new System.EventHandler(this.btnNovaConta_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(204, 318);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 22);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(290, 318);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 22);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Location = new System.Drawing.Point(90, 318);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(108, 22);
            this.btnTransferencia.TabIndex = 2;
            this.btnTransferencia.Text = "TRANSFERÊNCIA";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            this.btnTransferencia.Click += new System.EventHandler(this.btnTransferencia_Click);
            // 
            // frmContaLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 345);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnTransferencia);
            this.Controls.Add(this.btnNovaConta);
            this.Controls.Add(this.lvwContas);
            this.Name = "frmContaLista";
            this.Text = "LISTA DAS CONTAS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmContaLista_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwContas;
        private System.Windows.Forms.ColumnHeader column_IDConta;
        private System.Windows.Forms.ColumnHeader column_Conta;
        private System.Windows.Forms.Button btnNovaConta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ColumnHeader column_Saldo;
        private System.Windows.Forms.Button btnTransferencia;
    }
}