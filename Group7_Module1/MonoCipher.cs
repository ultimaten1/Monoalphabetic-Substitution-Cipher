using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group7_Module1
{
    public partial class MonoCipher : Form
    {
        public MonoCipher()
        {
            InitializeComponent();
        }

        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            string key = Models.MonoCipher.GenerateRandomKey().ToUpper();
            txtKey_Encrypt.Text = key;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string cypherText = Models.MonoCipher.Encrypt(txtPlainText_Encrypt.Text.ToLower(), txtKey_Encrypt.Text.ToLower()).ToUpper();
            txtCipherText_Encrypt.Text = cypherText;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string plainText = Models.MonoCipher.Decrypt(txtCipherText_Decrypt.Text.ToLower(), txtKey_Decrypt.Text.ToLower()).ToUpper();
            txtPlainText_Decrypt.Text = plainText;
        }

        private void btnInstructionManual_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "1. Encrypt:\n" +
                "- Enter the text into \"Plain text\" that needs to be encrypted\r\n- Click \"Generate key\" to create the key\r\n- Click \"Encrypt\" to encrypt \"Plain text\" into \"Cipher text\"\n" +
                "2. Decrypt:\n" +
                "- Enter the text \"Cipher text\" from the \"Encrypt\" group into the \"Decrypt\" group\r\n- Copy key from \"Encrypt\" group to \"Decrypt\" group\r\n- Click \"Decrypt\" to decrypt \"Cipher text\" into \"Plain text\"", 
                "Instruction Manual", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }
    }
}
