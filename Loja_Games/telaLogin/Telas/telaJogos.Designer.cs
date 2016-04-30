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
            this.abaExibeJogos = new System.Windows.Forms.TabPage();
            this.dGridResultado = new System.Windows.Forms.DataGridView();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnExibirTodos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.gpbGenero = new System.Windows.Forms.GroupBox();
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
            this.gpbConsole = new System.Windows.Forms.GroupBox();
            this.rbtnPc = new System.Windows.Forms.RadioButton();
            this.rbtnPSP = new System.Windows.Forms.RadioButton();
            this.rbtnXbox = new System.Windows.Forms.RadioButton();
            this.gbxBuscar = new System.Windows.Forms.GroupBox();
            this.txtCampoBusca = new System.Windows.Forms.TextBox();
            this.btnBuscarNome = new System.Windows.Forms.Button();
            this.lbNomeDoJogo = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbPreco = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpbTipoJogo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paginaAbasJogos.SuspendLayout();
            this.abaCadastraJogos.SuspendLayout();
            this.abaExibeJogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.gpbTipo.SuspendLayout();
            this.gpbGenero.SuspendLayout();
            this.gpbConsole.SuspendLayout();
            this.gbxBuscar.SuspendLayout();
            this.gpbTipoJogo.SuspendLayout();
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
            this.abaCadastraJogos.Controls.Add(this.gpbTipoJogo);
            this.abaCadastraJogos.Controls.Add(this.textBox1);
            this.abaCadastraJogos.Controls.Add(this.lbPreco);
            this.abaCadastraJogos.Controls.Add(this.txtNome);
            this.abaCadastraJogos.Controls.Add(this.lbNome);
            this.abaCadastraJogos.Location = new System.Drawing.Point(4, 22);
            this.abaCadastraJogos.Name = "abaCadastraJogos";
            this.abaCadastraJogos.Padding = new System.Windows.Forms.Padding(3);
            this.abaCadastraJogos.Size = new System.Drawing.Size(766, 465);
            this.abaCadastraJogos.TabIndex = 0;
            this.abaCadastraJogos.Text = "Cadastrar Jogo";
            this.abaCadastraJogos.UseVisualStyleBackColor = true;
            // 
            // abaExibeJogos
            // 
            this.abaExibeJogos.BackColor = System.Drawing.SystemColors.Control;
            this.abaExibeJogos.Controls.Add(this.btnEditar);
            this.abaExibeJogos.Controls.Add(this.dGridResultado);
            this.abaExibeJogos.Controls.Add(this.imgLogo);
            this.abaExibeJogos.Controls.Add(this.btnExibirTodos);
            this.abaExibeJogos.Controls.Add(this.btnSair);
            this.abaExibeJogos.Controls.Add(this.gpbTipo);
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
            this.dGridResultado.Location = new System.Drawing.Point(9, 183);
            this.dGridResultado.Name = "dGridResultado";
            this.dGridResultado.Size = new System.Drawing.Size(743, 248);
            this.dGridResultado.TabIndex = 5;
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(9, 434);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(96, 28);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 1;
            this.imgLogo.TabStop = false;
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExibirTodos.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirTodos.Location = new System.Drawing.Point(483, 437);
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
            this.btnSair.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(666, 437);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.btnLimpar);
            this.gpbTipo.Controls.Add(this.btnBuscarTipo);
            this.gpbTipo.Controls.Add(this.gpbGenero);
            this.gpbTipo.Controls.Add(this.gpbConsole);
            this.gpbTipo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipo.ForeColor = System.Drawing.Color.Black;
            this.gpbTipo.Location = new System.Drawing.Point(9, 70);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(749, 97);
            this.gpbTipo.TabIndex = 2;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(658, 60);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 27);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarTipo.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarTipo.Location = new System.Drawing.Point(658, 24);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(75, 27);
            this.btnBuscarTipo.TabIndex = 4;
            this.btnBuscarTipo.Text = "Buscar";
            this.btnBuscarTipo.UseVisualStyleBackColor = true;
            // 
            // gpbGenero
            // 
            this.gpbGenero.Controls.Add(this.cboxPuzzle);
            this.gpbGenero.Controls.Add(this.cboxTiro);
            this.gpbGenero.Controls.Add(this.cboxEstrategia);
            this.gpbGenero.Controls.Add(this.cboxMusicalRitmico);
            this.gpbGenero.Controls.Add(this.cboxLuta);
            this.gpbGenero.Controls.Add(this.cboxPlataforma);
            this.gpbGenero.Controls.Add(this.cboxCorrida);
            this.gpbGenero.Controls.Add(this.cboxEsportes);
            this.gpbGenero.Controls.Add(this.cboxRpg);
            this.gpbGenero.Controls.Add(this.cboxAcaoAventura);
            this.gpbGenero.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGenero.ForeColor = System.Drawing.Color.Black;
            this.gpbGenero.Location = new System.Drawing.Point(187, 18);
            this.gpbGenero.Name = "gpbGenero";
            this.gpbGenero.Size = new System.Drawing.Size(467, 73);
            this.gpbGenero.TabIndex = 3;
            this.gpbGenero.TabStop = false;
            this.gpbGenero.Text = "Gênero";
            // 
            // cboxPuzzle
            // 
            this.cboxPuzzle.AutoSize = true;
            this.cboxPuzzle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPuzzle.ForeColor = System.Drawing.Color.Black;
            this.cboxPuzzle.Location = new System.Drawing.Point(395, 42);
            this.cboxPuzzle.Name = "cboxPuzzle";
            this.cboxPuzzle.Size = new System.Drawing.Size(69, 18);
            this.cboxPuzzle.TabIndex = 12;
            this.cboxPuzzle.Text = "Puzzle";
            this.cboxPuzzle.UseVisualStyleBackColor = true;
            // 
            // cboxTiro
            // 
            this.cboxTiro.AutoSize = true;
            this.cboxTiro.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTiro.ForeColor = System.Drawing.Color.Black;
            this.cboxTiro.Location = new System.Drawing.Point(395, 20);
            this.cboxTiro.Name = "cboxTiro";
            this.cboxTiro.Size = new System.Drawing.Size(52, 18);
            this.cboxTiro.TabIndex = 11;
            this.cboxTiro.Text = "Tiro";
            this.cboxTiro.UseVisualStyleBackColor = true;
            // 
            // cboxEstrategia
            // 
            this.cboxEstrategia.AutoSize = true;
            this.cboxEstrategia.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEstrategia.ForeColor = System.Drawing.Color.Black;
            this.cboxEstrategia.Location = new System.Drawing.Point(210, 42);
            this.cboxEstrategia.Name = "cboxEstrategia";
            this.cboxEstrategia.Size = new System.Drawing.Size(93, 18);
            this.cboxEstrategia.TabIndex = 10;
            this.cboxEstrategia.Text = "Estratégia";
            this.cboxEstrategia.UseVisualStyleBackColor = true;
            // 
            // cboxMusicalRitmico
            // 
            this.cboxMusicalRitmico.AutoSize = true;
            this.cboxMusicalRitmico.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMusicalRitmico.ForeColor = System.Drawing.Color.Black;
            this.cboxMusicalRitmico.Location = new System.Drawing.Point(312, 42);
            this.cboxMusicalRitmico.Name = "cboxMusicalRitmico";
            this.cboxMusicalRitmico.Size = new System.Drawing.Size(75, 18);
            this.cboxMusicalRitmico.TabIndex = 9;
            this.cboxMusicalRitmico.Text = "Musical";
            this.cboxMusicalRitmico.UseVisualStyleBackColor = true;
            // 
            // cboxLuta
            // 
            this.cboxLuta.AutoSize = true;
            this.cboxLuta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLuta.ForeColor = System.Drawing.Color.Black;
            this.cboxLuta.Location = new System.Drawing.Point(312, 20);
            this.cboxLuta.Name = "cboxLuta";
            this.cboxLuta.Size = new System.Drawing.Size(55, 18);
            this.cboxLuta.TabIndex = 8;
            this.cboxLuta.Text = "Luta";
            this.cboxLuta.UseVisualStyleBackColor = true;
            // 
            // cboxPlataforma
            // 
            this.cboxPlataforma.AutoSize = true;
            this.cboxPlataforma.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPlataforma.ForeColor = System.Drawing.Color.Black;
            this.cboxPlataforma.Location = new System.Drawing.Point(210, 20);
            this.cboxPlataforma.Name = "cboxPlataforma";
            this.cboxPlataforma.Size = new System.Drawing.Size(99, 18);
            this.cboxPlataforma.TabIndex = 7;
            this.cboxPlataforma.Text = "Plataforma";
            this.cboxPlataforma.UseVisualStyleBackColor = true;
            // 
            // cboxCorrida
            // 
            this.cboxCorrida.AutoSize = true;
            this.cboxCorrida.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCorrida.ForeColor = System.Drawing.Color.Black;
            this.cboxCorrida.Location = new System.Drawing.Point(129, 42);
            this.cboxCorrida.Name = "cboxCorrida";
            this.cboxCorrida.Size = new System.Drawing.Size(75, 18);
            this.cboxCorrida.TabIndex = 6;
            this.cboxCorrida.Text = "Corrida";
            this.cboxCorrida.UseVisualStyleBackColor = true;
            // 
            // cboxEsportes
            // 
            this.cboxEsportes.AutoSize = true;
            this.cboxEsportes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEsportes.ForeColor = System.Drawing.Color.Black;
            this.cboxEsportes.Location = new System.Drawing.Point(129, 20);
            this.cboxEsportes.Name = "cboxEsportes";
            this.cboxEsportes.Size = new System.Drawing.Size(83, 18);
            this.cboxEsportes.TabIndex = 5;
            this.cboxEsportes.Text = "Esportes";
            this.cboxEsportes.UseVisualStyleBackColor = true;
            // 
            // cboxRpg
            // 
            this.cboxRpg.AutoSize = true;
            this.cboxRpg.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRpg.ForeColor = System.Drawing.Color.Black;
            this.cboxRpg.Location = new System.Drawing.Point(6, 42);
            this.cboxRpg.Name = "cboxRpg";
            this.cboxRpg.Size = new System.Drawing.Size(54, 18);
            this.cboxRpg.TabIndex = 4;
            this.cboxRpg.Text = "RPG";
            this.cboxRpg.UseVisualStyleBackColor = true;
            // 
            // cboxAcaoAventura
            // 
            this.cboxAcaoAventura.AutoSize = true;
            this.cboxAcaoAventura.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxAcaoAventura.ForeColor = System.Drawing.Color.Black;
            this.cboxAcaoAventura.Location = new System.Drawing.Point(6, 20);
            this.cboxAcaoAventura.Name = "cboxAcaoAventura";
            this.cboxAcaoAventura.Size = new System.Drawing.Size(126, 18);
            this.cboxAcaoAventura.TabIndex = 3;
            this.cboxAcaoAventura.Text = "Ação/Aventura";
            this.cboxAcaoAventura.UseVisualStyleBackColor = true;
            // 
            // gpbConsole
            // 
            this.gpbConsole.Controls.Add(this.rbtnPc);
            this.gpbConsole.Controls.Add(this.rbtnPSP);
            this.gpbConsole.Controls.Add(this.rbtnXbox);
            this.gpbConsole.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConsole.ForeColor = System.Drawing.Color.Black;
            this.gpbConsole.Location = new System.Drawing.Point(7, 24);
            this.gpbConsole.Name = "gpbConsole";
            this.gpbConsole.Size = new System.Drawing.Size(174, 67);
            this.gpbConsole.TabIndex = 2;
            this.gpbConsole.TabStop = false;
            this.gpbConsole.Text = "Console";
            // 
            // rbtnPc
            // 
            this.rbtnPc.AutoSize = true;
            this.rbtnPc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPc.ForeColor = System.Drawing.Color.Black;
            this.rbtnPc.Location = new System.Drawing.Point(122, 26);
            this.rbtnPc.Name = "rbtnPc";
            this.rbtnPc.Size = new System.Drawing.Size(45, 20);
            this.rbtnPc.TabIndex = 2;
            this.rbtnPc.TabStop = true;
            this.rbtnPc.Text = "PC";
            this.rbtnPc.UseVisualStyleBackColor = true;
            // 
            // rbtnPSP
            // 
            this.rbtnPSP.AutoSize = true;
            this.rbtnPSP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPSP.ForeColor = System.Drawing.Color.Black;
            this.rbtnPSP.Location = new System.Drawing.Point(3, 26);
            this.rbtnPSP.Name = "rbtnPSP";
            this.rbtnPSP.Size = new System.Drawing.Size(53, 20);
            this.rbtnPSP.TabIndex = 0;
            this.rbtnPSP.TabStop = true;
            this.rbtnPSP.Text = "PSP";
            this.rbtnPSP.UseVisualStyleBackColor = true;
            // 
            // rbtnXbox
            // 
            this.rbtnXbox.AutoSize = true;
            this.rbtnXbox.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnXbox.ForeColor = System.Drawing.Color.Black;
            this.rbtnXbox.Location = new System.Drawing.Point(59, 26);
            this.rbtnXbox.Name = "rbtnXbox";
            this.rbtnXbox.Size = new System.Drawing.Size(63, 20);
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
            this.gbxBuscar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBuscar.ForeColor = System.Drawing.Color.Black;
            this.gbxBuscar.Location = new System.Drawing.Point(8, 6);
            this.gbxBuscar.Name = "gbxBuscar";
            this.gbxBuscar.Size = new System.Drawing.Size(750, 58);
            this.gbxBuscar.TabIndex = 0;
            this.gbxBuscar.TabStop = false;
            this.gbxBuscar.Text = "Busca por Nome";
            // 
            // txtCampoBusca
            // 
            this.txtCampoBusca.Location = new System.Drawing.Point(122, 23);
            this.txtCampoBusca.Name = "txtCampoBusca";
            this.txtCampoBusca.Size = new System.Drawing.Size(527, 26);
            this.txtCampoBusca.TabIndex = 2;
            // 
            // btnBuscarNome
            // 
            this.btnBuscarNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarNome.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarNome.Location = new System.Drawing.Point(659, 22);
            this.btnBuscarNome.Name = "btnBuscarNome";
            this.btnBuscarNome.Size = new System.Drawing.Size(75, 26);
            this.btnBuscarNome.TabIndex = 1;
            this.btnBuscarNome.Text = "Buscar";
            this.btnBuscarNome.UseVisualStyleBackColor = true;
            this.btnBuscarNome.Click += new System.EventHandler(this.btnBuscarNome_Click);
            // 
            // lbNomeDoJogo
            // 
            this.lbNomeDoJogo.AutoSize = true;
            this.lbNomeDoJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeDoJogo.Location = new System.Drawing.Point(6, 28);
            this.lbNomeDoJogo.Name = "lbNomeDoJogo";
            this.lbNomeDoJogo.Size = new System.Drawing.Size(110, 16);
            this.lbNomeDoJogo.TabIndex = 0;
            this.lbNomeDoJogo.Text = "Nome do Jogo";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(575, 437);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(8, 23);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 16);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(68, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(352, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(439, 25);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(54, 16);
            this.lbPreco.TabIndex = 2;
            this.lbPreco.Text = "Preço:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(499, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "R$";
            // 
            // gpbTipoJogo
            // 
            this.gpbTipoJogo.Controls.Add(this.groupBox1);
            this.gpbTipoJogo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTipoJogo.Location = new System.Drawing.Point(11, 63);
            this.gpbTipoJogo.Name = "gpbTipoJogo";
            this.gpbTipoJogo.Size = new System.Drawing.Size(749, 97);
            this.gpbTipoJogo.TabIndex = 4;
            this.gpbTipoJogo.TabStop = false;
            this.gpbTipoJogo.Text = "Tipo";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console";
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
            this.gpbTipo.ResumeLayout(false);
            this.gpbGenero.ResumeLayout(false);
            this.gpbGenero.PerformLayout();
            this.gpbConsole.ResumeLayout(false);
            this.gpbConsole.PerformLayout();
            this.gbxBuscar.ResumeLayout(false);
            this.gbxBuscar.PerformLayout();
            this.gpbTipoJogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl paginaAbasJogos;
        private System.Windows.Forms.TabPage abaCadastraJogos;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.TabPage abaExibeJogos;
        private System.Windows.Forms.GroupBox gbxBuscar;
        private System.Windows.Forms.Button btnExibirTodos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.Button btnBuscarNome;
        private System.Windows.Forms.Label lbNomeDoJogo;
        private System.Windows.Forms.GroupBox gpbConsole;
        private System.Windows.Forms.RadioButton rbtnPSP;
        private System.Windows.Forms.RadioButton rbtnXbox;
        private System.Windows.Forms.GroupBox gpbGenero;
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gpbTipoJogo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}