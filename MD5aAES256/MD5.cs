using System;
using System.Security.Cryptography;
using System.Text;


namespace MD5aAES256
{
  public  class MD5
    {
        String strClave = "%ü&/@#$A?¡!°FHNX(O;MN:Z_{}[*¨[]$#!()/%/THO(yield()YH()S%";
        TripleDESCryptoServiceProvider des = new TripleDESCryptoServiceProvider(); //Algorithmo TripleDES
        MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider(); //objeto md5

        public string EncriptarMD5(string strPass)
        {
            try
            {
                string strEncriptada;
                des.Key = hashmd5.ComputeHash((new UnicodeEncoding()).GetBytes(strClave));
                des.Mode = CipherMode.ECB;
                ICryptoTransform encrypt = des.CreateEncryptor();
                Byte[] buff = UnicodeEncoding.ASCII.GetBytes(strPass);
                strEncriptada = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length));

                return strEncriptada;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public string DesencriptarMD5(string strPass)
        {
            try
            {
                string strDesencriptada;

                des.Key = hashmd5.ComputeHash((new UnicodeEncoding()).GetBytes(strClave));
                des.Mode = CipherMode.ECB;
                ICryptoTransform desencrypta = des.CreateDecryptor();
                Byte[] buff = Convert.FromBase64String(strPass);
                strDesencriptada = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length));

                return strDesencriptada;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

    }
}
