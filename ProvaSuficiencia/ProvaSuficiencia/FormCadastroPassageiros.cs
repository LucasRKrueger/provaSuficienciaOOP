using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProvaSuficiencia
{
    public partial class FormCadastroPassageiros : Form
    {
        //Lucas Rodrigo Krueger
        public FormCadastroPassageiros()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            txtBoxEscola.Visible = false;
            txtBoxRg.Visible = false;
            lbRg.Visible = false;
            lbEscola.Visible = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxNome.Text))
            {
                MessageBox.Show("Favor preencher o campo nome");
                txtBoxNome.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtBoxIdade.Text))
            {
                MessageBox.Show("Favor preencher o campo idade");
                txtBoxIdade.Focus();
                return;
            }

            if(!string.IsNullOrEmpty(txtBoxTelefone.Text))
            {
                if(CampoTelefoneIncorreto())
                {
                    MessageBox.Show("Favor preencher o campo telefone corretamente.");
                    txtBoxTelefone.Focus();
                    return;
                }
            }

            if(cbIdoso.Checked && string.IsNullOrEmpty(txtBoxRg.Text))
            {
                MessageBox.Show("Favor preencher o campo Rg");
                txtBoxRg.Focus();
                return;
            }

            if(cbEstudante.Checked && string.IsNullOrEmpty(txtBoxEscola.Text))
            {
                MessageBox.Show("Favor preencher o campo Escola");
                txtBoxEscola.Focus();
                return;
            }

            if (int.Parse(txtBoxIdade.Text) < 60 && cbIdoso.Checked)
            {
                MessageBox.Show("Passageiro não é um idoso");
                return;
            }

            if(cbIdoso.Checked)
            {
                Program._passageiros.Add(new Idoso(txtBoxNome.Text, txtBoxTelefone.Text, int.Parse(txtBoxIdade.Text), txtBoxRg.Text.ToString()));
            }
            else if (cbEstudante.Checked)
            {
                Program._passageiros.Add(new Estudante(txtBoxNome.Text, txtBoxTelefone.Text, int.Parse(txtBoxIdade.Text), txtBoxEscola.Text));
            }
            else
            {
                Program._passageiros.Add(new Passageiro(txtBoxNome.Text, txtBoxTelefone.Text, int.Parse(txtBoxIdade.Text)));
            }

            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void cbEstudante_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEstudante.Checked)
            {
                lbEscola.Visible = true;
                txtBoxEscola.Visible = true;
                txtBoxRg.Visible = false;
                lbRg.Visible = false;
                cbIdoso.Checked = false;
            }
            else
            {
                lbEscola.Visible = false;
                txtBoxEscola.Visible = false;
            }
        }

        private void cbIdoso_CheckedChanged(object sender, EventArgs e)
        {            
            if (cbIdoso.Checked)
            {
                lbEscola.Visible = false;
                txtBoxEscola.Visible = false;
                txtBoxRg.Visible = true;
                lbRg.Visible = true;
                cbEstudante.Checked = false;
            }
            else
            {
                txtBoxRg.Visible = false;
                lbRg.Visible = false;
            }
        }

        private bool CampoTelefoneIncorreto()
        {
            int qtdNumeros = 0;
            for (int i = 0; i < txtBoxTelefone.Text.Length; i++)
            {
                if (Char.IsDigit(txtBoxTelefone.Text[i]))
                    qtdNumeros++;
            }
            return qtdNumeros < 11;
        }
    }
}
