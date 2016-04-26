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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.abaVenda.SuspendLayout();
            this.gbpDadoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).BeginInit();
            this.abaAluguel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.abaVenda);
            this.tabControl1.Controls.Add(this.abaAluguel);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(657, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // abaVenda
            // 
            this.abaVenda.Controls.Add(this.gbpDadoVenda);
            this.abaVenda.Location = new System.Drawing.Point(4, 22);
            this.abaVenda.Margin = new System.Windows.Forms.Padding(2);
            this.abaVenda.Name = "abaVenda";
            this.abaVenda.Padding = new System.Windows.Forms.Padding(2);
            this.abaVenda.Size = new System.Drawing.Size(649, 363);
            this.abaVenda.TabIndex = 0;
            this.abaVenda.Text = "Venda";
            this.abaVenda.UseVisualStyleBackColor = true;
            this.abaVenda.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // gbpDadoVenda
            // 
            this.gbpDadoVenda.Controls.Add(this.txtQuantidade);
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
            this.gbpDadoVenda.Location = new System.Drawing.Point(4, 5);
            this.gbpDadoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.gbpDadoVenda.Name = "gbpDadoVenda";
            this.gbpDadoVenda.Padding = new System.Windows.Forms.Padding(2);
            this.gbpDadoVenda.Size = new System.Drawing.Size(649, 358);
            this.gbpDadoVenda.TabIndex = 9;
            this.gbpDadoVenda.TabStop = false;
            this.gbpDadoVenda.Text = "Dados Venda";
            this.gbpDadoVenda.Enter += new System.EventHandler(this.gbpDadoVenda_Enter);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(282, 60);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(106, 20);
            this.txtQuantidade.TabIndex = 21;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(209, 66);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(71, 13);
            this.lblQuantidade.TabIndex = 20;
            this.lblQuantidade.Text = "Quantidade : ";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(137, 323);
            this.lblJuros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(49, 13);
            this.lblJuros.TabIndex = 19;
            this.lblJuros.Text = "Juros % :";
            // 
            // txtJuros
            // 
            this.txtJuros.Enabled = false;
            this.txtJuros.Location = new System.Drawing.Point(221, 323);
            this.txtJuros.Margin = new System.Windows.Forms.Padding(2);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(76, 20);
            this.txtJuros.TabIndex = 18;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.Location = new System.Drawing.Point(304, 323);
            this.lblTotalCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(126, 18);
            this.lblTotalCompra.TabIndex = 17;
            this.lblTotalCompra.Text = "Total Compra : ";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(137, 298);
            this.lblDesconto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(70, 13);
            this.lblDesconto.TabIndex = 16;
            this.lblDesconto.Text = "Desconto % :";
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.Location = new System.Drawing.Point(434, 323);
            this.txtTotalCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(76, 22);
            this.txtTotalCompra.TabIndex = 15;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(221, 298);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(76, 20);
            this.txtDesconto.TabIndex = 14;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(415, 61);
            this.btnAdicionarItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(95, 29);
            this.btnAdicionarItem.TabIndex = 12;
            this.btnAdicionarItem.Text = "Adiconar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(524, 31);
            this.txtCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(106, 20);
            this.txtCodigoFuncionario.TabIndex = 11;
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(413, 30);
            this.lblCodigoFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(107, 13);
            this.lblCodigoFuncionario.TabIndex = 10;
            this.lblCodigoFuncionario.Text = "Código Funcionario : ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(550, 288);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 26);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(524, 61);
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
            this.btnFinalizarVenda.Location = new System.Drawing.Point(530, 321);
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
            this.txtCodigoProduto.Location = new System.Drawing.Point(92, 63);
            this.txtCodigoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(98, 20);
            this.txtCodigoProduto.TabIndex = 6;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(5, 63);
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
            this.dgvDescreveProdutos.Location = new System.Drawing.Point(8, 102);
            this.dgvDescreveProdutos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDescreveProdutos.Name = "dgvDescreveProdutos";
            this.dgvDescreveProdutos.RowTemplate.Height = 24;
            this.dgvDescreveProdutos.Size = new System.Drawing.Size(622, 176);
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
            this.txtCpf.Location = new System.Drawing.Point(282, 30);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(106, 20);
            this.txtCpf.TabIndex = 3;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(209, 33);
            this.lblCpfCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(74, 13);
            this.lblCpfCliente.TabIndex = 2;
            this.lblCpfCliente.Text = "CPF Cliente  : ";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(92, 30);
            this.txtCodigoVenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(98, 20);
            this.txtCodigoVenda.TabIndex = 1;
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Location = new System.Drawing.Point(5, 30);
            this.lblCodigoVenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoVenda.TabIndex = 0;
            this.lblCodigoVenda.Text = "Código Venda : ";
            // 
            // abaAluguel
            // 
            this.abaAluguel.Controls.Add(this.label1);
            this.abaAluguel.Location = new System.Drawing.Point(4, 22);
            this.abaAluguel.Margin = new System.Windows.Forms.Padding(2);
            this.abaAluguel.Name = "abaAluguel";
            this.abaAluguel.Padding = new System.Windows.Forms.Padding(2);
            this.abaAluguel.Size = new System.Drawing.Size(738, 339);
            this.abaAluguel.TabIndex = 1;
            this.abaAluguel.Text = "Aluguel";
            this.abaAluguel.UseVisualStyleBackColor = true;
            // 
            // pcbLogoGame
            // 
            this.pcbLogoGame.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pcbLogoGame.Location = new System.Drawing.Point(8, 294);
            this.pcbLogoGame.Name = "pcbLogoGame";
            this.pcbLogoGame.Size = new System.Drawing.Size(121, 49);
            this.pcbLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoGame.TabIndex = 1;
            this.pcbLogoGame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // telaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 411);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).EndInit();
            this.abaAluguel.ResumeLayout(false);
            this.abaAluguel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).EndInit();
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
        private System.Windows.Forms.Label label1;
    }
}