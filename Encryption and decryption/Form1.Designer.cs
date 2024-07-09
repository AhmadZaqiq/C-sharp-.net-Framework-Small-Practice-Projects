namespace Encryption_and_decryption
{
    partial class Form1
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
            this.txtToEncrypt = new System.Windows.Forms.TextBox();
            this.txtEncryptionResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnPasteE = new System.Windows.Forms.Button();
            this.btnResetE = new System.Windows.Forms.Button();
            this.btnEncryptedReset = new System.Windows.Forms.Button();
            this.btnCopyE = new System.Windows.Forms.Button();
            this.btnSaveEncryption = new System.Windows.Forms.Button();
            this.btnDecryptedReset = new System.Windows.Forms.Button();
            this.btnCopyD = new System.Windows.Forms.Button();
            this.btnSaveDecryption = new System.Windows.Forms.Button();
            this.btnResetD = new System.Windows.Forms.Button();
            this.btnPasteD = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecryptionResult = new System.Windows.Forms.TextBox();
            this.txtToDecrypt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbArabic = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encryption";
            // 
            // txtToEncrypt
            // 
            this.txtToEncrypt.Location = new System.Drawing.Point(54, 196);
            this.txtToEncrypt.MaxLength = 3276700;
            this.txtToEncrypt.Multiline = true;
            this.txtToEncrypt.Name = "txtToEncrypt";
            this.txtToEncrypt.Size = new System.Drawing.Size(320, 101);
            this.txtToEncrypt.TabIndex = 1;
            // 
            // txtEncryptionResult
            // 
            this.txtEncryptionResult.Location = new System.Drawing.Point(54, 408);
            this.txtEncryptionResult.MaxLength = 3276700;
            this.txtEncryptionResult.Multiline = true;
            this.txtEncryptionResult.Name = "txtEncryptionResult";
            this.txtEncryptionResult.ReadOnly = true;
            this.txtEncryptionResult.Size = new System.Drawing.Size(320, 181);
            this.txtEncryptionResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(51, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter The Text to Encrypt Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(51, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Encryption result";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEncrypt.Location = new System.Drawing.Point(54, 303);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(80, 30);
            this.btnEncrypt.TabIndex = 5;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnPasteE
            // 
            this.btnPasteE.BackColor = System.Drawing.Color.Transparent;
            this.btnPasteE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPasteE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteE.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPasteE.Location = new System.Drawing.Point(174, 303);
            this.btnPasteE.Name = "btnPasteE";
            this.btnPasteE.Size = new System.Drawing.Size(80, 30);
            this.btnPasteE.TabIndex = 6;
            this.btnPasteE.Text = "Paste";
            this.btnPasteE.UseVisualStyleBackColor = false;
            this.btnPasteE.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnResetE
            // 
            this.btnResetE.BackColor = System.Drawing.Color.Transparent;
            this.btnResetE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetE.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResetE.Location = new System.Drawing.Point(294, 303);
            this.btnResetE.Name = "btnResetE";
            this.btnResetE.Size = new System.Drawing.Size(80, 30);
            this.btnResetE.TabIndex = 7;
            this.btnResetE.Text = "Reset";
            this.btnResetE.UseVisualStyleBackColor = false;
            this.btnResetE.Click += new System.EventHandler(this.btnOriginalReset_Click);
            // 
            // btnEncryptedReset
            // 
            this.btnEncryptedReset.BackColor = System.Drawing.Color.Transparent;
            this.btnEncryptedReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEncryptedReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncryptedReset.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptedReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEncryptedReset.Location = new System.Drawing.Point(294, 595);
            this.btnEncryptedReset.Name = "btnEncryptedReset";
            this.btnEncryptedReset.Size = new System.Drawing.Size(80, 30);
            this.btnEncryptedReset.TabIndex = 10;
            this.btnEncryptedReset.Text = "Reset";
            this.btnEncryptedReset.UseVisualStyleBackColor = false;
            this.btnEncryptedReset.Click += new System.EventHandler(this.btnEncryptedReset_Click);
            // 
            // btnCopyE
            // 
            this.btnCopyE.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCopyE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyE.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCopyE.Location = new System.Drawing.Point(174, 595);
            this.btnCopyE.Name = "btnCopyE";
            this.btnCopyE.Size = new System.Drawing.Size(80, 30);
            this.btnCopyE.TabIndex = 9;
            this.btnCopyE.Text = "Copy";
            this.btnCopyE.UseVisualStyleBackColor = false;
            this.btnCopyE.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSaveEncryption
            // 
            this.btnSaveEncryption.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveEncryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEncryption.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEncryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveEncryption.Location = new System.Drawing.Point(54, 595);
            this.btnSaveEncryption.Name = "btnSaveEncryption";
            this.btnSaveEncryption.Size = new System.Drawing.Size(80, 30);
            this.btnSaveEncryption.TabIndex = 8;
            this.btnSaveEncryption.Text = "Save";
            this.btnSaveEncryption.UseVisualStyleBackColor = false;
            this.btnSaveEncryption.Click += new System.EventHandler(this.btnSaveEncryption_Click);
            // 
            // btnDecryptedReset
            // 
            this.btnDecryptedReset.BackColor = System.Drawing.Color.Transparent;
            this.btnDecryptedReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDecryptedReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecryptedReset.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptedReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDecryptedReset.Location = new System.Drawing.Point(1061, 595);
            this.btnDecryptedReset.Name = "btnDecryptedReset";
            this.btnDecryptedReset.Size = new System.Drawing.Size(80, 30);
            this.btnDecryptedReset.TabIndex = 21;
            this.btnDecryptedReset.Text = "Reset";
            this.btnDecryptedReset.UseVisualStyleBackColor = false;
            this.btnDecryptedReset.Click += new System.EventHandler(this.btnDecryptedReset_Click);
            // 
            // btnCopyD
            // 
            this.btnCopyD.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCopyD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyD.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCopyD.Location = new System.Drawing.Point(941, 595);
            this.btnCopyD.Name = "btnCopyD";
            this.btnCopyD.Size = new System.Drawing.Size(80, 30);
            this.btnCopyD.TabIndex = 20;
            this.btnCopyD.Text = "Copy";
            this.btnCopyD.UseVisualStyleBackColor = false;
            this.btnCopyD.Click += new System.EventHandler(this.btnCopyD_Click);
            // 
            // btnSaveDecryption
            // 
            this.btnSaveDecryption.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveDecryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSaveDecryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDecryption.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDecryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveDecryption.Location = new System.Drawing.Point(821, 595);
            this.btnSaveDecryption.Name = "btnSaveDecryption";
            this.btnSaveDecryption.Size = new System.Drawing.Size(80, 30);
            this.btnSaveDecryption.TabIndex = 19;
            this.btnSaveDecryption.Text = "Save";
            this.btnSaveDecryption.UseVisualStyleBackColor = false;
            this.btnSaveDecryption.Click += new System.EventHandler(this.btnSaveDecryption_Click);
            // 
            // btnResetD
            // 
            this.btnResetD.BackColor = System.Drawing.Color.Transparent;
            this.btnResetD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnResetD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetD.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResetD.Location = new System.Drawing.Point(1061, 303);
            this.btnResetD.Name = "btnResetD";
            this.btnResetD.Size = new System.Drawing.Size(80, 30);
            this.btnResetD.TabIndex = 18;
            this.btnResetD.Text = "Reset";
            this.btnResetD.UseVisualStyleBackColor = false;
            this.btnResetD.Click += new System.EventHandler(this.btnResetD_Click);
            // 
            // btnPasteD
            // 
            this.btnPasteD.BackColor = System.Drawing.Color.Transparent;
            this.btnPasteD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPasteD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasteD.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPasteD.Location = new System.Drawing.Point(941, 303);
            this.btnPasteD.Name = "btnPasteD";
            this.btnPasteD.Size = new System.Drawing.Size(80, 30);
            this.btnPasteD.TabIndex = 17;
            this.btnPasteD.Text = "Paste";
            this.btnPasteD.UseVisualStyleBackColor = false;
            this.btnPasteD.Click += new System.EventHandler(this.btnPasteD_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDecrypt.Location = new System.Drawing.Point(821, 303);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(80, 30);
            this.btnDecrypt.TabIndex = 16;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(818, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Decryption result";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(818, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Enter The Text to Decrypt Here";
            // 
            // txtDecryptionResult
            // 
            this.txtDecryptionResult.Location = new System.Drawing.Point(821, 408);
            this.txtDecryptionResult.MaxLength = 3276700;
            this.txtDecryptionResult.Multiline = true;
            this.txtDecryptionResult.Name = "txtDecryptionResult";
            this.txtDecryptionResult.ReadOnly = true;
            this.txtDecryptionResult.Size = new System.Drawing.Size(320, 181);
            this.txtDecryptionResult.TabIndex = 13;
            // 
            // txtToDecrypt
            // 
            this.txtToDecrypt.Location = new System.Drawing.Point(821, 196);
            this.txtToDecrypt.MaxLength = 3276700;
            this.txtToDecrypt.Multiline = true;
            this.txtToDecrypt.Name = "txtToDecrypt";
            this.txtToDecrypt.Size = new System.Drawing.Size(320, 101);
            this.txtToDecrypt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(812, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 62);
            this.label6.TabIndex = 11;
            this.label6.Text = "Decryption";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(502, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Choose language";
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.BackColor = System.Drawing.Color.Transparent;
            this.rbEnglish.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbEnglish.Location = new System.Drawing.Point(506, 172);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(86, 24);
            this.rbEnglish.TabIndex = 23;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = false;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbLanguage_CheckedChanged);
            // 
            // rbArabic
            // 
            this.rbArabic.AutoSize = true;
            this.rbArabic.BackColor = System.Drawing.Color.Transparent;
            this.rbArabic.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbArabic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rbArabic.Location = new System.Drawing.Point(610, 172);
            this.rbArabic.Name = "rbArabic";
            this.rbArabic.Size = new System.Drawing.Size(83, 24);
            this.rbArabic.TabIndex = 24;
            this.rbArabic.TabStop = true;
            this.rbArabic.Text = "Arabic";
            this.rbArabic.UseVisualStyleBackColor = false;
            this.rbArabic.CheckedChanged += new System.EventHandler(this.rbLanguage_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(457, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Enter password To use Decryption";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(507, 530);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(181, 20);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Font = new System.Drawing.Font("Lucida Calligraphy", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassword.ForeColor = System.Drawing.Color.Red;
            this.btnPassword.Location = new System.Drawing.Point(557, 580);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(80, 30);
            this.btnPassword.TabIndex = 27;
            this.btnPassword.Text = "Password";
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Encryption_and_decryption.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 632);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbArabic);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDecryptedReset);
            this.Controls.Add(this.btnCopyD);
            this.Controls.Add(this.btnSaveDecryption);
            this.Controls.Add(this.btnResetD);
            this.Controls.Add(this.btnPasteD);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDecryptionResult);
            this.Controls.Add(this.txtToDecrypt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEncryptedReset);
            this.Controls.Add(this.btnCopyE);
            this.Controls.Add(this.btnSaveEncryption);
            this.Controls.Add(this.btnResetE);
            this.Controls.Add(this.btnPasteE);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEncryptionResult);
            this.Controls.Add(this.txtToEncrypt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Encryption and Decryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToEncrypt;
        private System.Windows.Forms.TextBox txtEncryptionResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnPasteE;
        private System.Windows.Forms.Button btnResetE;
        private System.Windows.Forms.Button btnEncryptedReset;
        private System.Windows.Forms.Button btnCopyE;
        private System.Windows.Forms.Button btnSaveEncryption;
        private System.Windows.Forms.Button btnDecryptedReset;
        private System.Windows.Forms.Button btnCopyD;
        private System.Windows.Forms.Button btnSaveDecryption;
        private System.Windows.Forms.Button btnResetD;
        private System.Windows.Forms.Button btnPasteD;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDecryptionResult;
        private System.Windows.Forms.TextBox txtToDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbArabic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnPassword;
    }
}

