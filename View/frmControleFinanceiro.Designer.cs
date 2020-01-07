namespace Controle_Financeiro_Pessoal
{
    partial class frmControleFinanceiro
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiIniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiContas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInformacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIniciar,
            this.tsmiRelatorios,
            this.tsmiInformacoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiIniciar
            // 
            this.tsmiIniciar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClasses,
            this.tmsiContas,
            this.tsmiMovimentacoes});
            this.tsmiIniciar.Name = "tsmiIniciar";
            this.tsmiIniciar.Size = new System.Drawing.Size(51, 20);
            this.tsmiIniciar.Text = "Iniciar";
            // 
            // tsmiClasses
            // 
            this.tsmiClasses.Name = "tsmiClasses";
            this.tsmiClasses.Size = new System.Drawing.Size(159, 22);
            this.tsmiClasses.Text = "Classes";
            this.tsmiClasses.Click += new System.EventHandler(this.tsmiClasses_Click);
            // 
            // tmsiContas
            // 
            this.tmsiContas.Name = "tmsiContas";
            this.tmsiContas.Size = new System.Drawing.Size(159, 22);
            this.tmsiContas.Text = "Contas";
            this.tmsiContas.Click += new System.EventHandler(this.tmsiContas_Click);
            // 
            // tsmiMovimentacoes
            // 
            this.tsmiMovimentacoes.Name = "tsmiMovimentacoes";
            this.tsmiMovimentacoes.Size = new System.Drawing.Size(159, 22);
            this.tsmiMovimentacoes.Text = "Movimentações";
            this.tsmiMovimentacoes.Click += new System.EventHandler(this.tsmiMovimentacoes_Click);
            // 
            // tsmiRelatorios
            // 
            this.tsmiRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFluxoDeCaixa});
            this.tsmiRelatorios.Name = "tsmiRelatorios";
            this.tsmiRelatorios.Size = new System.Drawing.Size(71, 20);
            this.tsmiRelatorios.Text = "Relatórios";
            // 
            // tsmiFluxoDeCaixa
            // 
            this.tsmiFluxoDeCaixa.Name = "tsmiFluxoDeCaixa";
            this.tsmiFluxoDeCaixa.Size = new System.Drawing.Size(151, 22);
            this.tsmiFluxoDeCaixa.Text = "Fluxo de Caixa";
            this.tsmiFluxoDeCaixa.Click += new System.EventHandler(this.tsmiFluxoDeCaixa_Click);
            // 
            // tsmiInformacoes
            // 
            this.tsmiInformacoes.Name = "tsmiInformacoes";
            this.tsmiInformacoes.Size = new System.Drawing.Size(85, 20);
            this.tsmiInformacoes.Text = "Informações";
            this.tsmiInformacoes.Click += new System.EventHandler(this.tsmiInformacoes_Click);
            // 
            // frmControleFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 316);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmControleFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROLE FINANCEIRO PESSOAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiIniciar;
        private System.Windows.Forms.ToolStripMenuItem tsmiRelatorios;
        private System.Windows.Forms.ToolStripMenuItem tsmiFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem tsmiClasses;
        private System.Windows.Forms.ToolStripMenuItem tmsiContas;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformacoes;
    }
}

