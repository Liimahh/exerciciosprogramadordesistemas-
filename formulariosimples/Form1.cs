using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulariosimples
{
    public partial class frmFormularioSimples : Form
    {
        public frmFormularioSimples()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            //Validação de campos obrigatórios
            if (string.IsNullOrWhiteSpace(txtNumeroCadastro.Text)) 
            {
                MessageBox.Show("Por favor, preencha o número de cadastro.");
                return; //Interrompe a execuçao do código caso o campo esteja vazio
            }

            if (string.IsNullOrWhiteSpace(txtNomeCompleto.Text)) 
            {
                MessageBox.Show("Por favor, preencha o nome completo.");
                return;
            }

            // Validação da data de nascimento usando DateTimePicker
            dataNascimento = dateTimePicker1.Value.Date;

            //Verificar se a data é posterior ou igual á data atual
            if (dataNascimento >= DateTime.Now.Date) //Compara com a data atual sem hora
            {
                MessageBox.Show("Verifique novamente a sua data de nascimento.");
                return;
            }

            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a idade.");
                return;
            }

            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked)
            {
                MessageBox.Show("Por favor. selecione o genero");
                return;
            }


            //Agora, caso todos os campos esteja prenchido, a validaçaõ prossegue
            numeroCadastro = Convert.ToInt32(txtNumeroCadastro.Text);
            nomeUsuario = txtNomeCompleto.Text;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;


            //Formatar a data para exibir apenas a data (sem hora)
            string dataFormatada = dataNascimento.ToString("dd/MM/yyyy");

            //Determinar o gênero selecionado

            string generoselecionado = "Não informado"; //Caso nenhum gênero seja selecionado
            if (generoF)
                generoselecionado = "Feminino";
            else if (generoM)
                generoselecionado = "Masculino";
            else if (generoNB)
                generoselecionado = "Não Binário";

            //Exibir as informações em MessageBox
            MessageBox.Show("Número Cadastro:" + numeroCadastro);
            MessageBox.Show("Nome:" + nomeUsuario);
            MessageBox.Show("Data Nascimento:" + dataFormatada);
            MessageBox.Show("Cidade:" + cidade);
            MessageBox.Show("Genero: " + generoselecionado);



         }

        private void txtNumeroCadastro_Click(object sender, EventArgs e)
        {
            //Limpa o conteúdo do textBox quando o usuário clicar nele
           if (txtNumeroCadastro.Text == "Número Cadastro")
            {
                txtNumeroCadastro.Text = "";
            }
            
         
                
        }

        private void txtNomeCompleto_Click(object sender, EventArgs e)
        {
            //Limpa o conteúdo do TextBox quando o usuário  clicar nele
            if (txtNomeCompleto.Text == "insira o seu nome completo")
            {
                txtNomeCompleto.Text = "";
            }
        }  
    }
}
