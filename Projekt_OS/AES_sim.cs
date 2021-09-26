using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Projekt_OS
{
    public class AES_sim
    {
        //IV - inicijalizacijski vektor koji se koristi kod enkripcije
        public static byte[] EncryptStringToBytes_Aes(byte[] Key, byte[] IV)
        {
 
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            var fInfo = new FileInfo(CryptoApp._activeFile);

            var fileStream = fInfo.Open(FileMode.Open);
            fileStream.Position = 0;
            byte[] stream = CryptoApp.ReadFully(fileStream);
            fileStream.Close();

            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.BlockSize = 128;
                aesAlg.KeySize = 256;
                aesAlg.Mode = CipherMode.CBC;
                aesAlg.Padding = PaddingMode.PKCS7;
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                File.WriteAllText("tajni_kljuc.txt", Convert.ToBase64String(aesAlg.Key));

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(Encoding.UTF8.GetString(stream));
                        }
                        encrypted = msEncrypt.ToArray();
                        File.WriteAllBytes("enkriptirani_ulaz.txt", encrypted);

                    }
                }
            }

            return encrypted;
        }    

        //IV - inicijalizacijski vektor koji se koristi kod enkripcije
        public static string DecryptStringFromBytes_Aes(byte[] Key, byte[] IV)
        {

            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            var fInfo = new FileInfo("enkriptirani_ulaz.txt");

            var fileStream = fInfo.Open(FileMode.Open);
            fileStream.Position = 0;

            byte[] encryptedData = CryptoApp.ReadFully(fileStream);
            string outputString = null;

            fileStream.Close();

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(encryptedData))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            outputString = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return outputString;
        }

    }
}
