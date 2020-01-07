namespace Controle_Financeiro_Pessoal.View
{
    partial class frmClassificacaoExcluir
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
            this.lblNomeClasse = new System.Windows.Forms.Label();
            this.lblIDCategoria = new System.Windows.Forms.Label();
            this.txtNomeClasse = new System.Windows.Forms.TextBox();
            this.cmbIdCategoria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.lblIdClasse = new System.Windows.Forms.Label();
            this.cmbIdClasse = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(62, 95);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(138, 27);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblNomeClasse
            // 
            this.lblNomeClasse.AutoSize = true;
            this.lblNomeClasse.Location = new System.Drawing.Point(11, 43);
            this.lblNomeClasse.Name = "lblNomeClasse";
            this.lblNomeClasse.Size = new System.Drawing.Size(83, 13);
            this.lblNomeClasse.TabIndex = 2;
            this.lblNomeClasse.Text = "NOME CLASSE";
            // 
            // lblIDCategoria
            // 
            this.lblIDCategoria.AutoSize = true;
            this.lblIDCategoria.Location = new System.Drawing.Point(11, 75);
            this.lblIDCategoria.Name = "lblIDCategoria";
            this.lblIDCategoria.Size = new System.Drawing.Size(83, 13);
            this.lblIDCategoria.TabIndex = 2;
            this.lblIDCategoria.Text = "ID CATEGORIA";
            // 
            // txtNomeClasse
            // 
            this.txtNomeClasse.Location = new System.Drawing.Point(100, 40);
            this.txtNomeClasse.Name = "txtNomeClasse";
            this.txtNomeClasse.Size = new System.Drawing.Size(342, 20);
            this.txtNomeClasse.TabIndex = 1;
            // 
            // cmbIdCategoria
            // 
            this.cmbIdCategoria.FormattingEnabled = true;
            this.cmbIdCategoria.Location = new System.Drawing.Point(100, 68);
            this.cmbIdCategoria.Name = "cmbIdCategoria";
            this.cmbIdCategoria.Size = new System.Drawing.Size(82, 21);
            this.cmbIdCategoria.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 27);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(199, 73);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(274, 68);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(168, 20);
            this.txtNomeCategoria.TabIndex = 3;
            // 
            // lblIdClasse
            // 
            this.lblIdClasse.AutoSize = true;
            this.lblIdClasse.Location = new System.Drawing.Point(11, 15);
            this.lblIdClasse.Name = "lblIdClasse";
            this.lblIdClasse.Size = new System.Drawing.Size(62, 13);
            this.lblIdClasse.TabIndex = 2;
            this.lblIdClasse.Text = "ID CLASSE";
            // 
            // cmbIdClasse
            // 
            this.cmbIdClasse.FormattingEnabled = true;
            this.cmbIdClasse.Location = new System.Drawing.Point(100, 8);
            this.cmbIdClasse.Name = "cmbIdClasse";
            this.cmbIdClasse.Size = new System.Drawing.Size(82, 21);
            this.cmbIdClasse.TabIndex = 0;
            this.cmbIdClasse.SelectedIndexChanged += new System.EventHandler(this.cmbIdClasse_SelectedIndexChanged);
            // 
            // frmClassificacaoExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 134);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbIdClasse);
            this.Controls.Add(this.cmbIdCategoria);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.txtNomeClasse);
            this.Controls.Add(this.lblIdClasse);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblIDCategoria);
            this.Controls.Add(this.lblNomeClasse);
            this.Controls.Add(this.btnExcluir);
            this.Name = "frmClassificacaoExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EXCLUIR CLASSIFICAÇÃO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblNomeClasse;
        private System.Windows.Forms.Label lblIDCategoria;
        private System.Windows.Forms.TextBox txtNomeClasse;
        private System.Windows.Forms.ComboBox cmbIdCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label lblIdClasse;
        private System.Windows.Forms.ComboBox cmbIdClasse;
    }
}