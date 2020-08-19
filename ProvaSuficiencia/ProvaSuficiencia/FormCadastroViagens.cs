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
            var viagem = new Viagem(txtBoxPlacaOnibus.Text, txtBoxNomeMotorista.Text,
                                    dtpDataViagem.Value.Date, int.Parse(txtBoxHoraViagem.Text));

            foreach (var passageiro in Program.passageiros)
                viagem.AddPassageiro(passageiro);

            Program.viagens.Add(viagem);

            this.Hide();
        }

        protected override void OnLoad(EventArgs e)
        {
            labelQtdPass.Text = $"Quantidade de Passageiros nesta viagem: {Program.passageiros.Count}";
        }

        protected override void OnClick(EventArgs e)
        {
            labelQtdPass.Text = $"Quantidade de Passageiros nesta viagem: {Program.passageiros.Count}";
        }
    }
}
