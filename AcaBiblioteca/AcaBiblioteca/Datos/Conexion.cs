using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace AcaBiblioteca.Datos
{
    public class Conexion
    {

        private string cadenaConexion =
            "server= PEDRONEITOR; Database= AcaBiblioteca; Integrated Security=True; TrustServerCertificate=true;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
