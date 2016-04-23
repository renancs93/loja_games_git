namespace LojaGames
{
    partial class telaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaLogin));
            this.lbCabecalho = new System.Windows.Forms.Label();
            this.imgLogotipo = new System.Windows.Forms.PictureBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtCampoUsuario = new System.Windows.Forms.TextBox();
            this.txtCampoSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.imgOK_usuario = new System.Windows.Forms.PictureBox();
            this.imgOK_senha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogotipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK_senha)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCabecalho
            // 
            this.lbCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCabecalho.AutoSize = true;
            this.lbCabecalho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCabecalho.ForeColor = System.Drawing.Color.White;
            this.lbCabecalho.Location = new System.Drawing.Point(78, 17);
            this.lbCabecalho.Name = "lbCabecalho";
            this.lbCabecalho.Size = new System.Drawing.Size(187, 24);
            this.lbCabecalho.TabIndex = 0;
            this.lbCabecalho.Text = "Acesso ao Sistema";
            // 
            // imgLogotipo
            // 
            this.imgLogotipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgLogotipo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogotipo.Image")));
            this.imgLogotipo.Location = new System.Drawing.Point(61, 44);
            this.imgLogotipo.Name = "imgLogotipo";
            this.imgLogotipo.Size = new System.Drawing.Size(217, 203);
            this.imgLogotipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogotipo.TabIndex = 1;
            this.imgLogotipo.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(18, 263);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(67, 18);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuário";
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.Color.White;
            this.lbSenha.Location = new System.Drawing.Point(18, 299);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(55, 18);
            this.lbSenha.TabIndex = 3;
            this.lbSenha.Text = "Senha";
            // 
            // txtCampoUsuario
            // 
            this.txtCampoUsuario.Location = new System.Drawing.Point(91, 263);
            this.txtCampoUsuario.Name = "txtCampoUsuario";
            this.txtCampoUsuario.Size = new System.Drawing.Size(184, 20);
            this.txtCampoUsuario.TabIndex = 4;
            this.txtCampoUsuario.Leave += new System.EventHandler(this.txtCampoUsuario_Leave);
            // 
            // txtCampoSenha
            // 
            this.txtCampoSenha.Location = new System.Drawing.Point(91, 297);
            this.txtCampoSenha.Name = "txtCampoSenha";
            this.txtCampoSenha.Size = new System.Drawing.Size(184, 20);
            this.txtCampoSenha.TabIndex = 5;
            this.txtCampoSenha.UseSystemPasswordChar = true;
            this.txtCampoSenha.Leave += new System.EventHandler(this.txtCampoSenha_Leave);
            // 
            // btnLogar
            // 
            this.btnLogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogar.Enabled = false;
            this.btnLogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogar.Image = ((System.Drawing.Image)(resources.GetObject("btnLogar.Image")));
            this.btnLogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogar.Location = new System.Drawing.Point(53, 363);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(93, 38);
            this.btnLogar.TabIndex = 6;
            this.btnLogar.Text = "Logar";
            this.btnLogar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(196, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 38);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacoes.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes.Cursor = System.Windows.Forms.Cursors.Help;
            this.txtObservacoes.Enabled = false;
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.ForeColor = System.Drawing.Color.Red;
            this.txtObservacoes.Location = new System.Drawing.Point(53, 330);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(235, 20);
            this.txtObservacoes.TabIndex = 8;
            this.txtObservacoes.Visible = false;
            // 
            // imgOK_usuario
            // 
            this.imgOK_usuario.Enabled = false;
            this.imgOK_usuario.Image = ((System.Drawing.Image)(resources.GetObject("imgOK_usuario.Image")));
            this.imgOK_usuario.Location = new System.Drawing.Point(282, 265);
            this.imgOK_usuario.Name = "imgOK_usuario";
            this.imgOK_usuario.Size = new System.Drawing.Size(16, 16);
            this.imgOK_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgOK_usuario.TabIndex = 9;
            this.imgOK_usuario.TabStop = false;
            this.imgOK_usuario.Visible = false;
            // 
            // imgOK_senha
            // 
            this.imgOK_senha.Enabled = false;
            this.imgOK_senha.Image = ((System.Drawing.Image)(resources.GetObject("imgOK_senha.Image")));
            this.imgOK_senha.Location = new System.Drawing.Point(282, 299);
            this.imgOK_senha.Name = "imgOK_senha";
            this.imgOK_senha.Size = new System.Drawing.Size(16, 16);
            this.imgOK_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgOK_senha.TabIndex = 10;
            this.imgOK_senha.TabStop = false;
            this.imgOK_senha.Visible = false;
            // 
            // telaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(345, 436);
            this.Controls.Add(this.imgOK_senha);
            this.Controls.Add(this.imgOK_usuario);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtCampoSenha);
            this.Controls.Add(this.txtCampoUsuario);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.imgLogotipo);
            this.Controls.Add(this.lbCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaLogin";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.telaLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogotipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOK_senha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCabecalho;
        private System.Windows.Forms.PictureBox imgLogotipo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtCampoUsuario;
        private System.Windows.Forms.TextBox txtCampoSenha;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.PictureBox imgOK_usuario;
        private System.Windows.Forms.PictureBox imgOK_senha;
    }
}

