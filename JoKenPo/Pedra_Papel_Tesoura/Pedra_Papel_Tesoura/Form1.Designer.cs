namespace Pedra_Papel_Tesoura
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
            this.PbIA = new System.Windows.Forms.PictureBox();
            this.PbJogador = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblIA = new System.Windows.Forms.Label();
            this.lblJogador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbIA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJogador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // PbIA
            // 
            this.PbIA.Image = global::Pedra_Papel_Tesoura.Properties.Resources.papel_long2;
            this.PbIA.Location = new System.Drawing.Point(385, 12);
            this.PbIA.Name = "PbIA";
            this.PbIA.Size = new System.Drawing.Size(100, 162);
            this.PbIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbIA.TabIndex = 0;
            this.PbIA.TabStop = false;
            // 
            // PbJogador
            // 
            this.PbJogador.Image = global::Pedra_Papel_Tesoura.Properties.Resources.papel_long;
            this.PbJogador.Location = new System.Drawing.Point(385, 199);
            this.PbJogador.Name = "PbJogador";
            this.PbJogador.Size = new System.Drawing.Size(100, 162);
            this.PbJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbJogador.TabIndex = 1;
            this.PbJogador.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pedra_Papel_Tesoura.Properties.Resources.tesoura_peq;
            this.pictureBox3.Location = new System.Drawing.Point(555, 382);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "tesoura";
            this.pictureBox3.Click += new System.EventHandler(this.Escolhas_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Pedra_Papel_Tesoura.Properties.Resources.papel_peq;
            this.pictureBox4.Location = new System.Drawing.Point(385, 382);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(124, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "papel";
            this.pictureBox4.Click += new System.EventHandler(this.Escolhas_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Pedra_Papel_Tesoura.Properties.Resources.pedra_peq;
            this.pictureBox5.Location = new System.Drawing.Point(213, 382);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(124, 74);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "pedra";
            this.pictureBox5.Click += new System.EventHandler(this.Escolhas_Click);
            // 
            // lblIA
            // 
            this.lblIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIA.Location = new System.Drawing.Point(25, 13);
            this.lblIA.Name = "lblIA";
            this.lblIA.Size = new System.Drawing.Size(108, 39);
            this.lblIA.TabIndex = 5;
            this.lblIA.Text = "CPU : ";
            // 
            // lblJogador
            // 
            this.lblJogador.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador.Location = new System.Drawing.Point(25, 425);
            this.lblJogador.Name = "lblJogador";
            this.lblJogador.Size = new System.Drawing.Size(146, 31);
            this.lblJogador.TabIndex = 6;
            this.lblJogador.Text = "Jogador : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(913, 485);
            this.Controls.Add(this.lblJogador);
            this.Controls.Add(this.lblIA);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.PbJogador);
            this.Controls.Add(this.PbIA);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Jo Ken Po";
            ((System.ComponentModel.ISupportInitialize)(this.PbIA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbJogador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PbIA;
        private System.Windows.Forms.PictureBox PbJogador;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblIA;
        private System.Windows.Forms.Label lblJogador;
    }
}

