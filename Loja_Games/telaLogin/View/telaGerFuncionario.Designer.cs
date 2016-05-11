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
            this.abaExibiFuncionario = new System.Windows.Forms.TabPage();
            this.abasGerFuncionario.SuspendLayout();
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
            this.abasGerFuncionario.Size = new System.Drawing.Size(984, 512);
            this.abasGerFuncionario.TabIndex = 0;
            // 
            // abaCadFuncionario
            // 
            this.abaCadFuncionario.Location = new System.Drawing.Point(4, 22);
            this.abaCadFuncionario.Name = "abaCadFuncionario";
            this.abaCadFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.abaCadFuncionario.Size = new System.Drawing.Size(976, 486);
            this.abaCadFuncionario.TabIndex = 0;
            this.abaCadFuncionario.Text = "Cadastro de Funcionário";
            this.abaCadFuncionario.UseVisualStyleBackColor = true;
            // 
            // abaExibiFuncionario
            // 
            this.abaExibiFuncionario.Location = new System.Drawing.Point(4, 22);
            this.abaExibiFuncionario.Name = "abaExibiFuncionario";
            this.abaExibiFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.abaExibiFuncionario.Size = new System.Drawing.Size(976, 486);
            this.abaExibiFuncionario.TabIndex = 1;
            this.abaExibiFuncionario.Text = "Exibir Funcionários";
            this.abaExibiFuncionario.UseVisualStyleBackColor = true;
            // 
            // telaGerFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.abasGerFuncionario);
            this.MaximizeBox = false;
            this.Name = "telaGerFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Funcionário";
            this.abasGerFuncionario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl abasGerFuncionario;
        private System.Windows.Forms.TabPage abaCadFuncionario;
        private System.Windows.Forms.TabPage abaExibiFuncionario;
    }
}