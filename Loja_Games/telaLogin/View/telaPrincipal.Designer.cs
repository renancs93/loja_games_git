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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJogos
            // 
            this.btnJogos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJogos.BackColor = System.Drawing.Color.Black;
            this.btnJogos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogos.ForeColor = System.Drawing.Color.Red;
            this.btnJogos.Location = new System.Drawing.Point(545, 155);
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
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Silver;
            this.btnSair.Location = new System.Drawing.Point(571, 372);
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
            this.btnVenda.Location = new System.Drawing.Point(545, 195);
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
            // btnRelatorios
            // 
            this.btnRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatorios.BackColor = System.Drawing.Color.Black;
            this.btnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.Red;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(545, 235);
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
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.BackColor = System.Drawing.Color.Black;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Red;
            this.btnClientes.Location = new System.Drawing.Point(545, 71);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(119, 36);
            this.btnClientes.TabIndex = 10;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Visible = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.MouseEnter += new System.EventHandler(this.btnClientes_MouseEnter);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnClientes_MouseLeave);
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFuncionarios.BackColor = System.Drawing.Color.Black;
            this.btnFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.Red;
            this.btnFuncionarios.Location = new System.Drawing.Point(545, 113);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(119, 36);
            this.btnFuncionarios.TabIndex = 11;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Visible = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            this.btnFuncionarios.MouseEnter += new System.EventHandler(this.btnFuncionarios_MouseEnter);
            this.btnFuncionarios.MouseLeave += new System.EventHandler(this.btnFuncionarios_MouseLeave);
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
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLogarUsuario);
            this.Controls.Add(this.barraProgresso);
            this.Controls.Add(this.btnJogos);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "telaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaPrincipal_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Button btnLogarUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFuncionarios;
    }
}