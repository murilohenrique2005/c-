namespace ProjetoGerenciador
{
    partial class Adicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar));
            this.ListaDeTarefas = new System.Windows.Forms.Label();
            this.NomeProfessor = new System.Windows.Forms.MaskedTextBox();
            this.NomedoProfessor = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.DataEntrega = new System.Windows.Forms.Label();
            this.Prioridade = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Escolha = new System.Windows.Forms.ComboBox();
            this.enviarAtividade = new System.Windows.Forms.Button();
            this.codigoAtividade = new System.Windows.Forms.Label();
            this.CodAtividade = new System.Windows.Forms.MaskedTextBox();
            this.Turma = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ListaDeTarefas
            // 
            this.ListaDeTarefas.AutoSize = true;
            this.ListaDeTarefas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaDeTarefas.Location = new System.Drawing.Point(19, 76);
            this.ListaDeTarefas.Name = "ListaDeTarefas";
            this.ListaDeTarefas.Size = new System.Drawing.Size(198, 32);
            this.ListaDeTarefas.TabIndex = 0;
            this.ListaDeTarefas.Text = "Listar Tarefas";
            // 
            // NomeProfessor
            // 
            this.NomeProfessor.Location = new System.Drawing.Point(128, 165);
            this.NomeProfessor.Name = "NomeProfessor";
            this.NomeProfessor.Size = new System.Drawing.Size(140, 20);
            this.NomeProfessor.TabIndex = 1;
            this.NomeProfessor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.NomeProfessor_MaskInputRejected);
            // 
            // NomedoProfessor
            // 
            this.NomedoProfessor.AutoSize = true;
            this.NomedoProfessor.Location = new System.Drawing.Point(22, 168);
            this.NomedoProfessor.Name = "NomedoProfessor";
            this.NomedoProfessor.Size = new System.Drawing.Size(99, 13);
            this.NomedoProfessor.TabIndex = 2;
            this.NomedoProfessor.Text = "Nome Do Professor";
            this.NomedoProfessor.Click += new System.EventHandler(this.NomedoProfessor_Click);
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Location = new System.Drawing.Point(22, 203);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(55, 13);
            this.Descricao.TabIndex = 3;
            this.Descricao.Text = "Descrição";
            this.Descricao.Click += new System.EventHandler(this.Descricao_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(128, 200);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(140, 20);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // DataEntrega
            // 
            this.DataEntrega.AutoSize = true;
            this.DataEntrega.Location = new System.Drawing.Point(22, 239);
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.Size = new System.Drawing.Size(87, 13);
            this.DataEntrega.TabIndex = 5;
            this.DataEntrega.Text = "Data De Entrega";
            this.DataEntrega.Click += new System.EventHandler(this.DataEntrega_Click);
            // 
            // Prioridade
            // 
            this.Prioridade.AutoSize = true;
            this.Prioridade.Location = new System.Drawing.Point(25, 276);
            this.Prioridade.Name = "Prioridade";
            this.Prioridade.Size = new System.Drawing.Size(54, 13);
            this.Prioridade.TabIndex = 7;
            this.Prioridade.Text = "Prioridade";
            this.Prioridade.Click += new System.EventHandler(this.Prioridade_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2025, 7, 30, 15, 30, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Escolha
            // 
            this.Escolha.FormattingEnabled = true;
            this.Escolha.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.Escolha.Location = new System.Drawing.Point(128, 268);
            this.Escolha.Name = "Escolha";
            this.Escolha.Size = new System.Drawing.Size(121, 21);
            this.Escolha.TabIndex = 9;
            this.Escolha.SelectedIndexChanged += new System.EventHandler(this.Escolha_SelectedIndexChanged);
            // 
            // enviarAtividade
            // 
            this.enviarAtividade.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.enviarAtividade.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviarAtividade.ForeColor = System.Drawing.Color.White;
            this.enviarAtividade.Location = new System.Drawing.Point(25, 375);
            this.enviarAtividade.Name = "enviarAtividade";
            this.enviarAtividade.Size = new System.Drawing.Size(156, 33);
            this.enviarAtividade.TabIndex = 10;
            this.enviarAtividade.Text = "ENVIAR ATIVIDADE";
            this.enviarAtividade.UseVisualStyleBackColor = false;
            this.enviarAtividade.Click += new System.EventHandler(this.enviarAtividade_Click);
            // 
            // codigoAtividade
            // 
            this.codigoAtividade.AutoSize = true;
            this.codigoAtividade.Location = new System.Drawing.Point(24, 132);
            this.codigoAtividade.Name = "codigoAtividade";
            this.codigoAtividade.Size = new System.Drawing.Size(102, 13);
            this.codigoAtividade.TabIndex = 11;
            this.codigoAtividade.Text = "Código da Atividade";
            // 
            // CodAtividade
            // 
            this.CodAtividade.Location = new System.Drawing.Point(128, 132);
            this.CodAtividade.Mask = "99";
            this.CodAtividade.Name = "CodAtividade";
            this.CodAtividade.Size = new System.Drawing.Size(100, 20);
            this.CodAtividade.TabIndex = 12;
            this.CodAtividade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CodAtividade_MaskInputRejected);
            // 
            // Turma
            // 
            this.Turma.AutoSize = true;
            this.Turma.Location = new System.Drawing.Point(25, 311);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(37, 13);
            this.Turma.TabIndex = 13;
            this.Turma.Text = "Turma";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "6º ANO",
            "7º ANO",
            "8º ANO",
            "9º ANO",
            "Ensino Médio - 1º Ano",
            "Ensino Médio - 2º Ano",
            "Ensino Médio - 3º Ano "});
            this.comboBox1.Location = new System.Drawing.Point(128, 303);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(27, 346);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 15;
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pendente",
            "Em Andamento",
            "Concluida"});
            this.comboBox2.Location = new System.Drawing.Point(128, 343);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Turma);
            this.Controls.Add(this.CodAtividade);
            this.Controls.Add(this.codigoAtividade);
            this.Controls.Add(this.enviarAtividade);
            this.Controls.Add(this.Escolha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Prioridade);
            this.Controls.Add(this.DataEntrega);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.Descricao);
            this.Controls.Add(this.NomedoProfessor);
            this.Controls.Add(this.NomeProfessor);
            this.Controls.Add(this.ListaDeTarefas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.Adicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListaDeTarefas;
        private System.Windows.Forms.MaskedTextBox NomeProfessor;
        private System.Windows.Forms.Label NomedoProfessor;
        private System.Windows.Forms.Label Descricao;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label DataEntrega;
        private System.Windows.Forms.Label Prioridade;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox Escolha;
        private System.Windows.Forms.Button enviarAtividade;
        private System.Windows.Forms.Label codigoAtividade;
        private System.Windows.Forms.MaskedTextBox CodAtividade;
        private System.Windows.Forms.Label Turma;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}