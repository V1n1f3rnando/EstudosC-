using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Importando 
using System.Configuration;

namespace EstudosPOOPt1
{
    public class Conexao 
    {

        
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader dr;
        protected SqlTransaction tr;

        //Método para abrir a conexão
        protected void AbrirConexao()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString);
            con.Open();
        }

        protected void FecharConexao()
        {
            con.Close();
        }
    }
}
