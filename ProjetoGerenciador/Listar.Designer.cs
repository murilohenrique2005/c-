namespace ProjetoGerenciador
{
    partial class Listar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar));
            this.GerenciadorDeTarefas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botaoSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GerenciadorDeTarefas
            // 
            this.GerenciadorDeTarefas.AutoSize = true;
            this.GerenciadorDeTarefas.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.GerenciadorDeTarefas.Location = new System.Drawing.Point(261, 26);
            this.GerenciadorDeTarefas.Name = "GerenciadorDeTarefas";
            this.GerenciadorDeTarefas.Size = new System.Drawing.Size(270, 32);
            this.GerenciadorDeTarefas.TabIndex = 0;
            this.GerenciadorDeTarefas.Text = "Consulta De Lições";
            this.GerenciadorDeTarefas.Click += new System.EventHandler(this.GerenciadorDeTarefas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 317);
            this.dataGridView1.TabIndex = 1;
            // 
            // botaoSair
            // 
            this.botaoSair.BackColor = System.Drawing.Color.Blue;
            this.botaoSair.FlatAppearance.BorderSize = 0;
            this.botaoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSair.ForeColor = System.Drawing.Color.White;
            this.botaoSair.Location = new System.Drawing.Point(175, 414);
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(453, 27);
            this.botaoSair.TabIndex = 2;
            this.botaoSair.Text = "Voltar";
            this.botaoSair.UseVisualStyleBackColor = false;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // Listar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.botaoSair);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GerenciadorDeTarefas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listar";
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.Listar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GerenciadorDeTarefas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botaoSair;
    }
}