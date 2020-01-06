namespace Controle_Financeiro_Pessoal.View
{
    partial class frmMovimentacaoLista
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
            this.btnNovoMovimento = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.column_IDMovimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Classe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwmMovimentacoes = new System.Windows.Forms.ListView();
            this.column_Conta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Fornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnNovoMovimento
            // 
            this.btnNovoMovimento.Location = new System.Drawing.Point(342, 463);
            this.btnNovoMovimento.Name = "btnNovoMovimento";
            this.btnNovoMovimento.Size = new System.Drawing.Size(151, 22);
            this.btnNovoMovimento.TabIndex = 0;
            this.btnNovoMovimento.Text = "NOVO";
            this.btnNovoMovimento.UseVisualStyleBackColor = true;
            this.btnNovoMovimento.Click += new System.EventHandler(this.btnNovoMovimento_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(511, 463);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(151, 22);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(680, 463);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(151, 22);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // column_IDMovimento
            // 
            this.column_IDMovimento.Text = "ID MOVIMENTO";
            this.column_IDMovimento.Width = 100;
            // 
            // column_Categoria
            // 
            this.column_Categoria.Text = "CATEGORIA";
            this.column_Categoria.Width = 150;
            // 
            // column_Classe
            // 
            this.column_Classe.Text = "CLASSE";
            this.column_Classe.Width = 150;
            // 
            // lvwmMovimentacoes
            // 
            this.lvwmMovimentacoes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_IDMovimento,
            this.column_Conta,
            this.column_Categoria,
            this.column_Classe,
            this.column_Valor,
            this.column_Data,
            this.column_Fornecedor,
            this.column_Descricao});
            this.lvwmMovimentacoes.HideSelection = false;
            this.lvwmMovimentacoes.Location = new System.Drawing.Point(0, 4);
            this.lvwmMovimentacoes.Name = "lvwmMovimentacoes";
            this.lvwmMovimentacoes.Size = new System.Drawing.Size(1216, 453);
            this.lvwmMovimentacoes.TabIndex = 0;
            this.lvwmMovimentacoes.UseCompatibleStateImageBehavior = false;
            this.lvwmMovimentacoes.View = System.Windows.Forms.View.Details;
            // 
            // column_Conta
            // 
            this.column_Conta.Text = "CONTA";
            this.column_Conta.Width = 150;
            // 
            // column_Valor
            // 
            this.column_Valor.Text = "VALOR";
            this.column_Valor.Width = 80;
            // 
            // column_Data
            // 
            this.column_Data.Text = "DATA";
            this.column_Data.Width = 100;
            // 
            // column_Fornecedor
            // 
            this.column_Fornecedor.Text = "FORNECEDOR";
            this.column_Fornecedor.Width = 200;
            // 
            // column_Descricao
            // 
            this.column_Descricao.Text = "DESCRIÇÃO";
            this.column_Descricao.Width = 300;
            // 
            // frmMovimentacaoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1217, 497);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovoMovimento);
            this.Controls.Add(this.lvwmMovimentacoes);
            this.Name = "frmMovimentacaoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DAS MOVIMENTAÇÕES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMovimentacaoLista_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNovoMovimento;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ColumnHeader column_IDMovimento;
        private System.Windows.Forms.ColumnHeader column_Categoria;
        private System.Windows.Forms.ColumnHeader column_Classe;
        private System.Windows.Forms.ListView lvwmMovimentacoes;
        private System.Windows.Forms.ColumnHeader column_Conta;
        private System.Windows.Forms.ColumnHeader column_Valor;
        private System.Windows.Forms.ColumnHeader column_Data;
        private System.Windows.Forms.ColumnHeader column_Fornecedor;
        private System.Windows.Forms.ColumnHeader column_Descricao;
    }
}