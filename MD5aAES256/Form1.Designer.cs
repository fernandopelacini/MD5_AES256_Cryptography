namespace MD5aAES256
{
    partial class frmPrincipal
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
            this.grpMD5 = new System.Windows.Forms.GroupBox();
            this.btnmd5desencriptar = new System.Windows.Forms.Button();
            this.txtmd5desencriptada = new System.Windows.Forms.TextBox();
            this.txtmd5encriptada = new System.Windows.Forms.TextBox();
            this.lblmd5desencriptada = new System.Windows.Forms.Label();
            this.lblmd5encriptada = new System.Windows.Forms.Label();
            this.grpAES256 = new System.Windows.Forms.GroupBox();
            this.txtaes256encriptada = new System.Windows.Forms.TextBox();
            this.lblaes256encriptada = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblAES256Desencriptada = new System.Windows.Forms.Label();
            this.txtAES256aRevelar = new System.Windows.Forms.TextBox();
            this.lblAES256ARevelar = new System.Windows.Forms.Label();
            this.txtAES256Revelada = new System.Windows.Forms.TextBox();
            this.btnRevelar = new System.Windows.Forms.Button();
            this.grpMD5.SuspendLayout();
            this.grpAES256.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMD5
            // 
            this.grpMD5.Controls.Add(this.btnmd5desencriptar);
            this.grpMD5.Controls.Add(this.txtmd5desencriptada);
            this.grpMD5.Controls.Add(this.txtmd5encriptada);
            this.grpMD5.Controls.Add(this.lblmd5desencriptada);
            this.grpMD5.Controls.Add(this.lblmd5encriptada);
            this.grpMD5.Location = new System.Drawing.Point(27, 25);
            this.grpMD5.Name = "grpMD5";
            this.grpMD5.Size = new System.Drawing.Size(1001, 143);
            this.grpMD5.TabIndex = 0;
            this.grpMD5.TabStop = false;
            this.grpMD5.Text = "MD5";
            // 
            // btnmd5desencriptar
            // 
            this.btnmd5desencriptar.Location = new System.Drawing.Point(841, 35);
            this.btnmd5desencriptar.Name = "btnmd5desencriptar";
            this.btnmd5desencriptar.Size = new System.Drawing.Size(122, 32);
            this.btnmd5desencriptar.TabIndex = 6;
            this.btnmd5desencriptar.Text = "Desencriptar";
            this.btnmd5desencriptar.UseVisualStyleBackColor = true;
            this.btnmd5desencriptar.Click += new System.EventHandler(this.btnmd5desencriptar_Click);
            // 
            // txtmd5desencriptada
            // 
            this.txtmd5desencriptada.Location = new System.Drawing.Point(217, 88);
            this.txtmd5desencriptada.Name = "txtmd5desencriptada";
            this.txtmd5desencriptada.ReadOnly = true;
            this.txtmd5desencriptada.Size = new System.Drawing.Size(568, 26);
            this.txtmd5desencriptada.TabIndex = 5;
            // 
            // txtmd5encriptada
            // 
            this.txtmd5encriptada.Location = new System.Drawing.Point(217, 35);
            this.txtmd5encriptada.Name = "txtmd5encriptada";
            this.txtmd5encriptada.Size = new System.Drawing.Size(568, 26);
            this.txtmd5encriptada.TabIndex = 4;
            this.txtmd5encriptada.GotFocus += new System.EventHandler(this.txtmd5encriptada_GotFocus);
            // 
            // lblmd5desencriptada
            // 
            this.lblmd5desencriptada.AutoSize = true;
            this.lblmd5desencriptada.Location = new System.Drawing.Point(21, 94);
            this.lblmd5desencriptada.Name = "lblmd5desencriptada";
            this.lblmd5desencriptada.Size = new System.Drawing.Size(183, 20);
            this.lblmd5desencriptada.TabIndex = 3;
            this.lblmd5desencriptada.Text = "Password desencriptada";
            // 
            // lblmd5encriptada
            // 
            this.lblmd5encriptada.AutoSize = true;
            this.lblmd5encriptada.Location = new System.Drawing.Point(21, 38);
            this.lblmd5encriptada.Name = "lblmd5encriptada";
            this.lblmd5encriptada.Size = new System.Drawing.Size(157, 20);
            this.lblmd5encriptada.TabIndex = 2;
            this.lblmd5encriptada.Text = "Password encriptada";
            // 
            // grpAES256
            // 
            this.grpAES256.Controls.Add(this.btnRevelar);
            this.grpAES256.Controls.Add(this.txtAES256Revelada);
            this.grpAES256.Controls.Add(this.lblAES256ARevelar);
            this.grpAES256.Controls.Add(this.txtAES256aRevelar);
            this.grpAES256.Controls.Add(this.lblAES256Desencriptada);
            this.grpAES256.Controls.Add(this.txtaes256encriptada);
            this.grpAES256.Controls.Add(this.lblaes256encriptada);
            this.grpAES256.Location = new System.Drawing.Point(27, 175);
            this.grpAES256.Name = "grpAES256";
            this.grpAES256.Size = new System.Drawing.Size(1001, 199);
            this.grpAES256.TabIndex = 1;
            this.grpAES256.TabStop = false;
            this.grpAES256.Text = "AES256";
            // 
            // txtaes256encriptada
            // 
            this.txtaes256encriptada.Location = new System.Drawing.Point(217, 38);
            this.txtaes256encriptada.Name = "txtaes256encriptada";
            this.txtaes256encriptada.ReadOnly = true;
            this.txtaes256encriptada.Size = new System.Drawing.Size(568, 26);
            this.txtaes256encriptada.TabIndex = 6;
            // 
            // lblaes256encriptada
            // 
            this.lblaes256encriptada.AutoSize = true;
            this.lblaes256encriptada.Location = new System.Drawing.Point(21, 41);
            this.lblaes256encriptada.Name = "lblaes256encriptada";
            this.lblaes256encriptada.Size = new System.Drawing.Size(157, 20);
            this.lblaes256encriptada.TabIndex = 3;
            this.lblaes256encriptada.Text = "Password encriptada";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblAES256Desencriptada
            // 
            this.lblAES256Desencriptada.AutoSize = true;
            this.lblAES256Desencriptada.Location = new System.Drawing.Point(21, 151);
            this.lblAES256Desencriptada.Name = "lblAES256Desencriptada";
            this.lblAES256Desencriptada.Size = new System.Drawing.Size(186, 20);
            this.lblAES256Desencriptada.TabIndex = 7;
            this.lblAES256Desencriptada.Text = "Password Desencriptada";
            // 
            // txtAES256aRevelar
            // 
            this.txtAES256aRevelar.Location = new System.Drawing.Point(217, 99);
            this.txtAES256aRevelar.Name = "txtAES256aRevelar";
            this.txtAES256aRevelar.Size = new System.Drawing.Size(568, 26);
            this.txtAES256aRevelar.TabIndex = 8;
            this.txtAES256aRevelar.GotFocus += new System.EventHandler(this.txtAES256aRevelar_GotFocus);
            // 
            // lblAES256ARevelar
            // 
            this.lblAES256ARevelar.AutoSize = true;
            this.lblAES256ARevelar.Location = new System.Drawing.Point(21, 99);
            this.lblAES256ARevelar.Name = "lblAES256ARevelar";
            this.lblAES256ARevelar.Size = new System.Drawing.Size(142, 20);
            this.lblAES256ARevelar.TabIndex = 9;
            this.lblAES256ARevelar.Text = "Password a revelar";
            // 
            // txtAES256Revelada
            // 
            this.txtAES256Revelada.Location = new System.Drawing.Point(217, 148);
            this.txtAES256Revelada.Name = "txtAES256Revelada";
            this.txtAES256Revelada.ReadOnly = true;
            this.txtAES256Revelada.Size = new System.Drawing.Size(568, 26);
            this.txtAES256Revelada.TabIndex = 10;
            // 
            // btnRevelar
            // 
            this.btnRevelar.Location = new System.Drawing.Point(841, 99);
            this.btnRevelar.Name = "btnRevelar";
            this.btnRevelar.Size = new System.Drawing.Size(122, 32);
            this.btnRevelar.TabIndex = 11;
            this.btnRevelar.Text = "Revelar";
            this.btnRevelar.UseVisualStyleBackColor = true;
            this.btnRevelar.Click += new System.EventHandler(this.btnRevelar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 388);
            this.Controls.Add(this.grpAES256);
            this.Controls.Add(this.grpMD5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD5 a AES256 Conversor";
            this.grpMD5.ResumeLayout(false);
            this.grpMD5.PerformLayout();
            this.grpAES256.ResumeLayout(false);
            this.grpAES256.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMD5;
        private System.Windows.Forms.Button btnmd5desencriptar;
        private System.Windows.Forms.TextBox txtmd5desencriptada;
        private System.Windows.Forms.TextBox txtmd5encriptada;
        private System.Windows.Forms.Label lblmd5desencriptada;
        private System.Windows.Forms.Label lblmd5encriptada;
        private System.Windows.Forms.GroupBox grpAES256;
        private System.Windows.Forms.TextBox txtaes256encriptada;
        private System.Windows.Forms.Label lblaes256encriptada;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRevelar;
        private System.Windows.Forms.TextBox txtAES256Revelada;
        private System.Windows.Forms.Label lblAES256ARevelar;
        private System.Windows.Forms.TextBox txtAES256aRevelar;
        private System.Windows.Forms.Label lblAES256Desencriptada;
    }
}

