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
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            InitializeComponent();
            exc = new DAO();
        }

        private void exclusaotexto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) // EXCLUIR
        {
      
        }

        private void BotaoExcluir_Click(object sender, EventArgs e) // BOTÃO EXCLUIR
        {
            int codigo = Convert.ToInt32(maskedTextBox1.Text); 
            MessageBox.Show(exc.Excluir(codigo));
            this.Close();
        } // FIM DO METODO

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)// CODIGO EXCLUIR
        {

        }

        private void excluir_Load(object sender, EventArgs e)
        {

        }

        private void botaovoltar_Click(object sender, EventArgs e)// VOLTAR
        {
            this.Close();
        }// FIM DO VOLTAR

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
