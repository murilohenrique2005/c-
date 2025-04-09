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
    public partial class ConcluirAtividade : Form
    {
        public ConcluirAtividade()
        {
            InitializeComponent();
        }

        private void ConcluidaAtividade_CheckedChanged(object sender, EventArgs e) // CHECK BOX CONCLUA ATIVIDADE
        {
            ConcluirAtividade conc = new ConcluirAtividade();
            conc.ShowDialog();


        } // FIM DO METODO

        private void ConcluirAtividade_Load(object sender, EventArgs e)
        {

        }
    } // FIM DA CLASSE
} // FIM DO PROJETO
