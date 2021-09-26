using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Projekt_OS
{
    public class SHA_256
    {
        public static string ComputeSHA256Hash()
        {
            string outputString = "";

            try
            {
                using (var mySHA256 = SHA256.Create())
                {
                    var fInfo = new FileInfo(CryptoApp._activeFile);
                    var fileStream = fInfo.Open(FileMode.Open);

                    fileStream.Position = 0;
                    byte[] hashValue = mySHA256.ComputeHash(fileStream);

                    for (int i = 0; i < hashValue.Length; i++)
                    {
                        outputString += ($"{hashValue[i]:X2}");
                    }

                    fileStream.Close();
                }
            }
            catch (Exception UnsucessfulHashingException)
            {
                MessageBox.Show(UnsucessfulHashingException.Message);
            }
            return outputString;
        }

        public static byte[] ComputeSHA256HashBytes()
        {
            byte[] hashValue = null;
            try
            {
                using (var mySHA256 = SHA256.Create())
                {
                    var fInfo = new FileInfo(CryptoApp._activeFile);
                    var fileStream = fInfo.Open(FileMode.Open);

                    fileStream.Position = 0;

                    hashValue = mySHA256.ComputeHash(fileStream);

                    fileStream.Close();
                }
            }
            catch (Exception UnsucessfulHashingException)
            {
                MessageBox.Show(UnsucessfulHashingException.Message);
            }

            return hashValue;
        }
    }
}
