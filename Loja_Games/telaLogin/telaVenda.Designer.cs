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
            this.abaAluguel = new System.Windows.Forms.TabPage();
            this.gbpDadoVenda = new System.Windows.Forms.GroupBox();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCodigoFuncionario = new System.Windows.Forms.Label();
            this.txtCodigoFuncionario = new System.Windows.Forms.TextBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.abaVenda.SuspendLayout();
            this.gbpDadoVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.abaVenda);
            this.tabControl1.Controls.Add(this.abaAluguel);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // abaVenda
            // 
            this.abaVenda.Controls.Add(this.gbpDadoVenda);
            this.abaVenda.Location = new System.Drawing.Point(4, 25);
            this.abaVenda.Name = "abaVenda";
            this.abaVenda.Padding = new System.Windows.Forms.Padding(3);
            this.abaVenda.Size = new System.Drawing.Size(987, 420);
            this.abaVenda.TabIndex = 0;
            this.abaVenda.Text = "Venda";
            this.abaVenda.UseVisualStyleBackColor = true;
            this.abaVenda.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // abaAluguel
            // 
            this.abaAluguel.Location = new System.Drawing.Point(4, 25);
            this.abaAluguel.Name = "abaAluguel";
            this.abaAluguel.Padding = new System.Windows.Forms.Padding(3);
            this.abaAluguel.Size = new System.Drawing.Size(987, 420);
            this.abaAluguel.TabIndex = 1;
            this.abaAluguel.Text = "Aluguel";
            this.abaAluguel.UseVisualStyleBackColor = true;
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
            this.gbpDadoVenda.Location = new System.Drawing.Point(6, 6);
            this.gbpDadoVenda.Name = "gbpDadoVenda";
            this.gbpDadoVenda.Size = new System.Drawing.Size(975, 408);
            this.gbpDadoVenda.TabIndex = 9;
            this.gbpDadoVenda.TabStop = false;
            this.gbpDadoVenda.Text = "Dados Venda";
            this.gbpDadoVenda.Enter += new System.EventHandler(this.gbpDadoVenda_Enter);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(10, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.Location = new System.Drawing.Point(683, 95);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(143, 36);
            this.btnRemoverItem.TabIndex = 8;
            this.btnRemoverItem.Text = "Remover Item";
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnFinalizarVenda
            // 
            this.btnFinalizarVenda.Location = new System.Drawing.Point(164, 341);
            this.btnFinalizarVenda.Name = "btnFinalizarVenda";
            this.btnFinalizarVenda.Size = new System.Drawing.Size(133, 36);
            this.btnFinalizarVenda.TabIndex = 7;
            this.btnFinalizarVenda.Text = "Finalizar Venda";
            this.btnFinalizarVenda.UseVisualStyleBackColor = true;
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(123, 95);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoProduto.TabIndex = 6;
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(7, 95);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(118, 17);
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
            this.dgvDescreveProdutos.Location = new System.Drawing.Point(10, 148);
            this.dgvDescreveProdutos.Name = "dgvDescreveProdutos";
            this.dgvDescreveProdutos.RowTemplate.Height = 24;
            this.dgvDescreveProdutos.Size = new System.Drawing.Size(933, 150);
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
            this.txtCpf.Location = new System.Drawing.Point(386, 54);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(140, 22);
            this.txtCpf.TabIndex = 3;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(283, 54);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(97, 17);
            this.lblCpfCliente.TabIndex = 2;
            this.lblCpfCliente.Text = "CPF Cliente  : ";
            // 
            // txtCodigoVenda
            // 
            this.txtCodigoVenda.Location = new System.Drawing.Point(122, 54);
            this.txtCodigoVenda.Name = "txtCodigoVenda";
            this.txtCodigoVenda.Size = new System.Drawing.Size(130, 22);
            this.txtCodigoVenda.TabIndex = 1;
            // 
            // lblCodigoVenda
            // 
            this.lblCodigoVenda.AutoSize = true;
            this.lblCodigoVenda.Location = new System.Drawing.Point(7, 54);
            this.lblCodigoVenda.Name = "lblCodigoVenda";
            this.lblCodigoVenda.Size = new System.Drawing.Size(109, 17);
            this.lblCodigoVenda.TabIndex = 0;
            this.lblCodigoVenda.Text = "Código Venda : ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LojaGames.Properties.Resources.cabeçalho_cliente;
            this.pictureBox2.Location = new System.Drawing.Point(13, 469);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 55);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblCodigoFuncionario
            // 
            this.lblCodigoFuncionario.AutoSize = true;
            this.lblCodigoFuncionario.Location = new System.Drawing.Point(577, 54);
            this.lblCodigoFuncionario.Name = "lblCodigoFuncionario";
            this.lblCodigoFuncionario.Size = new System.Drawing.Size(142, 17);
            this.lblCodigoFuncionario.TabIndex = 10;
            this.lblCodigoFuncionario.Text = "Código Funcionario : ";
            // 
            // txtCodigoFuncionario
            // 
            this.txtCodigoFuncionario.Location = new System.Drawing.Point(725, 54);
            this.txtCodigoFuncionario.Name = "txtCodigoFuncionario";
            this.txtCodigoFuncionario.Size = new System.Drawing.Size(101, 22);
            this.txtCodigoFuncionario.TabIndex = 11;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(522, 95);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(127, 36);
            this.btnAdicionarItem.TabIndex = 12;
            this.btnAdicionarItem.Text = "Adiconar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(808, 321);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(100, 22);
            this.txtDesconto.TabIndex = 14;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.Location = new System.Drawing.Point(808, 380);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(100, 22);
            this.txtTotalCompra.TabIndex = 15;
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(696, 321);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(92, 17);
            this.lblDesconto.TabIndex = 16;
            this.lblDesconto.Text = "Desconto % :";
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Location = new System.Drawing.Point(696, 385);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(105, 17);
            this.lblTotalCompra.TabIndex = 17;
            this.lblTotalCompra.Text = "Total Compra : ";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(808, 352);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(100, 22);
            this.txtJuros.TabIndex = 18;
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Location = new System.Drawing.Point(696, 352);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(67, 17);
            this.lblJuros.TabIndex = 19;
            this.lblJuros.Text = "Juros % :";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(283, 95);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(94, 17);
            this.lblQuantidade.TabIndex = 20;
            this.lblQuantidade.Text = "Quantidade : ";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(384, 94);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 22);
            this.txtQuantidade.TabIndex = 21;
            // 
            // telaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "telaVenda";
            this.Text = "telaVenda";
            this.tabControl1.ResumeLayout(false);
            this.abaVenda.ResumeLayout(false);
            this.gbpDadoVenda.ResumeLayout(false);
            this.gbpDadoVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescreveProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
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
    }
}