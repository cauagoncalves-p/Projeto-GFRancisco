namespace Projeto_Socorrista
{
    partial class frmLoginVoluntario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginVoluntario));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblLinkCriarConta = new System.Windows.Forms.LinkLabel();
            this.lblNãoTemConta = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.picMonstrarSenha = new System.Windows.Forms.PictureBox();
            this.MtxtSenha = new ModernTextBox();
            this.btnCriarConta = new System.Windows.Forms.Button();
            this.MtxtEmail = new ModernTextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblPontilhado = new System.Windows.Forms.Label();
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSubTituloCriarConta = new System.Windows.Forms.Label();
            this.lblTituloCriarConta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTituloF = new System.Windows.Forms.Label();
            this.lblSubTituloF = new System.Windows.Forms.Label();
            this.lblTransforme = new System.Windows.Forms.Label();
            this.lblCompartilhe = new System.Windows.Forms.Label();
            this.lblDoe = new System.Windows.Forms.Label();
            this.lblDescritivo = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonstrarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.AutoScroll = true;
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(115)))));
            this.panelLogin.Controls.Add(this.lblLinkCriarConta);
            this.panelLogin.Controls.Add(this.lblNãoTemConta);
            this.panelLogin.Controls.Add(this.lblError);
            this.panelLogin.Controls.Add(this.picMonstrarSenha);
            this.panelLogin.Controls.Add(this.MtxtSenha);
            this.panelLogin.Controls.Add(this.btnCriarConta);
            this.panelLogin.Controls.Add(this.MtxtEmail);
            this.panelLogin.Controls.Add(this.lblSenha);
            this.panelLogin.Controls.Add(this.lblPontilhado);
            this.panelLogin.Controls.Add(this.lblDadosPessoais);
            this.panelLogin.Controls.Add(this.lblEmail);
            this.panelLogin.Controls.Add(this.lblSubTituloCriarConta);
            this.panelLogin.Controls.Add(this.lblTituloCriarConta);
            this.panelLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.panelLogin.Location = new System.Drawing.Point(953, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(925, 927);
            this.panelLogin.TabIndex = 10;
            // 
            // lblLinkCriarConta
            // 
            this.lblLinkCriarConta.AutoSize = true;
            this.lblLinkCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkCriarConta.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLinkCriarConta.LinkColor = System.Drawing.Color.White;
            this.lblLinkCriarConta.Location = new System.Drawing.Point(704, 821);
            this.lblLinkCriarConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinkCriarConta.Name = "lblLinkCriarConta";
            this.lblLinkCriarConta.Size = new System.Drawing.Size(129, 29);
            this.lblLinkCriarConta.TabIndex = 93;
            this.lblLinkCriarConta.TabStop = true;
            this.lblLinkCriarConta.Text = "Criar conta";
            this.lblLinkCriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkCriarConta_LinkClicked);
            // 
            // lblNãoTemConta
            // 
            this.lblNãoTemConta.AutoSize = true;
            this.lblNãoTemConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNãoTemConta.ForeColor = System.Drawing.Color.White;
            this.lblNãoTemConta.Location = new System.Drawing.Point(537, 822);
            this.lblNãoTemConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNãoTemConta.Name = "lblNãoTemConta";
            this.lblNãoTemConta.Size = new System.Drawing.Size(180, 29);
            this.lblNãoTemConta.TabIndex = 92;
            this.lblNãoTemConta.Text = "Não tem conta?";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(65, 892);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 91;
            // 
            // picMonstrarSenha
            // 
            this.picMonstrarSenha.Image = ((System.Drawing.Image)(resources.GetObject("picMonstrarSenha.Image")));
            this.picMonstrarSenha.Location = new System.Drawing.Point(752, 617);
            this.picMonstrarSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picMonstrarSenha.Name = "picMonstrarSenha";
            this.picMonstrarSenha.Size = new System.Drawing.Size(35, 27);
            this.picMonstrarSenha.TabIndex = 88;
            this.picMonstrarSenha.TabStop = false;
            // 
            // MtxtSenha
            // 
            this.MtxtSenha.BackColor = System.Drawing.Color.Transparent;
            this.MtxtSenha.EnablePlaceholder = true;
            this.MtxtSenha.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MtxtSenha.Location = new System.Drawing.Point(59, 603);
            this.MtxtSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MtxtSenha.MaxLength = 32767;
            this.MtxtSenha.Name = "MtxtSenha";
            this.MtxtSenha.PasswordChar = '\0';
            this.MtxtSenha.PlaceholderChar = '\0';
            this.MtxtSenha.PlaceholderText = "";
            this.MtxtSenha.SelectionStart = 0;
            this.MtxtSenha.Size = new System.Drawing.Size(743, 49);
            this.MtxtSenha.TabIndex = 81;
            this.MtxtSenha.TextValue = "";
            this.MtxtSenha.UseSystemPasswordChar = false;
            // 
            // btnCriarConta
            // 
            this.btnCriarConta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(115)))));
            this.btnCriarConta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarConta.ForeColor = System.Drawing.Color.White;
            this.btnCriarConta.Location = new System.Drawing.Point(59, 711);
            this.btnCriarConta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCriarConta.Name = "btnCriarConta";
            this.btnCriarConta.Size = new System.Drawing.Size(743, 57);
            this.btnCriarConta.TabIndex = 75;
            this.btnCriarConta.Text = "Criar conta";
            this.btnCriarConta.UseVisualStyleBackColor = false;
            // 
            // MtxtEmail
            // 
            this.MtxtEmail.BackColor = System.Drawing.Color.Transparent;
            this.MtxtEmail.EnablePlaceholder = true;
            this.MtxtEmail.Location = new System.Drawing.Point(59, 470);
            this.MtxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MtxtEmail.MaxLength = 32767;
            this.MtxtEmail.Name = "MtxtEmail";
            this.MtxtEmail.PasswordChar = '\0';
            this.MtxtEmail.PlaceholderChar = '\0';
            this.MtxtEmail.PlaceholderText = "Ex: caua@gmail.com";
            this.MtxtEmail.SelectionStart = 0;
            this.MtxtEmail.Size = new System.Drawing.Size(743, 49);
            this.MtxtEmail.TabIndex = 77;
            this.MtxtEmail.TextValue = "";
            this.MtxtEmail.UseSystemPasswordChar = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(55, 558);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(92, 31);
            this.lblSenha.TabIndex = 73;
            this.lblSenha.Text = "Senha";
            // 
            // lblPontilhado
            // 
            this.lblPontilhado.AutoSize = true;
            this.lblPontilhado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontilhado.ForeColor = System.Drawing.Color.White;
            this.lblPontilhado.Location = new System.Drawing.Point(55, 345);
            this.lblPontilhado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPontilhado.Name = "lblPontilhado";
            this.lblPontilhado.Size = new System.Drawing.Size(734, 31);
            this.lblPontilhado.TabIndex = 65;
            this.lblPontilhado.Text = "--------------------------------------------------------------------------------";
            // 
            // lblDadosPessoais
            // 
            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosPessoais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.lblDadosPessoais.Location = new System.Drawing.Point(59, 297);
            this.lblDadosPessoais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDadosPessoais.Name = "lblDadosPessoais";
            this.lblDadosPessoais.Size = new System.Drawing.Size(80, 31);
            this.lblDadosPessoais.TabIndex = 64;
            this.lblDadosPessoais.Text = "Login";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(55, 412);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 31);
            this.lblEmail.TabIndex = 61;
            this.lblEmail.Text = "Email";
            // 
            // lblSubTituloCriarConta
            // 
            this.lblSubTituloCriarConta.AutoSize = true;
            this.lblSubTituloCriarConta.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTituloCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTituloCriarConta.ForeColor = System.Drawing.Color.White;
            this.lblSubTituloCriarConta.Location = new System.Drawing.Point(24, 154);
            this.lblSubTituloCriarConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTituloCriarConta.Name = "lblSubTituloCriarConta";
            this.lblSubTituloCriarConta.Size = new System.Drawing.Size(680, 69);
            this.lblSubTituloCriarConta.TabIndex = 59;
            this.lblSubTituloCriarConta.Text = "Informe seu login abaixo";
            // 
            // lblTituloCriarConta
            // 
            this.lblTituloCriarConta.AutoSize = true;
            this.lblTituloCriarConta.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloCriarConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCriarConta.ForeColor = System.Drawing.Color.White;
            this.lblTituloCriarConta.Location = new System.Drawing.Point(75, 46);
            this.lblTituloCriarConta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCriarConta.Name = "lblTituloCriarConta";
            this.lblTituloCriarConta.Size = new System.Drawing.Size(588, 69);
            this.lblTituloCriarConta.TabIndex = 58;
            this.lblTituloCriarConta.Text = "Bem vindo voluntário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 1204);
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(303, 274);
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // lblTituloF
            // 
            this.lblTituloF.AutoSize = true;
            this.lblTituloF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblTituloF.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(112)))));
            this.lblTituloF.Location = new System.Drawing.Point(352, 191);
            this.lblTituloF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloF.Name = "lblTituloF";
            this.lblTituloF.Size = new System.Drawing.Size(290, 69);
            this.lblTituloF.TabIndex = 97;
            this.lblTituloF.Text = "Francisco";
            // 
            // lblSubTituloF
            // 
            this.lblSubTituloF.AutoSize = true;
            this.lblSubTituloF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblSubTituloF.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTituloF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(112)))));
            this.lblSubTituloF.Location = new System.Drawing.Point(352, 89);
            this.lblSubTituloF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTituloF.Name = "lblSubTituloF";
            this.lblSubTituloF.Size = new System.Drawing.Size(276, 69);
            this.lblSubTituloF.TabIndex = 96;
            this.lblSubTituloF.Text = "Grupo G.";
            // 
            // lblTransforme
            // 
            this.lblTransforme.AutoSize = true;
            this.lblTransforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblTransforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransforme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(139)))), ((int)(((byte)(106)))));
            this.lblTransforme.Location = new System.Drawing.Point(16, 585);
            this.lblTransforme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransforme.Name = "lblTransforme";
            this.lblTransforme.Size = new System.Drawing.Size(513, 69);
            this.lblTransforme.TabIndex = 100;
            this.lblTransforme.Text = "Doe com coração.";
            // 
            // lblCompartilhe
            // 
            this.lblCompartilhe.AutoSize = true;
            this.lblCompartilhe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblCompartilhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompartilhe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(119)))), ((int)(((byte)(0)))));
            this.lblCompartilhe.Location = new System.Drawing.Point(16, 502);
            this.lblCompartilhe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompartilhe.Name = "lblCompartilhe";
            this.lblCompartilhe.Size = new System.Drawing.Size(481, 69);
            this.lblCompartilhe.TabIndex = 99;
            this.lblCompartilhe.Text = "Ajude com amor.";
            // 
            // lblDoe
            // 
            this.lblDoe.AutoSize = true;
            this.lblDoe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblDoe.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.lblDoe.Location = new System.Drawing.Point(16, 415);
            this.lblDoe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoe.Name = "lblDoe";
            this.lblDoe.Size = new System.Drawing.Size(638, 69);
            this.lblDoe.TabIndex = 98;
            this.lblDoe.Text = "Transforme vidas hoje.";
            this.lblDoe.Click += new System.EventHandler(this.lblDoe_Click);
            // 
            // lblDescritivo
            // 
            this.lblDescritivo.AutoSize = true;
            this.lblDescritivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblDescritivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescritivo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDescritivo.Location = new System.Drawing.Point(31, 678);
            this.lblDescritivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescritivo.Name = "lblDescritivo";
            this.lblDescritivo.Size = new System.Drawing.Size(770, 216);
            this.lblDescritivo.TabIndex = 101;
            this.lblDescritivo.Text = resources.GetString("lblDescritivo.Text");
            // 
            // frmLoginVoluntario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1877, 921);
            this.Controls.Add(this.lblDescritivo);
            this.Controls.Add(this.lblTransforme);
            this.Controls.Add(this.lblCompartilhe);
            this.Controls.Add(this.lblDoe);
            this.Controls.Add(this.lblTituloF);
            this.Controls.Add(this.lblSubTituloF);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoginVoluntario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Voluntário ";
            this.Load += new System.EventHandler(this.frmLoginVoluntario_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMonstrarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox picMonstrarSenha;
        private ModernTextBox MtxtSenha;
        private System.Windows.Forms.Button btnCriarConta;
        private ModernTextBox MtxtEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblPontilhado;
        private System.Windows.Forms.Label lblDadosPessoais;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSubTituloCriarConta;
        private System.Windows.Forms.Label lblTituloCriarConta;
        private System.Windows.Forms.LinkLabel lblLinkCriarConta;
        private System.Windows.Forms.Label lblNãoTemConta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTituloF;
        private System.Windows.Forms.Label lblSubTituloF;
        private System.Windows.Forms.Label lblTransforme;
        private System.Windows.Forms.Label lblCompartilhe;
        private System.Windows.Forms.Label lblDoe;
        private System.Windows.Forms.Label lblDescritivo;
    }
}