using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGerenciador
{
    public partial class Adicionar : Form
    {

        public Adicionar()
        {
            InitializeComponent();
              
        }

        private void NomeProfessor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // NOME PROFESSOR
        {

        }// FIM DO METODO

        private void NomedoProfessor_Click(object sender, EventArgs e)// NOME DO PROFESSOR ESCRITA
        {

        }// FIM DO METODO

        private void Descricao_Click(object sender, EventArgs e)// DESCRIÇÃO
        {

        }// FIM DO METODO

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)// DATA DE ENTREGA
        {

        }

        private void DataEntrega_Click(object sender, EventArgs e)// TITULO DATA 
        {

        }

        private void Escolha_SelectedIndexChanged(object sender, EventArgs e)// ESCOLHA PRIORIDADE
        {

        }

        private void Prioridade_Click(object sender, EventArgs e)// ESCOLHA PRIORIDADE
        {

        }
        private void enviarAtividade_Click(object sender, EventArgs e)// ENVIAR ATIVIADE
        {
            //Instanciando a classe DAO
            DAO inserir = new DAO();
            //Coletando os dados dos campos
            int codigo = Convert.ToInt32(CodAtividade.Text);
            string nomeProfessor = NomeProfessor.Text;
            string descricao = maskedTextBox1.Text;
            string dataentrega = dateTimePicker1.Text;
            string prioridade = Escolha.Text;
            string turma = comboBox1.Text;
            string statusAtividade = comboBox2.Text;
            // CHAMANDO O METODO INSERIR6
            MessageBox.Show(inserir.Inserir(codigo, nomeProfessor, descricao, dataentrega, prioridade, turma, statusAtividade));




        }// FIM DO METODO

        public MySqlConnection conexao;
        public int[] codigo;
        public string[] nomeprofessor;
        public string[] descricao;
        public string[] dataentrega;
        public string[] prioridade;
        public string[] turma;
        public string[] statusAtividade;
        public int i;
        public int contador;
        

        private void CodAtividade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // TEXTO CODIGO ATIVIDADE
        {

        }// FIM DO METODO

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// SELECIONAR A TURMA
        {


        }// FIM DO METODO

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Status_Click(object sender, EventArgs e)// STATUS
        {

        }// FIM DO STATUS

        private void Adicionar_Load(object sender, EventArgs e)// PAGINA 
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// DESCRIÇÃO

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }// FIM DA CLASSE
}//FIM DO PROJETO
