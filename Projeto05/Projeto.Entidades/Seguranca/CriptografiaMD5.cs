using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entidades.Contratos;
using System.Security.Cryptography; //importando 

namespace Projeto.Entidades.Seguranca
{
    public class CriptografiaMD5 : ICriptografia
    {
        public string Encriptar(string valor)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //Convertendo o valor de string para bytes
            byte[] valorEmBytes = Encoding.UTF8.GetBytes(valor);

            //realizar a criptografia
            byte[] hash = md5.ComputeHash(valorEmBytes);

            //Convertendo o resultado da criptografia (hash)
            // de formato byte para formato string

            string resultado = string.Empty;

            //varrendo vetor de bytes
            foreach (var b in hash)
            {
                resultado += b.ToString("X2"); // X -> hexadecimal 
            }

            //retonando resultado 
            return resultado;
        }
    }
}
