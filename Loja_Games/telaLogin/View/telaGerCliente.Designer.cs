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
            this.abaExibiCliente = new System.Windows.Forms.TabPage();
            this.abasGerCliente.SuspendLayout();
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
            this.abasGerCliente.Size = new System.Drawing.Size(984, 512);
            this.abasGerCliente.TabIndex = 0;
            // 
            // abaCadCliente
            // 
            this.abaCadCliente.Location = new System.Drawing.Point(4, 22);
            this.abaCadCliente.Name = "abaCadCliente";
            this.abaCadCliente.Padding = new System.Windows.Forms.Padding(3);
            this.abaCadCliente.Size = new System.Drawing.Size(976, 486);
            this.abaCadCliente.TabIndex = 0;
            this.abaCadCliente.Text = "Cadastrar Cliente";
            this.abaCadCliente.UseVisualStyleBackColor = true;
            // 
            // abaExibiCliente
            // 
            this.abaExibiCliente.Location = new System.Drawing.Point(4, 22);
            this.abaExibiCliente.Name = "abaExibiCliente";
            this.abaExibiCliente.Padding = new System.Windows.Forms.Padding(3);
            this.abaExibiCliente.Size = new System.Drawing.Size(976, 486);
            this.abaExibiCliente.TabIndex = 1;
            this.abaExibiCliente.Text = "Exibir Clientes";
            this.abaExibiCliente.UseVisualStyleBackColor = true;
            // 
            // telaGerCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.Controls.Add(this.abasGerCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "telaGerCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Cliente";
            this.abasGerCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl abasGerCliente;
        private System.Windows.Forms.TabPage abaCadCliente;
        private System.Windows.Forms.TabPage abaExibiCliente;
    }
}