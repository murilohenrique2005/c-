namespace ProjetoGerenciador
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MarcarComoConcluida = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.ExcluirTarefa = new System.Windows.Forms.Button();
            this.EditarTarefa = new System.Windows.Forms.Button();
            this.ListarTarefa = new System.Windows.Forms.Button();
            this.AdicionarTarefa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MarcarComoConcluida
            // 
            this.MarcarComoConcluida.BackColor = System.Drawing.Color.DimGray;
            this.MarcarComoConcluida.ForeColor = System.Drawing.Color.White;
            this.MarcarComoConcluida.Location = new System.Drawing.Point(12, 269);
            this.MarcarComoConcluida.Name = "MarcarComoConcluida";
            this.MarcarComoConcluida.Size = new System.Drawing.Size(10, 12);
            this.MarcarComoConcluida.TabIndex = 4;
            this.MarcarComoConcluida.Text = "Marcar Como Concluida";
            this.MarcarComoConcluida.UseVisualStyleBackColor = false;
            this.MarcarComoConcluida.Click += new System.EventHandler(this.MarcarComoConcluida_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.Red;
            this.Sair.FlatAppearance.BorderSize = 0;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Sair.ForeColor = System.Drawing.Color.White;
            this.Sair.Location = new System.Drawing.Point(470, 540);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(277, 47);
            this.Sair.TabIndex = 6;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // ExcluirTarefa
            // 
            this.ExcluirTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.ExcluirTarefa.FlatAppearance.BorderSize = 0;
            this.ExcluirTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ExcluirTarefa.ForeColor = System.Drawing.Color.White;
            this.ExcluirTarefa.Location = new System.Drawing.Point(470, 488);
            this.ExcluirTarefa.Name = "ExcluirTarefa";
            this.ExcluirTarefa.Size = new System.Drawing.Size(277, 47);
            this.ExcluirTarefa.TabIndex = 5;
            this.ExcluirTarefa.Text = "Excluir Atividade";
            this.ExcluirTarefa.UseVisualStyleBackColor = false;
            this.ExcluirTarefa.Click += new System.EventHandler(this.ExcluirTarefa_Click);
            // 
            // EditarTarefa
            // 
            this.EditarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.EditarTarefa.FlatAppearance.BorderSize = 0;
            this.EditarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.EditarTarefa.ForeColor = System.Drawing.Color.White;
            this.EditarTarefa.Location = new System.Drawing.Point(470, 435);
            this.EditarTarefa.Name = "EditarTarefa";
            this.EditarTarefa.Size = new System.Drawing.Size(277, 47);
            this.EditarTarefa.TabIndex = 3;
            this.EditarTarefa.Text = "Editar Atividade";
            this.EditarTarefa.UseVisualStyleBackColor = false;
            this.EditarTarefa.Click += new System.EventHandler(this.EditarTarefa_Click);
            // 
            // ListarTarefa
            // 
            this.ListarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.ListarTarefa.FlatAppearance.BorderSize = 0;
            this.ListarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarTarefa.ForeColor = System.Drawing.Color.White;
            this.ListarTarefa.Location = new System.Drawing.Point(470, 382);
            this.ListarTarefa.Name = "ListarTarefa";
            this.ListarTarefa.Size = new System.Drawing.Size(277, 47);
            this.ListarTarefa.TabIndex = 1;
            this.ListarTarefa.Text = "Consultar Atividade";
            this.ListarTarefa.UseVisualStyleBackColor = false;
            this.ListarTarefa.Click += new System.EventHandler(this.ListarTarefa_Click);
            // 
            // AdicionarTarefa
            // 
            this.AdicionarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.AdicionarTarefa.FlatAppearance.BorderSize = 0;
            this.AdicionarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.AdicionarTarefa.ForeColor = System.Drawing.Color.White;
            this.AdicionarTarefa.Location = new System.Drawing.Point(470, 330);
            this.AdicionarTarefa.Name = "AdicionarTarefa";
            this.AdicionarTarefa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdicionarTarefa.Size = new System.Drawing.Size(277, 47);
            this.AdicionarTarefa.TabIndex = 2;
            this.AdicionarTarefa.Text = "Cadastrar Atividade";
            this.AdicionarTarefa.UseVisualStyleBackColor = false;
            this.AdicionarTarefa.Click += new System.EventHandler(this.AdicionarTarefa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(435, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Escolha uma das Opções :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProjetoGerenciador.Properties.Resources.Black_and_Gold_Simple_Online_Academy_Logo_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(444, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 206);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoGerenciador.Properties.Resources.homem_sorridente_de_vista_lateral_segurando_smartphone_23_2149659098;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 685);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ListarTarefa);
            this.Controls.Add(this.EditarTarefa);
            this.Controls.Add(this.ExcluirTarefa);
            this.Controls.Add(this.AdicionarTarefa);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.MarcarComoConcluida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MarcarComoConcluida;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button ExcluirTarefa;
        private System.Windows.Forms.Button EditarTarefa;
        private System.Windows.Forms.Button ListarTarefa;
        private System.Windows.Forms.Button AdicionarTarefa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

