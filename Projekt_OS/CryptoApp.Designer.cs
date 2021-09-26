namespace Projekt_OS
{
    partial class CryptoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoApp));
            this.buttonAESEncryption = new MetroFramework.Controls.MetroButton();
            this.labelDecodedData = new MetroFramework.Controls.MetroLabel();
            this.buttonRSAEncryption = new MetroFramework.Controls.MetroButton();
            this.buttonCalculateHash = new MetroFramework.Controls.MetroButton();
            this.buttonComputeDigitalSignature = new MetroFramework.Controls.MetroButton();
            this.labelEncodedData = new MetroFramework.Controls.MetroLabel();
            this.buttonCheckDigitalSignature = new MetroFramework.Controls.MetroButton();
            this.textboxEncryptedData = new MetroFramework.Controls.MetroTextBox();
            this.textboxDecryptedData = new MetroFramework.Controls.MetroTextBox();
            this.textboxTextInput = new MetroFramework.Controls.MetroTextBox();
            this.buttonSaveChangesFile = new MetroFramework.Controls.MetroButton();
            this.buttonSelectFile = new MetroFramework.Controls.MetroButton();
            this.labelFilePath = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // buttonAESEncryption
            // 
            this.buttonAESEncryption.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonAESEncryption.Location = new System.Drawing.Point(331, 180);
            this.buttonAESEncryption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAESEncryption.Name = "buttonAESEncryption";
            this.buttonAESEncryption.Size = new System.Drawing.Size(112, 55);
            this.buttonAESEncryption.TabIndex = 0;
            this.buttonAESEncryption.Text = "AES \r\nEncryption";
            this.buttonAESEncryption.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonAESEncryption.Click += new System.EventHandler(this.buttonAESEncryption_Click);
            // 
            // labelDecodedData
            // 
            this.labelDecodedData.AutoSize = true;
            this.labelDecodedData.Location = new System.Drawing.Point(605, 210);
            this.labelDecodedData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDecodedData.Name = "labelDecodedData";
            this.labelDecodedData.Size = new System.Drawing.Size(103, 19);
            this.labelDecodedData.TabIndex = 1;
            this.labelDecodedData.Text = "Decrypted data:";
            this.labelDecodedData.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // buttonRSAEncryption
            // 
            this.buttonRSAEncryption.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonRSAEncryption.Location = new System.Drawing.Point(331, 341);
            this.buttonRSAEncryption.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonRSAEncryption.Name = "buttonRSAEncryption";
            this.buttonRSAEncryption.Size = new System.Drawing.Size(112, 55);
            this.buttonRSAEncryption.TabIndex = 2;
            this.buttonRSAEncryption.Text = "RSA \r\nEncryption";
            this.buttonRSAEncryption.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonRSAEncryption.Click += new System.EventHandler(this.buttonRSAEncryption_Click);
            // 
            // buttonCalculateHash
            // 
            this.buttonCalculateHash.BackColor = System.Drawing.Color.White;
            this.buttonCalculateHash.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonCalculateHash.Location = new System.Drawing.Point(331, 103);
            this.buttonCalculateHash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCalculateHash.Name = "buttonCalculateHash";
            this.buttonCalculateHash.Size = new System.Drawing.Size(112, 55);
            this.buttonCalculateHash.TabIndex = 3;
            this.buttonCalculateHash.Text = "Compute \r\nSHA-256 Hash";
            this.buttonCalculateHash.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonCalculateHash.Click += new System.EventHandler(this.buttonSHA256Encryption_Click);
            // 
            // buttonComputeDigitalSignature
            // 
            this.buttonComputeDigitalSignature.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonComputeDigitalSignature.Location = new System.Drawing.Point(467, 147);
            this.buttonComputeDigitalSignature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonComputeDigitalSignature.Name = "buttonComputeDigitalSignature";
            this.buttonComputeDigitalSignature.Size = new System.Drawing.Size(112, 55);
            this.buttonComputeDigitalSignature.TabIndex = 4;
            this.buttonComputeDigitalSignature.Text = "Compute Digital \r\nSignature";
            this.buttonComputeDigitalSignature.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonComputeDigitalSignature.Click += new System.EventHandler(this.buttonComputeDigitalSignature_Click);
            // 
            // labelEncodedData
            // 
            this.labelEncodedData.AutoSize = true;
            this.labelEncodedData.Location = new System.Drawing.Point(605, 35);
            this.labelEncodedData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEncodedData.Name = "labelEncodedData";
            this.labelEncodedData.Size = new System.Drawing.Size(101, 19);
            this.labelEncodedData.TabIndex = 5;
            this.labelEncodedData.Text = "Encrypted data:";
            this.labelEncodedData.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // buttonCheckDigitalSignature
            // 
            this.buttonCheckDigitalSignature.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonCheckDigitalSignature.Location = new System.Drawing.Point(467, 245);
            this.buttonCheckDigitalSignature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCheckDigitalSignature.Name = "buttonCheckDigitalSignature";
            this.buttonCheckDigitalSignature.Size = new System.Drawing.Size(112, 55);
            this.buttonCheckDigitalSignature.TabIndex = 6;
            this.buttonCheckDigitalSignature.Text = "Check Digital \r\nSignature";
            this.buttonCheckDigitalSignature.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonCheckDigitalSignature.Click += new System.EventHandler(this.buttonCheckDigitalSignature_Click);
            // 
            // textboxEncryptedData
            // 
            // 
            // 
            // 
            this.textboxEncryptedData.CustomButton.Image = null;
            this.textboxEncryptedData.CustomButton.Location = new System.Drawing.Point(35, 2);
            this.textboxEncryptedData.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxEncryptedData.CustomButton.Name = "";
            this.textboxEncryptedData.CustomButton.Size = new System.Drawing.Size(101, 110);
            this.textboxEncryptedData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxEncryptedData.CustomButton.TabIndex = 1;
            this.textboxEncryptedData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxEncryptedData.CustomButton.Visible = false;
            this.textboxEncryptedData.Enabled = false;
            this.textboxEncryptedData.Lines = new string[] {
        "Encrypted data goes here"};
            this.textboxEncryptedData.Location = new System.Drawing.Point(605, 63);
            this.textboxEncryptedData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxEncryptedData.MaxLength = 32767;
            this.textboxEncryptedData.Multiline = true;
            this.textboxEncryptedData.Name = "textboxEncryptedData";
            this.textboxEncryptedData.PasswordChar = '\0';
            this.textboxEncryptedData.ReadOnly = true;
            this.textboxEncryptedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxEncryptedData.SelectedText = "";
            this.textboxEncryptedData.SelectionLength = 0;
            this.textboxEncryptedData.SelectionStart = 0;
            this.textboxEncryptedData.ShortcutsEnabled = true;
            this.textboxEncryptedData.Size = new System.Drawing.Size(185, 140);
            this.textboxEncryptedData.TabIndex = 7;
            this.textboxEncryptedData.Text = "Encrypted data goes here";
            this.textboxEncryptedData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxEncryptedData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxDecryptedData
            // 
            // 
            // 
            // 
            this.textboxDecryptedData.CustomButton.Image = null;
            this.textboxDecryptedData.CustomButton.Location = new System.Drawing.Point(35, 2);
            this.textboxDecryptedData.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxDecryptedData.CustomButton.Name = "";
            this.textboxDecryptedData.CustomButton.Size = new System.Drawing.Size(101, 110);
            this.textboxDecryptedData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxDecryptedData.CustomButton.TabIndex = 1;
            this.textboxDecryptedData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxDecryptedData.CustomButton.Visible = false;
            this.textboxDecryptedData.Enabled = false;
            this.textboxDecryptedData.Lines = new string[] {
        "Decrypted data goes here"};
            this.textboxDecryptedData.Location = new System.Drawing.Point(605, 238);
            this.textboxDecryptedData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxDecryptedData.MaxLength = 32767;
            this.textboxDecryptedData.Multiline = true;
            this.textboxDecryptedData.Name = "textboxDecryptedData";
            this.textboxDecryptedData.PasswordChar = '\0';
            this.textboxDecryptedData.ReadOnly = true;
            this.textboxDecryptedData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxDecryptedData.SelectedText = "";
            this.textboxDecryptedData.SelectionLength = 0;
            this.textboxDecryptedData.SelectionStart = 0;
            this.textboxDecryptedData.ShortcutsEnabled = true;
            this.textboxDecryptedData.Size = new System.Drawing.Size(185, 140);
            this.textboxDecryptedData.TabIndex = 8;
            this.textboxDecryptedData.Text = "Decrypted data goes here";
            this.textboxDecryptedData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxDecryptedData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textboxTextInput
            // 
            // 
            // 
            // 
            this.textboxTextInput.CustomButton.Image = null;
            this.textboxTextInput.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.textboxTextInput.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxTextInput.CustomButton.Name = "";
            this.textboxTextInput.CustomButton.Size = new System.Drawing.Size(158, 171);
            this.textboxTextInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxTextInput.CustomButton.TabIndex = 1;
            this.textboxTextInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxTextInput.CustomButton.Visible = false;
            this.textboxTextInput.Lines = new string[] {
        "Text goes here"};
            this.textboxTextInput.Location = new System.Drawing.Point(17, 105);
            this.textboxTextInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxTextInput.MaxLength = 32767;
            this.textboxTextInput.Multiline = true;
            this.textboxTextInput.Name = "textboxTextInput";
            this.textboxTextInput.PasswordChar = '\0';
            this.textboxTextInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxTextInput.SelectedText = "";
            this.textboxTextInput.SelectionLength = 0;
            this.textboxTextInput.SelectionStart = 0;
            this.textboxTextInput.ShortcutsEnabled = true;
            this.textboxTextInput.Size = new System.Drawing.Size(287, 213);
            this.textboxTextInput.TabIndex = 9;
            this.textboxTextInput.Text = "Text goes here";
            this.textboxTextInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxTextInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonSaveChangesFile
            // 
            this.buttonSaveChangesFile.BackColor = System.Drawing.Color.White;
            this.buttonSaveChangesFile.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonSaveChangesFile.Location = new System.Drawing.Point(192, 336);
            this.buttonSaveChangesFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSaveChangesFile.Name = "buttonSaveChangesFile";
            this.buttonSaveChangesFile.Size = new System.Drawing.Size(112, 55);
            this.buttonSaveChangesFile.TabIndex = 10;
            this.buttonSaveChangesFile.Text = "Save changes";
            this.buttonSaveChangesFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonSaveChangesFile.Click += new System.EventHandler(this.buttonSaveChangesFile_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.BackColor = System.Drawing.Color.White;
            this.buttonSelectFile.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.buttonSelectFile.Location = new System.Drawing.Point(17, 336);
            this.buttonSelectFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(112, 55);
            this.buttonSelectFile.TabIndex = 11;
            this.buttonSelectFile.Text = "Select file";
            this.buttonSelectFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(17, 74);
            this.labelFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(34, 19);
            this.labelFilePath.TabIndex = 12;
            this.labelFilePath.Text = "Path";
            this.labelFilePath.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.Location = new System.Drawing.Point(331, 261);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(112, 55);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "AES \r\nDecryption";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton2.Location = new System.Drawing.Point(331, 420);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(112, 55);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "RSA \r\nDecryption";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // CryptoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 506);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.buttonSaveChangesFile);
            this.Controls.Add(this.textboxTextInput);
            this.Controls.Add(this.textboxDecryptedData);
            this.Controls.Add(this.textboxEncryptedData);
            this.Controls.Add(this.buttonCheckDigitalSignature);
            this.Controls.Add(this.labelEncodedData);
            this.Controls.Add(this.buttonComputeDigitalSignature);
            this.Controls.Add(this.buttonCalculateHash);
            this.Controls.Add(this.buttonRSAEncryption);
            this.Controls.Add(this.labelDecodedData);
            this.Controls.Add(this.buttonAESEncryption);
            this.ForeColor = System.Drawing.Color.Turquoise;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "CryptoApp";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Crypto App";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton buttonAESEncryption;
        private MetroFramework.Controls.MetroLabel labelDecodedData;
        private MetroFramework.Controls.MetroButton buttonRSAEncryption;
        private MetroFramework.Controls.MetroButton buttonCalculateHash;
        private MetroFramework.Controls.MetroButton buttonComputeDigitalSignature;
        private MetroFramework.Controls.MetroLabel labelEncodedData;
        private MetroFramework.Controls.MetroButton buttonCheckDigitalSignature;
        private MetroFramework.Controls.MetroTextBox textboxEncryptedData;
        private MetroFramework.Controls.MetroTextBox textboxDecryptedData;
        private MetroFramework.Controls.MetroTextBox textboxTextInput;
        private MetroFramework.Controls.MetroButton buttonSaveChangesFile;
        private MetroFramework.Controls.MetroButton buttonSelectFile;
        private MetroFramework.Controls.MetroLabel labelFilePath;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

