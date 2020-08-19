namespace ProvaSuficiencia
{
    partial class FormCadastroViagens
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxHoraViagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNomeMotorista = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtBoxPlacaOnibus = new System.Windows.Forms.TextBox();
            this.btnAdicionaPassageiro = new System.Windows.Forms.Button();
            this.dtpDataViagem = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelQtdPass = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Hora da Viagem";
            // 
            // txtBoxHoraViagem
            // 
            this.txtBoxHoraViagem.Location = new System.Drawing.Point(12, 171);
            this.txtBoxHoraViagem.Name = "txtBoxHoraViagem";
            this.txtBoxHoraViagem.Size = new System.Drawing.Size(54, 20);
            this.txtBoxHoraViagem.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Data da Viagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome do Motorista";
            // 
            // txtBoxNomeMotorista
            // 
            this.txtBoxNomeMotorista.Location = new System.Drawing.Point(12, 74);
            this.txtBoxNomeMotorista.Name = "txtBoxNomeMotorista";
            this.txtBoxNomeMotorista.Size = new System.Drawing.Size(117, 20);
            this.txtBoxNomeMotorista.TabIndex = 18;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(9, 10);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(83, 13);
            this.labelNome.TabIndex = 15;
            this.labelNome.Text = "Placa do ônibus";
            // 
            // txtBoxPlacaOnibus
            // 
            this.txtBoxPlacaOnibus.Location = new System.Drawing.Point(12, 26);
            this.txtBoxPlacaOnibus.Name = "txtBoxPlacaOnibus";
            this.txtBoxPlacaOnibus.Size = new System.Drawing.Size(185, 20);
            this.txtBoxPlacaOnibus.TabIndex = 14;
            // 
            // btnAdicionaPassageiro
            // 
            this.btnAdicionaPassageiro.Location = new System.Drawing.Point(12, 402);
            this.btnAdicionaPassageiro.Name = "btnAdicionaPassageiro";
            this.btnAdicionaPassageiro.Size = new System.Drawing.Size(78, 36);
            this.btnAdicionaPassageiro.TabIndex = 26;
            this.btnAdicionaPassageiro.Text = "Adicionar Passageiro";
            this.btnAdicionaPassageiro.UseVisualStyleBackColor = true;
            this.btnAdicionaPassageiro.Click += new System.EventHandler(this.btnAdicionaPassageiro_Click);
            // 
            // dtpDataViagem
            // 
            this.dtpDataViagem.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dtpDataViagem.Location = new System.Drawing.Point(12, 126);
            this.dtpDataViagem.Name = "dtpDataViagem";
            this.dtpDataViagem.Size = new System.Drawing.Size(219, 20);
            this.dtpDataViagem.TabIndex = 27;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(195, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(276, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelQtdPass
            // 
            this.labelQtdPass.AutoSize = true;
            this.labelQtdPass.Location = new System.Drawing.Point(12, 375);
            this.labelQtdPass.Name = "labelQtdPass";
            this.labelQtdPass.Size = new System.Drawing.Size(0, 13);
            this.labelQtdPass.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(276, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Clique na tela para atualizar a quantidade de passageiros";
            // 
            // FormCadastroViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelQtdPass);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataViagem);
            this.Controls.Add(this.btnAdicionaPassageiro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxHoraViagem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNomeMotorista);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.txtBoxPlacaOnibus);
            this.Name = "FormCadastroViagens";
            this.Text = "FormCadastroViagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxHoraViagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNomeMotorista;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtBoxPlacaOnibus;
        private System.Windows.Forms.Button btnAdicionaPassageiro;
        private System.Windows.Forms.DateTimePicker dtpDataViagem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labelQtdPass;
        private System.Windows.Forms.Label label5;
    }
}