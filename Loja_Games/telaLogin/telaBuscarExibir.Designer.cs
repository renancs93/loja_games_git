namespace LojaGames
{
    partial class telaBuscarExibir
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabExibeBuscaCliente = new System.Windows.Forms.TabPage();
            this.tabExibeBuscaFunc = new System.Windows.Forms.TabPage();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabExibeBuscaCliente);
            this.tabControl1.Controls.Add(this.tabExibeBuscaFunc);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // tabExibeBuscaCliente
            // 
            this.tabExibeBuscaCliente.Location = new System.Drawing.Point(4, 22);
            this.tabExibeBuscaCliente.Name = "tabExibeBuscaCliente";
            this.tabExibeBuscaCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabExibeBuscaCliente.Size = new System.Drawing.Size(684, 407);
            this.tabExibeBuscaCliente.TabIndex = 0;
            this.tabExibeBuscaCliente.Text = "Clientes";
            this.tabExibeBuscaCliente.UseVisualStyleBackColor = true;
            // 
            // tabExibeBuscaFunc
            // 
            this.tabExibeBuscaFunc.Location = new System.Drawing.Point(4, 22);
            this.tabExibeBuscaFunc.Name = "tabExibeBuscaFunc";
            this.tabExibeBuscaFunc.Padding = new System.Windows.Forms.Padding(3);
            this.tabExibeBuscaFunc.Size = new System.Drawing.Size(684, 407);
            this.tabExibeBuscaFunc.TabIndex = 1;
            this.tabExibeBuscaFunc.Text = "Funcionários";
            this.tabExibeBuscaFunc.UseVisualStyleBackColor = true;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.imgLogo.Location = new System.Drawing.Point(4, 437);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(117, 36);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(606, 441);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // telaBuscarExibir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 475);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.tabControl1);
            this.Name = "telaBuscarExibir";
            this.Text = "telaBuscarExibir";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabExibeBuscaCliente;
        private System.Windows.Forms.TabPage tabExibeBuscaFunc;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Button btnSair;
    }
}