namespace Group7_Module1
{
    partial class MonoCipher
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
            this.txtPlainText_Encrypt = new System.Windows.Forms.TextBox();
            this.grbEncrypt = new System.Windows.Forms.GroupBox();
            this.lblAlphabet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblCipherText_Encrypt = new System.Windows.Forms.Label();
            this.txtCipherText_Encrypt = new System.Windows.Forms.TextBox();
            this.txtKey_Encrypt = new System.Windows.Forms.TextBox();
            this.btnGenerateKey = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblPlainText_Encrypt = new System.Windows.Forms.Label();
            this.grbDecrypt = new System.Windows.Forms.GroupBox();
            this.txtKey_Decrypt = new System.Windows.Forms.TextBox();
            this.lblPlainText_Decrypt = new System.Windows.Forms.Label();
            this.lblKey_Decrypt = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtPlainText_Decrypt = new System.Windows.Forms.TextBox();
            this.lblCipherText_Decrypt = new System.Windows.Forms.Label();
            this.txtCipherText_Decrypt = new System.Windows.Forms.TextBox();
            this.lblMonoCipher = new System.Windows.Forms.Label();
            this.btnInstructionManual = new System.Windows.Forms.Button();
            this.grbEncrypt.SuspendLayout();
            this.grbDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlainText_Encrypt
            // 
            this.txtPlainText_Encrypt.Location = new System.Drawing.Point(22, 81);
            this.txtPlainText_Encrypt.Multiline = true;
            this.txtPlainText_Encrypt.Name = "txtPlainText_Encrypt";
            this.txtPlainText_Encrypt.Size = new System.Drawing.Size(453, 51);
            this.txtPlainText_Encrypt.TabIndex = 0;
            // 
            // grbEncrypt
            // 
            this.grbEncrypt.Controls.Add(this.lblAlphabet);
            this.grbEncrypt.Controls.Add(this.label4);
            this.grbEncrypt.Controls.Add(this.btnEncrypt);
            this.grbEncrypt.Controls.Add(this.lblCipherText_Encrypt);
            this.grbEncrypt.Controls.Add(this.txtCipherText_Encrypt);
            this.grbEncrypt.Controls.Add(this.txtKey_Encrypt);
            this.grbEncrypt.Controls.Add(this.btnGenerateKey);
            this.grbEncrypt.Controls.Add(this.lblKey);
            this.grbEncrypt.Controls.Add(this.lblPlainText_Encrypt);
            this.grbEncrypt.Controls.Add(this.txtPlainText_Encrypt);
            this.grbEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEncrypt.Location = new System.Drawing.Point(12, 91);
            this.grbEncrypt.Name = "grbEncrypt";
            this.grbEncrypt.Size = new System.Drawing.Size(494, 499);
            this.grbEncrypt.TabIndex = 1;
            this.grbEncrypt.TabStop = false;
            this.grbEncrypt.Text = "Encrypt";
            // 
            // lblAlphabet
            // 
            this.lblAlphabet.AutoSize = true;
            this.lblAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphabet.Location = new System.Drawing.Point(139, 225);
            this.lblAlphabet.Name = "lblAlphabet";
            this.lblAlphabet.Size = new System.Drawing.Size(303, 20);
            this.lblAlphabet.TabIndex = 9;
            this.lblAlphabet.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alphabet:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(180, 328);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(142, 43);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblCipherText_Encrypt
            // 
            this.lblCipherText_Encrypt.AutoSize = true;
            this.lblCipherText_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCipherText_Encrypt.Location = new System.Drawing.Point(17, 388);
            this.lblCipherText_Encrypt.Name = "lblCipherText_Encrypt";
            this.lblCipherText_Encrypt.Size = new System.Drawing.Size(112, 25);
            this.lblCipherText_Encrypt.TabIndex = 6;
            this.lblCipherText_Encrypt.Text = "Cipher text:";
            // 
            // txtCipherText_Encrypt
            // 
            this.txtCipherText_Encrypt.Location = new System.Drawing.Point(22, 430);
            this.txtCipherText_Encrypt.Multiline = true;
            this.txtCipherText_Encrypt.Name = "txtCipherText_Encrypt";
            this.txtCipherText_Encrypt.Size = new System.Drawing.Size(453, 51);
            this.txtCipherText_Encrypt.TabIndex = 5;
            // 
            // txtKey_Encrypt
            // 
            this.txtKey_Encrypt.Location = new System.Drawing.Point(139, 266);
            this.txtKey_Encrypt.Multiline = true;
            this.txtKey_Encrypt.Name = "txtKey_Encrypt";
            this.txtKey_Encrypt.Size = new System.Drawing.Size(336, 31);
            this.txtKey_Encrypt.TabIndex = 4;
            // 
            // btnGenerateKey
            // 
            this.btnGenerateKey.Location = new System.Drawing.Point(180, 153);
            this.btnGenerateKey.Name = "btnGenerateKey";
            this.btnGenerateKey.Size = new System.Drawing.Size(142, 49);
            this.btnGenerateKey.TabIndex = 3;
            this.btnGenerateKey.Text = "Generate key";
            this.btnGenerateKey.UseVisualStyleBackColor = true;
            this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(17, 269);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(53, 25);
            this.lblKey.TabIndex = 2;
            this.lblKey.Text = "Key:";
            // 
            // lblPlainText_Encrypt
            // 
            this.lblPlainText_Encrypt.AutoSize = true;
            this.lblPlainText_Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainText_Encrypt.Location = new System.Drawing.Point(17, 41);
            this.lblPlainText_Encrypt.Name = "lblPlainText_Encrypt";
            this.lblPlainText_Encrypt.Size = new System.Drawing.Size(97, 25);
            this.lblPlainText_Encrypt.TabIndex = 1;
            this.lblPlainText_Encrypt.Text = "Plain text:";
            // 
            // grbDecrypt
            // 
            this.grbDecrypt.Controls.Add(this.txtKey_Decrypt);
            this.grbDecrypt.Controls.Add(this.lblPlainText_Decrypt);
            this.grbDecrypt.Controls.Add(this.lblKey_Decrypt);
            this.grbDecrypt.Controls.Add(this.btnDecrypt);
            this.grbDecrypt.Controls.Add(this.txtPlainText_Decrypt);
            this.grbDecrypt.Controls.Add(this.lblCipherText_Decrypt);
            this.grbDecrypt.Controls.Add(this.txtCipherText_Decrypt);
            this.grbDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDecrypt.Location = new System.Drawing.Point(512, 91);
            this.grbDecrypt.Name = "grbDecrypt";
            this.grbDecrypt.Size = new System.Drawing.Size(498, 499);
            this.grbDecrypt.TabIndex = 2;
            this.grbDecrypt.TabStop = false;
            this.grbDecrypt.Text = "Decrypt";
            // 
            // txtKey_Decrypt
            // 
            this.txtKey_Decrypt.Location = new System.Drawing.Point(103, 220);
            this.txtKey_Decrypt.Multiline = true;
            this.txtKey_Decrypt.Name = "txtKey_Decrypt";
            this.txtKey_Decrypt.Size = new System.Drawing.Size(371, 31);
            this.txtKey_Decrypt.TabIndex = 10;
            // 
            // lblPlainText_Decrypt
            // 
            this.lblPlainText_Decrypt.AutoSize = true;
            this.lblPlainText_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlainText_Decrypt.Location = new System.Drawing.Point(16, 388);
            this.lblPlainText_Decrypt.Name = "lblPlainText_Decrypt";
            this.lblPlainText_Decrypt.Size = new System.Drawing.Size(97, 25);
            this.lblPlainText_Decrypt.TabIndex = 9;
            this.lblPlainText_Decrypt.Text = "Plain text:";
            // 
            // lblKey_Decrypt
            // 
            this.lblKey_Decrypt.AutoSize = true;
            this.lblKey_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey_Decrypt.Location = new System.Drawing.Point(16, 220);
            this.lblKey_Decrypt.Name = "lblKey_Decrypt";
            this.lblKey_Decrypt.Size = new System.Drawing.Size(53, 25);
            this.lblKey_Decrypt.TabIndex = 8;
            this.lblKey_Decrypt.Text = "Key:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(186, 328);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(142, 43);
            this.btnDecrypt.TabIndex = 8;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtPlainText_Decrypt
            // 
            this.txtPlainText_Decrypt.Location = new System.Drawing.Point(21, 430);
            this.txtPlainText_Decrypt.Multiline = true;
            this.txtPlainText_Decrypt.Name = "txtPlainText_Decrypt";
            this.txtPlainText_Decrypt.Size = new System.Drawing.Size(453, 51);
            this.txtPlainText_Decrypt.TabIndex = 8;
            // 
            // lblCipherText_Decrypt
            // 
            this.lblCipherText_Decrypt.AutoSize = true;
            this.lblCipherText_Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCipherText_Decrypt.Location = new System.Drawing.Point(16, 41);
            this.lblCipherText_Decrypt.Name = "lblCipherText_Decrypt";
            this.lblCipherText_Decrypt.Size = new System.Drawing.Size(112, 25);
            this.lblCipherText_Decrypt.TabIndex = 2;
            this.lblCipherText_Decrypt.Text = "Cipher text:";
            // 
            // txtCipherText_Decrypt
            // 
            this.txtCipherText_Decrypt.Location = new System.Drawing.Point(21, 81);
            this.txtCipherText_Decrypt.Multiline = true;
            this.txtCipherText_Decrypt.Name = "txtCipherText_Decrypt";
            this.txtCipherText_Decrypt.Size = new System.Drawing.Size(453, 51);
            this.txtCipherText_Decrypt.TabIndex = 0;
            // 
            // lblMonoCipher
            // 
            this.lblMonoCipher.AutoSize = true;
            this.lblMonoCipher.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonoCipher.Location = new System.Drawing.Point(186, 26);
            this.lblMonoCipher.Name = "lblMonoCipher";
            this.lblMonoCipher.Size = new System.Drawing.Size(523, 36);
            this.lblMonoCipher.TabIndex = 3;
            this.lblMonoCipher.Text = "Monoalphabetic Substitution Cipher";
            // 
            // btnInstructionManual
            // 
            this.btnInstructionManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructionManual.Location = new System.Drawing.Point(830, 20);
            this.btnInstructionManual.Name = "btnInstructionManual";
            this.btnInstructionManual.Size = new System.Drawing.Size(180, 59);
            this.btnInstructionManual.TabIndex = 4;
            this.btnInstructionManual.Text = "Instruction manual";
            this.btnInstructionManual.UseVisualStyleBackColor = true;
            this.btnInstructionManual.Click += new System.EventHandler(this.btnInstructionManual_Click);
            // 
            // MonoCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.btnInstructionManual);
            this.Controls.Add(this.lblMonoCipher);
            this.Controls.Add(this.grbDecrypt);
            this.Controls.Add(this.grbEncrypt);
            this.Name = "MonoCipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonoCipher";
            this.grbEncrypt.ResumeLayout(false);
            this.grbEncrypt.PerformLayout();
            this.grbDecrypt.ResumeLayout(false);
            this.grbDecrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlainText_Encrypt;
        private System.Windows.Forms.GroupBox grbEncrypt;
        private System.Windows.Forms.GroupBox grbDecrypt;
        private System.Windows.Forms.TextBox txtCipherText_Decrypt;
        private System.Windows.Forms.Label lblMonoCipher;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblCipherText_Encrypt;
        private System.Windows.Forms.TextBox txtCipherText_Encrypt;
        private System.Windows.Forms.TextBox txtKey_Encrypt;
        private System.Windows.Forms.Button btnGenerateKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblPlainText_Encrypt;
        private System.Windows.Forms.Label lblPlainText_Decrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtPlainText_Decrypt;
        private System.Windows.Forms.Label lblCipherText_Decrypt;
        private System.Windows.Forms.TextBox txtKey_Decrypt;
        private System.Windows.Forms.Label lblKey_Decrypt;
        private System.Windows.Forms.Button btnInstructionManual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAlphabet;
    }
}

