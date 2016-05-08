namespace LojaGames
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
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.rbntFeminino = new System.Windows.Forms.RadioButton();
            this.rbntMasculino = new System.Windows.Forms.RadioButton();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbRG = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pcbCadastroCliente = new System.Windows.Forms.PictureBox();
            this.pcbLogoGame = new System.Windows.Forms.PictureBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbCodigoNumero = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadastroCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.BackColor = System.Drawing.Color.Transparent;
            this.gpbDadosPessoais.Controls.Add(this.mtbRG);
            this.gpbDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.mtbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.mtbCPF);
            this.gpbDadosPessoais.Controls.Add(this.cbxStatus);
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lbEmail);
            this.gpbDadosPessoais.Controls.Add(this.lbStatus);
            this.gpbDadosPessoais.Controls.Add(this.rbntFeminino);
            this.gpbDadosPessoais.Controls.Add(this.rbntMasculino);
            this.gpbDadosPessoais.Controls.Add(this.lbSexo);
            this.gpbDadosPessoais.Controls.Add(this.lbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.lbDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lbRG);
            this.gpbDadosPessoais.Controls.Add(this.lbCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lbNome);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.ForeColor = System.Drawing.Color.Black;
            this.gpbDadosPessoais.Location = new System.Drawing.Point(16, 78);
            this.gpbDadosPessoais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbDadosPessoais.Size = new System.Drawing.Size(805, 254);
            this.gpbDadosPessoais.TabIndex = 3;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // mtbRG
            // 
            this.mtbRG.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRG.Location = new System.Drawing.Point(529, 82);
            this.mtbRG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbRG.Mask = "99,999,999-99";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(228, 27);
            this.mtbRG.TabIndex = 9;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.CustomFormat = "dd/mm/yyyy";
            this.dtpDataNascimento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(229, 134);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(184, 27);
            this.dtpDataNascimento.TabIndex = 11;
            this.dtpDataNascimento.Value = new System.DateTime(2016, 5, 5, 0, 0, 0, 0);
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(580, 132);
            this.mtbTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbTelefone.Mask = "(99)9999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(177, 27);
            this.mtbTelefone.TabIndex = 13;
            this.mtbTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTelefone_MaskInputRejected);
            // 
            // mtbCPF
            // 
            this.mtbCPF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPF.Location = new System.Drawing.Point(99, 86);
            this.mtbCPF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbCPF.Mask = "999,999,999,99";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(315, 27);
            this.mtbCPF.TabIndex = 7;
            this.mtbCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCPF_MaskInputRejected);
            // 
            // cbxStatus
            // 
            this.cbxStatus.BackColor = System.Drawing.Color.White;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.ForeColor = System.Drawing.Color.Black;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Casado/a\t",
            "Solteiro/a",
            "Viúvo/a"});
            this.cbxStatus.Location = new System.Drawing.Point(580, 171);
            this.cbxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(177, 26);
            this.cbxStatus.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(99, 215);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(659, 27);
            this.txtEmail.TabIndex = 20;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(8, 219);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(69, 20);
            this.lbEmail.TabIndex = 19;
            this.lbEmail.Text = "Email:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(460, 176);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(77, 20);
            this.lbStatus.TabIndex = 17;
            this.lbStatus.Text = "Status:";
            // 
            // rbntFeminino
            // 
            this.rbntFeminino.AutoSize = true;
            this.rbntFeminino.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbntFeminino.Location = new System.Drawing.Point(281, 174);
            this.rbntFeminino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbntFeminino.Name = "rbntFeminino";
            this.rbntFeminino.Size = new System.Drawing.Size(109, 24);
            this.rbntFeminino.TabIndex = 16;
            this.rbntFeminino.TabStop = true;
            this.rbntFeminino.Text = "Feminino";
            this.rbntFeminino.UseVisualStyleBackColor = true;
            // 
            // rbntMasculino
            // 
            this.rbntMasculino.AutoSize = true;
            this.rbntMasculino.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbntMasculino.Location = new System.Drawing.Point(89, 174);
            this.rbntMasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbntMasculino.Name = "rbntMasculino";
            this.rbntMasculino.Size = new System.Drawing.Size(114, 24);
            this.rbntMasculino.TabIndex = 15;
            this.rbntMasculino.TabStop = true;
            this.rbntMasculino.Text = "Masculino";
            this.rbntMasculino.UseVisualStyleBackColor = true;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(8, 176);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(62, 20);
            this.lbSexo.TabIndex = 14;
            this.lbSexo.Text = "Sexo:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(460, 135);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(98, 20);
            this.lbTelefone.TabIndex = 12;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataNascimento.Location = new System.Drawing.Point(8, 135);
            this.lbDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(207, 20);
            this.lbDataNascimento.TabIndex = 10;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRG.Location = new System.Drawing.Point(460, 90);
            this.lbRG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(43, 20);
            this.lbRG.TabIndex = 8;
            this.lbRG.Text = "RG:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(8, 90);
            this.lbCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(51, 20);
            this.lbCPF.TabIndex = 6;
            this.lbCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(99, 38);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(659, 27);
            this.txtNome.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(8, 42);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(71, 20);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Nome:";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.BackColor = System.Drawing.Color.Transparent;
            this.gpbEndereco.Controls.Add(this.mtbCEP);
            this.gpbEndereco.Controls.Add(this.cbxEstado);
            this.gpbEndereco.Controls.Add(this.lbCEP);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.lbCidade);
            this.gpbEndereco.Controls.Add(this.txtRua);
            this.gpbEndereco.Controls.Add(this.lbBairro);
            this.gpbEndereco.Controls.Add(this.lbEstado);
            this.gpbEndereco.Controls.Add(this.lbNumero);
            this.gpbEndereco.Controls.Add(this.lbRua);
            this.gpbEndereco.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(16, 340);
            this.gpbEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbEndereco.Size = new System.Drawing.Size(805, 210);
            this.gpbEndereco.TabIndex = 21;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCEP.Location = new System.Drawing.Point(529, 114);
            this.mtbCEP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(228, 27);
            this.mtbCEP.TabIndex = 31;
            this.mtbCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbCEP_MaskInputRejected);
            // 
            // cbxEstado
            // 
            this.cbxEstado.BackColor = System.Drawing.Color.White;
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEstado.ForeColor = System.Drawing.Color.Black;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cbxEstado.Location = new System.Drawing.Point(99, 114);
            this.cbxEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(315, 26);
            this.cbxEstado.TabIndex = 29;
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCEP.Location = new System.Drawing.Point(460, 118);
            this.lbCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(52, 20);
            this.lbCEP.TabIndex = 30;
            this.lbCEP.Text = "CEP:";
            // 
            // txtCidade
            // 
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.ForeColor = System.Drawing.Color.Black;
            this.txtCidade.Location = new System.Drawing.Point(99, 155);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(659, 27);
            this.txtCidade.TabIndex = 33;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.Black;
            this.txtBairro.Location = new System.Drawing.Point(281, 75);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(476, 27);
            this.txtBairro.TabIndex = 27;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(99, 75);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(84, 27);
            this.txtNumero.TabIndex = 25;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(8, 159);
            this.lbCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(80, 20);
            this.lbCidade.TabIndex = 32;
            this.lbCidade.Text = "Cidade:";
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.White;
            this.txtRua.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.Black;
            this.txtRua.Location = new System.Drawing.Point(99, 34);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(659, 27);
            this.txtRua.TabIndex = 23;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(192, 79);
            this.lbBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(74, 20);
            this.lbBairro.TabIndex = 26;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(8, 118);
            this.lbEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(81, 20);
            this.lbEstado.TabIndex = 28;
            this.lbEstado.Text = "Estado:";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(8, 79);
            this.lbNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(40, 20);
            this.lbNumero.TabIndex = 24;
            this.lbNumero.Text = "Nº:";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRua.Location = new System.Drawing.Point(8, 38);
            this.lbRua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(52, 20);
            this.lbRua.TabIndex = 22;
            this.lbRua.Text = "Rua:";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(115, 559);
            this.btnCadastrarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(263, 71);
            this.btnCadastrarCliente.TabIndex = 34;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(480, 560);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(263, 71);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pcbCadastroCliente
            // 
            this.pcbCadastroCliente.Image = global::LojaGames.Properties.Resources.img_cadastro_cliente;
            this.pcbCadastroCliente.Location = new System.Drawing.Point(245, 15);
            this.pcbCadastroCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbCadastroCliente.Name = "pcbCadastroCliente";
            this.pcbCadastroCliente.Size = new System.Drawing.Size(384, 49);
            this.pcbCadastroCliente.TabIndex = 6;
            this.pcbCadastroCliente.TabStop = false;
            // 
            // pcbLogoGame
            // 
            this.pcbLogoGame.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pcbLogoGame.Location = new System.Drawing.Point(16, 15);
            this.pcbLogoGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbLogoGame.Name = "pcbLogoGame";
            this.pcbLogoGame.Size = new System.Drawing.Size(173, 49);
            this.pcbLogoGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoGame.TabIndex = 5;
            this.pcbLogoGame.TabStop = false;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(680, 34);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(82, 20);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código:";
            // 
            // lbCodigoNumero
            // 
            this.lbCodigoNumero.AutoSize = true;
            this.lbCodigoNumero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoNumero.Location = new System.Drawing.Point(772, 34);
            this.lbCodigoNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigoNumero.Name = "lbCodigoNumero";
            this.lbCodigoNumero.Size = new System.Drawing.Size(21, 20);
            this.lbCodigoNumero.TabIndex = 1;
            this.lbCodigoNumero.Text = "1";
            // 
            // telaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 655);
            this.Controls.Add(this.lbCodigoNumero);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.pcbCadastroCliente);
            this.Controls.Add(this.pcbLogoGame);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaCadastroCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaCadastroCliente_FormClosing);
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCadastroCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.RadioButton rbntFeminino;
        private System.Windows.Forms.RadioButton rbntMasculino;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.Label lbCEP;
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
        private System.Windows.Forms.PictureBox pcbLogoGame;
        private System.Windows.Forms.PictureBox pcbCadastroCliente;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbCodigoNumero;
        private System.Windows.Forms.MaskedTextBox mtbRG;
    }
}