namespace Controle_Financeiro_Pessoal.View
{
    partial class frmClassificacoesLista
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
            this.lvwClasses = new System.Windows.Forms.ListView();
            this.column_IDClasse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_IDCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_Classe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNovaClasse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwClasses
            // 
            this.lvwClasses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_IDClasse,
            this.column_IDCategoria,
            this.column_Categoria,
            this.column_Classe});
            this.lvwClasses.HideSelection = false;
            this.lvwClasses.Location = new System.Drawing.Point(0, 0);
            this.lvwClasses.Name = "lvwClasses";
            this.lvwClasses.Size = new System.Drawing.Size(534, 314);
            this.lvwClasses.TabIndex = 0;
            this.lvwClasses.UseCompatibleStateImageBehavior = false;
            this.lvwClasses.View = System.Windows.Forms.View.Details;
            // 
            // column_IDClasse
            // 
            this.column_IDClasse.Text = "ID CLASSE";
            this.column_IDClasse.Width = 90;
            // 
            // column_IDCategoria
            // 
            this.column_IDCategoria.Text = "ID CATEGORIA";
            this.column_IDCategoria.Width = 90;
            // 
            // column_Categoria
            // 
            this.column_Categoria.Text = "CATEGORIA";
            this.column_Categoria.Width = 180;
            // 
            // column_Classe
            // 
            this.column_Classe.Text = "CLASSE";
            this.column_Classe.Width = 190;
            // 
            // btnNovaClasse
            // 
            this.btnNovaClasse.Location = new System.Drawing.Point(22, 319);
            this.btnNovaClasse.Name = "btnNovaClasse";
            this.btnNovaClasse.Size = new System.Drawing.Size(151, 22);
            this.btnNovaClasse.TabIndex = 1;
            this.btnNovaClasse.Text = "NOVA";
            this.btnNovaClasse.UseVisualStyleBackColor = true;
            this.btnNovaClasse.Click += new System.EventHandler(this.btnNovaClasse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "EDITAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "EXCLUIR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmListaClassificacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 345);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNovaClasse);
            this.Controls.Add(this.lvwClasses);
            this.Name = "frmListaClassificacoes";
            this.Text = "LISTA DE CLASSIFICAÇÕES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmListaClassificacoes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwClasses;
        private System.Windows.Forms.ColumnHeader column_IDClasse;
        private System.Windows.Forms.ColumnHeader column_IDCategoria;
        private System.Windows.Forms.ColumnHeader column_Categoria;
        private System.Windows.Forms.ColumnHeader column_Classe;
        private System.Windows.Forms.Button btnNovaClasse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}