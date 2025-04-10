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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.exclusaotexto = new System.Windows.Forms.MaskedTextBox();
            this.botaovoltar = new System.Windows.Forms.Button();
            this.BotaoExcluir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(155, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = " Exclusão";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(164, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.White;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBox1.Location = new System.Drawing.Point(98, 360);
            this.maskedTextBox1.Mask = "99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(88, 26);
            this.maskedTextBox1.TabIndex = 4;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // exclusaotexto
            // 
            this.exclusaotexto.BackColor = System.Drawing.Color.White;
            this.exclusaotexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.exclusaotexto.Location = new System.Drawing.Point(98, 438);
            this.exclusaotexto.Name = "exclusaotexto";
            this.exclusaotexto.Size = new System.Drawing.Size(196, 26);
            this.exclusaotexto.TabIndex = 2;
            this.exclusaotexto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.exclusaotexto_MaskInputRejected);
            // 
            // botaovoltar
            // 
            this.botaovoltar.BackColor = System.Drawing.Color.Red;
            this.botaovoltar.FlatAppearance.BorderSize = 0;
            this.botaovoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaovoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.botaovoltar.ForeColor = System.Drawing.Color.White;
            this.botaovoltar.Location = new System.Drawing.Point(47, 523);
            this.botaovoltar.Name = "botaovoltar";
            this.botaovoltar.Size = new System.Drawing.Size(300, 27);
            this.botaovoltar.TabIndex = 6;
            this.botaovoltar.Text = "Voltar";
            this.botaovoltar.UseVisualStyleBackColor = false;
            this.botaovoltar.Click += new System.EventHandler(this.botaovoltar_Click);
            // 
            // BotaoExcluir
            // 
            this.BotaoExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.BotaoExcluir.FlatAppearance.BorderSize = 0;
            this.BotaoExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.BotaoExcluir.ForeColor = System.Drawing.Color.White;
            this.BotaoExcluir.Location = new System.Drawing.Point(47, 490);
            this.BotaoExcluir.Name = "BotaoExcluir";
            this.BotaoExcluir.Size = new System.Drawing.Size(300, 27);
            this.BotaoExcluir.TabIndex = 5;
            this.BotaoExcluir.Text = "Excluir Atividade";
            this.BotaoExcluir.UseVisualStyleBackColor = false;
            this.BotaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ProjetoGerenciador.Properties.Resources.estudante_sorridente_com_notebook_smiling_student_with_laptop_782430_52;
            this.pictureBox1.Location = new System.Drawing.Point(407, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 664);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::ProjetoGerenciador.Properties.Resources.Black_and_Gold_Simple_Online_Academy_Logo_removebg_preview1;
            this.pictureBox2.Location = new System.Drawing.Point(47, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(318, 278);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Excluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.botaovoltar);
            this.Controls.Add(this.BotaoExcluir);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exclusaotexto);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Excluir";
            this.Text = "excluir";
            this.Load += new System.EventHandler(this.excluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox exclusaotexto;
        private System.Windows.Forms.Button botaovoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BotaoExcluir;
    }
}