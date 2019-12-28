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
            this.fluxoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMFluxoDeCaixaAnual = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.edToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoPorContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesPorPeríodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fluxoDeCaixaToolStripMenuItem,
            this.contasToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fluxoDeCaixaToolStripMenuItem
            // 
            this.fluxoDeCaixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMFluxoDeCaixaAnual});
            this.fluxoDeCaixaToolStripMenuItem.Name = "fluxoDeCaixaToolStripMenuItem";
            this.fluxoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.fluxoDeCaixaToolStripMenuItem.Text = "Fluxo de Caixa";
            // 
            // TSMFluxoDeCaixaAnual
            // 
            this.TSMFluxoDeCaixaAnual.Name = "TSMFluxoDeCaixaAnual";
            this.TSMFluxoDeCaixaAnual.Size = new System.Drawing.Size(155, 22);
            this.TSMFluxoDeCaixaAnual.Text = "Visualizar anual";
            this.TSMFluxoDeCaixaAnual.Click += new System.EventHandler(this.TSMFluxoDeCaixaAnual_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaToolStripMenuItem1,
            this.edToolStripMenuItem,
            this.deletarToolStripMenuItem2,
            this.saldoPorContaToolStripMenuItem});
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.contasToolStripMenuItem.Text = "Contas";
            // 
            // novaToolStripMenuItem1
            // 
            this.novaToolStripMenuItem1.Name = "novaToolStripMenuItem1";
            this.novaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.novaToolStripMenuItem1.Text = "Nova";
            this.novaToolStripMenuItem1.Click += new System.EventHandler(this.TSMNovaConta_Click);
            // 
            // edToolStripMenuItem
            // 
            this.edToolStripMenuItem.Name = "edToolStripMenuItem";
            this.edToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edToolStripMenuItem.Text = "Editar";
            // 
            // deletarToolStripMenuItem2
            // 
            this.deletarToolStripMenuItem2.Name = "deletarToolStripMenuItem2";
            this.deletarToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.deletarToolStripMenuItem2.Text = "Deletar";
            // 
            // saldoPorContaToolStripMenuItem
            // 
            this.saldoPorContaToolStripMenuItem.Name = "saldoPorContaToolStripMenuItem";
            this.saldoPorContaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saldoPorContaToolStripMenuItem.Text = "Saldo por conta";
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.classiToolStripMenuItem,
            this.editarToolStripMenuItem3,
            this.deletarToolStripMenuItem1,
            this.movimentaçõesPorPeríodoToolStripMenuItem,
            this.movimentaçõesPorToolStripMenuItem});
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.editarToolStripMenuItem1.Text = "Movimentação";
            // 
            // classiToolStripMenuItem
            // 
            this.classiToolStripMenuItem.Name = "classiToolStripMenuItem";
            this.classiToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.classiToolStripMenuItem.Text = "Nova";
            this.classiToolStripMenuItem.Click += new System.EventHandler(this.TSMNovaMovimentacao_Click);
            // 
            // editarToolStripMenuItem3
            // 
            this.editarToolStripMenuItem3.Name = "editarToolStripMenuItem3";
            this.editarToolStripMenuItem3.Size = new System.Drawing.Size(304, 22);
            this.editarToolStripMenuItem3.Text = "Editar";
            // 
            // deletarToolStripMenuItem1
            // 
            this.deletarToolStripMenuItem1.Name = "deletarToolStripMenuItem1";
            this.deletarToolStripMenuItem1.Size = new System.Drawing.Size(304, 22);
            this.deletarToolStripMenuItem1.Text = "Deletar";
            // 
            // movimentaçõesPorPeríodoToolStripMenuItem
            // 
            this.movimentaçõesPorPeríodoToolStripMenuItem.Name = "movimentaçõesPorPeríodoToolStripMenuItem";
            this.movimentaçõesPorPeríodoToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.movimentaçõesPorPeríodoToolStripMenuItem.Text = "Movimentações por período";
            // 
            // movimentaçõesPorToolStripMenuItem
            // 
            this.movimentaçõesPorToolStripMenuItem.Name = "movimentaçõesPorToolStripMenuItem";
            this.movimentaçõesPorToolStripMenuItem.Size = new System.Drawing.Size(304, 22);
            this.movimentaçõesPorToolStripMenuItem.Text = "Movimentações por classificação financeira";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem,
            this.novaToolStripMenuItem,
            this.editarToolStripMenuItem2,
            this.deletarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.editarToolStripMenuItem.Text = "Classificação Financeira";
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.listaToolStripMenuItem.Text = "Lista";
            // 
            // novaToolStripMenuItem
            // 
            this.novaToolStripMenuItem.Name = "novaToolStripMenuItem";
            this.novaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaToolStripMenuItem.Text = "Nova";
            this.novaToolStripMenuItem.Click += new System.EventHandler(this.TSMNovaClassificacao_Click);
            // 
            // editarToolStripMenuItem2
            // 
            this.editarToolStripMenuItem2.Name = "editarToolStripMenuItem2";
            this.editarToolStripMenuItem2.Size = new System.Drawing.Size(111, 22);
            this.editarToolStripMenuItem2.Text = "Editar";
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.deletarToolStripMenuItem.Text = "Deletar";
            // 
            // frmControleFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 316);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmControleFinanceiro";
            this.Text = "CONTROLE FINANCEIRO PESSOAL";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem classiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fluxoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMFluxoDeCaixaAnual;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem edToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saldoPorContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesPorPeríodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
    }
}

