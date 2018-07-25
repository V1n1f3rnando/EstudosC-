using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entidades.Contratos
{
    public interface ICriptografia
    {
        //Método abstrato
        string Encriptar(string valor);
    }
}
