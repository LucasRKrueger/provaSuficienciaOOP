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
    public partial class FormCadastroPassageiros : Form
    {

        public FormCadastroPassageiros()
        {
            InitializeComponent();
        }

        private void FormCadastroPassageiros_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Program.passageiros.Add(new Passageiro(txtBoxNome.Text, txtBoxTelefone.Text, int.Parse(txtBoxIdade.Text)));
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
