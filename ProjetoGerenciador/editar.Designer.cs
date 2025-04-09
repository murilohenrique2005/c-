namespace ProjetoGerenciador
{
    partial class editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editar));
            this.TituloEditar = new System.Windows.Forms.Label();
            this.TituloTarefa = new System.Windows.Forms.Label();
            this.EditarCodigo = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.descricao = new System.Windows.Forms.Label();
            this.DigitarDescricao = new System.Windows.Forms.MaskedTextBox();
            this.editarDataDeEntrega = new System.Windows.Forms.Label();
            this.EditarDataAtividade = new System.Windows.Forms.DateTimePicker();
            this.Prioridade = new System.Windows.Forms.Label();
            this.EditarBotão = new System.Windows.Forms.Button();
            this.turma = new System.Windows.Forms.Label();
            this.EditarTurma = new System.Windows.Forms.ComboBox();
            this.EditarPrioridadew = new System.Windows.Forms.ComboBox();
            this.EditarStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.voltarEditar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloEditar
            // 
            this.TituloEditar.AutoSize = true;
            this.TituloEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.TituloEditar.Location = new System.Drawing.Point(41, 35);
            this.TituloEditar.Name = "TituloEditar";
            this.TituloEditar.Size = new System.Drawing.Size(204, 31);
            this.TituloEditar.TabIndex = 0;
            this.TituloEditar.Text = "Editar Atividade";
            this.TituloEditar.Click += new System.EventHandler(this.TituloEditar_Click);
            // 
            // TituloTarefa
            // 
            this.TituloTarefa.AutoSize = true;
            this.TituloTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TituloTarefa.Location = new System.Drawing.Point(44, 145);
            this.TituloTarefa.Name = "TituloTarefa";
            this.TituloTarefa.Size = new System.Drawing.Size(84, 13);
            this.TituloTarefa.TabIndex = 1;
            this.TituloTarefa.Text = "Titulo Da Tarefa";
            this.TituloTarefa.Click += new System.EventHandler(this.TituloTarefa_Click);
            // 
            // EditarCodigo
            // 
            this.EditarCodigo.AutoSize = true;
            this.EditarCodigo.Location = new System.Drawing.Point(44, 107);
            this.EditarCodigo.Name = "EditarCodigo";
            this.EditarCodigo.Size = new System.Drawing.Size(102, 13);
            this.EditarCodigo.TabIndex = 2;
            this.EditarCodigo.Text = "Código da Atividade";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(152, 104);
            this.maskedTextBox1.Mask = "99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(152, 142);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Location = new System.Drawing.Point(44, 181);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(55, 13);
            this.descricao.TabIndex = 5;
            this.descricao.Text = "Descrição";
            this.descricao.Click += new System.EventHandler(this.descricao_Click);
            // 
            // DigitarDescricao
            // 
            this.DigitarDescricao.Location = new System.Drawing.Point(152, 178);
            this.DigitarDescricao.Name = "DigitarDescricao";
            this.DigitarDescricao.Size = new System.Drawing.Size(133, 20);
            this.DigitarDescricao.TabIndex = 6;
            this.DigitarDescricao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DigitarDescricao_MaskInputRejected);
            // 
            // editarDataDeEntrega
            // 
            this.editarDataDeEntrega.AutoSize = true;
            this.editarDataDeEntrega.Location = new System.Drawing.Point(44, 217);
            this.editarDataDeEntrega.Name = "editarDataDeEntrega";
            this.editarDataDeEntrega.Size = new System.Drawing.Size(87, 13);
            this.editarDataDeEntrega.TabIndex = 7;
            this.editarDataDeEntrega.Text = "Data De Entrega";
            this.editarDataDeEntrega.Click += new System.EventHandler(this.editarDataDeEntrega_Click);
            // 
            // EditarDataAtividade
            // 
            this.EditarDataAtividade.Location = new System.Drawing.Point(152, 211);
            this.EditarDataAtividade.Name = "EditarDataAtividade";
            this.EditarDataAtividade.Size = new System.Drawing.Size(228, 20);
            this.EditarDataAtividade.TabIndex = 8;
            this.EditarDataAtividade.Value = new System.DateTime(2025, 7, 30, 0, 0, 0, 0);
            this.EditarDataAtividade.ValueChanged += new System.EventHandler(this.EditarDataAtividade_ValueChanged);
            // 
            // Prioridade
            // 
            this.Prioridade.AutoSize = true;
            this.Prioridade.Location = new System.Drawing.Point(44, 252);
            this.Prioridade.Name = "Prioridade";
            this.Prioridade.Size = new System.Drawing.Size(54, 13);
            this.Prioridade.TabIndex = 9;
            this.Prioridade.Text = "Prioridade";
            this.Prioridade.Click += new System.EventHandler(this.Prioridade_Click);
            // 
            // EditarBotão
            // 
            this.EditarBotão.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EditarBotão.ForeColor = System.Drawing.Color.White;
            this.EditarBotão.Location = new System.Drawing.Point(47, 351);
            this.EditarBotão.Name = "EditarBotão";
            this.EditarBotão.Size = new System.Drawing.Size(153, 35);
            this.EditarBotão.TabIndex = 11;
            this.EditarBotão.Text = "Editar";
            this.EditarBotão.UseVisualStyleBackColor = false;
            this.EditarBotão.Click += new System.EventHandler(this.EditarBotão_Click);
            // 
            // turma
            // 
            this.turma.AutoSize = true;
            this.turma.Location = new System.Drawing.Point(44, 284);
            this.turma.Name = "turma";
            this.turma.Size = new System.Drawing.Size(37, 13);
            this.turma.TabIndex = 12;
            this.turma.Text = "Turma";
            this.turma.Click += new System.EventHandler(this.turma_Click);
            // 
            // EditarTurma
            // 
            this.EditarTurma.FormattingEnabled = true;
            this.EditarTurma.Items.AddRange(new object[] {
            "6º ANO",
            "7º ANO",
            "8º ANO",
            "9º ANO",
            "Ensino Médio - 1º Ano",
            "Ensino Médio - 2º Ano",
            "Ensino Médio - 3º Ano "});
            this.EditarTurma.Location = new System.Drawing.Point(152, 284);
            this.EditarTurma.Name = "EditarTurma";
            this.EditarTurma.Size = new System.Drawing.Size(121, 21);
            this.EditarTurma.TabIndex = 13;
            this.EditarTurma.SelectedIndexChanged += new System.EventHandler(this.EditarTurma_SelectedIndexChanged);
            // 
            // EditarPrioridadew
            // 
            this.EditarPrioridadew.FormattingEnabled = true;
            this.EditarPrioridadew.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.EditarPrioridadew.Location = new System.Drawing.Point(152, 252);
            this.EditarPrioridadew.Name = "EditarPrioridadew";
            this.EditarPrioridadew.Size = new System.Drawing.Size(121, 21);
            this.EditarPrioridadew.TabIndex = 14;
            this.EditarPrioridadew.SelectedIndexChanged += new System.EventHandler(this.EditarPrioridadew_SelectedIndexChanged);
            // 
            // EditarStatus
            // 
            this.EditarStatus.AutoSize = true;
            this.EditarStatus.Location = new System.Drawing.Point(46, 321);
            this.EditarStatus.Name = "EditarStatus";
            this.EditarStatus.Size = new System.Drawing.Size(37, 13);
            this.EditarStatus.TabIndex = 15;
            this.EditarStatus.Text = "Status";
            this.EditarStatus.Click += new System.EventHandler(this.EditarStatus_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pendente",
            "Em Andamento",
            "Concluida"});
            this.comboBox1.Location = new System.Drawing.Point(107, 318);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // voltarEditar
            // 
            this.voltarEditar.Location = new System.Drawing.Point(225, 357);
            this.voltarEditar.Name = "voltarEditar";
            this.voltarEditar.Size = new System.Drawing.Size(117, 23);
            this.voltarEditar.TabIndex = 17;
            this.voltarEditar.Text = "Voltar";
            this.voltarEditar.UseVisualStyleBackColor = true;
            this.voltarEditar.Click += new System.EventHandler(this.voltarEditar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(305, 102);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 18;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.voltarEditar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EditarStatus);
            this.Controls.Add(this.EditarPrioridadew);
            this.Controls.Add(this.EditarTurma);
            this.Controls.Add(this.turma);
            this.Controls.Add(this.EditarBotão);
            this.Controls.Add(this.Prioridade);
            this.Controls.Add(this.EditarDataAtividade);
            this.Controls.Add(this.editarDataDeEntrega);
            this.Controls.Add(this.DigitarDescricao);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.EditarCodigo);
            this.Controls.Add(this.TituloTarefa);
            this.Controls.Add(this.TituloEditar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editar";
            this.Text = "editar";
            this.Load += new System.EventHandler(this.editar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloEditar;
        private System.Windows.Forms.Label TituloTarefa;
        private System.Windows.Forms.Label EditarCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label descricao;
        private System.Windows.Forms.MaskedTextBox DigitarDescricao;
        private System.Windows.Forms.Label editarDataDeEntrega;
        private System.Windows.Forms.DateTimePicker EditarDataAtividade;
        private System.Windows.Forms.Label Prioridade;
        private System.Windows.Forms.Button EditarBotão;
        private System.Windows.Forms.Label turma;
        private System.Windows.Forms.ComboBox EditarTurma;
        private System.Windows.Forms.ComboBox EditarPrioridadew;
        private System.Windows.Forms.Label EditarStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button voltarEditar;
        private System.Windows.Forms.Button buscar;
    }
}