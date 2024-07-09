using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Encryption_and_decryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string EncryptText(string Name, short Key)
        {
            char[] chars = Name.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] + Key);
            }
            return new string(chars);
        }

        private string DecryptText(string Encrypt, short Key)
        {
            char[] chars = Encrypt.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(chars[i] - Key);
            }
            return new string(chars);
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtEncryptionResult.Text = EncryptText(txtToEncrypt.Text, 10);
        }

        private void btnOriginalReset_Click(object sender, EventArgs e)
        {
            txtToEncrypt.Clear();
        }

        private void btnEncryptedReset_Click(object sender, EventArgs e)
        {
            txtEncryptionResult.Clear();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtToEncrypt.Text = Clipboard.GetText();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtEncryptionResult.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecryptionResult.Text = DecryptText(txtToDecrypt.Text, 10);
        }

        private void btnPasteD_Click(object sender, EventArgs e)
        {
            txtToDecrypt.Text = Clipboard.GetText();
        }

        private void btnResetD_Click(object sender, EventArgs e)
        {
            txtToDecrypt.Clear();
        }

        private void btnDecryptedReset_Click(object sender, EventArgs e)
        {
            txtDecryptionResult.Clear();
        }

        private void btnCopyD_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDecryptionResult.Text);
        }

        private void btnSaveDecryption_Click(object sender, EventArgs e)
        {


            saveFileDialog1.InitialDirectory = @"D:\";

            saveFileDialog1.Title = "Decryption";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtDecryptionResult.Text);

                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void btnSaveEncryption_Click(object sender, EventArgs e)
        {

            saveFileDialog1.InitialDirectory = @"D:\";

            saveFileDialog1.Title = "Encryption";

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txtEncryptionResult.Text);

                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbEnglish.Checked = true;

            DisableDecryption();
        }

        private void rbLanguage_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEnglish.Checked)
            {
                txtToEncrypt.RightToLeft= RightToLeft.No;
                txtToDecrypt.RightToLeft= RightToLeft.No;
                txtDecryptionResult.RightToLeft= RightToLeft.No;
                txtEncryptionResult.RightToLeft= RightToLeft.No;
            }

            if (rbArabic.Checked)
            {
                txtToEncrypt.RightToLeft = RightToLeft.Yes;
                txtToDecrypt.RightToLeft = RightToLeft.Yes;
                txtDecryptionResult.RightToLeft = RightToLeft.Yes;
                txtEncryptionResult.RightToLeft = RightToLeft.Yes;
            }
        }

        private void DisableDecryption()
        {
            txtToDecrypt.Enabled= false;
            btnDecrypt.Enabled= false;
            btnPasteD.Enabled= false;
            btnResetD.Enabled= false;
            btnSaveDecryption.Enabled= false;
            btnCopyD.Enabled= false;
            btnDecryptedReset.Enabled= false;
        }

        private void EnableDecryption()
        {
            txtToDecrypt.Enabled = true;
            btnDecrypt.Enabled = true;
            btnPasteD.Enabled = true;
            btnResetD.Enabled = true;
            btnSaveDecryption.Enabled = true;
            btnCopyD.Enabled = true;
            btnDecryptedReset.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text=="1062023")
            {
                EnableDecryption();
            }

            else
            {
                DisableDecryption();
            }
              
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Password is (1062023)", "Password", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }

}
