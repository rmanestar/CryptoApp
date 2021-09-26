using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Projekt_OS
{
    public class RSA_asim
    {
        private static RSACryptoServiceProvider RSAalgorithm = new RSACryptoServiceProvider();
        private static byte[] _signedHash = null;

        public static byte[] RSAEncrypt(RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            var fInfo = new FileInfo(CryptoApp._activeFile);
            var fileStream = fInfo.Open(FileMode.Open);

            fileStream.Position = 0;
            byte[] DataToEncrypt = CryptoApp.ReadFully(fileStream);

            fileStream.Close();
            try
            {
                byte[] encryptedData;

                RSAalgorithm = new RSACryptoServiceProvider();
                RSAalgorithm.ImportParameters(RSAKeyInfo);

                encryptedData = RSAalgorithm.Encrypt(DataToEncrypt, DoOAEPPadding);

                File.WriteAllBytes("enkriptirani_ulaz.txt", encryptedData);

                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

        public static byte[] RSADecryptFromFile(RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            var fInfo = new FileInfo("enkriptirani_ulaz.txt");
            var fileStream = fInfo.Open(FileMode.Open);
            fileStream.Position = 0;

            byte[] encryptedData = CryptoApp.ReadFully(fileStream);
            byte[] decryptedData;

            fileStream.Close();

            try
            {
                RSAalgorithm.ImportParameters(RSAKeyInfo);
                ExportPrivateKey(RSAalgorithm);

                decryptedData = RSAalgorithm.Decrypt(encryptedData, DoOAEPPadding);
                ExportPublicKey(RSAalgorithm);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

            return decryptedData;
        }

        private static void ExportPrivateKey(RSACryptoServiceProvider csp)
        {
            if (csp.PublicOnly) throw new ArgumentException("CSP does not contain a private key", "csp");
            var parameters = csp.ExportParameters(true);
            TextWriter outputStream = new StreamWriter("privatni_kljuc.txt");

            using (var stream = new MemoryStream())
            {
                var writer = new BinaryWriter(stream);
                writer.Write((byte)0x30);
                using (var innerStream = new MemoryStream())
                {
                    var innerWriter = new BinaryWriter(innerStream);
                    EncodeIntegerBigEndian(innerWriter, new byte[] { 0x00 });
                    EncodeIntegerBigEndian(innerWriter, parameters.Modulus);
                    EncodeIntegerBigEndian(innerWriter, parameters.Exponent);
                    EncodeIntegerBigEndian(innerWriter, parameters.D);
                    EncodeIntegerBigEndian(innerWriter, parameters.P);
                    EncodeIntegerBigEndian(innerWriter, parameters.Q);
                    EncodeIntegerBigEndian(innerWriter, parameters.DP);
                    EncodeIntegerBigEndian(innerWriter, parameters.DQ);
                    EncodeIntegerBigEndian(innerWriter, parameters.InverseQ);
                    var length = (int)innerStream.Length;
                    EncodeLength(writer, length);
                    writer.Write(innerStream.GetBuffer(), 0, length);
                }

                var base64 = Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length).ToCharArray();

                for (var i = 0; i < base64.Length; i++)
                {
                    outputStream.Write(base64[i]);
                }

                outputStream.Flush();
                outputStream.Close();
                outputStream = null;
            }
        }

        private static void ExportPublicKey(RSACryptoServiceProvider csp)
        {
            var parameters = csp.ExportParameters(false);
            TextWriter outputStream = new StreamWriter("javni_kljuc.txt");

            using (var stream = new MemoryStream())
            {
                var writer = new BinaryWriter(stream);
                writer.Write((byte)0x30);
                using (var innerStream = new MemoryStream())
                {
                    var innerWriter = new BinaryWriter(innerStream);
                    innerWriter.Write((byte)0x30);
                    EncodeLength(innerWriter, 13);
                    innerWriter.Write((byte)0x06); // OBJECT IDENTIFIER
                    var rsaEncryptionOid = new byte[] { 0x2a, 0x86, 0x48, 0x86, 0xf7, 0x0d, 0x01, 0x01, 0x01 };
                    EncodeLength(innerWriter, rsaEncryptionOid.Length);
                    innerWriter.Write(rsaEncryptionOid);
                    innerWriter.Write((byte)0x05); // NULL
                    EncodeLength(innerWriter, 0);
                    innerWriter.Write((byte)0x03); // BIT STRING
                    using (var bitStringStream = new MemoryStream())
                    {
                        var bitStringWriter = new BinaryWriter(bitStringStream);
                        bitStringWriter.Write((byte)0x00); // # of unused bits
                        bitStringWriter.Write((byte)0x30); 
                        using (var paramsStream = new MemoryStream())
                        {
                            var paramsWriter = new BinaryWriter(paramsStream);
                            EncodeIntegerBigEndian(paramsWriter, parameters.Modulus);
                            EncodeIntegerBigEndian(paramsWriter, parameters.Exponent);
                            var paramsLength = (int)paramsStream.Length;
                            EncodeLength(bitStringWriter, paramsLength);
                            bitStringWriter.Write(paramsStream.GetBuffer(), 0, paramsLength);
                        }
                        var bitStringLength = (int)bitStringStream.Length;
                        EncodeLength(innerWriter, bitStringLength);
                        innerWriter.Write(bitStringStream.GetBuffer(), 0, bitStringLength);
                    }
                    var length = (int)innerStream.Length;
                    EncodeLength(writer, length);
                    writer.Write(innerStream.GetBuffer(), 0, length);
                }

                var base64 = Convert.ToBase64String(stream.GetBuffer(), 0, (int)stream.Length).ToCharArray();
                outputStream.Write(base64);
                outputStream.Flush();
                outputStream.Close();
                outputStream = null;
            }
        }

        private static void EncodeLength(BinaryWriter stream, int length)
        {
            if (length < 0) throw new ArgumentOutOfRangeException("length", "Length must be non-negative");
            if (length < 0x80)
            {
                stream.Write((byte)length);
            }
            else
            {
                var temp = length;
                var bytesRequired = 0;
                while (temp > 0)
                {
                    temp >>= 8;
                    bytesRequired++;
                }
                stream.Write((byte)(bytesRequired | 0x80));
                for (var i = bytesRequired - 1; i >= 0; i--)
                {
                    stream.Write((byte)(length >> (8 * i) & 0xff));
                }
            }
        }

        private static void EncodeIntegerBigEndian(BinaryWriter stream, byte[] value, bool forceUnsigned = true)
        {
            stream.Write((byte)0x02);
            var prefixZeros = 0;
            for (var i = 0; i < value.Length; i++)
            {
                if (value[i] != 0) break;
                prefixZeros++;
            }
            if (value.Length - prefixZeros == 0)
            {
                EncodeLength(stream, 1);
                stream.Write((byte)0);
            }
            else
            {
                if (forceUnsigned && value[prefixZeros] > 0x7f)
                {
                    EncodeLength(stream, value.Length - prefixZeros + 1);
                    stream.Write((byte)0);
                }
                else
                {
                    EncodeLength(stream, value.Length - prefixZeros);
                }
                for (var i = prefixZeros; i < value.Length; i++)
                {
                    stream.Write(value[i]);
                }
            }
        }

        public static byte[] CalculateDigitalSignature()
        {
            byte[] hash = SHA_256.ComputeSHA256HashBytes();
            byte[] signedHash = RSAalgorithm.SignHash(hash, CryptoConfig.MapNameToOID("SHA256"));
            _signedHash = signedHash;
            return signedHash;
        }

        public static bool VerifyDigitalSignature()
        {
            return RSAalgorithm.VerifyHash(SHA_256.ComputeSHA256HashBytes(), CryptoConfig.MapNameToOID("SHA256"), _signedHash);
        }
    }
}
