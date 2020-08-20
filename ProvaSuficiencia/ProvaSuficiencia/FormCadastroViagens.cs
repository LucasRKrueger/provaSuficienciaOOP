using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProvaSuficiencia
{
    public partial class FormCadastroViagens : Form
    {
        //Lucas Rodrigo Krueger

        public FormCadastroViagens()
        {
            InitializeComponent();
        }

        private void btnAdicionaPassageiro_Click(object sender, EventArgs e)
        {
            new FormCadastroPassageiros().Show();            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (CamposEstaoPreenchidos())
            {
                if (rbMunicipal.Checked)
                {
                    if (Program._passageiros.Count > 55)
                    {
                        while (Program._passageiros.Count > 55)
                        {
                            Program._passageiros.RemoveAt(Program._passageiros.Count - 1);
                        }
                        MessageBox.Show("Número máximo de 55 passageiros atingidos, será removido os registros acima da quantidade");
                    }

                    var viagemMunicipal = new Municipal(txtBoxPlacaOnibus.Text.ToString(), txtBoxNomeMotorista.Text,
                        dtpDataViagem.Value.Date, int.Parse(txtBoxHoraViagem.Text));

                    foreach (var passageiro in Program._passageiros)
                    {
                        viagemMunicipal.AddPassageiro(passageiro);
                    }

                    Program._viagens.Add(viagemMunicipal);
                }
                else
                {
                    if (Program._passageiros.Count > 22)
                    {
                        MessageBox.Show("Número máximo de 22 passageiros atingido, será removido os registros acima da quantidade");

                        while (Program._passageiros.Count > 22)
                        {
                            Program._passageiros.RemoveAt(Program._passageiros.Count - 1);
                        }
                    }

                    var viagemIntermunicipal = new Intermunicipal(txtBoxPlacaOnibus.Text, txtBoxNomeMotorista.Text,
                                                        dtpDataViagem.Value.Date, int.Parse(txtBoxHoraViagem.Text));

                    foreach (var passageiro in Program._passageiros)
                    {
                        viagemIntermunicipal.AddPassageiro(passageiro);
                    }

                    Program._viagens.Add(viagemIntermunicipal);
                }
                this.Hide();
            }
        }

        private bool CamposEstaoPreenchidos()
        {
            return txtBoxPlacaOnibus.Text != string.Empty &&
                   txtBoxNomeMotorista.Text != string.Empty &&
                   txtBoxHoraViagem.Text.ToString() != string.Empty;
        }

        protected override void OnLoad(EventArgs e)
        {
            labelQtdPass.Text = $"Quantidade de Passageiros nesta viagem: {Program._passageiros.Count}";
        }

        protected override void OnClick(EventArgs e)
        {
            labelQtdPass.Text = $"Quantidade de Passageiros nesta viagem: {Program._passageiros.Count}";
        }
    }
}
