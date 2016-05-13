namespace LojaGames.View
{
    partial class DadosLoginFuncionario
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
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mtbSenha = new System.Windows.Forms.MaskedTextBox();
            this.mtbConfirmarSenha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(81, 68);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(63, 14);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuário:";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(91, 109);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(53, 14);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha:";
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmarSenha.Location = new System.Drawing.Point(21, 146);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(123, 14);
            this.lbConfirmarSenha.TabIndex = 2;
            this.lbConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(150, 65);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(67, 192);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 23);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(208, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // mtbSenha
            // 
            this.mtbSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbSenha.Location = new System.Drawing.Point(150, 106);
            this.mtbSenha.Name = "mtbSenha";
            this.mtbSenha.PasswordChar = '*';
            this.mtbSenha.Size = new System.Drawing.Size(100, 22);
            this.mtbSenha.TabIndex = 2;
            // 
            // mtbConfirmarSenha
            // 
            this.mtbConfirmarSenha.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbConfirmarSenha.Location = new System.Drawing.Point(150, 143);
            this.mtbConfirmarSenha.Name = "mtbConfirmarSenha";
            this.mtbConfirmarSenha.PasswordChar = '*';
            this.mtbConfirmarSenha.Size = new System.Drawing.Size(100, 22);
            this.mtbConfirmarSenha.TabIndex = 3;
            // 
            // DadosLoginFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 239);
            this.Controls.Add(this.mtbConfirmarSenha);
            this.Controls.Add(this.mtbSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbConfirmarSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.MaximizeBox = false;
            this.Name = "DadosLoginFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login do Funcionário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mtbSenha;
        private System.Windows.Forms.MaskedTextBox mtbConfirmarSenha;
    }
}