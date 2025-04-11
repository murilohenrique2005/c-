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
            this.nome = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditarCodigo
            // 
            this.EditarCodigo.AutoSize = true;
            this.EditarCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.EditarCodigo.Location = new System.Drawing.Point(535, 161);
            this.EditarCodigo.Name = "EditarCodigo";
            this.EditarCodigo.Size = new System.Drawing.Size(102, 13);
            this.EditarCodigo.TabIndex = 2;
            this.EditarCodigo.Text = "Código da Atividade";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(473, 177);
            this.maskedTextBox1.Mask = "9999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(128, 26);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.maskedTextBox2.Location = new System.Drawing.Point(473, 221);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(261, 31);
            this.maskedTextBox2.TabIndex = 4;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // descricao
            // 
            this.descricao.AutoSize = true;
            this.descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.descricao.Location = new System.Drawing.Point(572, 254);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(55, 13);
            this.descricao.TabIndex = 5;
            this.descricao.Text = "Descrição";
            this.descricao.Click += new System.EventHandler(this.descricao_Click);
            // 
            // DigitarDescricao
            // 
            this.DigitarDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigitarDescricao.Location = new System.Drawing.Point(473, 270);
            this.DigitarDescricao.Name = "DigitarDescricao";
            this.DigitarDescricao.Size = new System.Drawing.Size(261, 31);
            this.DigitarDescricao.TabIndex = 6;
            this.DigitarDescricao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.DigitarDescricao_MaskInputRejected);
            // 
            // editarDataDeEntrega
            // 
            this.editarDataDeEntrega.AutoSize = true;
            this.editarDataDeEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.editarDataDeEntrega.Location = new System.Drawing.Point(557, 310);
            this.editarDataDeEntrega.Name = "editarDataDeEntrega";
            this.editarDataDeEntrega.Size = new System.Drawing.Size(87, 13);
            this.editarDataDeEntrega.TabIndex = 7;
            this.editarDataDeEntrega.Text = "Data De Entrega";
            this.editarDataDeEntrega.Click += new System.EventHandler(this.editarDataDeEntrega_Click);
            // 
            // EditarDataAtividade
            // 
            this.EditarDataAtividade.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EditarDataAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarDataAtividade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EditarDataAtividade.Location = new System.Drawing.Point(473, 326);
            this.EditarDataAtividade.Name = "EditarDataAtividade";
            this.EditarDataAtividade.Size = new System.Drawing.Size(261, 26);
            this.EditarDataAtividade.TabIndex = 8;
            this.EditarDataAtividade.Value = new System.DateTime(2025, 7, 30, 0, 0, 0, 0);
            this.EditarDataAtividade.ValueChanged += new System.EventHandler(this.EditarDataAtividade_ValueChanged);
            // 
            // Prioridade
            // 
            this.Prioridade.AutoSize = true;
            this.Prioridade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Prioridade.Location = new System.Drawing.Point(572, 459);
            this.Prioridade.Name = "Prioridade";
            this.Prioridade.Size = new System.Drawing.Size(54, 13);
            this.Prioridade.TabIndex = 9;
            this.Prioridade.Text = "Prioridade";
            this.Prioridade.Click += new System.EventHandler(this.Prioridade_Click);
            // 
            // EditarBotão
            // 
            this.EditarBotão.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.EditarBotão.FlatAppearance.BorderSize = 0;
            this.EditarBotão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarBotão.ForeColor = System.Drawing.Color.White;
            this.EditarBotão.Location = new System.Drawing.Point(473, 527);
            this.EditarBotão.Name = "EditarBotão";
            this.EditarBotão.Size = new System.Drawing.Size(252, 27);
            this.EditarBotão.TabIndex = 11;
            this.EditarBotão.Text = "Editar";
            this.EditarBotão.UseVisualStyleBackColor = false;
            this.EditarBotão.Click += new System.EventHandler(this.EditarBotão_Click);
            // 
            // turma
            // 
            this.turma.AutoSize = true;
            this.turma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.turma.Location = new System.Drawing.Point(579, 407);
            this.turma.Name = "turma";
            this.turma.Size = new System.Drawing.Size(37, 13);
            this.turma.TabIndex = 12;
            this.turma.Text = "Turma";
            this.turma.Click += new System.EventHandler(this.turma_Click);
            // 
            // EditarTurma
            // 
            this.EditarTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.EditarTurma.FormattingEnabled = true;
            this.EditarTurma.Items.AddRange(new object[] {
            "6º ANO",
            "7º ANO",
            "8º ANO",
            "9º ANO",
            "Ensino Médio - 1º Ano",
            "Ensino Médio - 2º Ano",
            "Ensino Médio - 3º Ano "});
            this.EditarTurma.Location = new System.Drawing.Point(473, 423);
            this.EditarTurma.Name = "EditarTurma";
            this.EditarTurma.Size = new System.Drawing.Size(261, 33);
            this.EditarTurma.TabIndex = 13;
            this.EditarTurma.SelectedIndexChanged += new System.EventHandler(this.EditarTurma_SelectedIndexChanged);
            // 
            // EditarPrioridadew
            // 
            this.EditarPrioridadew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.EditarPrioridadew.FormattingEnabled = true;
            this.EditarPrioridadew.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.EditarPrioridadew.Location = new System.Drawing.Point(473, 475);
            this.EditarPrioridadew.Name = "EditarPrioridadew";
            this.EditarPrioridadew.Size = new System.Drawing.Size(261, 33);
            this.EditarPrioridadew.TabIndex = 14;
            this.EditarPrioridadew.SelectedIndexChanged += new System.EventHandler(this.EditarPrioridadew_SelectedIndexChanged);
            // 
            // EditarStatus
            // 
            this.EditarStatus.AutoSize = true;
            this.EditarStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.EditarStatus.Location = new System.Drawing.Point(580, 355);
            this.EditarStatus.Name = "EditarStatus";
            this.EditarStatus.Size = new System.Drawing.Size(37, 13);
            this.EditarStatus.TabIndex = 15;
            this.EditarStatus.Text = "Status";
            this.EditarStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditarStatus.Click += new System.EventHandler(this.EditarStatus_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pendente",
            "Em Andamento",
            "Concluida"});
            this.comboBox1.Location = new System.Drawing.Point(473, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 33);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // voltarEditar
            // 
            this.voltarEditar.BackColor = System.Drawing.Color.Red;
            this.voltarEditar.FlatAppearance.BorderSize = 0;
            this.voltarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltarEditar.ForeColor = System.Drawing.Color.White;
            this.voltarEditar.Location = new System.Drawing.Point(473, 560);
            this.voltarEditar.Name = "voltarEditar";
            this.voltarEditar.Size = new System.Drawing.Size(252, 27);
            this.voltarEditar.TabIndex = 17;
            this.voltarEditar.Text = "Voltar";
            this.voltarEditar.UseVisualStyleBackColor = false;
            this.voltarEditar.Click += new System.EventHandler(this.voltarEditar_Click);
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.buscar.FlatAppearance.BorderSize = 0;
            this.buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buscar.ForeColor = System.Drawing.Color.White;
            this.buscar.Location = new System.Drawing.Point(607, 177);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(74, 25);
            this.buscar.TabIndex = 18;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(553, 205);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(99, 13);
            this.nome.TabIndex = 22;
            this.nome.Text = "Nome Do Professor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoGerenciador.Properties.Resources.Black_and_Gold_Simple_Online_Academy_Logo_removebg_preview_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(458, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 147);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "editar";
            this.Text = "editar";
            this.Load += new System.EventHandler(this.editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nome;
    }
}