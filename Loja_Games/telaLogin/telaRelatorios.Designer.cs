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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.abaRelatorioVendaAluga = new System.Windows.Forms.TabPage();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbxDadosVendaAluga = new System.Windows.Forms.GroupBox();
            this.btnEncontrar = new System.Windows.Forms.Button();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.ckAluguel = new System.Windows.Forms.CheckBox();
            this.ckVenda = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbCpfCliente = new System.Windows.Forms.Label();
            this.txtCodVendaAluga = new System.Windows.Forms.TextBox();
            this.lbCodigoVendaAluguel = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lbNomeCliente = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.abaRelatorioVendaAluga.SuspendLayout();
            this.gbxResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxDadosVendaAluga.SuspendLayout();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.abaRelatorioVendaAluga);
            this.tabControl1.Location = new System.Drawing.Point(5, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // abaRelatorioVendaAluga
            // 
            this.abaRelatorioVendaAluga.Controls.Add(this.gbxResultado);
            this.abaRelatorioVendaAluga.Controls.Add(this.gbxDadosVendaAluga);
            this.abaRelatorioVendaAluga.Location = new System.Drawing.Point(4, 22);
            this.abaRelatorioVendaAluga.Name = "abaRelatorioVendaAluga";
            this.abaRelatorioVendaAluga.Padding = new System.Windows.Forms.Padding(3);
            this.abaRelatorioVendaAluga.Size = new System.Drawing.Size(698, 476);
            this.abaRelatorioVendaAluga.TabIndex = 0;
            this.abaRelatorioVendaAluga.Text = "Venda / Aluguel";
            this.abaRelatorioVendaAluga.UseVisualStyleBackColor = true;
            // 
            // gbxResultado
            // 
            this.gbxResultado.Controls.Add(this.dataGridView1);
            this.gbxResultado.Location = new System.Drawing.Point(7, 167);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Size = new System.Drawing.Size(685, 303);
            this.gbxResultado.TabIndex = 1;
            this.gbxResultado.TabStop = false;
            this.gbxResultado.Text = "Resultado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 278);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbxDadosVendaAluga
            // 
            this.gbxDadosVendaAluga.Controls.Add(this.btnEncontrar);
            this.gbxDadosVendaAluga.Controls.Add(this.gbxTipo);
            this.gbxDadosVendaAluga.Controls.Add(this.maskedTextBox1);
            this.gbxDadosVendaAluga.Controls.Add(this.lbCpfCliente);
            this.gbxDadosVendaAluga.Controls.Add(this.txtCodVendaAluga);
            this.gbxDadosVendaAluga.Controls.Add(this.lbCodigoVendaAluguel);
            this.gbxDadosVendaAluga.Controls.Add(this.txtNomeCliente);
            this.gbxDadosVendaAluga.Controls.Add(this.lbNomeCliente);
            this.gbxDadosVendaAluga.Location = new System.Drawing.Point(7, 7);
            this.gbxDadosVendaAluga.Name = "gbxDadosVendaAluga";
            this.gbxDadosVendaAluga.Size = new System.Drawing.Size(685, 153);
            this.gbxDadosVendaAluga.TabIndex = 0;
            this.gbxDadosVendaAluga.TabStop = false;
            this.gbxDadosVendaAluga.Text = "Dados";
            // 
            // btnEncontrar
            // 
            this.btnEncontrar.Location = new System.Drawing.Point(593, 119);
            this.btnEncontrar.Name = "btnEncontrar";
            this.btnEncontrar.Size = new System.Drawing.Size(75, 23);
            this.btnEncontrar.TabIndex = 7;
            this.btnEncontrar.Text = "Encontrar";
            this.btnEncontrar.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.ckAluguel);
            this.gbxTipo.Controls.Add(this.ckVenda);
            this.gbxTipo.Location = new System.Drawing.Point(9, 84);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(77, 63);
            this.gbxTipo.TabIndex = 6;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // ckAluguel
            // 
            this.ckAluguel.AutoSize = true;
            this.ckAluguel.Location = new System.Drawing.Point(7, 41);
            this.ckAluguel.Name = "ckAluguel";
            this.ckAluguel.Size = new System.Drawing.Size(61, 17);
            this.ckAluguel.TabIndex = 1;
            this.ckAluguel.Text = "Aluguel";
            this.ckAluguel.UseVisualStyleBackColor = true;
            // 
            // ckVenda
            // 
            this.ckVenda.AutoSize = true;
            this.ckVenda.Location = new System.Drawing.Point(7, 20);
            this.ckVenda.Name = "ckVenda";
            this.ckVenda.Size = new System.Drawing.Size(57, 17);
            this.ckVenda.TabIndex = 0;
            this.ckVenda.Text = "Venda";
            this.ckVenda.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(479, 57);
            this.maskedTextBox1.Mask = "999,999,999-99";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(99, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // lbCpfCliente
            // 
            this.lbCpfCliente.AutoSize = true;
            this.lbCpfCliente.Location = new System.Drawing.Point(395, 61);
            this.lbCpfCliente.Name = "lbCpfCliente";
            this.lbCpfCliente.Size = new System.Drawing.Size(77, 13);
            this.lbCpfCliente.TabIndex = 4;
            this.lbCpfCliente.Text = "CPF do Cliente";
            // 
            // txtCodVendaAluga
            // 
            this.txtCodVendaAluga.Location = new System.Drawing.Point(134, 25);
            this.txtCodVendaAluga.Name = "txtCodVendaAluga";
            this.txtCodVendaAluga.Size = new System.Drawing.Size(107, 20);
            this.txtCodVendaAluga.TabIndex = 3;
            // 
            // lbCodigoVendaAluguel
            // 
            this.lbCodigoVendaAluguel.AutoSize = true;
            this.lbCodigoVendaAluguel.Location = new System.Drawing.Point(6, 25);
            this.lbCodigoVendaAluguel.Name = "lbCodigoVendaAluguel";
            this.lbCodigoVendaAluguel.Size = new System.Drawing.Size(129, 13);
            this.lbCodigoVendaAluguel.TabIndex = 2;
            this.lbCodigoVendaAluguel.Text = "Código de Venda/Aluguel";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(82, 58);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(307, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // lbNomeCliente
            // 
            this.lbNomeCliente.AutoSize = true;
            this.lbNomeCliente.Location = new System.Drawing.Point(6, 58);
            this.lbNomeCliente.Name = "lbNomeCliente";
            this.lbNomeCliente.Size = new System.Drawing.Size(70, 13);
            this.lbNomeCliente.TabIndex = 0;
            this.lbNomeCliente.Text = "Nome Cliente";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(629, 514);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 27);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // telaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tabControl1);
            this.Name = "telaRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaRelatorios_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.abaRelatorioVendaAluga.ResumeLayout(false);
            this.gbxResultado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxDadosVendaAluga.ResumeLayout(false);
            this.gbxDadosVendaAluga.PerformLayout();
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage abaRelatorioVendaAluga;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxDadosVendaAluga;
        private System.Windows.Forms.Label lbNomeCliente;
        private System.Windows.Forms.Label lbCodigoVendaAluguel;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lbCpfCliente;
        private System.Windows.Forms.TextBox txtCodVendaAluga;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.CheckBox ckAluguel;
        private System.Windows.Forms.CheckBox ckVenda;
        private System.Windows.Forms.GroupBox gbxResultado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEncontrar;
    }
}