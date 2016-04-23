namespace Loja_games
{
    partial class telaCadastroCliente
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.rbntFeminino = new System.Windows.Forms.RadioButton();
            this.rbntMasculino = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Loja_games.Properties.Resources.img_cadastro_cliente1;
            this.pictureBox1.Location = new System.Drawing.Point(167, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosPessoais.Controls.Add(this.cbxStatus);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lbEmail);
            this.gpbDadosPessoais.Controls.Add(this.lbStatus);
            this.gpbDadosPessoais.Controls.Add(this.rbntFeminino);
            this.gpbDadosPessoais.Controls.Add(this.rbntMasculino);
            this.gpbDadosPessoais.Controls.Add(this.lbSexo);
            this.gpbDadosPessoais.Controls.Add(this.txtTelefone);
            this.gpbDadosPessoais.Controls.Add(this.lbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.txtDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lbDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.txtRG);
            this.gpbDadosPessoais.Controls.Add(this.lbRG);
            this.gpbDadosPessoais.Controls.Add(this.txtCPF);
            this.gpbDadosPessoais.Controls.Add(this.lbCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lbNome);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 79);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(604, 215);
            this.gpbDadosPessoais.TabIndex = 1;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Casado\t",
            "Solteiro",
            "Viúvo/a"});
            this.cbxStatus.Location = new System.Drawing.Point(435, 139);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(134, 26);
            this.cbxStatus.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 175);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(495, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(6, 178);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(58, 18);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Email:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(345, 143);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(68, 18);
            this.lbStatus.TabIndex = 12;
            this.lbStatus.Text = "Status:";
            // 
            // rbntFeminino
            // 
            this.rbntFeminino.AutoSize = true;
            this.rbntFeminino.Location = new System.Drawing.Point(211, 141);
            this.rbntFeminino.Name = "rbntFeminino";
            this.rbntFeminino.Size = new System.Drawing.Size(100, 22);
            this.rbntFeminino.TabIndex = 11;
            this.rbntFeminino.TabStop = true;
            this.rbntFeminino.Text = "Feminino";
            this.rbntFeminino.UseVisualStyleBackColor = true;
            // 
            // rbntMasculino
            // 
            this.rbntMasculino.AutoSize = true;
            this.rbntMasculino.Location = new System.Drawing.Point(67, 141);
            this.rbntMasculino.Name = "rbntMasculino";
            this.rbntMasculino.Size = new System.Drawing.Size(105, 22);
            this.rbntMasculino.TabIndex = 2;
            this.rbntMasculino.TabStop = true;
            this.rbntMasculino.Text = "Masculino";
            this.rbntMasculino.UseVisualStyleBackColor = true;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(6, 143);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(55, 18);
            this.lbSexo.TabIndex = 10;
            this.lbSexo.Text = "Sexo:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(435, 107);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(134, 26);
            this.txtTelefone.TabIndex = 9;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(345, 110);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(84, 18);
            this.lbTelefone.TabIndex = 8;
            this.lbTelefone.Text = "Telefone:";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(191, 107);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(120, 26);
            this.txtDataNascimento.TabIndex = 7;
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(6, 110);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(179, 18);
            this.lbDataNascimento.TabIndex = 6;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(389, 70);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(180, 26);
            this.txtRG.TabIndex = 5;
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(345, 73);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(38, 18);
            this.lbRG.TabIndex = 4;
            this.lbRG.Text = "RG:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(74, 70);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(237, 26);
            this.txtCPF.TabIndex = 3;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(6, 73);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(46, 18);
            this.lbCPF.TabIndex = 2;
            this.lbCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(74, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(495, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(6, 34);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(62, 18);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.BackColor = System.Drawing.Color.Transparent;
            this.gpbEndereco.Controls.Add(this.txtCEP);
            this.gpbEndereco.Controls.Add(this.lbCEP);
            this.gpbEndereco.Controls.Add(this.txtEstado);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.txtRua);
            this.gpbEndereco.Controls.Add(this.lbBairro);
            this.gpbEndereco.Controls.Add(this.lbEstado);
            this.gpbEndereco.Controls.Add(this.lbCidade);
            this.gpbEndereco.Controls.Add(this.lbNumero);
            this.gpbEndereco.Controls.Add(this.lbRua);
            this.gpbEndereco.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(12, 300);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(604, 171);
            this.gpbEndereco.TabIndex = 2;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(389, 93);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(180, 26);
            this.txtCEP.TabIndex = 11;
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(345, 96);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(46, 18);
            this.lbCEP.TabIndex = 10;
            this.lbCEP.Text = "CEP:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(74, 126);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(495, 26);
            this.txtEstado.TabIndex = 9;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(74, 93);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(237, 26);
            this.txtCidade.TabIndex = 8;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(211, 61);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(358, 26);
            this.txtBairro.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(74, 61);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 26);
            this.txtNumero.TabIndex = 6;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(74, 28);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(495, 26);
            this.txtRua.TabIndex = 5;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(144, 64);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(63, 18);
            this.lbBairro.TabIndex = 4;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(6, 129);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(70, 18);
            this.lbEstado.TabIndex = 3;
            this.lbEstado.Text = "Estado:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(6, 96);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(69, 18);
            this.lbCidade.TabIndex = 2;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(6, 64);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(35, 18);
            this.lbNumero.TabIndex = 1;
            this.lbNumero.Text = "Nº:";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(6, 31);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(46, 18);
            this.lbRua.TabIndex = 0;
            this.lbRua.Text = "Rua:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(86, 484);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(197, 58);
            this.btnCadastrarCliente.TabIndex = 3;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(360, 485);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(197, 58);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // telaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_games.Properties.Resources.imagem_ps4_editado;
            this.ClientSize = new System.Drawing.Size(634, 562);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbDadosPessoais);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaCadastroCliente";
            this.Text = "telaCadastroCliente";
            this.Load += new System.EventHandler(this.telaCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.RadioButton rbntFeminino;
        private System.Windows.Forms.RadioButton rbntMasculino;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnCancelar;
    }
}