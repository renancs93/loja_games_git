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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.abaVenda = new System.Windows.Forms.TabPage();
            this.gbpDadoVenda = new System.Windows.Forms.GroupBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.pcbLogoGame = new System.Windows.Forms.PictureBox();
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
            this.gbAlug = new System.Windows.Forms.GroupBox();
            this.imgLogoAlug = new System.Windows.Forms.PictureBox();
            this.btnFinAlug = new System.Windows.Forms.Button();
            this.btnCancAlug = new System.Windows.Forms.Button();
            this.txtTotalAlug = new System.Windows.Forms.TextBox();
            this.txtJurAlug = new System.Windows.Forms.TextBox();
            this.txtDescAlug = new System.Windows.Forms.TextBox();
            this.lbTotalAlug = new System.Windows.Forms.Label();
            this.lbDescAlug = new System.Windows.Forms.Label();
            this.lbJurAlug = new System.Windows.Forms.Label();
            this.dgvAlug = new System.Windows.Forms.DataGridView();
            this.dgvCodAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiasAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgValorAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemAlug = new System.Windows.Forms.Button();
            this.btnAddAlug = new System.Windows.Forms.Button();
            this.nudDiasAlug = new System.Windows.Forms.NumericUpDown();
            this.txtCodAlug = new System.Windows.Forms.TextBox();
            this.txtFuncAlug = new System.Windows.Forms.TextBox();
            this.txtProdAlug = new System.Windows.Forms.TextBox();
            this.txtCpfCliAlug = new System.Windows.Forms.TextBox();
            this.lbCodAlug = new System.Windows.Forms.Label();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbFuncAlug = new System.Windows.Forms.Label();
            this.lbProdAlug = new System.Windows.Forms.Label();
            this.lbCpfCliAlug = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.abaVenda.SuspendLayout();
            this.gbpDadoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).BeginInit();
            this.abaAluguel.SuspendLayout();
            this.gbAlug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoAlug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasAlug)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.abaVenda);
            this.tabControl1.Controls.Add(this.abaAluguel);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 482);
            this.tabControl1.TabIndex = 0;
            // 
            // abaVenda
            // 
            this.abaVenda.Controls.Add(this.gbpDadoVenda);
            this.abaVenda.Location = new System.Drawing.Point(4, 25);
            this.abaVenda.Margin = new System.Windows.Forms.Padding(2);
            this.abaVenda.Name = "abaVenda";
            this.abaVenda.Padding = new System.Windows.Forms.Padding(2);
            this.abaVenda.Size = new System.Drawing.Size(764, 453);
            this.abaVenda.TabIndex = 0;
            this.abaVenda.Text = "Venda";
            this.abaVenda.UseVisualStyleBackColor = true;
            this.abaVenda.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // gbpDadoVenda
            // 
            this.gbpDadoVenda.Controls.Add(this.numQuantidade);
            this.gbpDadoVenda.Controls.Add(this.pcbLogoGame);
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
            this.gbpDadoVenda.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpDadoVenda.Location = new System.Drawing.Point(4, 4);
            this.gbpDadoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.gbpDadoVenda.Name = "gbpDadoVenda";
            this.gbpDadoVenda.Padding = new System.Windows.Forms.Padding(2);
            this.gbpDadoVenda.Size = new System.Drawing.Size(753, 442);
            this.gbpDadoVenda.TabIndex = 9;
            this.gbpDadoVenda.TabStop = false;
            this.gbpDadoVenda.Text = "Dados Venda";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Location = new System.Drawing.Point(125, 134);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(60, 26);
            this.numQuantidade.TabIndex = 22;
            // 
            // pcbLogoGame
            // 
            this.pcbLogoGame.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pcbLogoGame.Location = new System.Drawing.Point(8, 364);
            this.pcbLogoGame.Name = "pcbLogoGame";
            this.pcbLogoGame.Size = new System.Drawing.Size(121, 49);
            this.pcbLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoGame.TabIndex = 1;
            this.pcbLogoGame.TabStop = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(4, 139);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(118, 18);
            this.lblQuantidade.TabIndex = 20;
            this.lblQuantidade.Text = "Quantidade : ";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(234, 396);
            this.lblJuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(87, 18);
            this.lblJuros.TabIndex = 19;
            this.lblJuros.Text = "Juros % :";
            // 
            // txtJuros
            // 
            this.txtJuros.Enabled = false;
            this.txtJuros.Location = new System.Drawing.Point(325, 393);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(76, 26);
            this.txtJuros.TabIndex = 18;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(405, 396);
            this.lblTotalCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(126, 18);
            this.lblTotalCompra.TabIndex = 17;
            this.lblTotalCompra.Text = "Total Compra : ";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(202, 362);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(119, 18);
            this.lblDesconto.TabIndex = 16;
            this.lblDesconto.Text = "Desconto % :";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(535, 395);
            this.txtTotalCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(76, 22);
            this.txtTotalCompra.TabIndex = 15;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(325, 359);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(76, 26);
            this.txtDesconto.TabIndex = 14;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(535, 128);
            this.btnAdicionarItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(95, 29);
            this.btnAdicionarItem.TabIndex = 12;
            this.btnAdicionarItem.Text = "Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(125, 101);
            this.txtCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(122, 26);
            this.txtCodigoFuncionario.TabIndex = 11;
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(10, 104);
            this.lblCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(117, 18);
            this.lblCodigoFuncionario.TabIndex = 10;
            this.lblCodigoFuncionario.Text = "Funcionario : ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(629, 357);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 29);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(643, 128);
            this.btnRemoverItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(86, 29);
            this.btnRemoverItem.TabIndex = 8;
            this.btnRemoverItem.Text = "Remover Item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(629, 391);
            this.btnFinalizarVenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(100, 29);
            this.btnFinalizarVenda.TabIndex = 7;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(125, 62);
            this.txtCodigoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(122, 26);
            this.txtCodigoProduto.TabIndex = 6;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(33, 65);
            this.lblCodigoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(89, 18);
            this.lblCodigoProduto.TabIndex = 5;
            this.lblCodigoProduto.Text = "Produto : ";
            // 
            // dgvDescreveProdutos
            // 
            this.dgvDescreveProdutos.AllowUserToAddRows = false;
            this.dgvDescreveProdutos.AllowUserToDeleteRows = false;
            this.dgvDescreveProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescreveProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDescreveProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescreveProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigo,
            this.dgvtbcDescricao,
            this.dgvtbcQuantidade,
            this.dgvtbcValorUnitario,
            this.dgvtbcValorTotalItem});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescreveProdutos.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDescreveProdutos.Location = new System.Drawing.Point(7, 164);
            this.dgvDescreveProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDescreveProdutos.Name = "dgvDescreveProdutos";
            this.dgvDescreveProdutos.RowHeadersWidth = 50;
            this.dgvDescreveProdutos.RowTemplate.Height = 24;
            this.dgvDescreveProdutos.Size = new System.Drawing.Size(742, 176);
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
            this.txtCpf.Location = new System.Drawing.Point(125, 26);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(122, 26);
            this.txtCpf.TabIndex = 3;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(5, 29);
            this.lblCpfCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(117, 18);
            this.lblCpfCliente.TabIndex = 2;
            this.lblCpfCliente.Text = "CPF Cliente : ";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Enabled = false;
            this.txtCodigoVenda.Location = new System.Drawing.Point(643, 14);
            this.txtCodigoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(80, 26);
            this.txtCodigoVenda.TabIndex = 1;
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Location = new System.Drawing.Point(510, 17);
            this.lblCodigoVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(135, 18);
            this.lblCodigoVenda.TabIndex = 0;
            this.lblCodigoVenda.Text = "Código Venda : ";
            // 
            // abaAluguel
            // 
            this.abaAluguel.Controls.Add(this.gbAlug);
            this.abaAluguel.Location = new System.Drawing.Point(4, 25);
            this.abaAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.abaAluguel.Name = "abaAluguel";
            this.abaAluguel.Padding = new System.Windows.Forms.Padding(2);
            this.abaAluguel.Size = new System.Drawing.Size(764, 453);
            this.abaAluguel.TabIndex = 1;
            this.abaAluguel.Text = "Aluguel";
            this.abaAluguel.UseVisualStyleBackColor = true;
            // 
            // gbAlug
            // 
            this.gbAlug.Controls.Add(this.imgLogoAlug);
            this.gbAlug.Controls.Add(this.btnFinAlug);
            this.gbAlug.Controls.Add(this.btnCancAlug);
            this.gbAlug.Controls.Add(this.txtTotalAlug);
            this.gbAlug.Controls.Add(this.txtJurAlug);
            this.gbAlug.Controls.Add(this.txtDescAlug);
            this.gbAlug.Controls.Add(this.lbTotalAlug);
            this.gbAlug.Controls.Add(this.lbDescAlug);
            this.gbAlug.Controls.Add(this.lbJurAlug);
            this.gbAlug.Controls.Add(this.dgvAlug);
            this.gbAlug.Controls.Add(this.btnRemAlug);
            this.gbAlug.Controls.Add(this.btnAddAlug);
            this.gbAlug.Controls.Add(this.nudDiasAlug);
            this.gbAlug.Controls.Add(this.txtCodAlug);
            this.gbAlug.Controls.Add(this.txtFuncAlug);
            this.gbAlug.Controls.Add(this.txtProdAlug);
            this.gbAlug.Controls.Add(this.txtCpfCliAlug);
            this.gbAlug.Controls.Add(this.lbCodAlug);
            this.gbAlug.Controls.Add(this.lbDias);
            this.gbAlug.Controls.Add(this.lbFuncAlug);
            this.gbAlug.Controls.Add(this.lbProdAlug);
            this.gbAlug.Controls.Add(this.lbCpfCliAlug);
            this.gbAlug.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAlug.Location = new System.Drawing.Point(-2, 5);
            this.gbAlug.Name = "gbAlug";
            this.gbAlug.Size = new System.Drawing.Size(758, 440);
            this.gbAlug.TabIndex = 0;
            this.gbAlug.TabStop = false;
            this.gbAlug.Text = "Dados Aluguel";
            // 
            // imgLogoAlug
            // 
            this.imgLogoAlug.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.imgLogoAlug.Location = new System.Drawing.Point(15, 367);
            this.imgLogoAlug.Name = "imgLogoAlug";
            this.imgLogoAlug.Size = new System.Drawing.Size(117, 50);
            this.imgLogoAlug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoAlug.TabIndex = 21;
            this.imgLogoAlug.TabStop = false;
            // 
            // btnFinAlug
            // 
            this.btnFinAlug.Location = new System.Drawing.Point(635, 382);
            this.btnFinAlug.Name = "btnFinAlug";
            this.btnFinAlug.Size = new System.Drawing.Size(94, 35);
            this.btnFinAlug.TabIndex = 20;
            this.btnFinAlug.Text = "Finalizar Aluguel";
            this.btnFinAlug.UseVisualStyleBackColor = true;
            this.btnFinAlug.Click += new System.EventHandler(this.btnFinAlug_Click);
            // 
            // btnCancAlug
            // 
            this.btnCancAlug.Location = new System.Drawing.Point(635, 339);
            this.btnCancAlug.Name = "btnCancAlug";
            this.btnCancAlug.Size = new System.Drawing.Size(94, 35);
            this.btnCancAlug.TabIndex = 19;
            this.btnCancAlug.Text = "Cancelar";
            this.btnCancAlug.UseVisualStyleBackColor = true;
            this.btnCancAlug.Click += new System.EventHandler(this.btnCancAlug_Click);
            // 
            // txtTotalAlug
            // 
            this.txtTotalAlug.Location = new System.Drawing.Point(545, 387);
            this.txtTotalAlug.Name = "txtTotalAlug";
            this.txtTotalAlug.Size = new System.Drawing.Size(76, 26);
            this.txtTotalAlug.TabIndex = 18;
            // 
            // txtJurAlug
            // 
            this.txtJurAlug.Location = new System.Drawing.Point(333, 387);
            this.txtJurAlug.Name = "txtJurAlug";
            this.txtJurAlug.Size = new System.Drawing.Size(75, 26);
            this.txtJurAlug.TabIndex = 17;
            // 
            // txtDescAlug
            // 
            this.txtDescAlug.Location = new System.Drawing.Point(333, 348);
            this.txtDescAlug.Name = "txtDescAlug";
            this.txtDescAlug.Size = new System.Drawing.Size(75, 26);
            this.txtDescAlug.TabIndex = 16;
            // 
            // lbTotalAlug
            // 
            this.lbTotalAlug.AutoSize = true;
            this.lbTotalAlug.Location = new System.Drawing.Point(414, 390);
            this.lbTotalAlug.Name = "lbTotalAlug";
            this.lbTotalAlug.Size = new System.Drawing.Size(125, 18);
            this.lbTotalAlug.TabIndex = 15;
            this.lbTotalAlug.Text = "Total Aluguel :";
            // 
            // lbDescAlug
            // 
            this.lbDescAlug.AutoSize = true;
            this.lbDescAlug.Location = new System.Drawing.Point(208, 351);
            this.lbDescAlug.Name = "lbDescAlug";
            this.lbDescAlug.Size = new System.Drawing.Size(119, 18);
            this.lbDescAlug.TabIndex = 14;
            this.lbDescAlug.Text = "Desconto % :";
            // 
            // lbJurAlug
            // 
            this.lbJurAlug.AutoSize = true;
            this.lbJurAlug.Location = new System.Drawing.Point(240, 390);
            this.lbJurAlug.Name = "lbJurAlug";
            this.lbJurAlug.Size = new System.Drawing.Size(87, 18);
            this.lbJurAlug.TabIndex = 13;
            this.lbJurAlug.Text = "Juros % :";
            // 
            // dgvAlug
            // 
            this.dgvAlug.AllowUserToAddRows = false;
            this.dgvAlug.AllowUserToDeleteRows = false;
            this.dgvAlug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlug.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAlug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlug.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodAlug,
            this.dgvDescAlug,
            this.dgvDiasAlug,
            this.dvgValorAlug});
            this.dgvAlug.Location = new System.Drawing.Point(12, 156);
            this.dgvAlug.Name = "dgvAlug";
            this.dgvAlug.RowHeadersWidth = 50;
            this.dgvAlug.Size = new System.Drawing.Size(740, 176);
            this.dgvAlug.TabIndex = 12;
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
            // dvgValorAlug
            // 
            this.dvgValorAlug.HeaderText = "Valor Aluguel";
            this.dvgValorAlug.Name = "dvgValorAlug";
            // 
            // btnRemAlug
            // 
            this.btnRemAlug.Location = new System.Drawing.Point(620, 113);
            this.btnRemAlug.Name = "btnRemAlug";
            this.btnRemAlug.Size = new System.Drawing.Size(107, 33);
            this.btnRemAlug.TabIndex = 11;
            this.btnRemAlug.Text = "Remover Item";
            this.btnRemAlug.UseVisualStyleBackColor = true;
            // 
            // btnAddAlug
            // 
            this.btnAddAlug.Location = new System.Drawing.Point(507, 113);
            this.btnAddAlug.Name = "btnAddAlug";
            this.btnAddAlug.Size = new System.Drawing.Size(107, 33);
            this.btnAddAlug.TabIndex = 10;
            this.btnAddAlug.Text = "Adicionar Item";
            this.btnAddAlug.UseVisualStyleBackColor = true;
            // 
            // nudDiasAlug
            // 
            this.nudDiasAlug.Location = new System.Drawing.Point(130, 120);
            this.nudDiasAlug.Name = "nudDiasAlug";
            this.nudDiasAlug.Size = new System.Drawing.Size(58, 26);
            this.nudDiasAlug.TabIndex = 9;
            // 
            // txtCodAlug
            // 
            this.txtCodAlug.Enabled = false;
            this.txtCodAlug.Location = new System.Drawing.Point(650, 19);
            this.txtCodAlug.Name = "txtCodAlug";
            this.txtCodAlug.Size = new System.Drawing.Size(79, 26);
            this.txtCodAlug.TabIndex = 8;
            // 
            // txtFuncAlug
            // 
            this.txtFuncAlug.Location = new System.Drawing.Point(130, 88);
            this.txtFuncAlug.Name = "txtFuncAlug";
            this.txtFuncAlug.Size = new System.Drawing.Size(100, 26);
            this.txtFuncAlug.TabIndex = 7;
            // 
            // txtProdAlug
            // 
            this.txtProdAlug.Location = new System.Drawing.Point(130, 56);
            this.txtProdAlug.Name = "txtProdAlug";
            this.txtProdAlug.Size = new System.Drawing.Size(100, 26);
            this.txtProdAlug.TabIndex = 6;
            this.txtProdAlug.TextChanged += new System.EventHandler(this.txtProdAlug_TextChanged);
            // 
            // txtCpfCliAlug
            // 
            this.txtCpfCliAlug.Location = new System.Drawing.Point(130, 24);
            this.txtCpfCliAlug.Name = "txtCpfCliAlug";
            this.txtCpfCliAlug.Size = new System.Drawing.Size(100, 26);
            this.txtCpfCliAlug.TabIndex = 5;
            // 
            // lbCodAlug
            // 
            this.lbCodAlug.AutoSize = true;
            this.lbCodAlug.Location = new System.Drawing.Point(505, 22);
            this.lbCodAlug.Name = "lbCodAlug";
            this.lbCodAlug.Size = new System.Drawing.Size(139, 18);
            this.lbCodAlug.TabIndex = 4;
            this.lbCodAlug.Text = "Código Aluguel :";
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Location = new System.Drawing.Point(70, 122);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(54, 18);
            this.lbDias.TabIndex = 3;
            this.lbDias.Text = "Dias :";
            // 
            // lbFuncAlug
            // 
            this.lbFuncAlug.AutoSize = true;
            this.lbFuncAlug.Location = new System.Drawing.Point(12, 91);
            this.lbFuncAlug.Name = "lbFuncAlug";
            this.lbFuncAlug.Size = new System.Drawing.Size(112, 18);
            this.lbFuncAlug.TabIndex = 2;
            this.lbFuncAlug.Text = "Funcionário :";
            // 
            // lbProdAlug
            // 
            this.lbProdAlug.AutoSize = true;
            this.lbProdAlug.Location = new System.Drawing.Point(40, 59);
            this.lbProdAlug.Name = "lbProdAlug";
            this.lbProdAlug.Size = new System.Drawing.Size(84, 18);
            this.lbProdAlug.TabIndex = 1;
            this.lbProdAlug.Text = "Produto :";
            // 
            // lbCpfCliAlug
            // 
            this.lbCpfCliAlug.AutoSize = true;
            this.lbCpfCliAlug.Location = new System.Drawing.Point(12, 27);
            this.lbCpfCliAlug.Name = "lbCpfCliAlug";
            this.lbCpfCliAlug.Size = new System.Drawing.Size(112, 18);
            this.lbCpfCliAlug.TabIndex = 0;
            this.lbCpfCliAlug.Text = "CPF Cliente :";
            // 
            // telaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 482);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "telaVenda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaVenda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaVenda_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.abaVenda.ResumeLayout(false);
            this.gbpDadoVenda.ResumeLayout(false);
            this.gbpDadoVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).EndInit();
            this.abaAluguel.ResumeLayout(false);
            this.gbAlug.ResumeLayout(false);
            this.gbAlug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoAlug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasAlug)).EndInit();
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
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.PictureBox pcbLogoGame;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.TextBox txtTotalAlug;
        private System.Windows.Forms.TextBox txtJurAlug;
        private System.Windows.Forms.TextBox txtDescAlug;
        private System.Windows.Forms.Label lbTotalAlug;
        private System.Windows.Forms.Label lbDescAlug;
        private System.Windows.Forms.Label lbJurAlug;
        private System.Windows.Forms.DataGridView dgvAlug;
        private System.Windows.Forms.Button btnRemAlug;
        private System.Windows.Forms.Button btnAddAlug;
        private System.Windows.Forms.NumericUpDown nudDiasAlug;
        private System.Windows.Forms.TextBox txtCodAlug;
        private System.Windows.Forms.TextBox txtFuncAlug;
        private System.Windows.Forms.TextBox txtProdAlug;
        private System.Windows.Forms.TextBox txtCpfCliAlug;
        private System.Windows.Forms.Label lbCodAlug;
        private System.Windows.Forms.Label lbCpfCliAlug;
        private System.Windows.Forms.Label lbProdAlug;
        private System.Windows.Forms.Label lbFuncAlug;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.GroupBox gbAlug;
        private System.Windows.Forms.Button btnFinAlug;
        private System.Windows.Forms.Button btnCancAlug;
        private System.Windows.Forms.PictureBox imgLogoAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiasAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgValorAlug;
    }
}