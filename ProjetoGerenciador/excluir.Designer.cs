namespace ProjetoGerenciador
{
    partial class Excluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Excluir));
            this.exclusao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.exclusaotexto = new System.Windows.Forms.MaskedTextBox();
            this.botaovoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exclusao
            // 
            this.exclusao.AutoSize = true;
            this.exclusao.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exclusao.Location = new System.Drawing.Point(43, 43);
            this.exclusao.Name = "exclusao";
            this.exclusao.Size = new System.Drawing.Size(326, 45);
            this.exclusao.TabIndex = 0;
            this.exclusao.Text = "EXCLUIR ATIVIDADE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motivo da Exclusão :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código Atividade :";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(242, 148);
            this.maskedTextBox1.Mask = "99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(127, 24);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.BackColor = System.Drawing.Color.Navy;
            this.BotaoExcluir.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.BotaoExcluir.ForeColor = System.Drawing.Color.White;
            this.BotaoExcluir.Location = new System.Drawing.Point(51, 263);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(118, 34);
            this.BotaoExcluir.TabIndex = 5;
            this.BotaoExcluir.Text = "Excluir Atividade";
            this.BotaoExcluir.UseVisualStyleBackColor = false;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // exclusaotexto
            // 
            this.exclusaotexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exclusaotexto.Location = new System.Drawing.Point(245, 209);
            this.exclusaotexto.Name = "exclusaotexto";
            this.exclusaotexto.Size = new System.Drawing.Size(127, 24);
            this.exclusaotexto.TabIndex = 2;
            this.exclusaotexto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.exclusaotexto_MaskInputRejected);
            // 
            // botaovoltar
            // 
            this.botaovoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.botaovoltar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.botaovoltar.ForeColor = System.Drawing.Color.White;
            this.botaovoltar.Location = new System.Drawing.Point(197, 263);
            this.botaovoltar.Name = "botaovoltar";
            this.botaovoltar.Size = new System.Drawing.Size(118, 34);
            this.botaovoltar.TabIndex = 6;
            this.botaovoltar.Text = "Voltar";
            this.botaovoltar.UseVisualStyleBackColor = false;
            this.botaovoltar.Click += new System.EventHandler(this.botaovoltar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(439, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaovoltar);
            this.Controls.Add(this.BotaoExcluir);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exclusaotexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exclusao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Excluir";
            this.Text = "excluir";
            this.Load += new System.EventHandler(this.excluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exclusao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button BotaoExcluir;
        private System.Windows.Forms.MaskedTextBox exclusaotexto;
        private System.Windows.Forms.Button botaovoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}