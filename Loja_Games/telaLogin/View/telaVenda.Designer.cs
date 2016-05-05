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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.abaAluguel = new System.Windows.Forms.TabPage();
            this.gpbAlug = new System.Windows.Forms.GroupBox();
            this.lbCpfCliAlug = new System.Windows.Forms.Label();
            this.lbProdAlug = new System.Windows.Forms.Label();
            this.lbFuncAlug = new System.Windows.Forms.Label();
            this.lbDias = new System.Windows.Forms.Label();
            this.lbCodAlug = new System.Windows.Forms.Label();
            this.txtCpfCliAlug = new System.Windows.Forms.TextBox();
            this.txtProdAlug = new System.Windows.Forms.TextBox();
            this.txtFuncAlug = new System.Windows.Forms.TextBox();
            this.txtCodAlug = new System.Windows.Forms.TextBox();
            this.numDiasAlug = new System.Windows.Forms.NumericUpDown();
            this.btnAddAlug = new System.Windows.Forms.Button();
            this.btnRemAlug = new System.Windows.Forms.Button();
            this.dgvAlug = new System.Windows.Forms.DataGridView();
            this.dvgValorAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiasAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodAlug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTotalAlug = new System.Windows.Forms.Label();
            this.txtTotalAlug = new System.Windows.Forms.TextBox();
            this.btnCancAlug = new System.Windows.Forms.Button();
            this.btnFinAlug = new System.Windows.Forms.Button();
            this.pcbLogoAlug = new System.Windows.Forms.PictureBox();
            this.abaVenda = new System.Windows.Forms.TabPage();
            this.gbpDadoVenda = new System.Windows.Forms.GroupBox();
            this.lbCodigoVenda = new System.Windows.Forms.Label();
            this.txtCodigoVenda = new System.Windows.Forms.TextBox();
            this.lbCpfCliente = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.dgvDescreveProdutos = new System.Windows.Forms.DataGridView();
            this.dgvtbcValorTotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbcCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbCodigoProduto = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.btnFinalizarVenda = new System.Windows.Forms.Button();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbCodigoFuncionario = new System.Windows.Forms.Label();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lbTotalCompra = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.pcbLogoGame = new System.Windows.Forms.PictureBox();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.tcVendaAluguel = new System.Windows.Forms.TabControl();
            this.abaAluguel.SuspendLayout();
            this.gpbAlug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasAlug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoAlug)).BeginInit();
            this.abaVenda.SuspendLayout();
            this.gbpDadoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.tcVendaAluguel.SuspendLayout();
            this.SuspendLayout();
            // 
            // abaAluguel
            // 
            this.abaAluguel.Controls.Add(this.gpbAlug);
            this.abaAluguel.Location = new System.Drawing.Point(4, 25);
            this.abaAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.abaAluguel.Name = "abaAluguel";
            this.abaAluguel.Padding = new System.Windows.Forms.Padding(2);
            this.abaAluguel.Size = new System.Drawing.Size(764, 453);
            this.abaAluguel.TabIndex = 1;
            this.abaAluguel.Text = "Aluguel";
            this.abaAluguel.UseVisualStyleBackColor = true;
            // 
            // gpbAlug
            // 
            this.gpbAlug.Controls.Add(this.pcbLogoAlug);
            this.gpbAlug.Controls.Add(this.btnFinAlug);
            this.gpbAlug.Controls.Add(this.btnCancAlug);
            this.gpbAlug.Controls.Add(this.txtTotalAlug);
            this.gpbAlug.Controls.Add(this.lbTotalAlug);
            this.gpbAlug.Controls.Add(this.dgvAlug);
            this.gpbAlug.Controls.Add(this.btnRemAlug);
            this.gpbAlug.Controls.Add(this.btnAddAlug);
            this.gpbAlug.Controls.Add(this.numDiasAlug);
            this.gpbAlug.Controls.Add(this.txtCodAlug);
            this.gpbAlug.Controls.Add(this.txtFuncAlug);
            this.gpbAlug.Controls.Add(this.txtProdAlug);
            this.gpbAlug.Controls.Add(this.txtCpfCliAlug);
            this.gpbAlug.Controls.Add(this.lbCodAlug);
            this.gpbAlug.Controls.Add(this.lbDias);
            this.gpbAlug.Controls.Add(this.lbFuncAlug);
            this.gpbAlug.Controls.Add(this.lbProdAlug);
            this.gpbAlug.Controls.Add(this.lbCpfCliAlug);
            this.gpbAlug.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAlug.Location = new System.Drawing.Point(-2, 5);
            this.gpbAlug.Name = "gpbAlug";
            this.gpbAlug.Size = new System.Drawing.Size(758, 440);
            this.gpbAlug.TabIndex = 0;
            this.gpbAlug.TabStop = false;
            this.gpbAlug.Text = "Dados Aluguel";
            // 
            // lbCpfCliAlug
            // 
            this.lbCpfCliAlug.AutoSize = true;
            this.lbCpfCliAlug.Location = new System.Drawing.Point(12, 27);
            this.lbCpfCliAlug.Name = "lbCpfCliAlug";
            this.lbCpfCliAlug.Size = new System.Drawing.Size(100, 16);
            this.lbCpfCliAlug.TabIndex = 0;
            this.lbCpfCliAlug.Text = "CPF Cliente :";
            // 
            // lbProdAlug
            // 
            this.lbProdAlug.AutoSize = true;
            this.lbProdAlug.Location = new System.Drawing.Point(40, 59);
            this.lbProdAlug.Name = "lbProdAlug";
            this.lbProdAlug.Size = new System.Drawing.Size(74, 16);
            this.lbProdAlug.TabIndex = 1;
            this.lbProdAlug.Text = "Produto :";
            // 
            // lbFuncAlug
            // 
            this.lbFuncAlug.AutoSize = true;
            this.lbFuncAlug.Location = new System.Drawing.Point(12, 91);
            this.lbFuncAlug.Name = "lbFuncAlug";
            this.lbFuncAlug.Size = new System.Drawing.Size(102, 16);
            this.lbFuncAlug.TabIndex = 2;
            this.lbFuncAlug.Text = "Funcionário :";
            // 
            // lbDias
            // 
            this.lbDias.AutoSize = true;
            this.lbDias.Location = new System.Drawing.Point(70, 122);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(48, 16);
            this.lbDias.TabIndex = 3;
            this.lbDias.Text = "Dias :";
            // 
            // lbCodAlug
            // 
            this.lbCodAlug.AutoSize = true;
            this.lbCodAlug.Location = new System.Drawing.Point(505, 22);
            this.lbCodAlug.Name = "lbCodAlug";
            this.lbCodAlug.Size = new System.Drawing.Size(125, 16);
            this.lbCodAlug.TabIndex = 4;
            this.lbCodAlug.Text = "Código Aluguel :";
            // 
            // txtCpfCliAlug
            // 
            this.txtCpfCliAlug.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCliAlug.Location = new System.Drawing.Point(130, 24);
            this.txtCpfCliAlug.Name = "txtCpfCliAlug";
            this.txtCpfCliAlug.Size = new System.Drawing.Size(100, 23);
            this.txtCpfCliAlug.TabIndex = 5;
            // 
            // txtProdAlug
            // 
            this.txtProdAlug.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdAlug.Location = new System.Drawing.Point(130, 56);
            this.txtProdAlug.Name = "txtProdAlug";
            this.txtProdAlug.Size = new System.Drawing.Size(100, 23);
            this.txtProdAlug.TabIndex = 6;
            this.txtProdAlug.TextChanged += new System.EventHandler(this.txtProdAlug_TextChanged);
            // 
            // txtFuncAlug
            // 
            this.txtFuncAlug.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncAlug.Location = new System.Drawing.Point(130, 88);
            this.txtFuncAlug.Name = "txtFuncAlug";
            this.txtFuncAlug.Size = new System.Drawing.Size(100, 23);
            this.txtFuncAlug.TabIndex = 7;
            // 
            // txtCodAlug
            // 
            this.txtCodAlug.Enabled = false;
            this.txtCodAlug.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodAlug.Location = new System.Drawing.Point(636, 19);
            this.txtCodAlug.Name = "txtCodAlug";
            this.txtCodAlug.Size = new System.Drawing.Size(79, 23);
            this.txtCodAlug.TabIndex = 8;
            // 
            // numDiasAlug
            // 
            this.numDiasAlug.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiasAlug.Location = new System.Drawing.Point(130, 120);
            this.numDiasAlug.Name = "numDiasAlug";
            this.numDiasAlug.Size = new System.Drawing.Size(58, 23);
            this.numDiasAlug.TabIndex = 9;
            // 
            // btnAddAlug
            // 
            this.btnAddAlug.Location = new System.Drawing.Point(507, 120);
            this.btnAddAlug.Name = "btnAddAlug";
            this.btnAddAlug.Size = new System.Drawing.Size(107, 25);
            this.btnAddAlug.TabIndex = 10;
            this.btnAddAlug.Text = "Adicionar Item";
            this.btnAddAlug.UseVisualStyleBackColor = true;
            // 
            // btnRemAlug
            // 
            this.btnRemAlug.Location = new System.Drawing.Point(620, 120);
            this.btnRemAlug.Name = "btnRemAlug";
            this.btnRemAlug.Size = new System.Drawing.Size(107, 25);
            this.btnRemAlug.TabIndex = 11;
            this.btnRemAlug.Text = "Remover Item";
            this.btnRemAlug.UseVisualStyleBackColor = true;
            // 
            // dgvAlug
            // 
            this.dgvAlug.AllowUserToAddRows = false;
            this.dgvAlug.AllowUserToDeleteRows = false;
            this.dgvAlug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlug.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlug.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodAlug,
            this.dgvDescAlug,
            this.dgvDiasAlug,
            this.dvgValorAlug});
            this.dgvAlug.Location = new System.Drawing.Point(12, 156);
            this.dgvAlug.Name = "dgvAlug";
            this.dgvAlug.RowHeadersWidth = 50;
            this.dgvAlug.Size = new System.Drawing.Size(740, 195);
            this.dgvAlug.TabIndex = 12;
            // 
            // dvgValorAlug
            // 
            this.dvgValorAlug.HeaderText = "Valor Aluguel";
            this.dvgValorAlug.Name = "dvgValorAlug";
            // 
            // dgvDiasAlug
            // 
            this.dgvDiasAlug.HeaderText = "Dias";
            this.dgvDiasAlug.Name = "dgvDiasAlug";
            // 
            // dgvDescAlug
            // 
            this.dgvDescAlug.HeaderText = "Descrição";
            this.dgvDescAlug.Name = "dgvDescAlug";
            // 
            // dgvCodAlug
            // 
            this.dgvCodAlug.HeaderText = "Código";
            this.dgvCodAlug.Name = "dgvCodAlug";
            // 
            // lbTotalAlug
            // 
            this.lbTotalAlug.AutoSize = true;
            this.lbTotalAlug.Location = new System.Drawing.Point(428, 390);
            this.lbTotalAlug.Name = "lbTotalAlug";
            this.lbTotalAlug.Size = new System.Drawing.Size(111, 16);
            this.lbTotalAlug.TabIndex = 15;
            this.lbTotalAlug.Text = "Total Aluguel :";
            // 
            // txtTotalAlug
            // 
            this.txtTotalAlug.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAlug.Location = new System.Drawing.Point(545, 387);
            this.txtTotalAlug.Name = "txtTotalAlug";
            this.txtTotalAlug.Size = new System.Drawing.Size(76, 23);
            this.txtTotalAlug.TabIndex = 18;
            // 
            // btnCancAlug
            // 
            this.btnCancAlug.Location = new System.Drawing.Point(644, 357);
            this.btnCancAlug.Name = "btnCancAlug";
            this.btnCancAlug.Size = new System.Drawing.Size(94, 35);
            this.btnCancAlug.TabIndex = 19;
            this.btnCancAlug.Text = "Cancelar";
            this.btnCancAlug.UseVisualStyleBackColor = true;
            this.btnCancAlug.Click += new System.EventHandler(this.btnCancAlug_Click);
            // 
            // btnFinAlug
            // 
            this.btnFinAlug.Location = new System.Drawing.Point(644, 400);
            this.btnFinAlug.Name = "btnFinAlug";
            this.btnFinAlug.Size = new System.Drawing.Size(94, 28);
            this.btnFinAlug.TabIndex = 20;
            this.btnFinAlug.Text = "Finalizar Aluguel";
            this.btnFinAlug.UseVisualStyleBackColor = true;
            this.btnFinAlug.Click += new System.EventHandler(this.btnFinAlug_Click);
            // 
            // pcbLogoAlug
            // 
            this.pcbLogoAlug.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pcbLogoAlug.Location = new System.Drawing.Point(15, 382);
            this.pcbLogoAlug.Name = "pcbLogoAlug";
            this.pcbLogoAlug.Size = new System.Drawing.Size(117, 50);
            this.pcbLogoAlug.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogoAlug.TabIndex = 21;
            this.pcbLogoAlug.TabStop = false;
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
            this.gbpDadoVenda.Controls.Add(this.lbQuantidade);
            this.gbpDadoVenda.Controls.Add(this.lbTotalCompra);
            this.gbpDadoVenda.Controls.Add(this.txtTotalCompra);
            this.gbpDadoVenda.Controls.Add(this.btnAdicionarItem);
            this.gbpDadoVenda.Controls.Add(this.txtCodigoFuncionario);
            this.gbpDadoVenda.Controls.Add(this.lbCodigoFuncionario);
            this.gbpDadoVenda.Controls.Add(this.btnCancelar);
            this.gbpDadoVenda.Controls.Add(this.btnRemoverItem);
            this.gbpDadoVenda.Controls.Add(this.btnFinalizarVenda);
            this.gbpDadoVenda.Controls.Add(this.txtCodigoProduto);
            this.gbpDadoVenda.Controls.Add(this.lbCodigoProduto);
            this.gbpDadoVenda.Controls.Add(this.dgvDescreveProdutos);
            this.gbpDadoVenda.Controls.Add(this.txtCpf);
            this.gbpDadoVenda.Controls.Add(this.lbCpfCliente);
            this.gbpDadoVenda.Controls.Add(this.txtCodigoVenda);
            this.gbpDadoVenda.Controls.Add(this.lbCodigoVenda);
            this.gbpDadoVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpDadoVenda.Location = new System.Drawing.Point(4, 4);
            this.gbpDadoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.gbpDadoVenda.Name = "gbpDadoVenda";
            this.gbpDadoVenda.Padding = new System.Windows.Forms.Padding(2);
            this.gbpDadoVenda.Size = new System.Drawing.Size(753, 442);
            this.gbpDadoVenda.TabIndex = 9;
            this.gbpDadoVenda.TabStop = false;
            this.gbpDadoVenda.Text = "Dados Venda";
            // 
            // lbCodigoVenda
            // 
            this.lbCodigoVenda.AutoSize = true;
            this.lbCodigoVenda.Location = new System.Drawing.Point(510, 17);
            this.lbCodigoVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoVenda.Name = "lbCodigoVenda";
            this.lbCodigoVenda.Size = new System.Drawing.Size(121, 16);
            this.lbCodigoVenda.TabIndex = 0;
            this.lbCodigoVenda.Text = "Código Venda : ";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Enabled = false;
            this.txtCodigoVenda.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVenda.Location = new System.Drawing.Point(629, 14);
            this.txtCodigoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(80, 23);
            this.txtCodigoVenda.TabIndex = 1;
            // 
            // lbCpfCliente
            // 
            this.lbCpfCliente.AutoSize = true;
            this.lbCpfCliente.Location = new System.Drawing.Point(5, 29);
            this.lbCpfCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCpfCliente.Name = "lbCpfCliente";
            this.lbCpfCliente.Size = new System.Drawing.Size(104, 16);
            this.lbCpfCliente.TabIndex = 2;
            this.lbCpfCliente.Text = "CPF Cliente : ";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(125, 26);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(122, 23);
            this.txtCpf.TabIndex = 3;
            // 
            // dgvDescreveProdutos
            // 
            this.dgvDescreveProdutos.AllowUserToAddRows = false;
            this.dgvDescreveProdutos.AllowUserToDeleteRows = false;
            this.dgvDescreveProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescreveProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDescreveProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescreveProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbcCodigo,
            this.dgvtbcDescricao,
            this.dgvtbcQuantidade,
            this.dgvtbcValorUnitario,
            this.dgvtbcValorTotalItem});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescreveProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDescreveProdutos.Location = new System.Drawing.Point(7, 164);
            this.dgvDescreveProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDescreveProdutos.Name = "dgvDescreveProdutos";
            this.dgvDescreveProdutos.RowHeadersWidth = 50;
            this.dgvDescreveProdutos.RowTemplate.Height = 24;
            this.dgvDescreveProdutos.Size = new System.Drawing.Size(742, 200);
            this.dgvDescreveProdutos.TabIndex = 4;
            // 
            // dgvtbcValorTotalItem
            // 
            this.dgvtbcValorTotalItem.HeaderText = "Valor Total Item";
            this.dgvtbcValorTotalItem.Name = "dgvtbcValorTotalItem";
            // 
            // dgvtbcValorUnitario
            // 
            this.dgvtbcValorUnitario.HeaderText = "Valor Unitario";
            this.dgvtbcValorUnitario.Name = "dgvtbcValorUnitario";
            // 
            // dgvtbcQuantidade
            // 
            this.dgvtbcQuantidade.HeaderText = "Quantidade";
            this.dgvtbcQuantidade.Name = "dgvtbcQuantidade";
            // 
            // dgvtbcDescricao
            // 
            this.dgvtbcDescricao.HeaderText = "Descrição";
            this.dgvtbcDescricao.Name = "dgvtbcDescricao";
            // 
            // dgvtbcCodigo
            // 
            this.dgvtbcCodigo.HeaderText = "Codigo";
            this.dgvtbcCodigo.Name = "dgvtbcCodigo";
            // 
            // lbCodigoProduto
            // 
            this.lbCodigoProduto.AutoSize = true;
            this.lbCodigoProduto.Location = new System.Drawing.Point(31, 65);
            this.lbCodigoProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoProduto.Name = "lbCodigoProduto";
            this.lbCodigoProduto.Size = new System.Drawing.Size(78, 16);
            this.lbCodigoProduto.TabIndex = 5;
            this.lbCodigoProduto.Text = "Produto : ";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProduto.Location = new System.Drawing.Point(125, 62);
            this.txtCodigoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(122, 23);
            this.txtCodigoProduto.TabIndex = 6;
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(629, 402);
            this.btnFinalizarVenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(100, 29);
            this.btnFinalizarVenda.TabIndex = 7;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            this.btnFinalizarVenda.Click += new System.EventHandler(this.btnFinalizarVenda_Click);
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(629, 368);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 29);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbCodigoFuncionario
            // 
            this.lbCodigoFuncionario.AutoSize = true;
            this.lbCodigoFuncionario.Location = new System.Drawing.Point(3, 101);
            this.lbCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoFuncionario.Name = "lbCodigoFuncionario";
            this.lbCodigoFuncionario.Size = new System.Drawing.Size(106, 16);
            this.lbCodigoFuncionario.TabIndex = 10;
            this.lbCodigoFuncionario.Text = "Funcionario : ";
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(125, 101);
            this.txtCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(122, 23);
            this.txtCodigoFuncionario.TabIndex = 11;
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
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(535, 395);
            this.txtTotalCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(76, 23);
            this.txtTotalCompra.TabIndex = 15;
            // 
            // lbTotalCompra
            // 
            this.lbTotalCompra.AutoSize = true;
            this.lbTotalCompra.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCompra.Location = new System.Drawing.Point(384, 397);
            this.lbTotalCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalCompra.Name = "lbTotalCompra";
            this.lbTotalCompra.Size = new System.Drawing.Size(118, 16);
            this.lbTotalCompra.TabIndex = 17;
            this.lbTotalCompra.Text = "Total Compra : ";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(4, 136);
            this.lbQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(105, 16);
            this.lbQuantidade.TabIndex = 20;
            this.lbQuantidade.Text = "Quantidade : ";
            // 
            // pcbLogoGame
            // 
            this.pcbLogoGame.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pcbLogoGame.Location = new System.Drawing.Point(8, 386);
            this.pcbLogoGame.Name = "pcbLogoGame";
            this.pcbLogoGame.Size = new System.Drawing.Size(121, 49);
            this.pcbLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoGame.TabIndex = 1;
            this.pcbLogoGame.TabStop = false;
            // 
            // numQuantidade
            // 
            this.numQuantidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantidade.Location = new System.Drawing.Point(125, 134);
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(60, 23);
            this.numQuantidade.TabIndex = 22;
            // 
            // tcVendaAluguel
            // 
            this.tcVendaAluguel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcVendaAluguel.Controls.Add(this.abaVenda);
            this.tcVendaAluguel.Controls.Add(this.abaAluguel);
            this.tcVendaAluguel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcVendaAluguel.Location = new System.Drawing.Point(-2, 0);
            this.tcVendaAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.tcVendaAluguel.Name = "tcVendaAluguel";
            this.tcVendaAluguel.SelectedIndex = 0;
            this.tcVendaAluguel.Size = new System.Drawing.Size(772, 482);
            this.tcVendaAluguel.TabIndex = 0;
            // 
            // telaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 482);
            this.Controls.Add(this.tcVendaAluguel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaVenda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda e Aluguel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaVenda_FormClosing);
            this.abaAluguel.ResumeLayout(false);
            this.gpbAlug.ResumeLayout(false);
            this.gpbAlug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiasAlug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoAlug)).EndInit();
            this.abaVenda.ResumeLayout(false);
            this.gbpDadoVenda.ResumeLayout(false);
            this.gbpDadoVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.tcVendaAluguel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage abaAluguel;
        private System.Windows.Forms.GroupBox gpbAlug;
        private System.Windows.Forms.PictureBox pcbLogoAlug;
        private System.Windows.Forms.Button btnFinAlug;
        private System.Windows.Forms.Button btnCancAlug;
        private System.Windows.Forms.TextBox txtTotalAlug;
        private System.Windows.Forms.Label lbTotalAlug;
        private System.Windows.Forms.DataGridView dgvAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiasAlug;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvgValorAlug;
        private System.Windows.Forms.Button btnRemAlug;
        private System.Windows.Forms.Button btnAddAlug;
        private System.Windows.Forms.NumericUpDown numDiasAlug;
        private System.Windows.Forms.TextBox txtCodAlug;
        private System.Windows.Forms.TextBox txtFuncAlug;
        private System.Windows.Forms.TextBox txtProdAlug;
        private System.Windows.Forms.TextBox txtCpfCliAlug;
        private System.Windows.Forms.Label lbCodAlug;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.Label lbFuncAlug;
        private System.Windows.Forms.Label lbProdAlug;
        private System.Windows.Forms.Label lbCpfCliAlug;
        private System.Windows.Forms.TabPage abaVenda;
        private System.Windows.Forms.GroupBox gbpDadoVenda;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.PictureBox pcbLogoGame;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbTotalCompra;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.TextBox txtCodigoFuncionario;
        private System.Windows.Forms.Label lbCodigoFuncionario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnFinalizarVenda;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Label lbCodigoProduto;
        private System.Windows.Forms.DataGridView dgvDescreveProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbcValorTotalItem;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lbCpfCliente;
        private System.Windows.Forms.TextBox txtCodigoVenda;
        private System.Windows.Forms.Label lbCodigoVenda;
        private System.Windows.Forms.TabControl tcVendaAluguel;
    }
}