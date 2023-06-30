using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscoladeNatação
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        List<Alunos> AlunosCadastrados = new List<Alunos>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Alunos alunosCadastrados = new Alunos();

            alunosCadastrados.Nome = txtNome.Text;
            alunosCadastrados.CPF = txtCPF.Text;
            alunosCadastrados.Endereco = txtEndereco.Text;
            alunosCadastrados.Telefone = txtTelefone.Text;
            alunosCadastrados.DataNascimento = dtpDataNascimento.Value;

            AlunosCadastrados.Add(alunosCadastrados);

            MessageBox.Show("O Aluno(a): " + alunosCadastrados.Nome + " foi cadastrado!");

            lblQuantidadeAlunosCadastrados.Text = AlunosCadastrados.Count.ToString();
        }

        public void CriarAlunosMockup()
        {
            Alunos Aluno = new Alunos();
            Aluno.Nome = "Oliver";
            Aluno.Endereco = "Rua 1";
            Aluno.CPF = "000.000.000-01";
            Aluno.Telefone = "(99)99999 - 9991";
            Aluno.DataNascimento = new DateTime(1989, 09, 28);

            AlunosCadastrados.Add(Aluno);

            Aluno.Nome = "Sebastian";
            Aluno.Endereco = "Rua 2";
            Aluno.CPF = "000.000.000-02";
            Aluno.Telefone = "(99)99999 - 9992";
            Aluno.DataNascimento = new DateTime(1993, 03, 02);

            AlunosCadastrados.Add(Aluno);

            Aluno.Nome = "Emma";
            Aluno.Endereco = "Rua 3";
            Aluno.CPF = "000.000.000-03";
            Aluno.Telefone = "(99)99999 - 9993";
            Aluno.DataNascimento = new DateTime(2000, 23, 15);

            AlunosCadastrados.Add(Aluno);

            Aluno.Nome = "Tessa";
            Aluno.Endereco = "Rua 4";
            Aluno.CPF = "000.000.000-04";
            Aluno.Telefone = "(99)99999 - 9994";
            Aluno.DataNascimento = new DateTime(1999, 01, 30);

            AlunosCadastrados.Add(Aluno);

        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            CriarAlunosMockup();
            lblQuantidadeAlunosCadastrados.Text = AlunosCadastrados.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBuscaPorCPF.Text != "")
            {
                var AlunosEncontrados = AlunosCadastrados.Where(p => p.CPF == txtBuscaPorCPF.Text);

                if (AlunosEncontrados.Any())
                {
                    Alunos AlunoEncontrado = AlunosEncontrados.First();
                    CarregaDadosAlunos(AlunoEncontrado);
                }
                else
                {
                    MessageBox.Show("A busca não retornou nenhum dado.");
                }
            }
            else
            {
                MessageBox.Show("Você deve digitar o CPF para busca.");
            }


            public void CarregaDadosAlunos(Alunos Aluno)
            {
                txtNome.Text = Aluno.Nome;
                txtCPF.Text = Aluno.CPF;
                txtEndereco.Text = Aluno.Endereco;
                txtTelefone.Text = Aluno.Telefone;
                dtpDataNascimento.Value = Aluno.DataNascimento;
               
            }
        }
    }
}
