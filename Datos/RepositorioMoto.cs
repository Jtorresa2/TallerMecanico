using Entidades;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioMoto
    {
        private readonly OracleConnection _conexion;
        public RepositorioMoto(BaseDatos conexion)
        {
            _conexion = conexion._conexion;
        }
       public int InsertarMotocicleta(Moto moto)
{
    using (var command = _conexion.CreateCommand())
    {
        command.CommandText = "INSERT INTO moto (idServicio, Propietario, Marca, Color, Placa) " +
                              "VALUES (:idServicio, :propietario, :marca, :color, :placa)";

        command.Parameters.Add(new OracleParameter("idServicio", moto.idSer));
        command.Parameters.Add(new OracleParameter("propietario", moto.Propietario));
        command.Parameters.Add(new OracleParameter("marca", moto.Marca));
        command.Parameters.Add(new OracleParameter("color", moto.Color));
        command.Parameters.Add(new OracleParameter("placa", moto.Placa));

        var rows = command.ExecuteNonQuery();
        return rows;
    }
}

    }
}
