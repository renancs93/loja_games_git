namespace Loja_games
{
    partial class telaJogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaJogos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.abaCadastraJogos = new System.Windows.Forms.TabPage();
            this.abaExibeJogos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.abaCadastraJogos.SuspendLayout();
            this.abaExibeJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.abaCadastraJogos);
            this.tabControl1.Controls.Add(this.abaExibeJogos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(774, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // abaCadastraJogos
            // 
            this.abaCadastraJogos.Controls.Add(this.label1);
            this.abaCadastraJogos.Location = new System.Drawing.Point(4, 22);
            this.abaCadastraJogos.Name = "abaCadastraJogos";
            this.abaCadastraJogos.Padding = new System.Windows.Forms.Padding(3);
            this.abaCadastraJogos.Size = new System.Drawing.Size(766, 426);
            this.abaCadastraJogos.TabIndex = 0;
            this.abaCadastraJogos.Text = "Cadastrar Jogo";
            this.abaCadastraJogos.UseVisualStyleBackColor = true;
            // 
            // abaExibeJogos
            // 
            this.abaExibeJogos.Controls.Add(this.label2);
            this.abaExibeJogos.Location = new System.Drawing.Point(4, 22);
            this.abaExibeJogos.Name = "abaExibeJogos";
            this.abaExibeJogos.Padding = new System.Windows.Forms.Padding(3);
            this.abaExibeJogos.Size = new System.Drawing.Size(766, 426);
            this.abaExibeJogos.TabIndex = 1;
            this.abaExibeJogos.Text = "Exibir Jogos";
            this.abaExibeJogos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "teste1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "teste 2";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(281, 6);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(200, 50);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // telaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 492);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.tabControl1);
            this.Name = "telaJogos";
            this.Text = "Jogos";
            this.Load += new System.EventHandler(this.telaJogos_Load);
            this.tabControl1.ResumeLayout(false);
            this.abaCadastraJogos.ResumeLayout(false);
            this.abaCadastraJogos.PerformLayout();
            this.abaExibeJogos.ResumeLayout(false);
            this.abaExibeJogos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage abaCadastraJogos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage abaExibeJogos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}