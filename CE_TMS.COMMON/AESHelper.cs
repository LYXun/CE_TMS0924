using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CE_TMS.COMMON
{
    public class AESHelper
    {
        /// <summary>
        /// AES 解密
        /// </summary>
        /// <param name="str">明文（待解密）</param>
        /// <param name="key">密文</param>
        /// <returns></returns>
        public static string AesDecrypt(string str,string key)
        {
            if (string.IsNullOrEmpty(str)) return null;
            Byte[] toEncryptArray = Convert.FromBase64String(str);

            RijndaelManaged rm = new RijndaelManaged
            {
                Key = Encoding.UTF8.GetBytes(key),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform cryptoTransform = rm.CreateDecryptor();
            Byte[] resultArray = cryptoTransform.TransformFinalBlock(toEncryptArray,0,toEncryptArray.Length);
            return Encoding.UTF8.GetString(resultArray);
        }

    }
}
