namespace Controle_Financeiro_Pessoal.View
{
    partial class frmContaEditar
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
            this.lblIdConta = new System.Windows.Forms.Label();
            this.cmbIdConta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(62, 69);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(138, 27);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblNomeConta
            // 
            this.lblNomeConta.AutoSize = true;
            this.lblNomeConta.Location = new System.Drawing.Point(11, 43);
            this.lblNomeConta.Name = "lblNomeConta";
            this.lblNomeConta.Size = new System.Drawing.Size(79, 13);
            this.lblNomeConta.TabIndex = 2;
            this.lblNomeConta.Text = "NOME CONTA";
            // 
            // txtNomeConta
            // 
            this.txtNomeConta.Location = new System.Drawing.Point(100, 40);
            this.txtNomeConta.Name = "txtNomeConta";
            this.txtNomeConta.Size = new System.Drawing.Size(342, 20);
            this.txtNomeConta.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(138, 27);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblIdConta
            // 
            this.lblIdConta.AutoSize = true;
            this.lblIdConta.Location = new System.Drawing.Point(11, 15);
            this.lblIdConta.Name = "lblIdConta";
            this.lblIdConta.Size = new System.Drawing.Size(58, 13);
            this.lblIdConta.TabIndex = 2;
            this.lblIdConta.Text = "ID CONTA";
            // 
            // cmbIdConta
            // 
            this.cmbIdConta.FormattingEnabled = true;
            this.cmbIdConta.Location = new System.Drawing.Point(100, 8);
            this.cmbIdConta.Name = "cmbIdConta";
            this.cmbIdConta.Size = new System.Drawing.Size(82, 21);
            this.cmbIdConta.TabIndex = 0;
            this.cmbIdConta.SelectedIndexChanged += new System.EventHandler(this.cmbIdConta_SelectedIndexChanged);
            // 
            // frmContaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 109);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbIdConta);
            this.Controls.Add(this.txtNomeConta);
            this.Controls.Add(this.lblIdConta);
            this.Controls.Add(this.lblNomeConta);
            this.Controls.Add(this.btnSalvar);
            this.Name = "frmContaEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EDITAR NOME DA CONTA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblNomeConta;
        private System.Windows.Forms.TextBox txtNomeConta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIdConta;
        private System.Windows.Forms.ComboBox cmbIdConta;
    }
}