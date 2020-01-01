namespace Controle_Financeiro_Pessoal.View
{
    partial class frmClassificacaoNova
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
            this.lblNomeClasse = new System.Windows.Forms.Label();
            this.lblIDCategoria = new System.Windows.Forms.Label();
            this.txtNomeClasse = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(63, 61);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 27);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNomeClasse
            // 
            this.lblNomeClasse.AutoSize = true;
            this.lblNomeClasse.Location = new System.Drawing.Point(12, 9);
            this.lblNomeClasse.Name = "lblNomeClasse";
            this.lblNomeClasse.Size = new System.Drawing.Size(83, 13);
            this.lblNomeClasse.TabIndex = 2;
            this.lblNomeClasse.Text = "NOME CLASSE";
            // 
            // lblIDCategoria
            // 
            this.lblIDCategoria.AutoSize = true;
            this.lblIDCategoria.Location = new System.Drawing.Point(12, 41);
            this.lblIDCategoria.Name = "lblIDCategoria";
            this.lblIDCategoria.Size = new System.Drawing.Size(83, 13);
            this.lblIDCategoria.TabIndex = 2;
            this.lblIDCategoria.Text = "ID CATEGORIA";
            // 
            // txtNomeClasse
            // 
            this.txtNomeClasse.Location = new System.Drawing.Point(101, 6);
            this.txtNomeClasse.Name = "txtNomeClasse";
            this.txtNomeClasse.Size = new System.Drawing.Size(342, 20);
            this.txtNomeClasse.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(101, 34);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(82, 21);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(234, 61);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 27);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CATEGORIA";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(275, 34);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(168, 20);
            this.txtNomeCategoria.TabIndex = 4;
            // 
            // frmNovaClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 98);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.txtNomeClasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIDCategoria);
            this.Controls.Add(this.lblNomeClasse);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmNovaClassificacao";
            this.Text = "NOVA CLASSIFICAÇÃO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNomeClasse;
        private System.Windows.Forms.Label lblIDCategoria;
        private System.Windows.Forms.TextBox txtNomeClasse;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCategoria;
    }
}