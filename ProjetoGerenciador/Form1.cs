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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Titulo_Click(object sender, EventArgs e)// TITULO
        {

        }// FIM DO METODO TITULO

        private void ListarTarefa_Click(object sender, EventArgs e) // LISTAR TAREFA
        {
            {
                Listar lis = new Listar();
                lis.ShowDialog();

            }
        } // FIM DO LISTAR TAREFA


        private void AdicionarTarefa_Click(object sender, EventArgs e) // ADICIONAR TAREFA
        {
            
            {
                Adicionar adi = new Adicionar();
                adi.ShowDialog();
            }

        }// FIM DO METODO

        private void EditarTarefa_Click(object sender, EventArgs e)// EDITAR TAREFA
        {
            editar edi = new editar();
            edi.ShowDialog();
        }// FIM DO METODO

        private void ExcluirTarefa_Click(object sender, EventArgs e) // EXCLUIR TAREFA
        {
            Excluir exc = new Excluir();
            exc.ShowDialog();
        }// FIM DO METODO

        private void Sair_Click(object sender, EventArgs e)// SAIR
        {
            this.Close();
        }// FIM DO METODO

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MarcarComoConcluida_Click(object sender, EventArgs e)// BOTÃO MARCAR COMO CONCLUIDA 
        {
            ConcluirAtividade conc = new ConcluirAtividade();
            conc.ShowDialog();
        }
    }
}
