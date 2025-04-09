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
    public partial class Listar : Form
    {
        DAO lis;
        public Listar()
        {
            lis = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();//Configuro a estrutura da coluna e linha
            NomeColunas();//Nomeando as colunas
            AdicionarDados();//Adicionando os dados para visualizar
        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome Professor";
            dataGridView1.Columns[2].Name = "Descrição";
            dataGridView1.Columns[3].Name = "Data Entrega";
            dataGridView1.Columns[4].Name = "Prioridade";
            dataGridView1.Columns[5].Name = "Turma";
            dataGridView1.Columns[6].Name = "Status Atividades";
        }// FIM DO NOMECOLUNAS

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Não pode adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Não pode apagar linhas
            dataGridView1.AllowUserToResizeColumns = false;//Não pode redimensionar as colunas
            dataGridView1.AllowUserToResizeRows = false;//Não pode redimensionar as linhas

            dataGridView1.ColumnCount = 7;
        }// FIM DO METODO DE CONFIGURAÇÃO

        public void AdicionarDados()
        {
            lis.PreencherVetor();//Preencher os vetores c/dados do bd
            for(int i=0; i  < lis.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(lis.codigo[i], lis.nomeprofessor[i], lis.descricao[i], lis.dataentrega[i],lis.prioridade[i],lis.turma[i], lis.statusAtividade[i]);
            }// fim do for
        }// fim do ADDDados

        private void GerenciadorDeTarefas_Click(object sender, EventArgs e)// TITULO
        {

        }// FIM DO TITULO

        private void Listar_Load(object sender, EventArgs e) // LISTAR
        {
            
        } // FIM DO LISTAR

        private void botaoSair_Click(object sender, EventArgs e)// VOLTAR
        {
            this.Close();
        }
    }// FIM DO LISTAR
}// FIM DA CLASSE 
