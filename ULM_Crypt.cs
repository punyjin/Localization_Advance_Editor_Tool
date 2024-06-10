using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Localization_Editor
{
    public static class ResourceData
    {
        private static readonly string UeHex = "Your Key";
        private static readonly string ivHex = "Your Key IV";
        public static readonly byte[] Unity = ConvertHexStringToByteArray(UeHex);
        public static readonly byte[] IV = ConvertHexStringToByteArray(ivHex);

        private static byte[] ConvertHexStringToByteArray(string hexString)
        {
            int length = hexString.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }
            return bytes;
        }

        public static string ImportFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null; // ถ้าผู้ใช้ยกเลิกการเลือกไฟล์
        }

        public static class GetDataInGame
        {
            public static byte[] EncryptStringToBytes_SEQ(string plainText, byte[] Key, byte[] IV)
            {
                if (plainText == null || plainText.Length <= 0)
                    throw new ArgumentNullException(nameof(plainText));
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException(nameof(Key));
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException(nameof(IV));

                byte[] encrypted;

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;
                    aesAlg.Padding = PaddingMode.PKCS7;

                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(plainText);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                }

                return encrypted;
            }

            public static string DecryptStringFromBytes_SEQ(byte[] cipherText, byte[] Key, byte[] IV)
            {
                if (cipherText == null || cipherText.Length <= 0)
                    throw new ArgumentNullException(nameof(cipherText));
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException(nameof(Key));
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException(nameof(IV));

                try
                {
                    using (Aes aesAlg = Aes.Create())
                    {
                        aesAlg.Key = Key;
                        aesAlg.IV = IV;
                        aesAlg.Padding = PaddingMode.PKCS7;

                        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                        using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                        {
                            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                            {
                                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                                {
                                    return srDecrypt.ReadToEnd();
                                }
                            }
                        }
                    }
                }
                catch (CryptographicException)
                {
                    // Show a message that the file is not encrypted and continue
                    //MessageBox.Show("ไฟล์ที่นำเข้าไม่ได้เข้ารหัส ", "แจ้งเตือน 101 : ไฟล์ดังกล่าวไม่ได้ถูกเข้ารหัสไว้ ");
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
