using Entidades;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioCliente
    {
        private readonly OracleConnection _conexion;
        public RepositorioCliente(BaseDatos conexion)
        {
            _conexion = conexion._conexion;
        }
      
            public int InsertarCliente(Cliente cliente)
            {
                using (var command = _conexion.CreateCommand())
                {
                    command.CommandText = "INSERT INTO cliente (Cedula, Nombre, Apellido, Telefono) " +
                                          "VALUES (:cedula, :nombre, :apellido, :telefono)";

                    command.Parameters.Add(new OracleParameter("cedula", cliente.Cedula));
                    command.Parameters.Add(new OracleParameter("nombre", cliente.Nombre));
                    command.Parameters.Add(new OracleParameter("apellido", cliente.Apellido));
                    command.Parameters.Add(new OracleParameter("telefono", cliente.Telefono));

                    var rows = command.ExecuteNonQuery();
                    return rows;
                }
            }


        public int InsertarClienteBicicleta(Cliente cliente)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "INSERT INTO clientebicicleta (Cedula, Nombre, Apellido, Telefono) " +
                                      "VALUES (:cedula, :nombre, :apellido, :telefono)";

                command.Parameters.Add(new OracleParameter("cedula", cliente.Cedula));
                command.Parameters.Add(new OracleParameter("nombre", cliente.Nombre));
                command.Parameters.Add(new OracleParameter("apellido", cliente.Apellido));
                command.Parameters.Add(new OracleParameter("telefono", cliente.Telefono));

                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }

        public int InsertarClienteMotocicleta(Cliente cliente)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "INSERT INTO clientemoto (Cedula, Nombre, Apellido, Telefono) " +
                                      "VALUES (:cedula, :nombre, :apellido, :telefono)";

                command.Parameters.Add(new OracleParameter("cedula", cliente.Cedula));
                command.Parameters.Add(new OracleParameter("nombre", cliente.Nombre));
                command.Parameters.Add(new OracleParameter("apellido", cliente.Apellido));
                command.Parameters.Add(new OracleParameter("telefono", cliente.Telefono));

                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }
    }
}
