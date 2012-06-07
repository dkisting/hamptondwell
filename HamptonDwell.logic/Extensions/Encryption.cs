using System;
using System.IO;
using System.Security.Cryptography;


namespace EBS.HamptonDwell.Web.Logic.Extensions
{
    public static class Encryption
    {
        #region --Members--

        private static byte[] KEY_64 = { 11, 16, 93, 126, 98, 4, 218, 12 };
        private static byte[] IV_64 = { 251, 13, 246, 71, 106, 99, 167, 1 };

        //24 byte or 192 bit key and IV for TripleDES
        private static byte[] KEY_192 = { 142, 16, 93, 156, 78, 4, 218, 32, 15, 167, 44, 80, 26, 220, 155, 112, 2, 94, 11, 204, 119, 35, 184, 197 };
        private static byte[] IV_192 = { 55, 123, 146, 79, 36, 19, 167, 3, 42, 5, 62, 83, 184, 7, 209, 13, 145, 23, 200, 58, 174, 10, 121, 222 };

        #endregion

        #region --Public Methods--

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Encrypt(this string input)
        {
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();

            try
            {
                input = input.Replace(" ", "+");
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateEncryptor(KEY_64, IV_64), CryptoStreamMode.Write);
                StreamWriter sw = new StreamWriter(cs);

                sw.WriteLine(input);
                sw.Flush();
                cs.FlushFinalBlock();
                ms.Flush();

                return Convert.ToBase64String(ms.GetBuffer(), 0, Convert.ToInt32(ms.Length));
            }
            catch
            {
                return string.Empty;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Decrypt(this string input)
        {

            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();

            try
            {
                input = input.Replace(" ", "+");
                byte[] buffer = System.Convert.FromBase64String(input);
                MemoryStream ms = new MemoryStream(buffer);
                CryptoStream cs = new CryptoStream(ms, cryptoProvider.CreateDecryptor(KEY_64, IV_64), CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(cs);


                return sr.ReadToEnd().Replace("\n", string.Empty).Replace("\r", string.Empty);
            }
            catch
            {
                return string.Empty;
            }

        }


        #endregion
    }
}
