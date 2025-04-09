using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoGerenciador
{
    public partial class editar : Form
    {
        DAO atu;
        public editar()
        {
            atu = new DAO();
            InitializeComponent();
            maskedTextBox1.ReadOnly = false;
            maskedTextBox2.ReadOnly = true;
            DigitarDescricao.ReadOnly = true;
            EditarDataAtividade.Enabled = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)// EDITAR TITULO DA TAREFA
        {

        }

        private void DigitarDescricao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)// EDITAR DESCRIÇÃO
        {

        }// FIM DO METODO

        private void TituloEditar_Click(object sender, EventArgs e)// EDITAR CODIGO 
        {

        }// FIM DO METODO

        private void TituloTarefa_Click(object sender, EventArgs e)// TITULO TAREFA
        {

        }// FIM DO METODO

        private void descricao_Click(object sender, EventArgs e)// FIM DO DESCRIÇÃO EDITAR
        {

        }// FIM DO METODO

        private void editarDataDeEntrega_Click(object sender, EventArgs e)// FIM DO EDITAR DATA DE ENTREGA
        {

        }

        private void EditarDataAtividade_ValueChanged(object sender, EventArgs e)// FIM DO EDITAR DATA
        {

        }// FIM DO METODO

        private void Prioridade_Click(object sender, EventArgs e)// FIM DO PRIORIDADE
        {

        }// FIM DO PRIORIDADE

        private void EditarBotão_Click(object sender, EventArgs e)// FIM DO EDITAR BOTÃO
        {
            int codigo = Convert.ToInt32(maskedTextBox1.Text);
            string nomeprofessor = maskedTextBox2.Text;
            string descricao = DigitarDescricao.Text;
            string dataentrega = EditarDataAtividade.Text;
            string prioridade = EditarPrioridadew.Text;
            string turma = EditarTurma.Text;
            string statusAtividade = comboBox1.Text;

            atu.Atualizar(codigo, "nomeprofessor", nomeprofessor);
            atu.Atualizar(codigo, "descricao", descricao);
            atu.Atualizar(codigo, "dataentrega", dataentrega);
            atu.Atualizar(codigo, "prioridade", prioridade);
            atu.Atualizar(codigo, "turma", turma);
            atu.Atualizar(codigo, "statusAtividade", statusAtividade);
            MessageBox.Show("Dados Atualizados!");
            this.Close();




        }// FIM DO BOTÃO EDITAR

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                maskedTextBox2.Text = "Informe o Código"; // Professor
                DigitarDescricao.Text = "Informe o Código";
                EditarDataAtividade.Text = "Informe o Código";
                EditarPrioridadew.Text = "Informe um Código";
                EditarTurma.Text = "Informe um Código";
                comboBox1.Text = "Informe um Código";
            }
            else
            {
                int codigo = Convert.ToInt32(maskedTextBox1.Text);

                maskedTextBox2.Text = atu.RetornarNome(codigo);//Preechendo o campo
                DigitarDescricao.Text = atu.RetornarDescricao(codigo);
                EditarDataAtividade.Text = atu.RetornarData(codigo);
                EditarPrioridadew.Text = atu.RetornarPrioridade(codigo);
                EditarTurma.Text = atu.RetornarTurma(codigo);
                comboBox1.Text = atu.RetornarStatus(codigo);

            }
        }

        private void editar_Load(object sender, EventArgs e)
        {

        }

        

        private void turma_Click(object sender, EventArgs e)// TURMA
        {

        }

        private void EditarTurma_SelectedIndexChanged(object sender, EventArgs e)// Editar Turma
        {

        }

        private void EditarPrioridadew_SelectedIndexChanged(object sender, EventArgs e)// FIM DO EDITAR PRIORIDADE
        {

        }

        private void EditarStatus_Click(object sender, EventArgs e)// FIM DO EDITAR STATUS
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// EDITAR STATYS
        {

        }

        private void voltarEditar_Click(object sender, EventArgs e)// VOLTAR
        {
            this.Close();
        }

       
    }// FIM DA CLASSE
}//FIM DO PROJETO
