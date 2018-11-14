using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class DAO : IArchivo<Votacion>
    {
        public Votacion Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(string ruta, Votacion v)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=votacion-sp-2018;Integrated Security=True");
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = string.Format("INSERT INTO dbo.Votaciones (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) VALUES ('{0}',{1},{2},{3},'Greco Gonzalo')", v.NombreLey, v.Afirmativo, v.Negativo, v.Abstencion);
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                return true;
            }
            catch(Exception exc)
            {
                throw exc;
            }
        }
    }
}
