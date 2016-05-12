namespace LojaGames.View
{
    partial class telaGerFuncionario
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
            this.abasGerFuncionario = new System.Windows.Forms.TabControl();
            this.abaCadFuncionario = new System.Windows.Forms.TabPage();
            this.gpbDadosCadastrais = new System.Windows.Forms.GroupBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.lbDataInicio = new System.Windows.Forms.Label();
            this.txtSalarioBase = new System.Windows.Forms.TextBox();
            this.lbSalarioBase = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lbRua = new System.Windows.Forms.Label();
            this.mtbCEP = new System.Windows.Forms.MaskedTextBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtnNInformado = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.lbRG = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCodigoNumero = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.abaExibiFuncionario = new System.Windows.Forms.TabPage();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.abasGerFuncionario.SuspendLayout();
            this.abaCadFuncionario.SuspendLayout();
            this.gpbDadosCadastrais.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // abasGerFuncionario
            // 
            this.abasGerFuncionario.Controls.Add(this.abaCadFuncionario);
            this.abasGerFuncionario.Controls.Add(this.abaExibiFuncionario);
            this.abasGerFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abasGerFuncionario.Location = new System.Drawing.Point(0, 0);
            this.abasGerFuncionario.Name = "abasGerFuncionario";
            this.abasGerFuncionario.SelectedIndex = 0;
            this.abasGerFuncionario.Size = new System.Drawing.Size(821, 643);
            this.abasGerFuncionario.TabIndex = 0;
            // 
            // abaCadFuncionario
            // 
            this.abaCadFuncionario.Controls.Add(this.btnCancelar);
            this.abaCadFuncionario.Controls.Add(this.btnCadastrarFuncionario);
            this.abaCadFuncionario.Controls.Add(this.gpbDadosCadastrais);
            this.abaCadFuncionario.Controls.Add(this.gpbEndereco);
            this.abaCadFuncionario.Controls.Add(this.gpbDadosPessoais);
            this.abaCadFuncionario.Location = new System.Drawing.Point(4, 22);
            this.abaCadFuncionario.Name = "abaCadFuncionario";
            this.abaCadFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.abaCadFuncionario.Size = new System.Drawing.Size(813, 617);
            this.abaCadFuncionario.TabIndex = 0;
            this.abaCadFuncionario.Text = "Cadastro de Funcionário";
            this.abaCadFuncionario.UseVisualStyleBackColor = true;
            // 
            // gpbDadosCadastrais
            // 
            this.gpbDadosCadastrais.Controls.Add(this.btnCadastro);
            this.gpbDadosCadastrais.Controls.Add(this.dtpDataInicio);
            this.gpbDadosCadastrais.Controls.Add(this.lbDataInicio);
            this.gpbDadosCadastrais.Controls.Add(this.txtSalarioBase);
            this.gpbDadosCadastrais.Controls.Add(this.lbSalarioBase);
            this.gpbDadosCadastrais.Controls.Add(this.txtCargo);
            this.gpbDadosCadastrais.Controls.Add(this.lbCargo);
            this.gpbDadosCadastrais.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosCadastrais.Location = new System.Drawing.Point(18, 433);
            this.gpbDadosCadastrais.Name = "gpbDadosCadastrais";
            this.gpbDadosCadastrais.Size = new System.Drawing.Size(776, 100);
            this.gpbDadosCadastrais.TabIndex = 3;
            this.gpbDadosCadastrais.TabStop = false;
            this.gpbDadosCadastrais.Text = "Dados Cadastrais";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(503, 66);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(148, 23);
            this.btnCadastro.TabIndex = 20;
            this.btnCadastro.Text = "Cadastrar Senha:";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(502, 30);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(149, 22);
            this.dtpDataInicio.TabIndex = 18;
            // 
            // lbDataInicio
            // 
            this.lbDataInicio.AutoSize = true;
            this.lbDataInicio.Location = new System.Drawing.Point(392, 33);
            this.lbDataInicio.Name = "lbDataInicio";
            this.lbDataInicio.Size = new System.Drawing.Size(104, 14);
            this.lbDataInicio.TabIndex = 4;
            this.lbDataInicio.Text = "Data de Início:";
            // 
            // txtSalarioBase
            // 
            this.txtSalarioBase.Location = new System.Drawing.Point(135, 67);
            this.txtSalarioBase.Name = "txtSalarioBase";
            this.txtSalarioBase.Size = new System.Drawing.Size(144, 22);
            this.txtSalarioBase.TabIndex = 19;
            // 
            // lbSalarioBase
            // 
            this.lbSalarioBase.AutoSize = true;
            this.lbSalarioBase.Location = new System.Drawing.Point(33, 70);
            this.lbSalarioBase.Name = "lbSalarioBase";
            this.lbSalarioBase.Size = new System.Drawing.Size(95, 14);
            this.lbSalarioBase.TabIndex = 2;
            this.lbSalarioBase.Text = "Salário Base:";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(92, 30);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(282, 22);
            this.txtCargo.TabIndex = 17;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(33, 33);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(51, 14);
            this.lbCargo.TabIndex = 0;
            this.lbCargo.Text = "Cargo:";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.cbxEstado);
            this.gpbEndereco.Controls.Add(this.lbEstado);
            this.gpbEndereco.Controls.Add(this.txtCidade);
            this.gpbEndereco.Controls.Add(this.lbCidade);
            this.gpbEndereco.Controls.Add(this.txtBairro);
            this.gpbEndereco.Controls.Add(this.lbBairro);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.lbNumero);
            this.gpbEndereco.Controls.Add(this.txtRua);
            this.gpbEndereco.Controls.Add(this.lbRua);
            this.gpbEndereco.Controls.Add(this.mtbCEP);
            this.gpbEndereco.Controls.Add(this.lbCEP);
            this.gpbEndereco.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(18, 264);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(776, 153);
            this.gpbEndereco.TabIndex = 2;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxEstado.Location = new System.Drawing.Point(688, 106);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(64, 22);
            this.cbxEstado.TabIndex = 16;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(618, 109);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(56, 14);
            this.lbEstado.TabIndex = 10;
            this.lbEstado.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(455, 106);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(143, 22);
            this.txtCidade.TabIndex = 15;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(392, 109);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(57, 14);
            this.lbCidade.TabIndex = 8;
            this.lbCidade.Text = "Cidade:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(92, 106);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(282, 22);
            this.txtBairro.TabIndex = 14;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(33, 109);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(53, 14);
            this.lbBairro.TabIndex = 6;
            this.lbBairro.Text = "Bairro:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(688, 66);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(64, 22);
            this.txtNumero.TabIndex = 13;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(618, 69);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(64, 14);
            this.lbNumero.TabIndex = 4;
            this.lbNumero.Text = "Número:";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(92, 66);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(506, 22);
            this.txtRua.TabIndex = 12;
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(34, 69);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(37, 14);
            this.lbRua.TabIndex = 2;
            this.lbRua.Text = "Rua:";
            // 
            // mtbCEP
            // 
            this.mtbCEP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCEP.Location = new System.Drawing.Point(92, 28);
            this.mtbCEP.Mask = "00000-000";
            this.mtbCEP.Name = "mtbCEP";
            this.mtbCEP.Size = new System.Drawing.Size(90, 22);
            this.mtbCEP.TabIndex = 11;
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Location = new System.Drawing.Point(33, 31);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(38, 14);
            this.lbCEP.TabIndex = 0;
            this.lbCEP.Text = "CEP:";
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.txtEmail);
            this.gpbDadosPessoais.Controls.Add(this.lbEmail);
            this.gpbDadosPessoais.Controls.Add(this.cbxStatus);
            this.gpbDadosPessoais.Controls.Add(this.lbEstadoCivil);
            this.gpbDadosPessoais.Controls.Add(this.mtbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.lbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.gpbSexo);
            this.gpbDadosPessoais.Controls.Add(this.dtpDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lbDataNascimento);
            this.gpbDadosPessoais.Controls.Add(this.mtbRG);
            this.gpbDadosPessoais.Controls.Add(this.lbRG);
            this.gpbDadosPessoais.Controls.Add(this.mtbCPF);
            this.gpbDadosPessoais.Controls.Add(this.lbCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtNome);
            this.gpbDadosPessoais.Controls.Add(this.lbNome);
            this.gpbDadosPessoais.Controls.Add(this.lbCodigoNumero);
            this.gpbDadosPessoais.Controls.Add(this.lbCodigo);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(18, 17);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(776, 232);
            this.gpbDadosPessoais.TabIndex = 1;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados Pessoais";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(308, 173);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(444, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(248, 178);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 14);
            this.lbEmail.TabIndex = 15;
            this.lbEmail.Text = "Email:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "Solteiro/a",
            "Casado/a",
            "Viúvo/a"});
            this.cbxStatus.Location = new System.Drawing.Point(347, 123);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 22);
            this.cbxStatus.TabIndex = 8;
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Location = new System.Drawing.Point(248, 126);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(89, 14);
            this.lbEstadoCivil.TabIndex = 13;
            this.lbEstadoCivil.Text = "Estado Civil:";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTelefone.Location = new System.Drawing.Point(566, 123);
            this.mtbTelefone.Mask = "(00)00000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(142, 22);
            this.mtbTelefone.TabIndex = 9;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(491, 126);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(69, 14);
            this.lbTelefone.TabIndex = 11;
            this.lbTelefone.Text = "Telefone:";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtnNInformado);
            this.gpbSexo.Controls.Add(this.rbtnFeminino);
            this.gpbSexo.Controls.Add(this.rbtnMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(36, 123);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(158, 92);
            this.gpbSexo.TabIndex = 10;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbtnNInformado
            // 
            this.rbtnNInformado.AutoSize = true;
            this.rbtnNInformado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNInformado.Location = new System.Drawing.Point(26, 68);
            this.rbtnNInformado.Name = "rbtnNInformado";
            this.rbtnNInformado.Size = new System.Drawing.Size(119, 18);
            this.rbtnNInformado.TabIndex = 7;
            this.rbtnNInformado.TabStop = true;
            this.rbtnNInformado.Text = "Não Informado";
            this.rbtnNInformado.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFeminino.Location = new System.Drawing.Point(26, 44);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(81, 18);
            this.rbtnFeminino.TabIndex = 6;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(26, 20);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(86, 18);
            this.rbtnMasculino.TabIndex = 5;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(610, 75);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(142, 22);
            this.dtpDataNascimento.TabIndex = 4;
            this.dtpDataNascimento.Value = new System.DateTime(2016, 5, 11, 0, 0, 0, 0);
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(460, 78);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(144, 14);
            this.lbDataNascimento.TabIndex = 8;
            this.lbDataNascimento.Text = "Data de Nascimento:";
            // 
            // mtbRG
            // 
            this.mtbRG.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbRG.Location = new System.Drawing.Point(285, 75);
            this.mtbRG.Mask = "00,000,000-00";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(117, 22);
            this.mtbRG.TabIndex = 3;
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Location = new System.Drawing.Point(248, 78);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(31, 14);
            this.lbRG.TabIndex = 6;
            this.lbRG.Text = "RG:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCPF.Location = new System.Drawing.Point(92, 75);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(122, 22);
            this.mtbCPF.TabIndex = 2;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(45, 78);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(38, 14);
            this.lbCPF.TabIndex = 4;
            this.lbCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(92, 32);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(433, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(33, 35);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(50, 14);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // lbCodigoNumero
            // 
            this.lbCodigoNumero.AutoSize = true;
            this.lbCodigoNumero.Location = new System.Drawing.Point(725, 35);
            this.lbCodigoNumero.Name = "lbCodigoNumero";
            this.lbCodigoNumero.Size = new System.Drawing.Size(16, 14);
            this.lbCodigoNumero.TabIndex = 1;
            this.lbCodigoNumero.Text = "1";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(662, 35);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(57, 14);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Código:";
            // 
            // abaExibiFuncionario
            // 
            this.abaExibiFuncionario.Location = new System.Drawing.Point(4, 22);
            this.abaExibiFuncionario.Name = "abaExibiFuncionario";
            this.abaExibiFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.abaExibiFuncionario.Size = new System.Drawing.Size(813, 550);
            this.abaExibiFuncionario.TabIndex = 1;
            this.abaExibiFuncionario.Text = "Exibir Funcionários";
            this.abaExibiFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(584, 553);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(95, 45);
            this.btnCadastrarFuncionario.TabIndex = 4;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(699, 553);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 45);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // telaGerFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 643);
            this.Controls.Add(this.abasGerFuncionario);
            this.MaximizeBox = false;
            this.Name = "telaGerFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Funcionário";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaGerFuncionario_FormClosing);
            this.abasGerFuncionario.ResumeLayout(false);
            this.abaCadFuncionario.ResumeLayout(false);
            this.gpbDadosCadastrais.ResumeLayout(false);
            this.gpbDadosCadastrais.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl abasGerFuncionario;
        private System.Windows.Forms.TabPage abaCadFuncionario;
        private System.Windows.Forms.TabPage abaExibiFuncionario;
        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCodigoNumero;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.MaskedTextBox mtbCEP;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.RadioButton rbtnNInformado;
        private System.Windows.Forms.GroupBox gpbDadosCadastrais;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label lbDataInicio;
        private System.Windows.Forms.TextBox txtSalarioBase;
        private System.Windows.Forms.Label lbSalarioBase;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
    }
}