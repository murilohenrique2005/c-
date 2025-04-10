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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
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
            this.Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Sair.ForeColor = System.Drawing.Color.White;
            this.Sair.Location = new System.Drawing.Point(310, 359);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(240, 53);
            this.Sair.TabIndex = 6;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // ExcluirTarefa
            // 
            this.ExcluirTarefa.BackColor = System.Drawing.Color.White;
            this.ExcluirTarefa.FlatAppearance.BorderSize = 0;
            this.ExcluirTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcluirTarefa.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ExcluirTarefa.ForeColor = System.Drawing.Color.Black;
            this.ExcluirTarefa.Location = new System.Drawing.Point(608, 19);
            this.ExcluirTarefa.Name = "ExcluirTarefa";
            this.ExcluirTarefa.Size = new System.Drawing.Size(167, 42);
            this.ExcluirTarefa.TabIndex = 5;
            this.ExcluirTarefa.Text = "Excluir Atividade";
            this.ExcluirTarefa.UseVisualStyleBackColor = false;
            this.ExcluirTarefa.Click += new System.EventHandler(this.ExcluirTarefa_Click);
            // 
            // EditarTarefa
            // 
            this.EditarTarefa.BackColor = System.Drawing.Color.White;
            this.EditarTarefa.FlatAppearance.BorderSize = 0;
            this.EditarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarTarefa.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.EditarTarefa.ForeColor = System.Drawing.Color.Black;
            this.EditarTarefa.Location = new System.Drawing.Point(426, 20);
            this.EditarTarefa.Name = "EditarTarefa";
            this.EditarTarefa.Size = new System.Drawing.Size(167, 42);
            this.EditarTarefa.TabIndex = 3;
            this.EditarTarefa.Text = "Editar Atividade";
            this.EditarTarefa.UseVisualStyleBackColor = false;
            this.EditarTarefa.Click += new System.EventHandler(this.EditarTarefa_Click);
            // 
            // ListarTarefa
            // 
            this.ListarTarefa.BackColor = System.Drawing.Color.White;
            this.ListarTarefa.FlatAppearance.BorderSize = 0;
            this.ListarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListarTarefa.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ListarTarefa.ForeColor = System.Drawing.Color.Black;
            this.ListarTarefa.Location = new System.Drawing.Point(237, 19);
            this.ListarTarefa.Name = "ListarTarefa";
            this.ListarTarefa.Size = new System.Drawing.Size(167, 42);
            this.ListarTarefa.TabIndex = 1;
            this.ListarTarefa.Text = "Consultar Atividade";
            this.ListarTarefa.UseVisualStyleBackColor = false;
            this.ListarTarefa.Click += new System.EventHandler(this.ListarTarefa_Click);
            // 
            // AdicionarTarefa
            // 
            this.AdicionarTarefa.BackColor = System.Drawing.Color.White;
            this.AdicionarTarefa.FlatAppearance.BorderSize = 0;
            this.AdicionarTarefa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdicionarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AdicionarTarefa.ForeColor = System.Drawing.Color.Black;
            this.AdicionarTarefa.Location = new System.Drawing.Point(47, 21);
            this.AdicionarTarefa.Name = "AdicionarTarefa";
            this.AdicionarTarefa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdicionarTarefa.Size = new System.Drawing.Size(167, 42);
            this.AdicionarTarefa.TabIndex = 2;
            this.AdicionarTarefa.Text = "Cadastrar Atividade";
            this.AdicionarTarefa.UseVisualStyleBackColor = false;
            this.AdicionarTarefa.Click += new System.EventHandler(this.AdicionarTarefa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.AdicionarTarefa);
            this.groupBox1.Controls.Add(this.ExcluirTarefa);
            this.groupBox1.Controls.Add(this.EditarTarefa);
            this.groupBox1.Controls.Add(this.ListarTarefa);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 89);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MarcarComoConcluida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button MarcarComoConcluida;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button ExcluirTarefa;
        private System.Windows.Forms.Button EditarTarefa;
        private System.Windows.Forms.Button ListarTarefa;
        private System.Windows.Forms.Button AdicionarTarefa;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

