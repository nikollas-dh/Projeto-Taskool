namespace Projeto_Taskool
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.linkCadastro = new System.Windows.Forms.LinkLabel();
            this.linkTeclado = new System.Windows.Forms.LinkLabel();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.lblCaps = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem-vindo ao Taskool!";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(355, 265);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ShortcutsEnabled = false;
            this.txtSenha.Size = new System.Drawing.Size(290, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(355, 229);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(290, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // btnAcessar
            // 
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.Location = new System.Drawing.Point(422, 355);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(118, 41);
            this.btnAcessar.TabIndex = 3;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // linkCadastro
            // 
            this.linkCadastro.AutoSize = true;
            this.linkCadastro.Location = new System.Drawing.Point(452, 463);
            this.linkCadastro.Name = "linkCadastro";
            this.linkCadastro.Size = new System.Drawing.Size(52, 13);
            this.linkCadastro.TabIndex = 4;
            this.linkCadastro.TabStop = true;
            this.linkCadastro.Text = "Cadastrar";
            this.linkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastro_LinkClicked);
            // 
            // linkTeclado
            // 
            this.linkTeclado.AutoSize = true;
            this.linkTeclado.Location = new System.Drawing.Point(717, 267);
            this.linkTeclado.Name = "linkTeclado";
            this.linkTeclado.Size = new System.Drawing.Size(77, 13);
            this.linkTeclado.TabIndex = 4;
            this.linkTeclado.TabStop = true;
            this.linkTeclado.Text = "Teclado virtual";
            this.linkTeclado.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTeclado_LinkClicked);
            // 
            // pbxFoto
            // 
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.Location = new System.Drawing.Point(422, 132);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(126, 73);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 11;
            this.pbxFoto.TabStop = false;
            // 
            // lblCaps
            // 
            this.lblCaps.AutoSize = true;
            this.lblCaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaps.ForeColor = System.Drawing.Color.Red;
            this.lblCaps.Location = new System.Drawing.Point(352, 301);
            this.lblCaps.Name = "lblCaps";
            this.lblCaps.Size = new System.Drawing.Size(135, 17);
            this.lblCaps.TabIndex = 12;
            this.lblCaps.Text = "CAPS LOCK ativado";
            this.lblCaps.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 594);
            this.Controls.Add(this.lblCaps);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.linkTeclado);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.LinkLabel linkCadastro;
        private System.Windows.Forms.LinkLabel linkTeclado;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Label lblCaps;
        private System.Windows.Forms.Timer timer1;
    }
}

