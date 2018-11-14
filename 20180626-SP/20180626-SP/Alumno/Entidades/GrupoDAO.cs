using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class GrupoDAO
    {
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=correo-sp-2017;Integrated Security=True");
    }
}
