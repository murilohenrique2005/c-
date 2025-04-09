using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjetoGerenciador
{
    class DAO
    {
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

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;Database=ProjetoGerenciador;Uid=root;password=");
            try
            {
                conexao.Open();//Tentando conectar com o banco
                MessageBox.Show("Conectado");

            }
            catch (Exception erro)

            {
                MessageBox.Show("Algo deu errado\n\n\n" + erro);
            }
        }//fim do construtor

        public string Inserir(int codigo, string nomeprofessor, string descricao, string dataentrega , string priodidade, string turma, string statusAtividade)
        {
            string inserir = $"Insert atividades(codigo, nomeprofessor, descricao, dataentrega, prioridade, turma, statusAtividade) values('{codigo}','{nomeprofessor}','{descricao}', '{dataentrega}','{priodidade}','{turma}','{statusAtividade}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";
            return resultado;
        }// FIM DO METODO INSERIR

        public void PreencherVetor()
        {
            string query = "select * from atividades";

            // INSTANCIAR OS VETORES

            this.codigo = new int[100];
            this.nomeprofessor = new string[100];
            this.descricao = new string[100];
            this.dataentrega = new string[100];
            this.prioridade = new string[100];
            this.turma = new string[100];
            this.statusAtividade = new string[100];

            //prepara o comando para o banco
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //Chamar o leitor do banco de dados
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0; // INSTANCIAR O CONTADOR
            contador = 0;
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                nomeprofessor[i] = leitura["nomeprofessor"] + "";
                descricao[i] = leitura["descricao"] + "";
                dataentrega[i] = leitura["dataentrega"] + "";
                prioridade[i] = leitura["prioridade"] + "";
                turma[i] = leitura["turma"] + "";
                statusAtividade[i] = leitura["statusAtividade"] + "";
                i++;//Contador De Giro
                contador++;
            }//FIM DO WHILE

            //Encerrar o Processo de Leitura
            leitura.Close();
        }// FIM DO METODO

        public int ConsultarPorCodigo(int cod)
        {
            PreencherVetor(); //Preenchendo o vetor com os dados do banco

            i = 0;// Instanciando o contador
            while(i < QuantidadeDeDados())
            {
                if (codigo[i] == cod)
                {
                    return i;
                }
                i++;//Contador Gire
            }// FIM DO WHILE

            return -1;
        }// FIM DO METODO

        public string RetornarNome(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
                if (posicao > -1)
            {
                return nomeprofessor[posicao];
            }
            return "Digite um código valido";
        }// FIM DO METODO NOME

        public string RetornarDescricao(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return descricao[posicao];
            }
            return "Digite um código valido";
        }// FIM DO DESCRIÇÃO

        public string RetornarData(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return dataentrega[posicao];
            }
            return "Digite um código valido";
        }// FIM DO DATA

        public string RetornarPrioridade(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return prioridade[posicao];
            }
            return "Digite um código valido";
        }// FIM DO RETORNAR PRIORIDADE

        public string RetornarTurma(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return turma[posicao];
            }
            return "Digite um código valido";
        }

        public string RetornarStatus(int cod)
        {
            int posicao = ConsultarPorCodigo(cod);
            if (posicao > -1)
            {
                return statusAtividade[posicao];
            }
            return "Digite um código valido";
        }// FIM DO RETORNARSTATUS

        public int QuantidadeDeDados()
        {
            return contador;
        }// FIM DO QUANTIDADE DADOS

        public string Atualizar (int codigo, string campo, string dado)
         {
            string query = $"update atividades set {campo} = '{dado}' where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + "Atualizado!";
            return resultado;
         }// FIM DO MÉTODO

        //EXCLUIR
        public string Excluir(int codigo)
        {
            string query = $"delete from atividades where codigo = '{codigo}'";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Deletado";
            return resultado;
        } // fim do excluir

    }//fim da classe
}//fim da namespace