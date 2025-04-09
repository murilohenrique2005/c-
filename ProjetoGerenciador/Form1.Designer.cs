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
            this.Titulo = new System.Windows.Forms.Label();
            this.ListarTarefa = new System.Windows.Forms.Button();
            this.AdicionarTarefa = new System.Windows.Forms.Button();
            this.EditarTarefa = new System.Windows.Forms.Button();
            this.MarcarComoConcluida = new System.Windows.Forms.Button();
            this.ExcluirTarefa = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(239, 41);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(329, 32);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "PAINEL DE ATIVIDADES";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // ListarTarefa
            // 
            this.ListarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.ListarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListarTarefa.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ListarTarefa.ForeColor = System.Drawing.Color.White;
            this.ListarTarefa.Location = new System.Drawing.Point(258, 164);
            this.ListarTarefa.Name = "ListarTarefa";
            this.ListarTarefa.Size = new System.Drawing.Size(288, 56);
            this.ListarTarefa.TabIndex = 1;
            this.ListarTarefa.Text = "Consultar Atividade";
            this.ListarTarefa.UseVisualStyleBackColor = false;
            this.ListarTarefa.Click += new System.EventHandler(this.ListarTarefa_Click);
            // 
            // AdicionarTarefa
            // 
            this.AdicionarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.AdicionarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AdicionarTarefa.ForeColor = System.Drawing.Color.White;
            this.AdicionarTarefa.Location = new System.Drawing.Point(258, 102);
            this.AdicionarTarefa.Name = "AdicionarTarefa";
            this.AdicionarTarefa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdicionarTarefa.Size = new System.Drawing.Size(288, 56);
            this.AdicionarTarefa.TabIndex = 2;
            this.AdicionarTarefa.Text = "Cadastrar Atividade";
            this.AdicionarTarefa.UseVisualStyleBackColor = false;
            this.AdicionarTarefa.Click += new System.EventHandler(this.AdicionarTarefa_Click);
            // 
            // EditarTarefa
            // 
            this.EditarTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.EditarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarTarefa.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.EditarTarefa.ForeColor = System.Drawing.Color.White;
            this.EditarTarefa.Location = new System.Drawing.Point(258, 226);
            this.EditarTarefa.Name = "EditarTarefa";
            this.EditarTarefa.Size = new System.Drawing.Size(288, 56);
            this.EditarTarefa.TabIndex = 3;
            this.EditarTarefa.Text = "Editar Atividade";
            this.EditarTarefa.UseVisualStyleBackColor = false;
            this.EditarTarefa.Click += new System.EventHandler(this.EditarTarefa_Click);
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
            // ExcluirTarefa
            // 
            this.ExcluirTarefa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.ExcluirTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirTarefa.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ExcluirTarefa.ForeColor = System.Drawing.Color.White;
            this.ExcluirTarefa.Location = new System.Drawing.Point(258, 288);
            this.ExcluirTarefa.Name = "ExcluirTarefa";
            this.ExcluirTarefa.Size = new System.Drawing.Size(288, 56);
            this.ExcluirTarefa.TabIndex = 5;
            this.ExcluirTarefa.Text = "Excluir Atividade";
            this.ExcluirTarefa.UseVisualStyleBackColor = false;
            this.ExcluirTarefa.Click += new System.EventHandler(this.ExcluirTarefa_Click);
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Sair.ForeColor = System.Drawing.Color.White;
            this.Sair.Location = new System.Drawing.Point(258, 350);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(288, 56);
            this.Sair.TabIndex = 6;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.ExcluirTarefa);
            this.Controls.Add(this.MarcarComoConcluida);
            this.Controls.Add(this.EditarTarefa);
            this.Controls.Add(this.AdicionarTarefa);
            this.Controls.Add(this.ListarTarefa);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button ListarTarefa;
        private System.Windows.Forms.Button AdicionarTarefa;
        private System.Windows.Forms.Button EditarTarefa;
        private System.Windows.Forms.Button MarcarComoConcluida;
        private System.Windows.Forms.Button ExcluirTarefa;
        private System.Windows.Forms.Button Sair;
    }
}

