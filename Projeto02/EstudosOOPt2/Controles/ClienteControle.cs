using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; //Importando
using EstudosOOPt2.Entidades; //Importando

namespace EstudosOOPt2.Controles
{
    public class ClienteControle
    {
        //Método para exportar dados para XML
        public void ExportarDadosXml(Cliente c)
        {
            //criando o arquivo XML
            XmlWriter xml = XmlWriter.Create("c:\\temp\\cliente.xml");
            xml.WriteStartDocument();//Escrever o cabeçalho do XML

            xml.WriteStartElement("Cliente"); // <Cliente>

            xml.WriteStartElement("idCliente", c.IdCliente.ToString());
            xml.WriteStartElement("nome", c.Nome);
            xml.WriteStartElement("email", c.Email);

            xml.WriteStartElement("Endereco");

            xml.WriteStartElement("idEndereco", c.Endereco.IdEndereco.ToString());
            xml.WriteStartElement("logradouro", c.Endereco.Logradouro);
            xml.WriteStartElement("cidade", c.Endereco.Cidade);
            xml.WriteStartElement("estado", c.Endereco.Estado);
            xml.WriteStartElement("cep", c.Endereco.Cep);

            xml.WriteEndElement(); // </endereco>
            xml.WriteEndElement(); // </cliente>

            //fechando o arquivo
            xml.Close();
        }
    }
}
