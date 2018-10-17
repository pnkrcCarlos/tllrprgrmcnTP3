using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace EJ4
{
    public class EncriptadorAES : Encriptador
    {
        private static readonly byte[] KEY = new byte[] { 123, 217, 19, 11, 24, 26, 85, 45, 114, 184, 27, 162, 37, 112, 222, 209, 241, 24, 175, 144, 173, 53, 196, 29, 24, 26, 17, 218, 131, 236, 53, 209 };
        private static readonly byte[] IV = new byte[] { 146, 64, 191, 111, 23, 3, 113, 119, 231, 121, 221, 112, 79, 32, 114, 156 };

        /// <summary>
        /// Crea una nueva instancia de EncriptadorAES.
        /// </summary>
        public EncriptadorAES() : base("AES") { }

        /// <summary>
        /// Retorna la cadena que se obtiene de encriptar la cadena pasada como parámetro usando AES.
        /// </summary>
        /// <param name="pString">Cadena a encriptar.</param>
        /// <returns>String.</returns>
        public override String Encriptar(String pString)
        {
            return Convert.ToBase64String(EncriptarStringABytes_Aes(pString));
        }

        /// <summary>
        /// Retorna la cadena que se obtiene de desencriptar la cadena pasada como parámetro usando AES.
        /// </summary>
        /// <param name="pString">Cadena a desencriptar.</param>
        /// <returns>String.</returns>
        public override String Desencriptar(String pString)
        {
            return DesencriptarStringDeBytes_Aes(Convert.FromBase64String(pString));
        }

        // encriptar y desencriptar adaptados de https://docs.microsoft.com/es-es/dotnet/api/system.security.cryptography.aes?redirectedfrom=MSDN&view=netframework-4.7.2

        private static byte[] EncriptarStringABytes_Aes(string pTextoPlano)
        {
            // Revisar parámetro
            if (pTextoPlano == null || pTextoPlano.Length <= 0)
                throw new ArgumentNullException("pTextoPlano");

            byte[] encriptado;

            // Crear un objeto Aes con la clave y vector de inicializacion especificados
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = KEY;
                aesAlg.IV = IV;

                // Crear un encriptador para realizar la transformación del stream
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Crear streams usados en la encriptacion
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //escribir datos en el stream
                            swEncrypt.Write(pTextoPlano);
                        }
                        encriptado = msEncrypt.ToArray();
                    }
                }
            }

            // devolver los bytes encriptados del stream de memoria
            return encriptado;
        }

        private static string DesencriptarStringDeBytes_Aes(byte[] pEncriptado)
        {
            // Revisar parámetro
            if (pEncriptado == null || pEncriptado.Length <= 0)
                throw new ArgumentNullException("pEncriptado");

            // Declarar cadena para almacenar texto desencriptado
            string textoPlano = null;

            // Crear un objeto Aes con la clave y vector de inicialización especificados
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = KEY;
                aesAlg.IV = IV;

                // Crear un desencriptador para realizar la transformación del stream
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Crear los streams usados para desencriptación
                using (MemoryStream msDecrypt = new MemoryStream(pEncriptado))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Leer los bytes desencriptados desde el stream de desencriptación y ponerlos en una cadena
                            textoPlano = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return textoPlano;
        }
    }
}
