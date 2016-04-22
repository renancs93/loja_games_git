namespace LojaGames
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
            this.btnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJogos
            // 
            this.btnJogos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnJogos.BackColor = System.Drawing.Color.Black;
            this.btnJogos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogos.ForeColor = System.Drawing.Color.Red;
            this.btnJogos.Location = new System.Drawing.Point(575, 71);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(115, 30);
            this.btnJogos.TabIndex = 0;
            this.btnJogos.Text = "Jogos";
            this.btnJogos.UseVisualStyleBackColor = false;
            this.btnJogos.Click += new System.EventHandler(this.btnJogos_Click);
            this.btnJogos.MouseEnter += new System.EventHandler(this.btnJogos_MouseEnter);
            this.btnJogos.MouseLeave += new System.EventHandler(this.btnJogos_MouseLeave);
            // 
            // barraProgresso
            // 
            this.barraProgresso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.barraProgresso.Enabled = false;
            this.barraProgresso.Location = new System.Drawing.Point(513, 485);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(220, 10);
            this.barraProgresso.TabIndex = 1;
            // 
            // btnLogar
            // 
            this.btnLogar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogar.Location = new System.Drawing.Point(653, 2);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(80, 22);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // telaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 497);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.barraProgresso);
            this.Controls.Add(this.btnJogos);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "telaPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.ProgressBar barraProgresso;
        private System.Windows.Forms.Button btnLogar;
    }
}