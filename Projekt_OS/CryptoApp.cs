using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Projekt_OS
{
    public partial class CryptoApp : MetroFramework.Forms.MetroForm
    {
        public static string _activeFile = "ulazna_datoteka.txt";
        public static Aes myAes = Aes.Create();
        public static RSA RSA = new RSACryptoServiceProvider();

        public CryptoApp()
        {
            InitializeComponent();
            var fullPath = Path.GetFullPath(_activeFile);
            labelFilePath.Text = fullPath;
            textboxTextInput.Text = File.ReadAllText(fullPath);
        }

        private void buttonAESEncryption_Click(object sender, EventArgs e)
        {
            byte[] encrypted = AES_sim.EncryptStringToBytes_Aes(myAes.Key, myAes.IV);
            textboxEncryptedData.Text = Encoding.UTF8.GetString(encrypted);
        }

        //Metoda koja sadržaj ulaznog toka podataka pohranjuje u polje bajtova
        public static byte[] ReadFully(Stream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        private void buttonRSAEncryption_Click(object sender, EventArgs e)
        {
            var ByteConverter = new UTF8Encoding();

            byte[] encryptedData = RSA_asim.RSAEncrypt(RSA.ExportParameters(false), false);

            textboxEncryptedData.Text = ByteConverter.GetString(encryptedData);
        }

        private void buttonSHA256Encryption_Click(object sender, EventArgs e)
        {
            textboxEncryptedData.Text = SHA_256.ComputeSHA256Hash();
        }

        private void buttonComputeDigitalSignature_Click(object sender, EventArgs e)
        {
            RSA_asim.CalculateDigitalSignature();
        }

        private void buttonCheckDigitalSignature_Click(object sender, EventArgs e)
        {
            try
            {
                if (RSA_asim.VerifyDigitalSignature())
                    MessageBox.Show("Digital signature is valid", "Signature verification result", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (!RSA_asim.VerifyDigitalSignature())
                    MessageBox.Show("Digital signature is not valid", "Signature verification result", 
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception exceptionSignatureVerification)
            {
                MessageBox.Show("Please click 'Calculate digital signature' button before checking " +
                    "validity of the digital signature", "Signature verification error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSaveChangesFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText("ulazna_datoteka.txt", textboxTextInput.Text);
        }

        //Provjera veličine se provodi jer RSA algoritam nije pogodan za enkriptiranje velikih fileova.
        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(_activeFile);

                if (fileInfo.Length > 2097152)
                    MessageBox.Show("Odabrana prevelika datoteka", "error");
                else
                {
                    _activeFile = Path.GetFullPath(fileDialog.FileName);
                    labelFilePath.Text = _activeFile;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string decrypted = AES_sim.DecryptStringFromBytes_Aes(myAes.Key, myAes.IV);
            try
            {
                textboxDecryptedData.Text = decrypted;
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error upon decryption occured", "Decryption error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var ByteConverter = new UTF8Encoding();

            byte[] decryptedData = RSA_asim.RSADecryptFromFile(RSA.ExportParameters(true), false);
            try
            {
                textboxDecryptedData.Text = ByteConverter.GetString(decryptedData);
            }
            catch(Exception exc)
            {
                MessageBox.Show("Error upon decryption occured", "Decryption error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
