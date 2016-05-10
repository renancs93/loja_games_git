namespace LojaGames
{
    partial class telaRelatorios
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
            this.tcVendaAluguel = new System.Windows.Forms.TabControl();
            this.abaRelatorioVendaAluga = new System.Windows.Forms.TabPage();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.gbxDadosVendaAluga = new System.Windows.Forms.GroupBox();
            this.gbxPeriodo = new System.Windows.Forms.GroupBox();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.lbAte = new System.Windows.Forms.Label();
            this.lbDe = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.ckbAluguel = new System.Windows.Forms.CheckBox();
            this.ckbVenda = new System.Windows.Forms.CheckBox();
            this.mtbCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.lbCpfCliente = new System.Windows.Forms.Label();
            this.txtCodVendaAluga = new System.Windows.Forms.TextBox();
            this.lbCodigoVendaAluguel = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pcbGameLogo = new System.Windows.Forms.PictureBox();
            this.tcVendaAluguel.SuspendLayout();
            this.abaRelatorioVendaAluga.SuspendLayout();
            this.gbxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.gbxDadosVendaAluga.SuspendLayout();
            this.gbxPeriodo.SuspendLayout();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcVendaAluguel
            // 
            this.tcVendaAluguel.Controls.Add(this.abaRelatorioVendaAluga);
            this.tcVendaAluguel.Location = new System.Drawing.Point(6, 2);
            this.tcVendaAluguel.Name = "tcVendaAluguel";
            this.tcVendaAluguel.SelectedIndex = 0;
            this.tcVendaAluguel.Size = new System.Drawing.Size(562, 502);
            this.tcVendaAluguel.TabIndex = 0;
            // 
            // abaRelatorioVendaAluga
            // 
            this.abaRelatorioVendaAluga.Controls.Add(this.gbxResultado);
            this.abaRelatorioVendaAluga.Controls.Add(this.gbxDadosVendaAluga);
            this.abaRelatorioVendaAluga.Location = new System.Drawing.Point(4, 22);
            this.abaRelatorioVendaAluga.Name = "abaRelatorioVendaAluga";
            this.abaRelatorioVendaAluga.Padding = new System.Windows.Forms.Padding(3);
            this.abaRelatorioVendaAluga.Size = new System.Drawing.Size(554, 476);
            this.abaRelatorioVendaAluga.TabIndex = 0;
            this.abaRelatorioVendaAluga.Text = "Venda / Aluguel";
            this.abaRelatorioVendaAluga.UseVisualStyleBackColor = true;
            // 
            // gbxResultado
            // 
            this.gbxResultado.Controls.Add(this.dgvResultado);
            this.gbxResultado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxResultado.Location = new System.Drawing.Point(8, 167);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Size = new System.Drawing.Size(539, 303);
            this.gbxResultado.TabIndex = 1;
            this.gbxResultado.TabStop = false;
            this.gbxResultado.Text = "Resultado";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(7, 19);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(526, 278);
            this.dgvResultado.TabIndex = 0;
            // 
            // gbxDadosVendaAluga
            // 
            this.gbxDadosVendaAluga.Controls.Add(this.gbxPeriodo);
            this.gbxDadosVendaAluga.Controls.Add(this.btnGerarRelatorio);
            this.gbxDadosVendaAluga.Controls.Add(this.gbxTipo);
            this.gbxDadosVendaAluga.Controls.Add(this.mtbCpfCliente);
            this.gbxDadosVendaAluga.Controls.Add(this.lbCpfCliente);
            this.gbxDadosVendaAluga.Controls.Add(this.txtCodVendaAluga);
            this.gbxDadosVendaAluga.Controls.Add(this.lbCodigoVendaAluguel);
            this.gbxDadosVendaAluga.Controls.Add(this.txtNomeCliente);
            this.gbxDadosVendaAluga.Controls.Add(this.lbNomeCliente);
            this.gbxDadosVendaAluga.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDadosVendaAluga.Location = new System.Drawing.Point(8, 7);
            this.gbxDadosVendaAluga.Name = "gbxDadosVendaAluga";
            this.gbxDadosVendaAluga.Size = new System.Drawing.Size(539, 153);
            this.gbxDadosVendaAluga.TabIndex = 0;
            this.gbxDadosVendaAluga.TabStop = false;
            this.gbxDadosVendaAluga.Text = "Dados";
            // 
            // gbxPeriodo
            // 
            this.gbxPeriodo.Controls.Add(this.dtpAte);
            this.gbxPeriodo.Controls.Add(this.lbAte);
            this.gbxPeriodo.Controls.Add(this.lbDe);
            this.gbxPeriodo.Controls.Add(this.dtpDe);
            this.gbxPeriodo.Location = new System.Drawing.Point(107, 71);
            this.gbxPeriodo.Name = "gbxPeriodo";
            this.gbxPeriodo.Size = new System.Drawing.Size(190, 76);
            this.gbxPeriodo.TabIndex = 8;
            this.gbxPeriodo.TabStop = false;
            this.gbxPeriodo.Text = "Período";
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(56, 43);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(117, 23);
            this.dtpAte.TabIndex = 3;
            this.dtpAte.Value = new System.DateTime(2016, 4, 30, 0, 0, 0, 0);
            // 
            // lbAte
            // 
            this.lbAte.AutoSize = true;
            this.lbAte.Location = new System.Drawing.Point(9, 48);
            this.lbAte.Name = "lbAte";
            this.lbAte.Size = new System.Drawing.Size(38, 16);
            this.lbAte.TabIndex = 2;
            this.lbAte.Text = "Até:";
            // 
            // lbDe
            // 
            this.lbDe.AutoSize = true;
            this.lbDe.Location = new System.Drawing.Point(9, 22);
            this.lbDe.Name = "lbDe";
            this.lbDe.Size = new System.Drawing.Size(32, 16);
            this.lbDe.TabIndex = 1;
            this.lbDe.Text = "De:";
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(57, 16);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(116, 23);
            this.dtpDe.TabIndex = 0;
            this.dtpDe.Value = new System.DateTime(2016, 4, 30, 0, 0, 0, 0);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(317, 87);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(87, 23);
            this.btnGerarRelatorio.TabIndex = 7;
            this.btnGerarRelatorio.Text = "Gerar Relatorio";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.ckbAluguel);
            this.gbxTipo.Controls.Add(this.ckbVenda);
            this.gbxTipo.Location = new System.Drawing.Point(10, 71);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(90, 76);
            this.gbxTipo.TabIndex = 6;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // ckbAluguel
            // 
            this.ckbAluguel.AutoSize = true;
            this.ckbAluguel.Location = new System.Drawing.Point(8, 48);
            this.ckbAluguel.Name = "ckbAluguel";
            this.ckbAluguel.Size = new System.Drawing.Size(81, 20);
            this.ckbAluguel.TabIndex = 1;
            this.ckbAluguel.Text = "Aluguel";
            this.ckbAluguel.UseVisualStyleBackColor = true;
            // 
            // ckbVenda
            // 
            this.ckbVenda.AutoSize = true;
            this.ckbVenda.Location = new System.Drawing.Point(8, 21);
            this.ckbVenda.Name = "ckbVenda";
            this.ckbVenda.Size = new System.Drawing.Size(73, 20);
            this.ckbVenda.TabIndex = 0;
            this.ckbVenda.Text = "Venda";
            this.ckbVenda.UseVisualStyleBackColor = true;
            // 
            // mtbCpfCliente
            // 
            this.mtbCpfCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfCliente.Location = new System.Drawing.Point(377, 14);
            this.mtbCpfCliente.Mask = "000,000,000-00";
            this.mtbCpfCliente.Name = "mtbCpfCliente";
            this.mtbCpfCliente.Size = new System.Drawing.Size(128, 23);
            this.mtbCpfCliente.TabIndex = 5;
            this.mtbCpfCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCpfCliente_MaskInputRejected);
            // 
            // lbCpfCliente
            // 
            this.lbCpfCliente.AutoSize = true;
            this.lbCpfCliente.Location = new System.Drawing.Point(258, 17);
            this.lbCpfCliente.Name = "lbCpfCliente";
            this.lbCpfCliente.Size = new System.Drawing.Size(113, 16);
            this.lbCpfCliente.TabIndex = 4;
            this.lbCpfCliente.Text = "CPF do Cliente";
            // 
            // txtCodVendaAluga
            // 
            this.txtCodVendaAluga.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVendaAluga.Location = new System.Drawing.Point(206, 14);
            this.txtCodVendaAluga.Name = "txtCodVendaAluga";
            this.txtCodVendaAluga.Size = new System.Drawing.Size(46, 23);
            this.txtCodVendaAluga.TabIndex = 3;
            this.txtCodVendaAluga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodVendaAluga_KeyPress);
            // 
            // lbCodigoVendaAluguel
            // 
            this.lbCodigoVendaAluguel.AutoSize = true;
            this.lbCodigoVendaAluguel.Location = new System.Drawing.Point(7, 17);
            this.lbCodigoVendaAluguel.Name = "lbCodigoVendaAluguel";
            this.lbCodigoVendaAluguel.Size = new System.Drawing.Size(193, 16);
            this.lbCodigoVendaAluguel.TabIndex = 2;
            this.lbCodigoVendaAluguel.Text = "Código de Venda/Aluguel";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(118, 44);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(387, 23);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(7, 44);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(105, 16);
            this.lbNomeCliente.TabIndex = 0;
            this.lbNomeCliente.Text = "Nome Cliente";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(477, 514);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 27);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pcbGameLogo
            // 
            this.pcbGameLogo.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pcbGameLogo.Location = new System.Drawing.Point(6, 506);
            this.pcbGameLogo.Name = "pcbGameLogo";
            this.pcbGameLogo.Size = new System.Drawing.Size(134, 40);
            this.pcbGameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGameLogo.TabIndex = 2;
            this.pcbGameLogo.TabStop = false;
            // 
            // telaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 553);
            this.Controls.Add(this.pcbGameLogo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tcVendaAluguel);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaRelatorios_FormClosing);
            this.tcVendaAluguel.ResumeLayout(false);
            this.abaRelatorioVendaAluga.ResumeLayout(false);
            this.gbxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.gbxDadosVendaAluga.ResumeLayout(false);
            this.gbxDadosVendaAluga.PerformLayout();
            this.gbxPeriodo.ResumeLayout(false);
            this.gbxPeriodo.PerformLayout();
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcVendaAluguel;
        private System.Windows.Forms.TabPage abaRelatorioVendaAluga;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pcbGameLogo;
        private System.Windows.Forms.GroupBox gbxDadosVendaAluga;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbCodigoVendaAluguel;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lbCpfCliente;
        private System.Windows.Forms.TextBox txtCodVendaAluga;
        private System.Windows.Forms.MaskedTextBox mtbCpfCliente;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.CheckBox ckbAluguel;
        private System.Windows.Forms.CheckBox ckbVenda;
        private System.Windows.Forms.GroupBox gbxResultado;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.GroupBox gbxPeriodo;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label lbAte;
        private System.Windows.Forms.Label lbDe;
        private System.Windows.Forms.DateTimePicker dtpAte;
    }
}