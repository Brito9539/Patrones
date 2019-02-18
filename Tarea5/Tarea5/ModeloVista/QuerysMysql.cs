using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Tarea5.ModeloVista
{
    class QuerysMysql
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection cn;

        public void Editar(string Nombre, string ApMaterno, string ApPaterno, int Matricula)
        {
            cn = Conexion.conectar();
            cmd.Connection = cn;


            cmd.CommandText = "UPDATE alumno SET Nombre = '" + Nombre + "',Ap_Materno ='" + ApMaterno + "',Ap_Paterno = '" + ApPaterno + "'  WHERE Matricula = '" + Matricula + "'";
            cmd.ExecuteNonQuery();
        }


        public void Agregar(string Nombre, string ApMaterno, string ApPaterno, int Matricula)
        {
            cn = Conexion.conectar();
            cmd.Connection = cn;
            cmd.CommandText = "INSERT INTO alumno(Matricula, Nombre, Ap_Materno, Ap_Paterno) VALUES('" + Matricula + "','" + Nombre + "','" + ApMaterno + "','" + ApPaterno + "')";
            cmd.ExecuteNonQuery();
        }

        public void Eliminar(int Matricula)
        {
            cn = Conexion.conectar();
            cmd.Connection = cn;
            cmd.CommandText = "DELETE FROM alumno WHERE Matricula='" + Matricula + "'";
            cmd.ExecuteNonQuery();
        }
    }
}
