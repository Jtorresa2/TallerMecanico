using Entidades;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioAutomovil 
    {
        private readonly OracleConnection _conexion;
        public RepositorioAutomovil(BaseDatos conexion)
        {
            _conexion = conexion._conexion;
        }
        public int InsertarVehiculo(Auto auto)
        {
           using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "INSERT INTO auto (idServicio, Propietario, Marca, Color, Placa) " +
                              "VALUES (:idServicio, :propietario, :marca, :color, :placa)";

                command.Parameters.Add(new OracleParameter("idServicio", auto.idSer));
                command.Parameters.Add(new OracleParameter("propietario", auto.Propietario));
                command.Parameters.Add(new OracleParameter("marca", auto.Marca));
                command.Parameters.Add(new OracleParameter("color", auto.Color));
                command.Parameters.Add(new OracleParameter("placa", auto.Placa));
                var rows = command.ExecuteNonQuery();
                return rows;
                    
            }
        }
        public List<Auto> Consultar()
        {
            OracleDataReader dataReader;
            List<Auto> autos = new List<Auto>();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "SELECT c.cedula, c.nombre, c.apellido, s.idservicio, s.nombreservicio, a.color, a.placa, a.marca FROM cliente c JOIN servicio s ON c.cedula = s.cedulacliente  JOIN auto a ON c.cedula = a.propietario;";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Auto auto = Mapear(dataReader);
                        autos.Add(auto);
                    }
                }
            }
            return autos;
        }
        private Auto Mapear(OracleDataReader dataReader)
        {
            Servicio servicio = new Servicio
            {
                IdServicio = dataReader.GetString(4)
            };
            Auto auto = new Auto
            {
                Propietario = dataReader.GetString(1),
                Marca = dataReader.GetString(2),
                Color  = dataReader.GetString(3),
                idSer = servicio,
                Placa = dataReader.GetString(5)
            };
            return auto;
        }
    }
}
