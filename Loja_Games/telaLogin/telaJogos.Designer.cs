namespace LojaGames
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
            this.paginaAbasJogos = new System.Windows.Forms.TabControl();
            this.abaCadastraJogos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.abaExibeJogos = new System.Windows.Forms.TabPage();
            this.dGridResultado = new System.Windows.Forms.DataGridView();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnExibirTodos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.gboxGenero = new System.Windows.Forms.GroupBox();
            this.cboxPuzzle = new System.Windows.Forms.CheckBox();
            this.cboxTiro = new System.Windows.Forms.CheckBox();
            this.cboxEstrategia = new System.Windows.Forms.CheckBox();
            this.cboxMusicalRitmico = new System.Windows.Forms.CheckBox();
            this.cboxLuta = new System.Windows.Forms.CheckBox();
            this.cboxPlataforma = new System.Windows.Forms.CheckBox();
            this.cboxCorrida = new System.Windows.Forms.CheckBox();
            this.cboxEsportes = new System.Windows.Forms.CheckBox();
            this.cboxRpg = new System.Windows.Forms.CheckBox();
            this.cboxAcaoAventura = new System.Windows.Forms.CheckBox();
            this.gboxConsole = new System.Windows.Forms.GroupBox();
            this.rbtnPc = new System.Windows.Forms.RadioButton();
            this.rbtnPSP = new System.Windows.Forms.RadioButton();
            this.rbtnXbox = new System.Windows.Forms.RadioButton();
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.txtCampoBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.lbNomeDoJogo = new System.Windows.Forms.Label();
            this.paginaAbasJogos.SuspendLayout();
            this.abaCadastraJogos.SuspendLayout();
            this.abaExibeJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gboxGenero.SuspendLayout();
            this.gboxConsole.SuspendLayout();
            this.gbxBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // paginaAbasJogos
            // 
            this.paginaAbasJogos.Controls.Add(this.abaCadastraJogos);
            this.paginaAbasJogos.Controls.Add(this.abaExibeJogos);
            this.paginaAbasJogos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paginaAbasJogos.Location = new System.Drawing.Point(0, 1);
            this.paginaAbasJogos.Name = "paginaAbasJogos";
            this.paginaAbasJogos.SelectedIndex = 0;
            this.paginaAbasJogos.Size = new System.Drawing.Size(774, 491);
            this.paginaAbasJogos.TabIndex = 0;
            // 
            // abaCadastraJogos
            // 
            this.abaCadastraJogos.Controls.Add(this.label1);
            this.abaCadastraJogos.Location = new System.Drawing.Point(4, 22);
            this.abaCadastraJogos.Name = "abaCadastraJogos";
            this.abaCadastraJogos.Padding = new System.Windows.Forms.Padding(3);
            this.abaCadastraJogos.Size = new System.Drawing.Size(766, 465);
            this.abaCadastraJogos.TabIndex = 0;
            this.abaCadastraJogos.Text = "Cadastrar Jogo";
            this.abaCadastraJogos.UseVisualStyleBackColor = true;
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
            // abaExibeJogos
            // 
            this.abaExibeJogos.BackColor = System.Drawing.SystemColors.Control;
            this.abaExibeJogos.Controls.Add(this.dGridResultado);
            this.abaExibeJogos.Controls.Add(this.imgLogo);
            this.abaExibeJogos.Controls.Add(this.btnExibirTodos);
            this.abaExibeJogos.Controls.Add(this.btnSair);
            this.abaExibeJogos.Controls.Add(this.groupBox1);
            this.abaExibeJogos.Controls.Add(this.gbxBuscar);
            this.abaExibeJogos.Location = new System.Drawing.Point(4, 22);
            this.abaExibeJogos.Name = "abaExibeJogos";
            this.abaExibeJogos.Padding = new System.Windows.Forms.Padding(3);
            this.abaExibeJogos.Size = new System.Drawing.Size(766, 465);
            this.abaExibeJogos.TabIndex = 1;
            this.abaExibeJogos.Text = "Exibir Jogos";
            // 
            // dGridResultado
            // 
            this.dGridResultado.AllowUserToOrderColumns = true;
            this.dGridResultado.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dGridResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridResultado.Location = new System.Drawing.Point(9, 132);
            this.dGridResultado.Name = "dGridResultado";
            this.dGridResultado.Size = new System.Drawing.Size(743, 299);
            this.dGridResultado.TabIndex = 5;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(6, 434);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(96, 28);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirTodos.Location = new System.Drawing.Point(591, 437);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(86, 23);
            this.btnExibirTodos.TabIndex = 4;
            this.btnExibirTodos.Text = "Exibir Todos";
            this.btnExibirTodos.UseVisualStyleBackColor = true;
            this.btnExibirTodos.Click += new System.EventHandler(this.btnExibirTodos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Location = new System.Drawing.Point(683, 437);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnBuscarTipo);
            this.groupBox1.Controls.Add(this.gboxGenero);
            this.groupBox1.Controls.Add(this.gboxConsole);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(9, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(654, 45);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarTipo.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarTipo.Location = new System.Drawing.Point(654, 15);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTipo.TabIndex = 4;
            this.btnBuscarTipo.Text = "Buscar";
            this.btnBuscarTipo.UseVisualStyleBackColor = true;
            // 
            // gboxGenero
            // 
            this.gboxGenero.Controls.Add(this.cboxPuzzle);
            this.gboxGenero.Controls.Add(this.cboxTiro);
            this.gboxGenero.Controls.Add(this.cboxEstrategia);
            this.gboxGenero.Controls.Add(this.cboxMusicalRitmico);
            this.gboxGenero.Controls.Add(this.cboxLuta);
            this.gboxGenero.Controls.Add(this.cboxPlataforma);
            this.gboxGenero.Controls.Add(this.cboxCorrida);
            this.gboxGenero.Controls.Add(this.cboxEsportes);
            this.gboxGenero.Controls.Add(this.cboxRpg);
            this.gboxGenero.Controls.Add(this.cboxAcaoAventura);
            this.gboxGenero.ForeColor = System.Drawing.Color.Black;
            this.gboxGenero.Location = new System.Drawing.Point(184, 9);
            this.gboxGenero.Name = "gboxGenero";
            this.gboxGenero.Size = new System.Drawing.Size(456, 59);
            this.gboxGenero.TabIndex = 3;
            this.gboxGenero.TabStop = false;
            this.gboxGenero.Text = "Gênero";
            // 
            // cboxPuzzle
            // 
            this.cboxPuzzle.AutoSize = true;
            this.cboxPuzzle.ForeColor = System.Drawing.Color.Black;
            this.cboxPuzzle.Location = new System.Drawing.Point(397, 37);
            this.cboxPuzzle.Name = "cboxPuzzle";
            this.cboxPuzzle.Size = new System.Drawing.Size(57, 17);
            this.cboxPuzzle.TabIndex = 12;
            this.cboxPuzzle.Text = "Puzzle";
            this.cboxPuzzle.UseVisualStyleBackColor = true;
            // 
            // cboxTiro
            // 
            this.cboxTiro.AutoSize = true;
            this.cboxTiro.ForeColor = System.Drawing.Color.Black;
            this.cboxTiro.Location = new System.Drawing.Point(397, 14);
            this.cboxTiro.Name = "cboxTiro";
            this.cboxTiro.Size = new System.Drawing.Size(44, 17);
            this.cboxTiro.TabIndex = 11;
            this.cboxTiro.Text = "Tiro";
            this.cboxTiro.UseVisualStyleBackColor = true;
            // 
            // cboxEstrategia
            // 
            this.cboxEstrategia.AutoSize = true;
            this.cboxEstrategia.ForeColor = System.Drawing.Color.Black;
            this.cboxEstrategia.Location = new System.Drawing.Point(290, 14);
            this.cboxEstrategia.Name = "cboxEstrategia";
            this.cboxEstrategia.Size = new System.Drawing.Size(73, 17);
            this.cboxEstrategia.TabIndex = 10;
            this.cboxEstrategia.Text = "Estratégia";
            this.cboxEstrategia.UseVisualStyleBackColor = true;
            // 
            // cboxMusicalRitmico
            // 
            this.cboxMusicalRitmico.AutoSize = true;
            this.cboxMusicalRitmico.ForeColor = System.Drawing.Color.Black;
            this.cboxMusicalRitmico.Location = new System.Drawing.Point(290, 36);
            this.cboxMusicalRitmico.Name = "cboxMusicalRitmico";
            this.cboxMusicalRitmico.Size = new System.Drawing.Size(104, 17);
            this.cboxMusicalRitmico.TabIndex = 9;
            this.cboxMusicalRitmico.Text = "Musical/Rítmico";
            this.cboxMusicalRitmico.UseVisualStyleBackColor = true;
            // 
            // cboxLuta
            // 
            this.cboxLuta.AutoSize = true;
            this.cboxLuta.ForeColor = System.Drawing.Color.Black;
            this.cboxLuta.Location = new System.Drawing.Point(207, 36);
            this.cboxLuta.Name = "cboxLuta";
            this.cboxLuta.Size = new System.Drawing.Size(47, 17);
            this.cboxLuta.TabIndex = 8;
            this.cboxLuta.Text = "Luta";
            this.cboxLuta.UseVisualStyleBackColor = true;
            // 
            // cboxPlataforma
            // 
            this.cboxPlataforma.AutoSize = true;
            this.cboxPlataforma.ForeColor = System.Drawing.Color.Black;
            this.cboxPlataforma.Location = new System.Drawing.Point(207, 14);
            this.cboxPlataforma.Name = "cboxPlataforma";
            this.cboxPlataforma.Size = new System.Drawing.Size(76, 17);
            this.cboxPlataforma.TabIndex = 7;
            this.cboxPlataforma.Text = "Plataforma";
            this.cboxPlataforma.UseVisualStyleBackColor = true;
            // 
            // cboxCorrida
            // 
            this.cboxCorrida.AutoSize = true;
            this.cboxCorrida.ForeColor = System.Drawing.Color.Black;
            this.cboxCorrida.Location = new System.Drawing.Point(121, 36);
            this.cboxCorrida.Name = "cboxCorrida";
            this.cboxCorrida.Size = new System.Drawing.Size(59, 17);
            this.cboxCorrida.TabIndex = 6;
            this.cboxCorrida.Text = "Corrida";
            this.cboxCorrida.UseVisualStyleBackColor = true;
            // 
            // cboxEsportes
            // 
            this.cboxEsportes.AutoSize = true;
            this.cboxEsportes.ForeColor = System.Drawing.Color.Black;
            this.cboxEsportes.Location = new System.Drawing.Point(121, 14);
            this.cboxEsportes.Name = "cboxEsportes";
            this.cboxEsportes.Size = new System.Drawing.Size(67, 17);
            this.cboxEsportes.TabIndex = 5;
            this.cboxEsportes.Text = "Esportes";
            this.cboxEsportes.UseVisualStyleBackColor = true;
            // 
            // cboxRpg
            // 
            this.cboxRpg.AutoSize = true;
            this.cboxRpg.ForeColor = System.Drawing.Color.Black;
            this.cboxRpg.Location = new System.Drawing.Point(6, 36);
            this.cboxRpg.Name = "cboxRpg";
            this.cboxRpg.Size = new System.Drawing.Size(49, 17);
            this.cboxRpg.TabIndex = 4;
            this.cboxRpg.Text = "RPG";
            this.cboxRpg.UseVisualStyleBackColor = true;
            // 
            // cboxAcaoAventura
            // 
            this.cboxAcaoAventura.AutoSize = true;
            this.cboxAcaoAventura.ForeColor = System.Drawing.Color.Black;
            this.cboxAcaoAventura.Location = new System.Drawing.Point(6, 14);
            this.cboxAcaoAventura.Name = "cboxAcaoAventura";
            this.cboxAcaoAventura.Size = new System.Drawing.Size(99, 17);
            this.cboxAcaoAventura.TabIndex = 3;
            this.cboxAcaoAventura.Text = "Ação/Aventura";
            this.cboxAcaoAventura.UseVisualStyleBackColor = true;
            // 
            // gboxConsole
            // 
            this.gboxConsole.Controls.Add(this.rbtnPc);
            this.gboxConsole.Controls.Add(this.rbtnPSP);
            this.gboxConsole.Controls.Add(this.rbtnXbox);
            this.gboxConsole.ForeColor = System.Drawing.Color.Black;
            this.gboxConsole.Location = new System.Drawing.Point(13, 14);
            this.gboxConsole.Name = "gboxConsole";
            this.gboxConsole.Size = new System.Drawing.Size(161, 53);
            this.gboxConsole.TabIndex = 2;
            this.gboxConsole.TabStop = false;
            this.gboxConsole.Text = "Console";
            // 
            // rbtnPc
            // 
            this.rbtnPc.AutoSize = true;
            this.rbtnPc.ForeColor = System.Drawing.Color.Black;
            this.rbtnPc.Location = new System.Drawing.Point(116, 21);
            this.rbtnPc.Name = "rbtnPc";
            this.rbtnPc.Size = new System.Drawing.Size(39, 17);
            this.rbtnPc.TabIndex = 2;
            this.rbtnPc.TabStop = true;
            this.rbtnPc.Text = "PC";
            this.rbtnPc.UseVisualStyleBackColor = true;
            // 
            // rbtnPSP
            // 
            this.rbtnPSP.AutoSize = true;
            this.rbtnPSP.ForeColor = System.Drawing.Color.Black;
            this.rbtnPSP.Location = new System.Drawing.Point(9, 21);
            this.rbtnPSP.Name = "rbtnPSP";
            this.rbtnPSP.Size = new System.Drawing.Size(46, 17);
            this.rbtnPSP.TabIndex = 0;
            this.rbtnPSP.TabStop = true;
            this.rbtnPSP.Text = "PSP";
            this.rbtnPSP.UseVisualStyleBackColor = true;
            // 
            // rbtnXbox
            // 
            this.rbtnXbox.AutoSize = true;
            this.rbtnXbox.ForeColor = System.Drawing.Color.Black;
            this.rbtnXbox.Location = new System.Drawing.Point(61, 21);
            this.rbtnXbox.Name = "rbtnXbox";
            this.rbtnXbox.Size = new System.Drawing.Size(49, 17);
            this.rbtnXbox.TabIndex = 1;
            this.rbtnXbox.TabStop = true;
            this.rbtnXbox.Text = "Xbox";
            this.rbtnXbox.UseVisualStyleBackColor = true;
            // 
            // gbxBuscar
            // 
            this.gbxBuscar.Controls.Add(this.txtCampoBusca);
            this.gbxBuscar.Controls.Add(this.btnBuscarNome);
            this.gbxBuscar.Controls.Add(this.lbNomeDoJogo);
            this.gbxBuscar.ForeColor = System.Drawing.Color.Black;
            this.gbxBuscar.Location = new System.Drawing.Point(8, 6);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(750, 43);
            this.gbxBuscar.TabIndex = 0;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Busca por Nome";
            // 
            // txtCampoBusca
            // 
            this.txtCampoBusca.Location = new System.Drawing.Point(125, 14);
            this.txtCampoBusca.Name = "txtCampoBusca";
            this.txtCampoBusca.Size = new System.Drawing.Size(537, 20);
            this.txtCampoBusca.TabIndex = 2;
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarNome.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarNome.Location = new System.Drawing.Point(669, 12);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNome.TabIndex = 1;
            this.btnBuscarNome.Text = "Buscar";
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            this.btnBuscarNome.Click += new System.EventHandler(this.btnBuscarNome_Click);
            // 
            // lbNomeDoJogo
            // 
            this.lbNomeDoJogo.AutoSize = true;
            this.lbNomeDoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeDoJogo.Location = new System.Drawing.Point(7, 15);
            this.lbNomeDoJogo.Name = "lbNomeDoJogo";
            this.lbNomeDoJogo.Size = new System.Drawing.Size(110, 16);
            this.lbNomeDoJogo.TabIndex = 0;
            this.lbNomeDoJogo.Text = "Nome do Jogo";
            // 
            // telaJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(774, 492);
            this.Controls.Add(this.paginaAbasJogos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "telaJogos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaJogos_FormClosing);
            this.paginaAbasJogos.ResumeLayout(false);
            this.abaCadastraJogos.ResumeLayout(false);
            this.abaCadastraJogos.PerformLayout();
            this.abaExibeJogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gboxGenero.ResumeLayout(false);
            this.gboxGenero.PerformLayout();
            this.gboxConsole.ResumeLayout(false);
            this.gboxConsole.PerformLayout();
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl paginaAbasJogos;
        private System.Windows.Forms.TabPage abaCadastraJogos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.TabPage abaExibeJogos;
        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.Button btnExibirTodos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarNome;
        private System.Windows.Forms.Label lbNomeDoJogo;
        private System.Windows.Forms.GroupBox gboxConsole;
        private System.Windows.Forms.RadioButton rbtnPSP;
        private System.Windows.Forms.RadioButton rbtnXbox;
        private System.Windows.Forms.GroupBox gboxGenero;
        private System.Windows.Forms.CheckBox cboxAcaoAventura;
        private System.Windows.Forms.TextBox txtCampoBusca;
        private System.Windows.Forms.CheckBox cboxRpg;
        private System.Windows.Forms.CheckBox cboxPuzzle;
        private System.Windows.Forms.CheckBox cboxTiro;
        private System.Windows.Forms.CheckBox cboxEstrategia;
        private System.Windows.Forms.CheckBox cboxMusicalRitmico;
        private System.Windows.Forms.CheckBox cboxLuta;
        private System.Windows.Forms.CheckBox cboxPlataforma;
        private System.Windows.Forms.CheckBox cboxCorrida;
        private System.Windows.Forms.CheckBox cboxEsportes;
        private System.Windows.Forms.RadioButton rbtnPc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnBuscarTipo;
        private System.Windows.Forms.DataGridView dGridResultado;
    }
}