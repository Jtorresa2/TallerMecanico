using Entidades;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioBicicleta
    {
        private readonly OracleConnection _conexion;
        public RepositorioBicicleta(BaseDatos conexion)
        {
            _conexion = conexion._conexion;
        }
        public int InsertarBicicleta(Bicicleta bici)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "INSERT INTO auto (idServicio, Propietario, Marca, Color) " +
                              "VALUES (:idServicio, :propietario, :marca, :color)";

                command.Parameters.Add(new OracleParameter("idServicio", bici.idSer));
                command.Parameters.Add(new OracleParameter("propietario", bici.Propietario));
                command.Parameters.Add(new OracleParameter("marca", bici.Marca));
                command.Parameters.Add(new OracleParameter("color", bici.Color));
         
                var rows = command.ExecuteNonQuery();
                return rows;

            }
        }
    }
}
