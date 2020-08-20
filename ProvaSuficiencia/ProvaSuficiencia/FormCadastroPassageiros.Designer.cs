namespace ProvaSuficiencia
{
    partial class FormCadastroPassageiros
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxIdade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRg = new System.Windows.Forms.Label();
            this.txtBoxRg = new System.Windows.Forms.TextBox();
            this.lbEscola = new System.Windows.Forms.Label();
            this.txtBoxEscola = new System.Windows.Forms.TextBox();
            this.cbIdoso = new System.Windows.Forms.CheckBox();
            this.cbEstudante = new System.Windows.Forms.CheckBox();
            this.txtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(240, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(159, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(15, 29);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(185, 20);
            this.txtBoxNome.TabIndex = 2;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(12, 13);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 3;
            this.labelNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Idade";
            // 
            // txtBoxIdade
            // 
            this.txtBoxIdade.Location = new System.Drawing.Point(264, 29);
            this.txtBoxIdade.Name = "txtBoxIdade";
            this.txtBoxIdade.Size = new System.Drawing.Size(35, 20);
            this.txtBoxIdade.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Telefone";
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Location = new System.Drawing.Point(12, 108);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(21, 13);
            this.lbRg.TabIndex = 11;
            this.lbRg.Text = "Rg";
            // 
            // txtBoxRg
            // 
            this.txtBoxRg.Location = new System.Drawing.Point(15, 124);
            this.txtBoxRg.Name = "txtBoxRg";
            this.txtBoxRg.Size = new System.Drawing.Size(117, 20);
            this.txtBoxRg.TabIndex = 10;
            // 
            // lbEscola
            // 
            this.lbEscola.AutoSize = true;
            this.lbEscola.Location = new System.Drawing.Point(12, 108);
            this.lbEscola.Name = "lbEscola";
            this.lbEscola.Size = new System.Drawing.Size(39, 13);
            this.lbEscola.TabIndex = 13;
            this.lbEscola.Text = "Escola";
            // 
            // txtBoxEscola
            // 
            this.txtBoxEscola.Location = new System.Drawing.Point(15, 124);
            this.txtBoxEscola.Name = "txtBoxEscola";
            this.txtBoxEscola.Size = new System.Drawing.Size(117, 20);
            this.txtBoxEscola.TabIndex = 12;
            // 
            // cbIdoso
            // 
            this.cbIdoso.AutoSize = true;
            this.cbIdoso.Location = new System.Drawing.Point(159, 77);
            this.cbIdoso.Name = "cbIdoso";
            this.cbIdoso.Size = new System.Drawing.Size(52, 17);
            this.cbIdoso.TabIndex = 14;
            this.cbIdoso.Text = "Idoso";
            this.cbIdoso.UseVisualStyleBackColor = true;
            this.cbIdoso.CheckedChanged += new System.EventHandler(this.cbIdoso_CheckedChanged);
            // 
            // cbEstudante
            // 
            this.cbEstudante.AutoSize = true;
            this.cbEstudante.Location = new System.Drawing.Point(227, 77);
            this.cbEstudante.Name = "cbEstudante";
            this.cbEstudante.Size = new System.Drawing.Size(74, 17);
            this.cbEstudante.TabIndex = 15;
            this.cbEstudante.Text = "Estudante";
            this.cbEstudante.UseVisualStyleBackColor = true;
            this.cbEstudante.CheckedChanged += new System.EventHandler(this.cbEstudante_CheckedChanged);
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Location = new System.Drawing.Point(12, 77);
            this.txtBoxTelefone.Mask = "(99)9 9999-9999";
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(87, 20);
            this.txtBoxTelefone.TabIndex = 16;
            // 
            // FormCadastroPassageiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.txtBoxTelefone);
            this.Controls.Add(this.cbEstudante);
            this.Controls.Add(this.cbIdoso);
            this.Controls.Add(this.lbEscola);
            this.Controls.Add(this.txtBoxEscola);
            this.Controls.Add(this.lbRg);
            this.Controls.Add(this.txtBoxRg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxIdade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FormCadastroPassageiros";
            this.Text = "FormCadastroPassageiros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxIdade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.TextBox txtBoxRg;
        private System.Windows.Forms.Label lbEscola;
        private System.Windows.Forms.TextBox txtBoxEscola;
        private System.Windows.Forms.CheckBox cbIdoso;
        private System.Windows.Forms.CheckBox cbEstudante;
        private System.Windows.Forms.MaskedTextBox txtBoxTelefone;
    }
}