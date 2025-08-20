namespace Projeto_Socorrista
{
    partial class frmTrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrocarSenha));
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmeSenha = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MtxtConfimeSenha = new ModernTextBox();
            this.MtxtSenha = new ModernTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(459, 339);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 23);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmeSenha
            // 
            this.lblConfirmeSenha.AutoSize = true;
            this.lblConfirmeSenha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmeSenha.Location = new System.Drawing.Point(459, 451);
            this.lblConfirmeSenha.Name = "lblConfirmeSenha";
            this.lblConfirmeSenha.Size = new System.Drawing.Size(150, 23);
            this.lblConfirmeSenha.TabIndex = 3;
            this.lblConfirmeSenha.Text = "Confirme sua senha";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(115)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(463, 601);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(399, 44);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(156)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(415, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 55);
            this.label1.TabIndex = 105;
            this.label1.Text = "Redefinir sua senha ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(445, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 119);
            this.panel1.TabIndex = 107;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 108;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(109, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 58);
            this.label2.TabIndex = 108;
            this.label2.Text = "A nova senha precisa ser \r\ndiferente da senha atual";
            // 
            // MtxtConfimeSenha
            // 
            this.MtxtConfimeSenha.BackColor = System.Drawing.Color.Transparent;
            this.MtxtConfimeSenha.BorderColorB = System.Drawing.Color.Black;
            this.MtxtConfimeSenha.EnablePlaceholder = true;
            this.MtxtConfimeSenha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MtxtConfimeSenha.Location = new System.Drawing.Point(462, 486);
            this.MtxtConfimeSenha.MaxLength = 32767;
            this.MtxtConfimeSenha.Name = "MtxtConfimeSenha";
            this.MtxtConfimeSenha.PasswordChar = '\0';
            this.MtxtConfimeSenha.PlaceholderChar = '\0';
            this.MtxtConfimeSenha.PlaceholderColor = System.Drawing.Color.Black;
            this.MtxtConfimeSenha.PlaceholderText = "Ex: SenhaForte@2025";
            this.MtxtConfimeSenha.SelectionStart = 0;
            this.MtxtConfimeSenha.Size = new System.Drawing.Size(400, 41);
            this.MtxtConfimeSenha.TabIndex = 1;
            this.MtxtConfimeSenha.Tamanho = new System.Drawing.Size(380, 20);
            this.MtxtConfimeSenha.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.MtxtConfimeSenha.TextValue = "";
            this.MtxtConfimeSenha.UseSystemPasswordChar = false;
            this.MtxtConfimeSenha.WordWrap = true;
            // 
            // MtxtSenha
            // 
            this.MtxtSenha.BackColor = System.Drawing.Color.Transparent;
            this.MtxtSenha.BorderColorB = System.Drawing.Color.Black;
            this.MtxtSenha.EnablePlaceholder = true;
            this.MtxtSenha.ForeColor = System.Drawing.Color.Black;
            this.MtxtSenha.Location = new System.Drawing.Point(462, 381);
            this.MtxtSenha.MaxLength = 32767;
            this.MtxtSenha.Name = "MtxtSenha";
            this.MtxtSenha.PasswordChar = '\0';
            this.MtxtSenha.PlaceholderChar = '\0';
            this.MtxtSenha.PlaceholderColor = System.Drawing.Color.Black;
            this.MtxtSenha.PlaceholderText = "Ex: SenhaForte@2025";
            this.MtxtSenha.SelectionStart = 0;
            this.MtxtSenha.Size = new System.Drawing.Size(400, 40);
            this.MtxtSenha.TabIndex = 0;
            this.MtxtSenha.Tamanho = new System.Drawing.Size(380, 20);
            this.MtxtSenha.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.MtxtSenha.TextValue = "";
            this.MtxtSenha.UseSystemPasswordChar = false;
            this.MtxtSenha.WordWrap = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(460, 428);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 20);
            this.lblError.TabIndex = 108;
            // 
            // frmTrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1362, 748);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblConfirmeSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.MtxtConfimeSenha);
            this.Controls.Add(this.MtxtSenha);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmTrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redefinir senha ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModernTextBox MtxtSenha;
        private ModernTextBox MtxtConfimeSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmeSenha;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblError;
    }
}