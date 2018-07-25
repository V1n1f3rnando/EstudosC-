using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades.Contratos;
using System.Security.Cryptography;

namespace Projeto.Entidades.Seguranca
{
    public class CriptografiaSHA1 : ICriptografia
    {
        public string Encriptar(string valor)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();

            //convertendo o valor de string para bytes
            byte[] valorEmBytes = Encoding.UTF8.GetBytes(valor);

            //realizar criptografia 
            byte[] hash = sha1.ComputeHash(valorEmBytes);

            //Convertendo o resultado da criptografia (hash)
            // de byte para string 

            string resultado = string.Empty;

            //varrendo o vetor de bytes
            foreach (var b in hash)
            {
                resultado += b.ToString("X2"); // X -> hexadecimal
            }

            //retornando
            return resultado;
        }
    }
}
