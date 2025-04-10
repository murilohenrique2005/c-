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
            this.Voltar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeProfessor
            // 
            this.NomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeProfessor.Location = new System.Drawing.Point(509, 284);
            this.NomeProfessor.Name = "NomeProfessor";
            this.NomeProfessor.Size = new System.Drawing.Size(195, 26);
            this.NomeProfessor.TabIndex = 1;
            this.NomeProfessor.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.NomeProfessor_MaskInputRejected);
            // 
            // NomedoProfessor
            // 
            this.NomedoProfessor.AutoSize = true;
            this.NomedoProfessor.Location = new System.Drawing.Point(552, 268);
            this.NomedoProfessor.Name = "NomedoProfessor";
            this.NomedoProfessor.Size = new System.Drawing.Size(99, 13);
            this.NomedoProfessor.TabIndex = 2;
            this.NomedoProfessor.Text = "Nome Do Professor";
            this.NomedoProfessor.Click += new System.EventHandler(this.NomedoProfessor_Click);
            // 
            // Descricao
            // 
            this.Descricao.AutoSize = true;
            this.Descricao.Location = new System.Drawing.Point(578, 313);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(55, 13);
            this.Descricao.TabIndex = 3;
            this.Descricao.Text = "Descrição";
            this.Descricao.Click += new System.EventHandler(this.Descricao_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(509, 329);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(195, 26);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // DataEntrega
            // 
            this.DataEntrega.AutoSize = true;
            this.DataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DataEntrega.Location = new System.Drawing.Point(564, 358);
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.Size = new System.Drawing.Size(87, 13);
            this.DataEntrega.TabIndex = 5;
            this.DataEntrega.Text = "Data De Entrega";
            this.DataEntrega.Click += new System.EventHandler(this.DataEntrega_Click);
            // 
            // Prioridade
            // 
            this.Prioridade.AutoSize = true;
            this.Prioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Prioridade.Location = new System.Drawing.Point(578, 399);
            this.Prioridade.Name = "Prioridade";
            this.Prioridade.Size = new System.Drawing.Size(54, 13);
            this.Prioridade.TabIndex = 7;
            this.Prioridade.Text = "Prioridade";
            this.Prioridade.Click += new System.EventHandler(this.Prioridade_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(509, 374);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2025, 7, 30, 15, 30, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Escolha
            // 
            this.Escolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Escolha.FormattingEnabled = true;
            this.Escolha.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.Escolha.Location = new System.Drawing.Point(509, 415);
            this.Escolha.Name = "Escolha";
            this.Escolha.Size = new System.Drawing.Size(195, 28);
            this.Escolha.TabIndex = 9;
            this.Escolha.SelectedIndexChanged += new System.EventHandler(this.Escolha_SelectedIndexChanged);
            // 
            // enviarAtividade
            // 
            this.enviarAtividade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.enviarAtividade.FlatAppearance.BorderSize = 0;
            this.enviarAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviarAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.enviarAtividade.ForeColor = System.Drawing.Color.White;
            this.enviarAtividade.Location = new System.Drawing.Point(483, 554);
            this.enviarAtividade.Name = "enviarAtividade";
            this.enviarAtividade.Size = new System.Drawing.Size(252, 27);
            this.enviarAtividade.TabIndex = 10;
            this.enviarAtividade.Text = "Enviar Atividade";
            this.enviarAtividade.UseVisualStyleBackColor = false;
            this.enviarAtividade.Click += new System.EventHandler(this.enviarAtividade_Click);
            // 
            // codigoAtividade
            // 
            this.codigoAtividade.AutoSize = true;
            this.codigoAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.codigoAtividade.Location = new System.Drawing.Point(547, 223);
            this.codigoAtividade.Name = "codigoAtividade";
            this.codigoAtividade.Size = new System.Drawing.Size(102, 13);
            this.codigoAtividade.TabIndex = 11;
            this.codigoAtividade.Text = "Código da Atividade";
            // 
            // CodAtividade
            // 
            this.CodAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodAtividade.Location = new System.Drawing.Point(509, 239);
            this.CodAtividade.Mask = "99";
            this.CodAtividade.Name = "CodAtividade";
            this.CodAtividade.Size = new System.Drawing.Size(88, 26);
            this.CodAtividade.TabIndex = 12;
            this.CodAtividade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CodAtividade_MaskInputRejected);
            // 
            // Turma
            // 
            this.Turma.AutoSize = true;
            this.Turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Turma.Location = new System.Drawing.Point(584, 446);
            this.Turma.Name = "Turma";
            this.Turma.Size = new System.Drawing.Size(37, 13);
            this.Turma.TabIndex = 13;
            this.Turma.Text = "Turma";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "6º ANO",
            "7º ANO",
            "8º ANO",
            "9º ANO",
            "Ensino Médio - 1º Ano",
            "Ensino Médio - 2º Ano",
            "Ensino Médio - 3º Ano "});
            this.comboBox1.Location = new System.Drawing.Point(509, 462);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Status.Location = new System.Drawing.Point(584, 493);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(37, 13);
            this.Status.TabIndex = 15;
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Pendente",
            "Em Andamento",
            "Concluida"});
            this.comboBox2.Location = new System.Drawing.Point(509, 509);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 28);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.Color.Red;
            this.Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Voltar.ForeColor = System.Drawing.Color.White;
            this.Voltar.Location = new System.Drawing.Point(483, 587);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(252, 27);
            this.Voltar.TabIndex = 17;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoGerenciador.Properties.Resources.Black_and_Gold_Simple_Online_Academy_Logo_removebg_preview_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(445, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(290, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoGerenciador.Properties.Resources.nulherroxo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Adicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Voltar);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Adicionar";
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.Adicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}