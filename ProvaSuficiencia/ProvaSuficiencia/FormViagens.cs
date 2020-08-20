using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProvaSuficiencia
{
    public partial class FormViagens : Form
    {
        //Lucas Rodrigo Krueger
        public FormViagens(Viagem viagem = null)
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            new FormCadastroViagens().Show();
        }

        private void SetDataGridView()
        {
            dgvPassageiros.Rows.Clear();
            dgvPassageiros.Columns.Clear();

            dgvPassageiros.ColumnCount = 3;
            dgvPassageiros.ColumnHeadersVisible = true;

            dgvPassageiros.Columns[0].Name = "Passageiro";
            dgvPassageiros.Columns[1].Name = "Idade";
            dgvPassageiros.Columns[2].Name = "Motorista";

            if (Program._viagens.Count > 0)
            {
                var empresa = new Empresa();

                empresa.Viagens = Program._viagens;
                for (int i = 0; i < dgvPassageiros.Rows.Count; i++)
                {
                    if (CellIsNull(i) && i == 0)
                        AddRow(empresa);                    
                    else if (!IsRowDuplicated(empresa.Viagens.First(), i))
                        AddRow(empresa);
                }
            }
        }

        private void AddRow(Empresa empresa)
        {
            foreach (var passageiro in empresa.GetPassageirosMaisVelhos())
            {
                dgvPassageiros.Rows.Add(passageiro.GetNome(), passageiro.GetIdade().ToString(), empresa.Viagens.First().GetNomeMotorista());
            }
        }

        private bool IsRowDuplicated(Viagem viagem, int index)
        {
            foreach (var passageiro in viagem.passageiros)
            {
                if (CellIsNull(index) || dgvPassageiros.Rows[index].Cells[0].Value.ToString() == passageiro.GetNome() &&
                                        dgvPassageiros.Rows[index].Cells[1].Value.ToString() == passageiro.GetIdade().ToString() &&
                                        dgvPassageiros.Rows[index].Cells[2].Value.ToString() == viagem.GetNomeMotorista())
                {
                    return true;
                }
            }
            return false;
        }

        private bool CellIsNull(int index)
        {
            return dgvPassageiros.Rows[index].Cells[0].Value is null ||
                   dgvPassageiros.Rows[index].Cells[1].Value is null ||
                   dgvPassageiros.Rows[index].Cells[2].Value is null;
        }

        protected override void OnLoad(EventArgs e)
        {
            SetDataGridView();
        }

        protected override void OnClick(EventArgs e)
        {
            SetDataGridView();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbHoraViagem.Text) && !string.IsNullOrEmpty(tbPlacaOnibus.Text) && dtpDataViagem.Value != dtpDataViagem.MinDate)
            {
                dgvPassageiros.Rows.Clear();
                dgvPassageiros.Columns.Clear();

                dgvPassageiros.ColumnCount = 3;
                dgvPassageiros.ColumnHeadersVisible = true;

                dgvPassageiros.Columns[0].Name = "Valor Total Viagem";
                dgvPassageiros.Columns[1].Name = "Passageiros";
                dgvPassageiros.Columns[2].Name = "Ociosidade de Passageiros";

                if (!string.IsNullOrEmpty(tbHoraViagem.Text))
                {
                    foreach (var viagem in Program._viagens.Where(v => (v.GetHoraViagem() == int.Parse(tbHoraViagem.Text)) && (v.GetPlacaOnibus() == tbPlacaOnibus.Text) && (dtpDataViagem.Value == v.GetDataViagem())))                                                           
                    {
                        dgvPassageiros.Rows.Add($"R$ {viagem.GetValorTotal()}", viagem.GetPassageiros().Count, viagem.LimitePassageiro - viagem.GetPassageiros().Count);
                    }
                }
            }
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            if (Program._viagens.Count > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (var viagem in Program._viagens)
                {
                    var tipoViagem = viagem.GetType().Name;

                    stringBuilder.AppendLine($"{tipoViagem}, {viagem.GetDataViagem()}, {viagem.GetPlacaOnibus()}, {viagem.GetNomeMotorista()}");

                    foreach (var passageiro in viagem.passageiros)
                    {
                        var tipoPessoa = passageiro.GetType().Name;

                        char tipoPessoaChar = tipoPessoa.ToString().First();

                        if (tipoPessoaChar == 'P')
                            stringBuilder.AppendLine($"{passageiro.GerarCSV()}");
                        else if (tipoPessoaChar == 'E')
                            stringBuilder.AppendLine($"{passageiro.GerarCSV()}");
                        else
                            stringBuilder.AppendLine($"{passageiro.GerarCSV()}");
                    }
                }
                string path = "teste.csv";

                File.AppendAllText(path, stringBuilder.ToString());

                MessageBox.Show("CSV Gerado com sucesso!");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Program._viagens.Count > 0)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                FileStream fileStream = new FileStream("registro.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                try
                {
                    using (fileStream)
                    {
                        binaryFormatter.Serialize(fileStream, Program._viagens);
                        MessageBox.Show("Arquivo salvo com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
