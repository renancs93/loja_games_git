namespace LojaGames.View
{
    partial class telaGerCliente
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
            this.abasGerCliente = new System.Windows.Forms.TabControl();
            this.abaCadCliente = new System.Windows.Forms.TabPage();
            this.pcbLogoCli = new System.Windows.Forms.PictureBox();
            this.btnCancelarCli = new System.Windows.Forms.Button();
            this.btnCadastrarCli = new System.Windows.Forms.Button();
            this.gpbEnderecoCli = new System.Windows.Forms.GroupBox();
            this.cbxEstadoCli = new System.Windows.Forms.ComboBox();
            this.mtbCepCli = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroCli = new System.Windows.Forms.TextBox();
            this.txtCidadeCli = new System.Windows.Forms.TextBox();
            this.txtBairroCli = new System.Windows.Forms.TextBox();
            this.txtRuaCli = new System.Windows.Forms.TextBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbCep = new System.Windows.Forms.Label();
            this.gbpDadosPessoaisCli = new System.Windows.Forms.GroupBox();
            this.gbpSexo = new System.Windows.Forms.GroupBox();
            this.rbtnNaoInformadoCli = new System.Windows.Forms.RadioButton();
            this.rbtnFemininoCli = new System.Windows.Forms.RadioButton();
            this.rbtnMasculinoCli = new System.Windows.Forms.RadioButton();
            this.dtpDataNascCli = new System.Windows.Forms.DateTimePicker();
            this.cbxEstadoCivilCli = new System.Windows.Forms.ComboBox();
            this.mtbTelefoneCli = new System.Windows.Forms.MaskedTextBox();
            this.mtbRgCli = new System.Windows.Forms.MaskedTextBox();
            this.mtbCpfCli = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lbCodigoNumeroCli = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.lbRg = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.abaExibiCliente = new System.Windows.Forms.TabPage();
            this.btnSairCli = new System.Windows.Forms.Button();
            this.btnExibirTodosCli = new System.Windows.Forms.Button();
            this.pcbLogoExiCli = new System.Windows.Forms.PictureBox();
            this.gpbDadosExibeCli = new System.Windows.Forms.GroupBox();
            this.dgvExibeCli = new System.Windows.Forms.DataGridView();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbBuscaCli = new System.Windows.Forms.GroupBox();
            this.btnBuscarCli = new System.Windows.Forms.Button();
            this.btnEditarCli = new System.Windows.Forms.Button();
            this.btnExcluirCli = new System.Windows.Forms.Button();
            this.mtbCpfExiCli = new System.Windows.Forms.MaskedTextBox();
            this.txtNomeExiCli = new System.Windows.Forms.TextBox();
            this.lbNomeExibeCli = new System.Windows.Forms.Label();
            this.lbOU = new System.Windows.Forms.Label();
            this.lbCpfExibeCli = new System.Windows.Forms.Label();
            this.abasGerCliente.SuspendLayout();
            this.abaCadCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCli)).BeginInit();
            this.gpbEnderecoCli.SuspendLayout();
            this.gbpDadosPessoaisCli.SuspendLayout();
            this.gbpSexo.SuspendLayout();
            this.abaExibiCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoExiCli)).BeginInit();
            this.gpbDadosExibeCli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibeCli)).BeginInit();
            this.gpbBuscaCli.SuspendLayout();
            this.SuspendLayout();
            // 
            // abasGerCliente
            // 
            this.abasGerCliente.Controls.Add(this.abaCadCliente);
            this.abasGerCliente.Controls.Add(this.abaExibiCliente);
            this.abasGerCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abasGerCliente.Location = new System.Drawing.Point(0, 0);
            this.abasGerCliente.Name = "abasGerCliente";
            this.abasGerCliente.SelectedIndex = 0;
            this.abasGerCliente.Size = new System.Drawing.Size(815, 580);
            this.abasGerCliente.TabIndex = 0;
            // 
            // abaCadCliente
            // 
            this.abaCadCliente.Controls.Add(this.pcbLogoCli);
            this.abaCadCliente.Controls.Add(this.btnCancelarCli);
            this.abaCadCliente.Controls.Add(this.btnCadastrarCli);
            this.abaCadCliente.Controls.Add(this.gpbEnderecoCli);
            this.abaCadCliente.Controls.Add(this.gbpDadosPessoaisCli);
            this.abaCadCliente.Location = new System.Drawing.Point(4, 22);
            this.abaCadCliente.Name = "abaCadCliente";
            this.abaCadCliente.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.abaCadCliente.Size = new System.Drawing.Size(807, 493);
            this.abaCadCliente.TabIndex = 0;
            this.abaCadCliente.Text = "Cadastrar Cliente";
            this.abaCadCliente.UseVisualStyleBackColor = true;
            // 
            // pcbLogoCli
            // 
            this.pcbLogoCli.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pcbLogoCli.Location = new System.Drawing.Point(18, 420);
            this.pcbLogoCli.Name = "pcbLogoCli";
            this.pcbLogoCli.Size = new System.Drawing.Size(128, 69);
            this.pcbLogoCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoCli.TabIndex = 6;
            this.pcbLogoCli.TabStop = false;
            // 
            // btnCancelarCli
            // 
            this.btnCancelarCli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarCli.Location = new System.Drawing.Point(699, 435);
            this.btnCancelarCli.Name = "btnCancelarCli";
            this.btnCancelarCli.Size = new System.Drawing.Size(95, 45);
            this.btnCancelarCli.TabIndex = 5;
            this.btnCancelarCli.Text = "Cancelar";
            this.btnCancelarCli.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarCli
            // 
            this.btnCadastrarCli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadastrarCli.Location = new System.Drawing.Point(584, 435);
            this.btnCadastrarCli.Name = "btnCadastrarCli";
            this.btnCadastrarCli.Size = new System.Drawing.Size(95, 45);
            this.btnCadastrarCli.TabIndex = 4;
            this.btnCadastrarCli.Text = "Cadastrar";
            this.btnCadastrarCli.UseVisualStyleBackColor = true;
            // 
            // gpbEnderecoCli
            // 
            this.gpbEnderecoCli.Controls.Add(this.cbxEstadoCli);
            this.gpbEnderecoCli.Controls.Add(this.mtbCepCli);
            this.gpbEnderecoCli.Controls.Add(this.txtNumeroCli);
            this.gpbEnderecoCli.Controls.Add(this.txtCidadeCli);
            this.gpbEnderecoCli.Controls.Add(this.txtBairroCli);
            this.gpbEnderecoCli.Controls.Add(this.txtRuaCli);
            this.gpbEnderecoCli.Controls.Add(this.lbEstado);
            this.gpbEnderecoCli.Controls.Add(this.lbNumero);
            this.gpbEnderecoCli.Controls.Add(this.lbCidade);
            this.gpbEnderecoCli.Controls.Add(this.lbBairro);
            this.gpbEnderecoCli.Controls.Add(this.lbRua);
            this.gpbEnderecoCli.Controls.Add(this.lbCep);
            this.gpbEnderecoCli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.gpbEnderecoCli.Location = new System.Drawing.Point(18, 262);
            this.gpbEnderecoCli.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.gpbEnderecoCli.Name = "gpbEnderecoCli";
            this.gpbEnderecoCli.Size = new System.Drawing.Size(776, 155);
            this.gpbEnderecoCli.TabIndex = 1;
            this.gpbEnderecoCli.TabStop = false;
            this.gpbEnderecoCli.Text = "Endereço";
            // 
            // cbxEstadoCli
            // 
            this.cbxEstadoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoCli.FormattingEnabled = true;
            this.cbxEstadoCli.Items.AddRange(new object[] {
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
            this.cbxEstadoCli.Location = new System.Drawing.Point(688, 106);
            this.cbxEstadoCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEstadoCli.Name = "cbxEstadoCli";
            this.cbxEstadoCli.Size = new System.Drawing.Size(64, 22);
            this.cbxEstadoCli.TabIndex = 16;
            // 
            // mtbCepCli
            // 
            this.mtbCepCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.mtbCepCli.Location = new System.Drawing.Point(92, 28);
            this.mtbCepCli.Mask = "00000-000";
            this.mtbCepCli.Name = "mtbCepCli";
            this.mtbCepCli.Size = new System.Drawing.Size(90, 22);
            this.mtbCepCli.TabIndex = 11;
            this.mtbCepCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNumeroCli
            // 
            this.txtNumeroCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtNumeroCli.Location = new System.Drawing.Point(688, 66);
            this.txtNumeroCli.Name = "txtNumeroCli";
            this.txtNumeroCli.Size = new System.Drawing.Size(64, 22);
            this.txtNumeroCli.TabIndex = 13;
            // 
            // txtCidadeCli
            // 
            this.txtCidadeCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtCidadeCli.Location = new System.Drawing.Point(455, 106);
            this.txtCidadeCli.Name = "txtCidadeCli";
            this.txtCidadeCli.Size = new System.Drawing.Size(143, 22);
            this.txtCidadeCli.TabIndex = 15;
            // 
            // txtBairroCli
            // 
            this.txtBairroCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtBairroCli.Location = new System.Drawing.Point(92, 106);
            this.txtBairroCli.Name = "txtBairroCli";
            this.txtBairroCli.Size = new System.Drawing.Size(282, 22);
            this.txtBairroCli.TabIndex = 14;
            // 
            // txtRuaCli
            // 
            this.txtRuaCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtRuaCli.Location = new System.Drawing.Point(92, 66);
            this.txtRuaCli.Name = "txtRuaCli";
            this.txtRuaCli.Size = new System.Drawing.Size(506, 22);
            this.txtRuaCli.TabIndex = 12;
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(618, 109);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(60, 14);
            this.lbEstado.TabIndex = 10;
            this.lbEstado.Text = "Estado: ";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(618, 69);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(68, 14);
            this.lbNumero.TabIndex = 4;
            this.lbNumero.Text = "Número: ";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(392, 109);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(61, 14);
            this.lbCidade.TabIndex = 8;
            this.lbCidade.Text = "Cidade: ";
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(33, 109);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(57, 14);
            this.lbBairro.TabIndex = 6;
            this.lbBairro.Text = "Bairro: ";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(34, 69);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(41, 14);
            this.lbRua.TabIndex = 1;
            this.lbRua.Text = "Rua: ";
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(33, 31);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(42, 14);
            this.lbCep.TabIndex = 0;
            this.lbCep.Text = "CEP: ";
            // 
            // gbpDadosPessoaisCli
            // 
            this.gbpDadosPessoaisCli.Controls.Add(this.gbpSexo);
            this.gbpDadosPessoaisCli.Controls.Add(this.dtpDataNascCli);
            this.gbpDadosPessoaisCli.Controls.Add(this.cbxEstadoCivilCli);
            this.gbpDadosPessoaisCli.Controls.Add(this.mtbTelefoneCli);
            this.gbpDadosPessoaisCli.Controls.Add(this.mtbRgCli);
            this.gbpDadosPessoaisCli.Controls.Add(this.mtbCpfCli);
            this.gbpDadosPessoaisCli.Controls.Add(this.txtEmailCli);
            this.gbpDadosPessoaisCli.Controls.Add(this.txtNomeCli);
            this.gbpDadosPessoaisCli.Controls.Add(this.lbCodigoNumeroCli);
            this.gbpDadosPessoaisCli.Controls.Add(this.lbCodigo);
            this.gbpDadosPessoaisCli.Controls.Add(this.lbEmail);
            this.gbpDadosPessoaisCli.Controls.Add(this.lbTelefone);
            this.gbpDadosPessoaisCli.Controls.Add(this.lbDataNascimento);
            this.gbpDadosPessoaisCli.Controls.Add(this.lbEstadoCivil);
            this.gbpDadosPessoaisCli.Controls.Add(this.lbRg);
            this.gbpDadosPessoaisCli.Controls.Add(this.lbCpf);
            this.gbpDadosPessoaisCli.Controls.Add(this.lbNome);
            this.gbpDadosPessoaisCli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.gbpDadosPessoaisCli.Location = new System.Drawing.Point(18, 17);
            this.gbpDadosPessoaisCli.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.gbpDadosPessoaisCli.Name = "gbpDadosPessoaisCli";
            this.gbpDadosPessoaisCli.Size = new System.Drawing.Size(776, 232);
            this.gbpDadosPessoaisCli.TabIndex = 0;
            this.gbpDadosPessoaisCli.TabStop = false;
            this.gbpDadosPessoaisCli.Text = "Dados Pessoais";
            // 
            // gbpSexo
            // 
            this.gbpSexo.Controls.Add(this.rbtnNaoInformadoCli);
            this.gbpSexo.Controls.Add(this.rbtnFemininoCli);
            this.gbpSexo.Controls.Add(this.rbtnMasculinoCli);
            this.gbpSexo.Location = new System.Drawing.Point(36, 123);
            this.gbpSexo.Name = "gbpSexo";
            this.gbpSexo.Size = new System.Drawing.Size(158, 92);
            this.gbpSexo.TabIndex = 10;
            this.gbpSexo.TabStop = false;
            this.gbpSexo.Text = "Sexo";
            // 
            // rbtnNaoInformadoCli
            // 
            this.rbtnNaoInformadoCli.AutoSize = true;
            this.rbtnNaoInformadoCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.rbtnNaoInformadoCli.Location = new System.Drawing.Point(26, 68);
            this.rbtnNaoInformadoCli.Name = "rbtnNaoInformadoCli";
            this.rbtnNaoInformadoCli.Size = new System.Drawing.Size(119, 18);
            this.rbtnNaoInformadoCli.TabIndex = 7;
            this.rbtnNaoInformadoCli.TabStop = true;
            this.rbtnNaoInformadoCli.Text = "Não Informado";
            this.rbtnNaoInformadoCli.UseVisualStyleBackColor = true;
            // 
            // rbtnFemininoCli
            // 
            this.rbtnFemininoCli.AutoSize = true;
            this.rbtnFemininoCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.rbtnFemininoCli.Location = new System.Drawing.Point(26, 44);
            this.rbtnFemininoCli.Name = "rbtnFemininoCli";
            this.rbtnFemininoCli.Size = new System.Drawing.Size(81, 18);
            this.rbtnFemininoCli.TabIndex = 6;
            this.rbtnFemininoCli.TabStop = true;
            this.rbtnFemininoCli.Text = "Feminino";
            this.rbtnFemininoCli.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculinoCli
            // 
            this.rbtnMasculinoCli.AutoSize = true;
            this.rbtnMasculinoCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.rbtnMasculinoCli.Location = new System.Drawing.Point(26, 20);
            this.rbtnMasculinoCli.Name = "rbtnMasculinoCli";
            this.rbtnMasculinoCli.Size = new System.Drawing.Size(86, 18);
            this.rbtnMasculinoCli.TabIndex = 5;
            this.rbtnMasculinoCli.TabStop = true;
            this.rbtnMasculinoCli.Text = "Masculino";
            this.rbtnMasculinoCli.UseVisualStyleBackColor = true;
            // 
            // dtpDataNascCli
            // 
            this.dtpDataNascCli.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascCli.Location = new System.Drawing.Point(610, 75);
            this.dtpDataNascCli.Name = "dtpDataNascCli";
            this.dtpDataNascCli.Size = new System.Drawing.Size(131, 22);
            this.dtpDataNascCli.TabIndex = 16;
            this.dtpDataNascCli.Value = new System.DateTime(2016, 5, 14, 0, 0, 0, 0);
            // 
            // cbxEstadoCivilCli
            // 
            this.cbxEstadoCivilCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoCivilCli.FormattingEnabled = true;
            this.cbxEstadoCivilCli.Items.AddRange(new object[] {
            "Solteiro/a",
            "Casado/a",
            "Viúvo/a"});
            this.cbxEstadoCivilCli.Location = new System.Drawing.Point(347, 123);
            this.cbxEstadoCivilCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxEstadoCivilCli.Name = "cbxEstadoCivilCli";
            this.cbxEstadoCivilCli.Size = new System.Drawing.Size(121, 22);
            this.cbxEstadoCivilCli.TabIndex = 8;
            // 
            // mtbTelefoneCli
            // 
            this.mtbTelefoneCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.mtbTelefoneCli.Location = new System.Drawing.Point(566, 123);
            this.mtbTelefoneCli.Mask = "(00)00000-0000";
            this.mtbTelefoneCli.Name = "mtbTelefoneCli";
            this.mtbTelefoneCli.Size = new System.Drawing.Size(142, 22);
            this.mtbTelefoneCli.TabIndex = 9;
            this.mtbTelefoneCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbRgCli
            // 
            this.mtbRgCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.mtbRgCli.Location = new System.Drawing.Point(285, 75);
            this.mtbRgCli.Mask = "00,000,000-00";
            this.mtbRgCli.Name = "mtbRgCli";
            this.mtbRgCli.Size = new System.Drawing.Size(117, 22);
            this.mtbRgCli.TabIndex = 3;
            this.mtbRgCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbCpfCli
            // 
            this.mtbCpfCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.mtbCpfCli.Location = new System.Drawing.Point(92, 75);
            this.mtbCpfCli.Mask = "000,000,000-00";
            this.mtbCpfCli.Name = "mtbCpfCli";
            this.mtbCpfCli.Size = new System.Drawing.Size(122, 22);
            this.mtbCpfCli.TabIndex = 2;
            this.mtbCpfCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtEmailCli.Location = new System.Drawing.Point(308, 173);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(444, 22);
            this.txtEmailCli.TabIndex = 10;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtNomeCli.Location = new System.Drawing.Point(92, 32);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(433, 22);
            this.txtNomeCli.TabIndex = 1;
            // 
            // lbCodigoNumeroCli
            // 
            this.lbCodigoNumeroCli.AutoSize = true;
            this.lbCodigoNumeroCli.Location = new System.Drawing.Point(725, 35);
            this.lbCodigoNumeroCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodigoNumeroCli.Name = "lbCodigoNumeroCli";
            this.lbCodigoNumeroCli.Size = new System.Drawing.Size(16, 14);
            this.lbCodigoNumeroCli.TabIndex = 1;
            this.lbCodigoNumeroCli.Text = "1";
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
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(248, 178);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 14);
            this.lbEmail.TabIndex = 15;
            this.lbEmail.Text = "Email:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(491, 126);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(73, 14);
            this.lbTelefone.TabIndex = 11;
            this.lbTelefone.Text = "Telefone: ";
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
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Location = new System.Drawing.Point(248, 126);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(89, 14);
            this.lbEstadoCivil.TabIndex = 13;
            this.lbEstadoCivil.Text = "Estado Civil:";
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Location = new System.Drawing.Point(248, 78);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(31, 14);
            this.lbRg.TabIndex = 6;
            this.lbRg.Text = "RG:";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Location = new System.Drawing.Point(45, 78);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(38, 14);
            this.lbCpf.TabIndex = 4;
            this.lbCpf.Text = "CPF:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(37, 35);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(50, 14);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome:";
            // 
            // abaExibiCliente
            // 
            this.abaExibiCliente.Controls.Add(this.btnSairCli);
            this.abaExibiCliente.Controls.Add(this.btnExibirTodosCli);
            this.abaExibiCliente.Controls.Add(this.pcbLogoExiCli);
            this.abaExibiCliente.Controls.Add(this.gpbDadosExibeCli);
            this.abaExibiCliente.Controls.Add(this.gpbBuscaCli);
            this.abaExibiCliente.Location = new System.Drawing.Point(4, 22);
            this.abaExibiCliente.Name = "abaExibiCliente";
            this.abaExibiCliente.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.abaExibiCliente.Size = new System.Drawing.Size(807, 554);
            this.abaExibiCliente.TabIndex = 1;
            this.abaExibiCliente.Text = "Exibir Clientes";
            this.abaExibiCliente.UseVisualStyleBackColor = true;
            // 
            // btnSairCli
            // 
            this.btnSairCli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnSairCli.Location = new System.Drawing.Point(705, 504);
            this.btnSairCli.Name = "btnSairCli";
            this.btnSairCli.Size = new System.Drawing.Size(84, 32);
            this.btnSairCli.TabIndex = 3;
            this.btnSairCli.Text = "Sair";
            this.btnSairCli.UseVisualStyleBackColor = true;
            // 
            // btnExibirTodosCli
            // 
            this.btnExibirTodosCli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnExibirTodosCli.Location = new System.Drawing.Point(574, 498);
            this.btnExibirTodosCli.Name = "btnExibirTodosCli";
            this.btnExibirTodosCli.Size = new System.Drawing.Size(110, 45);
            this.btnExibirTodosCli.TabIndex = 1;
            this.btnExibirTodosCli.Text = "Exibir Todos";
            this.btnExibirTodosCli.UseVisualStyleBackColor = true;
            // 
            // pcbLogoExiCli
            // 
            this.pcbLogoExiCli.Image = global::LojaGames.Properties.Resources.img_game_logo;
            this.pcbLogoExiCli.Location = new System.Drawing.Point(9, 498);
            this.pcbLogoExiCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbLogoExiCli.Name = "pcbLogoExiCli";
            this.pcbLogoExiCli.Size = new System.Drawing.Size(128, 50);
            this.pcbLogoExiCli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoExiCli.TabIndex = 3;
            this.pcbLogoExiCli.TabStop = false;
            // 
            // gpbDadosExibeCli
            // 
            this.gpbDadosExibeCli.Controls.Add(this.dgvExibeCli);
            this.gpbDadosExibeCli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.gpbDadosExibeCli.Location = new System.Drawing.Point(7, 187);
            this.gpbDadosExibeCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDadosExibeCli.Name = "gpbDadosExibeCli";
            this.gpbDadosExibeCli.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gpbDadosExibeCli.Size = new System.Drawing.Size(796, 306);
            this.gpbDadosExibeCli.TabIndex = 1;
            this.gpbDadosExibeCli.TabStop = false;
            this.gpbDadosExibeCli.Text = "Dados Clientes";
            // 
            // dgvExibeCli
            // 
            this.dgvExibeCli.AllowUserToAddRows = false;
            this.dgvExibeCli.AllowUserToDeleteRows = false;
            this.dgvExibeCli.AllowUserToOrderColumns = true;
            this.dgvExibeCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExibeCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExibeCli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPF,
            this.NOME});
            this.dgvExibeCli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExibeCli.Location = new System.Drawing.Point(2, 17);
            this.dgvExibeCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvExibeCli.Name = "dgvExibeCli";
            this.dgvExibeCli.RowTemplate.Height = 24;
            this.dgvExibeCli.Size = new System.Drawing.Size(792, 287);
            this.dgvExibeCli.TabIndex = 0;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            // 
            // gpbBuscaCli
            // 
            this.gpbBuscaCli.Controls.Add(this.btnBuscarCli);
            this.gpbBuscaCli.Controls.Add(this.btnEditarCli);
            this.gpbBuscaCli.Controls.Add(this.btnExcluirCli);
            this.gpbBuscaCli.Controls.Add(this.mtbCpfExiCli);
            this.gpbBuscaCli.Controls.Add(this.txtNomeExiCli);
            this.gpbBuscaCli.Controls.Add(this.lbNomeExibeCli);
            this.gpbBuscaCli.Controls.Add(this.lbOU);
            this.gpbBuscaCli.Controls.Add(this.lbCpfExibeCli);
            this.gpbBuscaCli.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.gpbBuscaCli.Location = new System.Drawing.Point(6, 6);
            this.gpbBuscaCli.Name = "gpbBuscaCli";
            this.gpbBuscaCli.Size = new System.Drawing.Size(797, 176);
            this.gpbBuscaCli.TabIndex = 2;
            this.gpbBuscaCli.TabStop = false;
            this.gpbBuscaCli.Text = "Buscar Cliente";
            // 
            // btnBuscarCli
            // 
            this.btnBuscarCli.Location = new System.Drawing.Point(622, 117);
            this.btnBuscarCli.Name = "btnBuscarCli";
            this.btnBuscarCli.Size = new System.Drawing.Size(142, 53);
            this.btnBuscarCli.TabIndex = 5;
            this.btnBuscarCli.Text = "Buscar";
            this.btnBuscarCli.UseVisualStyleBackColor = true;
            // 
            // btnEditarCli
            // 
            this.btnEditarCli.Location = new System.Drawing.Point(640, 69);
            this.btnEditarCli.Name = "btnEditarCli";
            this.btnEditarCli.Size = new System.Drawing.Size(108, 42);
            this.btnEditarCli.TabIndex = 6;
            this.btnEditarCli.Text = "Editar";
            this.btnEditarCli.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCli
            // 
            this.btnExcluirCli.Location = new System.Drawing.Point(640, 21);
            this.btnExcluirCli.Name = "btnExcluirCli";
            this.btnExcluirCli.Size = new System.Drawing.Size(108, 42);
            this.btnExcluirCli.TabIndex = 7;
            this.btnExcluirCli.Text = "Excluir";
            this.btnExcluirCli.UseVisualStyleBackColor = true;
            // 
            // mtbCpfExiCli
            // 
            this.mtbCpfExiCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.mtbCpfExiCli.Location = new System.Drawing.Point(143, 39);
            this.mtbCpfExiCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtbCpfExiCli.Mask = "000,000,000-00";
            this.mtbCpfExiCli.Name = "mtbCpfExiCli";
            this.mtbCpfExiCli.Size = new System.Drawing.Size(126, 22);
            this.mtbCpfExiCli.TabIndex = 1;
            this.mtbCpfExiCli.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtNomeExiCli
            // 
            this.txtNomeExiCli.Font = new System.Drawing.Font("Verdana", 9F);
            this.txtNomeExiCli.Location = new System.Drawing.Point(143, 110);
            this.txtNomeExiCli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomeExiCli.Name = "txtNomeExiCli";
            this.txtNomeExiCli.Size = new System.Drawing.Size(297, 22);
            this.txtNomeExiCli.TabIndex = 4;
            // 
            // lbNomeExibeCli
            // 
            this.lbNomeExibeCli.AutoSize = true;
            this.lbNomeExibeCli.Location = new System.Drawing.Point(28, 112);
            this.lbNomeExibeCli.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomeExibeCli.Name = "lbNomeExibeCli";
            this.lbNomeExibeCli.Size = new System.Drawing.Size(120, 14);
            this.lbNomeExibeCli.TabIndex = 2;
            this.lbNomeExibeCli.Text = "Nome do Cliente:";
            // 
            // lbOU
            // 
            this.lbOU.AutoSize = true;
            this.lbOU.Location = new System.Drawing.Point(67, 80);
            this.lbOU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOU.Name = "lbOU";
            this.lbOU.Size = new System.Drawing.Size(28, 14);
            this.lbOU.TabIndex = 1;
            this.lbOU.Text = "OU";
            // 
            // lbCpfExibeCli
            // 
            this.lbCpfExibeCli.AutoSize = true;
            this.lbCpfExibeCli.Location = new System.Drawing.Point(28, 39);
            this.lbCpfExibeCli.Name = "lbCpfExibeCli";
            this.lbCpfExibeCli.Size = new System.Drawing.Size(112, 14);
            this.lbCpfExibeCli.TabIndex = 0;
            this.lbCpfExibeCli.Text = "CPF do Cliente: ";
            // 
            // telaGerCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 580);
            this.Controls.Add(this.abasGerCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "telaGerCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaGerCliente_FormClosing);
            this.abasGerCliente.ResumeLayout(false);
            this.abaCadCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCli)).EndInit();
            this.gpbEnderecoCli.ResumeLayout(false);
            this.gpbEnderecoCli.PerformLayout();
            this.gbpDadosPessoaisCli.ResumeLayout(false);
            this.gbpDadosPessoaisCli.PerformLayout();
            this.gbpSexo.ResumeLayout(false);
            this.gbpSexo.PerformLayout();
            this.abaExibiCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoExiCli)).EndInit();
            this.gpbDadosExibeCli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExibeCli)).EndInit();
            this.gpbBuscaCli.ResumeLayout(false);
            this.gpbBuscaCli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl abasGerCliente;
        private System.Windows.Forms.TabPage abaCadCliente;
        private System.Windows.Forms.TabPage abaExibiCliente;
        private System.Windows.Forms.GroupBox gpbEnderecoCli;
        private System.Windows.Forms.GroupBox gbpDadosPessoaisCli;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.Label lbCodigoNumeroCli;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.TextBox txtEmailCli;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.TextBox txtNumeroCli;
        private System.Windows.Forms.TextBox txtCidadeCli;
        private System.Windows.Forms.TextBox txtBairroCli;
        private System.Windows.Forms.TextBox txtRuaCli;
        private System.Windows.Forms.MaskedTextBox mtbCepCli;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneCli;
        private System.Windows.Forms.MaskedTextBox mtbRgCli;
        private System.Windows.Forms.MaskedTextBox mtbCpfCli;
        private System.Windows.Forms.ComboBox cbxEstadoCivilCli;
        private System.Windows.Forms.ComboBox cbxEstadoCli;
        private System.Windows.Forms.DateTimePicker dtpDataNascCli;
        private System.Windows.Forms.GroupBox gbpSexo;
        private System.Windows.Forms.RadioButton rbtnNaoInformadoCli;
        private System.Windows.Forms.RadioButton rbtnFemininoCli;
        private System.Windows.Forms.RadioButton rbtnMasculinoCli;
        private System.Windows.Forms.Button btnCancelarCli;
        private System.Windows.Forms.Button btnCadastrarCli;
        private System.Windows.Forms.PictureBox pcbLogoCli;
        private System.Windows.Forms.GroupBox gpbDadosExibeCli;
        private System.Windows.Forms.GroupBox gpbBuscaCli;
        private System.Windows.Forms.Label lbNomeExibeCli;
        private System.Windows.Forms.Label lbOU;
        private System.Windows.Forms.Label lbCpfExibeCli;
        private System.Windows.Forms.MaskedTextBox mtbCpfExiCli;
        private System.Windows.Forms.TextBox txtNomeExiCli;
        private System.Windows.Forms.Button btnBuscarCli;
        private System.Windows.Forms.Button btnEditarCli;
        private System.Windows.Forms.Button btnExcluirCli;
        private System.Windows.Forms.DataGridView dgvExibeCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.PictureBox pcbLogoExiCli;
        private System.Windows.Forms.Button btnSairCli;
        private System.Windows.Forms.Button btnExibirTodosCli;
    }
}