﻿namespace Projeto_Socorrista
{
    partial class frmCarregar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarregar));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTituloF = new System.Windows.Forms.Label();
            this.lblSubTituloF = new System.Windows.Forms.Label();
            this.picreload = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picreload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloF
            // 
            this.lblTituloF.AutoSize = true;
            this.lblTituloF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblTituloF.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(112)))));
            this.lblTituloF.Location = new System.Drawing.Point(681, 205);
            this.lblTituloF.Name = "lblTituloF";
            this.lblTituloF.Size = new System.Drawing.Size(260, 55);
            this.lblTituloF.TabIndex = 7;
            this.lblTituloF.Text = "Francisco";
            // 
            // lblSubTituloF
            // 
            this.lblSubTituloF.AutoSize = true;
            this.lblSubTituloF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.lblSubTituloF.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTituloF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(158)))), ((int)(((byte)(112)))));
            this.lblSubTituloF.Location = new System.Drawing.Point(681, 114);
            this.lblSubTituloF.Name = "lblSubTituloF";
            this.lblSubTituloF.Size = new System.Drawing.Size(246, 55);
            this.lblSubTituloF.TabIndex = 5;
            this.lblSubTituloF.Text = "Grupo G.";
            // 
            // picreload
            // 
            this.picreload.Location = new System.Drawing.Point(523, 360);
            this.picreload.Name = "picreload";
            this.picreload.Size = new System.Drawing.Size(334, 267);
            this.picreload.TabIndex = 8;
            this.picreload.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(432, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 223);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frmCarregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1408, 748);
            this.Controls.Add(this.picreload);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTituloF);
            this.Controls.Add(this.lblSubTituloF);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reload";
            ((System.ComponentModel.ISupportInitialize)(this.picreload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTituloF;
        private System.Windows.Forms.Label lblSubTituloF;
        private System.Windows.Forms.PictureBox picreload;
    }
}