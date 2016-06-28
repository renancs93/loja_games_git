namespace LojaGames.View
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
            this.btnSair = new System.Windows.Forms.Button();
            this.gbxDadosVendaAluga = new System.Windows.Forms.GroupBox();
            this.btnBuscarTipo = new System.Windows.Forms.Button();
            this.pcbGameLogo = new System.Windows.Forms.PictureBox();
            this.btnBuscarCod = new System.Windows.Forms.Button();
            this.btnBuscaCpf = new System.Windows.Forms.Button();
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.rbAluguel = new System.Windows.Forms.RadioButton();
            this.rbVenda = new System.Windows.Forms.RadioButton();
            this.mtbCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.lbCpfCliente = new System.Windows.Forms.Label();
            this.txtCodVendaAluga = new System.Windows.Forms.TextBox();
            this.lbCodigoVendaAluguel = new System.Windows.Forms.Label();
            this.tcVendaAluguel.SuspendLayout();
            this.abaRelatorioVendaAluga.SuspendLayout();
            this.gbxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.gbxDadosVendaAluga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameLogo)).BeginInit();
            this.gbxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcVendaAluguel
            // 
            this.tcVendaAluguel.Controls.Add(this.abaRelatorioVendaAluga);
            this.tcVendaAluguel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcVendaAluguel.Location = new System.Drawing.Point(0, 0);
            this.tcVendaAluguel.Name = "tcVendaAluguel";
            this.tcVendaAluguel.SelectedIndex = 0;
            this.tcVendaAluguel.Size = new System.Drawing.Size(799, 532);
            this.tcVendaAluguel.TabIndex = 0;
            // 
            // abaRelatorioVendaAluga
            // 
            this.abaRelatorioVendaAluga.Controls.Add(this.gbxResultado);
            this.abaRelatorioVendaAluga.Controls.Add(this.btnSair);
            this.abaRelatorioVendaAluga.Controls.Add(this.gbxDadosVendaAluga);
            this.abaRelatorioVendaAluga.Location = new System.Drawing.Point(4, 22);
            this.abaRelatorioVendaAluga.Name = "abaRelatorioVendaAluga";
            this.abaRelatorioVendaAluga.Padding = new System.Windows.Forms.Padding(3);
            this.abaRelatorioVendaAluga.Size = new System.Drawing.Size(791, 506);
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
            this.gbxResultado.Size = new System.Drawing.Size(775, 303);
            this.gbxResultado.TabIndex = 1;
            this.gbxResultado.TabStop = false;
            this.gbxResultado.Text = "Resultado";
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResultado.Location = new System.Drawing.Point(3, 19);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(769, 281);
            this.dgvResultado.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(693, 473);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(87, 27);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gbxDadosVendaAluga
            // 
            this.gbxDadosVendaAluga.Controls.Add(this.btnBuscarTipo);
            this.gbxDadosVendaAluga.Controls.Add(this.pcbGameLogo);
            this.gbxDadosVendaAluga.Controls.Add(this.btnBuscarCod);
            this.gbxDadosVendaAluga.Controls.Add(this.btnBuscaCpf);
            this.gbxDadosVendaAluga.Controls.Add(this.btnGerarRelatorio);
            this.gbxDadosVendaAluga.Controls.Add(this.gbxTipo);
            this.gbxDadosVendaAluga.Controls.Add(this.mtbCpfCliente);
            this.gbxDadosVendaAluga.Controls.Add(this.lbCpfCliente);
            this.gbxDadosVendaAluga.Controls.Add(this.txtCodVendaAluga);
            this.gbxDadosVendaAluga.Controls.Add(this.lbCodigoVendaAluguel);
            this.gbxDadosVendaAluga.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDadosVendaAluga.Location = new System.Drawing.Point(8, 7);
            this.gbxDadosVendaAluga.Name = "gbxDadosVendaAluga";
            this.gbxDadosVendaAluga.Size = new System.Drawing.Size(775, 153);
            this.gbxDadosVendaAluga.TabIndex = 0;
            this.gbxDadosVendaAluga.TabStop = false;
            this.gbxDadosVendaAluga.Text = "Dados";
            // 
            // btnBuscarTipo
            // 
            this.btnBuscarTipo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTipo.Location = new System.Drawing.Point(260, 105);
            this.btnBuscarTipo.Name = "btnBuscarTipo";
            this.btnBuscarTipo.Size = new System.Drawing.Size(127, 23);
            this.btnBuscarTipo.TabIndex = 2;
            this.btnBuscarTipo.Text = "Buscar Tipo";
            this.btnBuscarTipo.UseVisualStyleBackColor = true;
            this.btnBuscarTipo.Click += new System.EventHandler(this.btnBuscarTipo_Click);
            // 
            // pcbGameLogo
            // 
            this.pcbGameLogo.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pcbGameLogo.Location = new System.Drawing.Point(664, 14);
            this.pcbGameLogo.Name = "pcbGameLogo";
            this.pcbGameLogo.Size = new System.Drawing.Size(105, 76);
            this.pcbGameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGameLogo.TabIndex = 2;
            this.pcbGameLogo.TabStop = false;
            // 
            // btnBuscarCod
            // 
            this.btnBuscarCod.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCod.Location = new System.Drawing.Point(260, 14);
            this.btnBuscarCod.Name = "btnBuscarCod";
            this.btnBuscarCod.Size = new System.Drawing.Size(127, 23);
            this.btnBuscarCod.TabIndex = 9;
            this.btnBuscarCod.Text = "Buscar Código";
            this.btnBuscarCod.UseVisualStyleBackColor = true;
            this.btnBuscarCod.Click += new System.EventHandler(this.btnBuscarCod_Click);
            // 
            // btnBuscaCpf
            // 
            this.btnBuscaCpf.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCpf.Location = new System.Drawing.Point(260, 53);
            this.btnBuscaCpf.Name = "btnBuscaCpf";
            this.btnBuscaCpf.Size = new System.Drawing.Size(127, 23);
            this.btnBuscaCpf.TabIndex = 8;
            this.btnBuscaCpf.Text = "Buscar CPF";
            this.btnBuscaCpf.UseVisualStyleBackColor = true;
            this.btnBuscaCpf.Click += new System.EventHandler(this.btnBuscaCpf_Click);
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(664, 96);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(105, 45);
            this.btnGerarRelatorio.TabIndex = 7;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Visible = false;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbAluguel);
            this.gbxTipo.Controls.Add(this.rbVenda);
            this.gbxTipo.Location = new System.Drawing.Point(10, 87);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(244, 54);
            this.gbxTipo.TabIndex = 6;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // rbAluguel
            // 
            this.rbAluguel.AutoSize = true;
            this.rbAluguel.Location = new System.Drawing.Point(142, 21);
            this.rbAluguel.Name = "rbAluguel";
            this.rbAluguel.Size = new System.Drawing.Size(80, 20);
            this.rbAluguel.TabIndex = 1;
            this.rbAluguel.TabStop = true;
            this.rbAluguel.Text = "Aluguel";
            this.rbAluguel.UseVisualStyleBackColor = true;
            // 
            // rbVenda
            // 
            this.rbVenda.AutoSize = true;
            this.rbVenda.Location = new System.Drawing.Point(38, 21);
            this.rbVenda.Name = "rbVenda";
            this.rbVenda.Size = new System.Drawing.Size(72, 20);
            this.rbVenda.TabIndex = 0;
            this.rbVenda.TabStop = true;
            this.rbVenda.Text = "Venda";
            this.rbVenda.UseVisualStyleBackColor = true;
            // 
            // mtbCpfCliente
            // 
            this.mtbCpfCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCpfCliente.Location = new System.Drawing.Point(126, 53);
            this.mtbCpfCliente.Mask = "000,000,000-00";
            this.mtbCpfCliente.Name = "mtbCpfCliente";
            this.mtbCpfCliente.Size = new System.Drawing.Size(128, 23);
            this.mtbCpfCliente.TabIndex = 5;
            this.mtbCpfCliente.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbCpfCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCpfCliente_MaskInputRejected);
            // 
            // lbCpfCliente
            // 
            this.lbCpfCliente.AutoSize = true;
            this.lbCpfCliente.Location = new System.Drawing.Point(7, 56);
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
            this.txtCodVendaAluga.Size = new System.Drawing.Size(48, 23);
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
            // telaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 532);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameLogo)).EndInit();
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcVendaAluguel;
        private System.Windows.Forms.TabPage abaRelatorioVendaAluga;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pcbGameLogo;
        private System.Windows.Forms.GroupBox gbxDadosVendaAluga;
        private System.Windows.Forms.Label lbCodigoVendaAluguel;
        private System.Windows.Forms.Label lbCpfCliente;
        private System.Windows.Forms.TextBox txtCodVendaAluga;
        private System.Windows.Forms.MaskedTextBox mtbCpfCliente;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.GroupBox gbxResultado;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.RadioButton rbAluguel;
        private System.Windows.Forms.RadioButton rbVenda;
        private System.Windows.Forms.Button btnBuscarCod;
        private System.Windows.Forms.Button btnBuscaCpf;
        private System.Windows.Forms.Button btnBuscarTipo;
    }
}