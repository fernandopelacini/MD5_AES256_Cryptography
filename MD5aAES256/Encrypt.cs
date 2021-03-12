using System;
using System.Text;
using System.Security.Cryptography;

namespace MD5aAES256
{
       public class Encrypt
    {
        AesCryptoServiceProvider aesProvider = new AesCryptoServiceProvider();

        private static readonly byte[] Salt = new byte[] { 10, 20, 30, 40, 50, 60, 70, 80 };
        private  string keyDeEncriptacion = "%ü&/@#$A?¡!°FHNX(O;MN:Z_{}[*¨[]$#!()/%/THO(yield()YH()S%";
        public Encrypt()
        {
            
            aesProvider.BlockSize = 128;
            aesProvider.KeySize = 256;
            aesProvider.Mode = CipherMode.CBC;

            byte[][] keys = GetHashKeys();
            aesProvider.IV = keys[1];
            aesProvider.Key = keys[0];
            aesProvider.Padding = PaddingMode.PKCS7;
        }

        private byte[][] GetHashKeys()
        {
            byte[][] result = new byte[2][];
            Encoding enc = Encoding.UTF8;

            SHA256 sha2 = new SHA256CryptoServiceProvider();

            byte[] rawKey = enc.GetBytes(keyDeEncriptacion);
            byte[] rawIV = enc.GetBytes(keyDeEncriptacion);

            byte[] hashKey = sha2.ComputeHash(rawKey);
            byte[] hashIV = sha2.ComputeHash(rawIV);

            Array.Resize(ref hashIV, 16);

            result[0] = hashKey;
            result[1] = hashIV;

            return result;
        }


        public string Encriptar(string cadenaAencriptar)
        {
            ICryptoTransform conversor = aesProvider.CreateEncryptor();
            byte[] arrayCadenaEncriptada = conversor.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(cadenaAencriptar), 0, cadenaAencriptar.Length);
            string cadenaEncriptada = Convert.ToBase64String(arrayCadenaEncriptada);
            return cadenaEncriptada;
        }

        public string Desencriptar(string cadenaEncriptada)
        {
            ICryptoTransform conversor = aesProvider.CreateDecryptor();
            byte[] arrayEncriptado = Convert.FromBase64String(cadenaEncriptada);
            byte[] arrayCadenaDesencriptada = conversor.TransformFinalBlock(arrayEncriptado,0,arrayEncriptado.Length);
            string cadenaDesencriptada = ASCIIEncoding.ASCII.GetString(arrayCadenaDesencriptada);
            return cadenaDesencriptada;
        }

    }
}
