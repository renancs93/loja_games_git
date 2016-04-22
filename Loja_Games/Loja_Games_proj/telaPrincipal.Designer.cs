namespace telaLogin
{
    partial class telaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaPrincipal));
            this.btnJogos = new System.Windows.Forms.Button();
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnJogos
            // 
            this.btnJogos.Location = new System.Drawing.Point(580, 121);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(105, 31);
            this.btnJogos.TabIndex = 0;
            this.btnJogos.Text = "Jogos";
            this.btnJogos.UseVisualStyleBackColor = true;
            this.btnJogos.Click += new System.EventHandler(this.btnJogos_Click);
            // 
            // barraProgresso
            // 
            this.barraProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraProgresso.Enabled = false;
            this.barraProgresso.Location = new System.Drawing.Point(513, 515);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(220, 13);
            this.barraProgresso.TabIndex = 1;
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 530);
            this.Controls.Add(this.barraProgresso);
            this.Controls.Add(this.btnJogos);
            this.Name = "telaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Tela Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.ProgressBar barraProgresso;
    }
}