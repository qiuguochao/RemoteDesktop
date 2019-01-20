/******************
*修改时间：2019/1/19 18:26:32
*修改人:qiuguochao
******************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace RemoteDesktop.Helper
{
    public class EncryptDecryptHelper
    {
        private const string ENCRYPT_DECRYPT_KEY = "***39102F52D2FC8123E9E364549768B170.***.D2FC8055E9E36454.***"; // 密钥

        #region 加密
        /// <summary>
        /// 加密文本
        /// </summary>
        /// <param name="encryptText">待加密字符串</param>
        /// <returns></returns>
        public static string DESEncrypt(string encryptText)
        {
            return DESEncrypt(encryptText, ENCRYPT_DECRYPT_KEY);
        }
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="encryptData">待加密字符串</param> 
        /// <param name="encryptKey">加密密钥</param> 
        /// <returns></returns> 
        public static string DESEncrypt(string encryptData, string encryptKey)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray;
                inputByteArray = Encoding.Default.GetBytes(encryptData);
                des.Key = ASCIIEncoding.ASCII.GetBytes(MD5(encryptKey, true).Substring(0, 8));
                des.IV = ASCIIEncoding.ASCII.GetBytes(MD5(encryptKey, true).Substring(0, 8));
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                StringBuilder ret = new StringBuilder();
                foreach (byte b in ms.ToArray())
                {
                    ret.AppendFormat("{0:X2}", b);
                }
                return ret.ToString();
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region 解密
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="decryptText">待解密字符串</param>
        /// <returns></returns>
        public static string DESDecrypt(string decryptText)
        {
            return DESDecrypt(decryptText, ENCRYPT_DECRYPT_KEY);
        }
        /// <summary> 
        /// DES解密数据 
        /// </summary> 
        /// <param name="decryptData">待解密字符串</param> 
        /// <param name="decryptKey">解密密钥</param> 
        /// <returns></returns> 
        public static string DESDecrypt(string decryptData, string decryptKey)
        {
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                int len;
                len = decryptData.Length / 2;
                byte[] inputByteArray = new byte[len];
                int x, i;
                for (x = 0; x < len; x++)
                {
                    i = Convert.ToInt32(decryptData.Substring(x * 2, 2), 16);
                    inputByteArray[x] = (byte)i;
                }
                des.Key = ASCIIEncoding.ASCII.GetBytes(MD5(decryptKey, true).Substring(0, 8));
                des.IV = ASCIIEncoding.ASCII.GetBytes(MD5(decryptKey, true).Substring(0, 8));
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                return Encoding.Default.GetString(ms.ToArray());
            }
            catch
            {
                return null;
            }
        }

        #endregion
        #region MD5
        /// <summary>
        /// MD5函数
        /// </summary>
        /// <param name="strData">原始字符串</param>
        /// <param name="isUpper">是否大写形式</param>
        /// <returns>MD5结果</returns>
        public static string MD5(string strData, bool isUpper)
        {
            byte[] byteData = Encoding.UTF8.GetBytes(strData);
            byteData = new MD5CryptoServiceProvider().ComputeHash(byteData);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < byteData.Length; i++)
            {
                result.Append(byteData[i].ToString("x2"));
            }
            if (isUpper)
            {
                return result.ToString().ToUpper();
            }
            else
            {
                return result.ToString();
            }
        }
        #endregion
    }
}
