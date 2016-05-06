namespace LojaGames
{
    partial class telaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            this.btnJogos = new System.Windows.Forms.Button();
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.btnLogarUsuario = new System.Windows.Forms.Button();
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnBuscaExibir = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJogos
            // 
            this.btnJogos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogos.BackColor = System.Drawing.Color.Black;
            this.btnJogos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogos.ForeColor = System.Drawing.Color.Red;
            this.btnJogos.Location = new System.Drawing.Point(545, 54);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(119, 35);
            this.btnJogos.TabIndex = 1;
            this.btnJogos.Text = "Jogos";
            this.btnJogos.UseVisualStyleBackColor = false;
            this.btnJogos.Visible = false;
            this.btnJogos.Click += new System.EventHandler(this.btnJogos_Click);
            this.btnJogos.MouseEnter += new System.EventHandler(this.btnJogos_MouseEnter);
            this.btnJogos.MouseLeave += new System.EventHandler(this.btnJogos_MouseLeave);
            // 
            // barraProgresso
            // 
            this.barraProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.barraProgresso.Enabled = false;
            this.barraProgresso.Location = new System.Drawing.Point(513, 485);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(220, 10);
            this.barraProgresso.TabIndex = 1;
            // 
            // btnLogarUsuario
            // 
            this.btnLogarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogarUsuario.BackColor = System.Drawing.Color.Gold;
            this.btnLogarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogarUsuario.Location = new System.Drawing.Point(653, 2);
            this.btnLogarUsuario.Name = "btnLogarUsuario";
            this.btnLogarUsuario.Size = new System.Drawing.Size(80, 22);
            this.btnLogarUsuario.TabIndex = 7;
            this.btnLogarUsuario.Text = "Logar";
            this.btnLogarUsuario.UseVisualStyleBackColor = false;
            this.btnLogarUsuario.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastroCliente.BackColor = System.Drawing.Color.Black;
            this.btnCadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.Red;
            this.btnCadastroCliente.Location = new System.Drawing.Point(545, 95);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(119, 45);
            this.btnCadastroCliente.TabIndex = 2;
            this.btnCadastroCliente.Text = "Cadastrar Cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Visible = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            this.btnCadastroCliente.MouseEnter += new System.EventHandler(this.btnCadastroCliente_MouseEnter_1);
            this.btnCadastroCliente.MouseLeave += new System.EventHandler(this.btnCadastroCliente_MouseLeave_1);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Silver;
            this.btnSair.Location = new System.Drawing.Point(590, 365);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 28);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // btnVenda
            // 
            this.btnVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVenda.BackColor = System.Drawing.Color.Black;
            this.btnVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVenda.ForeColor = System.Drawing.Color.Red;
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenda.Location = new System.Drawing.Point(545, 196);
            this.btnVenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(119, 35);
            this.btnVenda.TabIndex = 4;
            this.btnVenda.Text = "Venda / Aluga";
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Visible = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            this.btnVenda.MouseEnter += new System.EventHandler(this.btnVenda_MouseEnter);
            this.btnVenda.MouseLeave += new System.EventHandler(this.btnVenda_MouseLeave);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarFuncionario.BackColor = System.Drawing.Color.Black;
            this.btnCadastrarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.ForeColor = System.Drawing.Color.Red;
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(545, 146);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(119, 45);
            this.btnCadastrarFuncionario.TabIndex = 3;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = false;
            this.btnCadastrarFuncionario.Visible = false;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            this.btnCadastrarFuncionario.MouseEnter += new System.EventHandler(this.btnCadastrarFuncionario_MouseEnter);
            this.btnCadastrarFuncionario.MouseLeave += new System.EventHandler(this.btnCadastrarFuncionario_MouseLeave);
            // 
            // btnLogoff
            // 
            this.btnLogoff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoff.Enabled = false;
            this.btnLogoff.Location = new System.Drawing.Point(679, 24);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(53, 21);
            this.btnLogoff.TabIndex = 8;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnBuscaExibir
            // 
            this.btnBuscaExibir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscaExibir.BackColor = System.Drawing.Color.Black;
            this.btnBuscaExibir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaExibir.ForeColor = System.Drawing.Color.Red;
            this.btnBuscaExibir.Location = new System.Drawing.Point(454, 127);
            this.btnBuscaExibir.Name = "btnBuscaExibir";
            this.btnBuscaExibir.Size = new System.Drawing.Size(95, 33);
            this.btnBuscaExibir.TabIndex = 5;
            this.btnBuscaExibir.Text = "Busca / Exibir";
            this.btnBuscaExibir.UseVisualStyleBackColor = false;
            this.btnBuscaExibir.Visible = false;
            this.btnBuscaExibir.Click += new System.EventHandler(this.btnBuscaExibir_Click);
            this.btnBuscaExibir.MouseEnter += new System.EventHandler(this.btnBuscaExibir_MouseEnter);
            this.btnBuscaExibir.MouseLeave += new System.EventHandler(this.btnBuscaExibir_MouseLeave);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatorios.BackColor = System.Drawing.Color.Black;
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.Red;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(545, 236);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(119, 36);
            this.btnRelatorios.TabIndex = 6;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Visible = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            this.btnRelatorios.MouseEnter += new System.EventHandler(this.btnRelatorios_MouseEnter);
            this.btnRelatorios.MouseLeave += new System.EventHandler(this.btnRelatorios_MouseLeave);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 497);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroCliente);
            this.Controls.Add(this.btnLogarUsuario);
            this.Controls.Add(this.barraProgresso);
            this.Controls.Add(this.btnJogos);
            this.Controls.Add(this.btnBuscaExibir);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Button btnLogarUsuario;
        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnBuscaExibir;
        private System.Windows.Forms.Button btnRelatorios;
    }
}