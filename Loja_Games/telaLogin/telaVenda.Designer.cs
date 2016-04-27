namespace LojaGames
{
    partial class telaVenda
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
            this.abaVenda = new System.Windows.Forms.TabPage();
            this.gbpDadoVenda = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.dgvDescreveProdutos = new System.Windows.Forms.DataGridView();
            this.dgvtbcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorTotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.lblCodigoVenda = new System.Windows.Forms.Label();
            this.abaAluguel = new System.Windows.Forms.TabPage();
            this.pcbLogoGame = new System.Windows.Forms.PictureBox();
            this.gbAlug = new System.Windows.Forms.GroupBox();
            this.lbCodAlug = new System.Windows.Forms.Label();
            this.lbCodProdAlug = new System.Windows.Forms.Label();
            this.lbCpfAlug = new System.Windows.Forms.Label();
            this.lbDiasAlug = new System.Windows.Forms.Label();
            this.lbCodFunAlug = new System.Windows.Forms.Label();
            this.txtCodAlug = new System.Windows.Forms.TextBox();
            this.txtCpfAlug = new System.Windows.Forms.TextBox();
            this.txtCodProdAlug = new System.Windows.Forms.TextBox();
            this.txtDiasAlug = new System.Windows.Forms.TextBox();
            this.txtCodFuncAlug = new System.Windows.Forms.TextBox();
            this.btnRemAlug = new System.Windows.Forms.Button();
            this.btnAddAlug = new System.Windows.Forms.Button();
            this.dgvAlug = new System.Windows.Forms.DataGridView();
            this.btnCancAlug = new System.Windows.Forms.Button();
            this.btnFinAlug = new System.Windows.Forms.Button();
            this.lbDescAlug = new System.Windows.Forms.Label();
            this.lbJurAlug = new System.Windows.Forms.Label();
            this.lbTotAlug = new System.Windows.Forms.Label();
            this.txtDescAlug = new System.Windows.Forms.TextBox();
            this.txtJurAlug = new System.Windows.Forms.TextBox();
            this.txtTotAlug = new System.Windows.Forms.TextBox();
            this.dgvCodAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiasAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.abaVenda.SuspendLayout();
            this.gbpDadoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).BeginInit();
            this.abaAluguel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).BeginInit();
            this.gbAlug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlug)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.abaVenda);
            this.tabControl1.Controls.Add(this.abaAluguel);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(745, 365);
            this.tabControl1.TabIndex = 0;
            // 
            // abaVenda
            // 
            this.abaVenda.Controls.Add(this.gbpDadoVenda);
            this.abaVenda.Location = new System.Drawing.Point(4, 22);
            this.abaVenda.Margin = new System.Windows.Forms.Padding(2);
            this.abaVenda.Name = "abaVenda";
            this.abaVenda.Padding = new System.Windows.Forms.Padding(2);
            this.abaVenda.Size = new System.Drawing.Size(737, 339);
            this.abaVenda.TabIndex = 0;
            this.abaVenda.Text = "Venda";
            this.abaVenda.UseVisualStyleBackColor = true;
            this.abaVenda.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // gbpDadoVenda
            // 
            this.gbpDadoVenda.Controls.Add(this.txtQuantidade);
            this.gbpDadoVenda.Controls.Add(this.lblQuantidade);
            this.gbpDadoVenda.Controls.Add(this.lblJuros);
            this.gbpDadoVenda.Controls.Add(this.txtJuros);
            this.gbpDadoVenda.Controls.Add(this.lblTotalCompra);
            this.gbpDadoVenda.Controls.Add(this.lblDesconto);
            this.gbpDadoVenda.Controls.Add(this.txtTotalCompra);
            this.gbpDadoVenda.Controls.Add(this.txtDesconto);
            this.gbpDadoVenda.Controls.Add(this.btnAdicionarItem);
            this.gbpDadoVenda.Controls.Add(this.txtCodigoFuncionario);
            this.gbpDadoVenda.Controls.Add(this.lblCodigoFuncionario);
            this.gbpDadoVenda.Controls.Add(this.btnCancelar);
            this.gbpDadoVenda.Controls.Add(this.btnRemoverItem);
            this.gbpDadoVenda.Controls.Add(this.btnFinalizarVenda);
            this.gbpDadoVenda.Controls.Add(this.txtCodigoProduto);
            this.gbpDadoVenda.Controls.Add(this.lblCodigoProduto);
            this.gbpDadoVenda.Controls.Add(this.dgvDescreveProdutos);
            this.gbpDadoVenda.Controls.Add(this.txtCpf);
            this.gbpDadoVenda.Controls.Add(this.lblCpfCliente);
            this.gbpDadoVenda.Controls.Add(this.txtCodigoVenda);
            this.gbpDadoVenda.Controls.Add(this.lblCodigoVenda);
            this.gbpDadoVenda.Location = new System.Drawing.Point(4, 5);
            this.gbpDadoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.gbpDadoVenda.Name = "gbpDadoVenda";
            this.gbpDadoVenda.Padding = new System.Windows.Forms.Padding(2);
            this.gbpDadoVenda.Size = new System.Drawing.Size(731, 332);
            this.gbpDadoVenda.TabIndex = 9;
            this.gbpDadoVenda.TabStop = false;
            this.gbpDadoVenda.Text = "Dados Venda";
            this.gbpDadoVenda.Enter += new System.EventHandler(this.gbpDadoVenda_Enter);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(288, 76);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(76, 20);
            this.txtQuantidade.TabIndex = 21;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(212, 77);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(71, 13);
            this.lblQuantidade.TabIndex = 20;
            this.lblQuantidade.Text = "Quantidade : ";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(522, 286);
            this.lblJuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(49, 13);
            this.lblJuros.TabIndex = 19;
            this.lblJuros.Text = "Juros % :";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(606, 286);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(76, 20);
            this.txtJuros.TabIndex = 18;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Location = new System.Drawing.Point(522, 313);
            this.lblTotalCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(79, 13);
            this.lblTotalCompra.TabIndex = 17;
            this.lblTotalCompra.Text = "Total Compra : ";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(522, 261);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(70, 13);
            this.lblDesconto.TabIndex = 16;
            this.lblDesconto.Text = "Desconto % :";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Location = new System.Drawing.Point(606, 309);
            this.txtTotalCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(76, 20);
            this.txtTotalCompra.TabIndex = 15;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(606, 261);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(76, 20);
            this.txtDesconto.TabIndex = 14;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(392, 77);
            this.btnAdicionarItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(95, 29);
            this.btnAdicionarItem.TabIndex = 12;
            this.btnAdicionarItem.Text = "Adiconar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(544, 44);
            this.txtCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(77, 20);
            this.txtCodigoFuncionario.TabIndex = 11;
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(433, 44);
            this.lblCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(107, 13);
            this.lblCodigoFuncionario.TabIndex = 10;
            this.lblCodigoFuncionario.Text = "Código Funcionario : ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(8, 277);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 29);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(512, 77);
            this.btnRemoverItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(107, 29);
            this.btnRemoverItem.TabIndex = 8;
            this.btnRemoverItem.Text = "Remover Item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(123, 277);
            this.btnFinalizarVenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(100, 29);
            this.btnFinalizarVenda.TabIndex = 7;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(92, 77);
            this.txtCodigoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(76, 20);
            this.txtCodigoProduto.TabIndex = 6;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(5, 77);
            this.lblCodigoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoProduto.TabIndex = 5;
            this.lblCodigoProduto.Text = "Código Produto : ";
            // 
            // dgvDescreveProdutos
            // 
            this.dgvDescreveProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescreveProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigo,
            this.dgvtbcDescricao,
            this.dgvtbcQuantidade,
            this.dgvtbcValorUnitario,
            this.dgvtbcValorTotalItem});
            this.dgvDescreveProdutos.Location = new System.Drawing.Point(8, 120);
            this.dgvDescreveProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDescreveProdutos.Name = "dgvDescreveProdutos";
            this.dgvDescreveProdutos.RowTemplate.Height = 24;
            this.dgvDescreveProdutos.Size = new System.Drawing.Size(700, 122);
            this.dgvDescreveProdutos.TabIndex = 4;
            // 
            // dgvtbcCodigo
            // 
            this.dgvtbcCodigo.HeaderText = "Codigo";
            this.dgvtbcCodigo.Name = "dgvtbcCodigo";
            // 
            // dgvtbcDescricao
            // 
            this.dgvtbcDescricao.HeaderText = "Descrição";
            this.dgvtbcDescricao.Name = "dgvtbcDescricao";
            // 
            // dgvtbcQuantidade
            // 
            this.dgvtbcQuantidade.HeaderText = "Quantidade";
            this.dgvtbcQuantidade.Name = "dgvtbcQuantidade";
            // 
            // dgvtbcValorUnitario
            // 
            this.dgvtbcValorUnitario.HeaderText = "Valor Unitario";
            this.dgvtbcValorUnitario.Name = "dgvtbcValorUnitario";
            // 
            // dgvtbcValorTotalItem
            // 
            this.dgvtbcValorTotalItem.HeaderText = "Valor Total Item";
            this.dgvtbcValorTotalItem.Name = "dgvtbcValorTotalItem";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(290, 44);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(106, 20);
            this.txtCpf.TabIndex = 3;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(212, 44);
            this.lblCpfCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(74, 13);
            this.lblCpfCliente.TabIndex = 2;
            this.lblCpfCliente.Text = "CPF Cliente  : ";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(92, 44);
            this.txtCodigoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(98, 20);
            this.txtCodigoVenda.TabIndex = 1;
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Location = new System.Drawing.Point(5, 44);
            this.lblCodigoVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoVenda.TabIndex = 0;
            this.lblCodigoVenda.Text = "Código Venda : ";
            // 
            // abaAluguel
            // 
            this.abaAluguel.Controls.Add(this.gbAlug);
            this.abaAluguel.Location = new System.Drawing.Point(4, 22);
            this.abaAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.abaAluguel.Name = "abaAluguel";
            this.abaAluguel.Padding = new System.Windows.Forms.Padding(2);
            this.abaAluguel.Size = new System.Drawing.Size(737, 339);
            this.abaAluguel.TabIndex = 1;
            this.abaAluguel.Text = "Aluguel";
            this.abaAluguel.UseVisualStyleBackColor = true;
            // 
            // pcbLogoGame
            // 
            this.pcbLogoGame.Image = global::Loja_games.Properties.Resources.img_game_logo;
            this.pcbLogoGame.Location = new System.Drawing.Point(26, 381);
            this.pcbLogoGame.Name = "pcbLogoGame";
            this.pcbLogoGame.Size = new System.Drawing.Size(130, 50);
            this.pcbLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoGame.TabIndex = 1;
            this.pcbLogoGame.TabStop = false;
            // 
            // gbAlug
            // 
            this.gbAlug.Controls.Add(this.txtTotAlug);
            this.gbAlug.Controls.Add(this.txtJurAlug);
            this.gbAlug.Controls.Add(this.txtDescAlug);
            this.gbAlug.Controls.Add(this.lbTotAlug);
            this.gbAlug.Controls.Add(this.lbJurAlug);
            this.gbAlug.Controls.Add(this.lbDescAlug);
            this.gbAlug.Controls.Add(this.btnFinAlug);
            this.gbAlug.Controls.Add(this.btnCancAlug);
            this.gbAlug.Controls.Add(this.dgvAlug);
            this.gbAlug.Controls.Add(this.btnAddAlug);
            this.gbAlug.Controls.Add(this.btnRemAlug);
            this.gbAlug.Controls.Add(this.txtCodFuncAlug);
            this.gbAlug.Controls.Add(this.txtDiasAlug);
            this.gbAlug.Controls.Add(this.txtCodProdAlug);
            this.gbAlug.Controls.Add(this.txtCpfAlug);
            this.gbAlug.Controls.Add(this.txtCodAlug);
            this.gbAlug.Controls.Add(this.lbCodFunAlug);
            this.gbAlug.Controls.Add(this.lbDiasAlug);
            this.gbAlug.Controls.Add(this.lbCpfAlug);
            this.gbAlug.Controls.Add(this.lbCodProdAlug);
            this.gbAlug.Controls.Add(this.lbCodAlug);
            this.gbAlug.Location = new System.Drawing.Point(3, 5);
            this.gbAlug.Name = "gbAlug";
            this.gbAlug.Size = new System.Drawing.Size(735, 334);
            this.gbAlug.TabIndex = 0;
            this.gbAlug.TabStop = false;
            this.gbAlug.Text = "Dados Aluguel";
            this.gbAlug.Enter += new System.EventHandler(this.gbAlug_Enter);
            // 
            // lbCodAlug
            // 
            this.lbCodAlug.AutoSize = true;
            this.lbCodAlug.Location = new System.Drawing.Point(5, 43);
            this.lbCodAlug.Name = "lbCodAlug";
            this.lbCodAlug.Size = new System.Drawing.Size(84, 13);
            this.lbCodAlug.TabIndex = 0;
            this.lbCodAlug.Text = "Código Aluguel :";
            // 
            // lbCodProdAlug
            // 
            this.lbCodProdAlug.AutoSize = true;
            this.lbCodProdAlug.Location = new System.Drawing.Point(5, 75);
            this.lbCodProdAlug.Name = "lbCodProdAlug";
            this.lbCodProdAlug.Size = new System.Drawing.Size(86, 13);
            this.lbCodProdAlug.TabIndex = 1;
            this.lbCodProdAlug.Text = "Código Produto :";
            // 
            // lbCpfAlug
            // 
            this.lbCpfAlug.AutoSize = true;
            this.lbCpfAlug.Location = new System.Drawing.Point(214, 43);
            this.lbCpfAlug.Name = "lbCpfAlug";
            this.lbCpfAlug.Size = new System.Drawing.Size(68, 13);
            this.lbCpfAlug.TabIndex = 2;
            this.lbCpfAlug.Text = "CPF Cliente :";
            this.lbCpfAlug.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lbDiasAlug
            // 
            this.lbDiasAlug.AutoSize = true;
            this.lbDiasAlug.Location = new System.Drawing.Point(214, 75);
            this.lbDiasAlug.Name = "lbDiasAlug";
            this.lbDiasAlug.Size = new System.Drawing.Size(34, 13);
            this.lbDiasAlug.TabIndex = 3;
            this.lbDiasAlug.Text = "Dias :";
            // 
            // lbCodFunAlug
            // 
            this.lbCodFunAlug.AutoSize = true;
            this.lbCodFunAlug.Location = new System.Drawing.Point(406, 43);
            this.lbCodFunAlug.Name = "lbCodFunAlug";
            this.lbCodFunAlug.Size = new System.Drawing.Size(104, 13);
            this.lbCodFunAlug.TabIndex = 4;
            this.lbCodFunAlug.Text = "Código Funcionário :";
            this.lbCodFunAlug.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtCodAlug
            // 
            this.txtCodAlug.Location = new System.Drawing.Point(97, 40);
            this.txtCodAlug.Name = "txtCodAlug";
            this.txtCodAlug.Size = new System.Drawing.Size(88, 20);
            this.txtCodAlug.TabIndex = 5;
            // 
            // txtCpfAlug
            // 
            this.txtCpfAlug.Location = new System.Drawing.Point(291, 40);
            this.txtCpfAlug.Name = "txtCpfAlug";
            this.txtCpfAlug.Size = new System.Drawing.Size(100, 20);
            this.txtCpfAlug.TabIndex = 6;
            // 
            // txtCodProdAlug
            // 
            this.txtCodProdAlug.Location = new System.Drawing.Point(97, 72);
            this.txtCodProdAlug.Name = "txtCodProdAlug";
            this.txtCodProdAlug.Size = new System.Drawing.Size(76, 20);
            this.txtCodProdAlug.TabIndex = 7;
            // 
            // txtDiasAlug
            // 
            this.txtDiasAlug.Location = new System.Drawing.Point(291, 75);
            this.txtDiasAlug.Name = "txtDiasAlug";
            this.txtDiasAlug.Size = new System.Drawing.Size(66, 20);
            this.txtDiasAlug.TabIndex = 8;
            // 
            // txtCodFuncAlug
            // 
            this.txtCodFuncAlug.Location = new System.Drawing.Point(516, 40);
            this.txtCodFuncAlug.Name = "txtCodFuncAlug";
            this.txtCodFuncAlug.Size = new System.Drawing.Size(81, 20);
            this.txtCodFuncAlug.TabIndex = 9;
            // 
            // btnRemAlug
            // 
            this.btnRemAlug.Location = new System.Drawing.Point(516, 75);
            this.btnRemAlug.Name = "btnRemAlug";
            this.btnRemAlug.Size = new System.Drawing.Size(98, 29);
            this.btnRemAlug.TabIndex = 10;
            this.btnRemAlug.Text = "Remover Item";
            this.btnRemAlug.UseVisualStyleBackColor = true;
            // 
            // btnAddAlug
            // 
            this.btnAddAlug.Location = new System.Drawing.Point(398, 75);
            this.btnAddAlug.Name = "btnAddAlug";
            this.btnAddAlug.Size = new System.Drawing.Size(98, 29);
            this.btnAddAlug.TabIndex = 11;
            this.btnAddAlug.Text = "Adicionar Item";
            this.btnAddAlug.UseVisualStyleBackColor = true;
            // 
            // dgvAlug
            // 
            this.dgvAlug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlug.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodAlug,
            this.dgvDescAlug,
            this.dgvDiasAlug,
            this.dgvValorAlug});
            this.dgvAlug.Location = new System.Drawing.Point(7, 114);
            this.dgvAlug.Name = "dgvAlug";
            this.dgvAlug.Size = new System.Drawing.Size(699, 130);
            this.dgvAlug.TabIndex = 12;
            this.dgvAlug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // btnCancAlug
            // 
            this.btnCancAlug.Location = new System.Drawing.Point(8, 271);
            this.btnCancAlug.Name = "btnCancAlug";
            this.btnCancAlug.Size = new System.Drawing.Size(98, 32);
            this.btnCancAlug.TabIndex = 13;
            this.btnCancAlug.Text = "Cancelar";
            this.btnCancAlug.UseVisualStyleBackColor = true;
            // 
            // btnFinAlug
            // 
            this.btnFinAlug.Location = new System.Drawing.Point(121, 271);
            this.btnFinAlug.Name = "btnFinAlug";
            this.btnFinAlug.Size = new System.Drawing.Size(98, 32);
            this.btnFinAlug.TabIndex = 14;
            this.btnFinAlug.Text = "Finalizar Aluguel";
            this.btnFinAlug.UseVisualStyleBackColor = true;
            this.btnFinAlug.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lbDescAlug
            // 
            this.lbDescAlug.AutoSize = true;
            this.lbDescAlug.Location = new System.Drawing.Point(522, 260);
            this.lbDescAlug.Name = "lbDescAlug";
            this.lbDescAlug.Size = new System.Drawing.Size(70, 13);
            this.lbDescAlug.TabIndex = 15;
            this.lbDescAlug.Text = "Desconto % :";
            // 
            // lbJurAlug
            // 
            this.lbJurAlug.AutoSize = true;
            this.lbJurAlug.Location = new System.Drawing.Point(522, 283);
            this.lbJurAlug.Name = "lbJurAlug";
            this.lbJurAlug.Size = new System.Drawing.Size(49, 13);
            this.lbJurAlug.TabIndex = 16;
            this.lbJurAlug.Text = "Juros % :";
            this.lbJurAlug.Click += new System.EventHandler(this.lbJurAlug_Click);
            // 
            // lbTotAlug
            // 
            this.lbTotAlug.AutoSize = true;
            this.lbTotAlug.Location = new System.Drawing.Point(522, 305);
            this.lbTotAlug.Name = "lbTotAlug";
            this.lbTotAlug.Size = new System.Drawing.Size(75, 13);
            this.lbTotAlug.TabIndex = 17;
            this.lbTotAlug.Text = "Total Aluguel :";
            this.lbTotAlug.Click += new System.EventHandler(this.lbTotAlug_Click);
            // 
            // txtDescAlug
            // 
            this.txtDescAlug.Location = new System.Drawing.Point(606, 257);
            this.txtDescAlug.Name = "txtDescAlug";
            this.txtDescAlug.Size = new System.Drawing.Size(75, 20);
            this.txtDescAlug.TabIndex = 18;
            // 
            // txtJurAlug
            // 
            this.txtJurAlug.Location = new System.Drawing.Point(606, 280);
            this.txtJurAlug.Name = "txtJurAlug";
            this.txtJurAlug.Size = new System.Drawing.Size(75, 20);
            this.txtJurAlug.TabIndex = 19;
            // 
            // txtTotAlug
            // 
            this.txtTotAlug.Location = new System.Drawing.Point(606, 305);
            this.txtTotAlug.Name = "txtTotAlug";
            this.txtTotAlug.Size = new System.Drawing.Size(75, 20);
            this.txtTotAlug.TabIndex = 20;
            // 
            // dgvCodAlug
            // 
            this.dgvCodAlug.HeaderText = "Código";
            this.dgvCodAlug.Name = "dgvCodAlug";
            // 
            // dgvDescAlug
            // 
            this.dgvDescAlug.HeaderText = "Descrição";
            this.dgvDescAlug.Name = "dgvDescAlug";
            // 
            // dgvDiasAlug
            // 
            this.dgvDiasAlug.HeaderText = "Dias";
            this.dgvDiasAlug.Name = "dgvDiasAlug";
            // 
            // dgvValorAlug
            // 
            this.dgvValorAlug.HeaderText = "Valor Aluguel";
            this.dgvValorAlug.Name = "dgvValorAlug";
            // 
            // telaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 436);
            this.Controls.Add(this.pcbLogoGame);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "telaVenda";
            this.Text = "telaVenda";
            this.tabControl1.ResumeLayout(false);
            this.abaVenda.ResumeLayout(false);
            this.gbpDadoVenda.ResumeLayout(false);
            this.gbpDadoVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).EndInit();
            this.abaAluguel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).EndInit();
            this.gbAlug.ResumeLayout(false);
            this.gbAlug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage abaVenda;
        private System.Windows.Forms.TabPage abaAluguel;
        private System.Windows.Forms.GroupBox gbpDadoVenda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.DataGridView dgvDescreveProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalItem;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.Label lblCodigoVenda;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.Label lblCodigoFuncionario;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.PictureBox pcbLogoGame;
        private System.Windows.Forms.GroupBox gbAlug;
        private System.Windows.Forms.Label lbCodFunAlug;
        private System.Windows.Forms.Label lbDiasAlug;
        private System.Windows.Forms.Label lbCpfAlug;
        private System.Windows.Forms.Label lbCodProdAlug;
        private System.Windows.Forms.Label lbCodAlug;
        private System.Windows.Forms.TextBox txtCodFuncAlug;
        private System.Windows.Forms.TextBox txtDiasAlug;
        private System.Windows.Forms.TextBox txtCodProdAlug;
        private System.Windows.Forms.TextBox txtCpfAlug;
        private System.Windows.Forms.TextBox txtCodAlug;
        private System.Windows.Forms.Label lbTotAlug;
        private System.Windows.Forms.Label lbJurAlug;
        private System.Windows.Forms.Label lbDescAlug;
        private System.Windows.Forms.Button btnFinAlug;
        private System.Windows.Forms.Button btnCancAlug;
        private System.Windows.Forms.DataGridView dgvAlug;
        private System.Windows.Forms.Button btnAddAlug;
        private System.Windows.Forms.Button btnRemAlug;
        private System.Windows.Forms.TextBox txtTotAlug;
        private System.Windows.Forms.TextBox txtJurAlug;
        private System.Windows.Forms.TextBox txtDescAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiasAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValorAlug;
    }
}