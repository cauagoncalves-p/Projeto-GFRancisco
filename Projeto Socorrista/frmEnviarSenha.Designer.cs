namespace Projeto_Socorrista
{
    partial class frmEnviarSenha
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.MtxtEmail = new ModernTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(395, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 55);
            this.label1.TabIndex = 104;
            this.label1.Text = "Redefinição de senha ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(430, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 87);
            this.label2.TabIndex = 105;
            this.label2.Text = "Digite o email no campo abaixo e lhe enviaremos\r\numa nova senha\r\n\r\n";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(409, 301);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 106;
            this.lblEmail.Text = "Email";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(115)))));
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(435, 453);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(485, 47);
            this.btnEnviar.TabIndex = 108;
            this.btnEnviar.Text = "Enviar e-mail";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // MtxtEmail
            // 
            this.MtxtEmail.BackColor = System.Drawing.Color.Transparent;
            this.MtxtEmail.BorderColorB = System.Drawing.Color.Black;
            this.MtxtEmail.EnablePlaceholder = true;
            this.MtxtEmail.Location = new System.Drawing.Point(405, 364);
            this.MtxtEmail.MaxLength = 32767;
            this.MtxtEmail.Name = "MtxtEmail";
            this.MtxtEmail.PasswordChar = '\0';
            this.MtxtEmail.PlaceholderChar = '\0';
            this.MtxtEmail.PlaceholderColor = System.Drawing.Color.Black;
            this.MtxtEmail.PlaceholderText = "Ex: cauagoncalves2190@gmail.com";
            this.MtxtEmail.SelectionStart = 0;
            this.MtxtEmail.Size = new System.Drawing.Size(556, 40);
            this.MtxtEmail.TabIndex = 109;
            this.MtxtEmail.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.MtxtEmail.TextValue = "";
            this.MtxtEmail.UseSystemPasswordChar = false;
            // 
            // frmEnviarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1362, 748);
            this.Controls.Add(this.MtxtEmail);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEnviarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trocar senha ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnEnviar;
        private ModernTextBox MtxtEmail;
    }
}