using Entidades;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Datos
{
    public class RepositorioServicio
    {
        private readonly OracleConnection _conexion;
        public RepositorioServicio(BaseDatos conexion)
        {
            _conexion = conexion._conexion;
        }
        public int InsertarServicio(Servicio servicio)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "INSERT INTO servicio (IdServicio, NombreServicio, IdMecanico, Precio) " +
                                      "VALUES (:idServicio, :nombreServicio, :idMecanico, :precio)";

                command.Parameters.Add(new OracleParameter("idServicio", servicio.IdServicio));
                command.Parameters.Add(new OracleParameter("nombreServicio", servicio.NombreServicio));
                command.Parameters.Add(new OracleParameter("idMecanico", servicio.idMecanico));
                command.Parameters.Add(new OracleParameter("precio", servicio.Precio));

                var rows = command.ExecuteNonQuery();
                return rows;
            }
        }


        public int InsertarServicioBicicleta(Servicio servicio)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "INSERT INTO servicio (IdServicio, NombreServicio, IdMecanico, Precio) " +
                                      "VALUES (:idServicio, :nombreServicio, :idMecanico, :precio)";

                command.Parameters.Add(new OracleParameter("idServicio", servicio.IdServicio));
                command.Parameters.Add(new OracleParameter("nombreServicio", servicio.NombreServicio));
                command.Parameters.Add(new OracleParameter("idMecanico", servicio.idMecanico));
                command.Parameters.Add(new OracleParameter("precio", servicio.Precio));

                var rows = command.ExecuteNonQuery();
                return rows;
            }

        }

        public int InsertarServicioMotocicleta(Servicio servicio)
        {
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "INSERT INTO servicio (IdServicio, NombreServicio, IdMecanico, Precio) " +
                                      "VALUES (:idServicio, :nombreServicio, :idMecanico, :precio)";

                command.Parameters.Add(new OracleParameter("idServicio", servicio.IdServicio));
                command.Parameters.Add(new OracleParameter("nombreServicio", servicio.NombreServicio));
                command.Parameters.Add(new OracleParameter("idMecanico", servicio.idMecanico));
                command.Parameters.Add(new OracleParameter("precio", servicio.Precio));

                var rows = command.ExecuteNonQuery();
                return rows;
            }

        }

        public List<Servicio> Consultar()
        {
            OracleDataReader dataReader;
            List<Servicio> servicio = new List<Servicio>();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = "SELECT * FROM servicio";
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Servicio servicios = Mapear(dataReader);
                    servicio.Add(servicios);
                }
                dataReader.Close();
            }
            return servicio;

        }
        private Servicio Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Mecanico mecanico = new Mecanico
            {
                idMecanico = dataReader.GetString(2)
            };
            Servicio sesion = new Servicio
            {
                IdServicio = (dataReader.GetString(0)),
                NombreServicio = dataReader.GetString(1),
                idMecanico = mecanico,
                Precio = double.Parse(dataReader.GetString(3))
            };
            return sesion;
        }


        public List<Servicio> Buscar(string nombre)
        {
           
                OracleDataReader dataReader;
                List<Servicio> servicios = new List<Servicio>();
                using (var command = _conexion.CreateCommand())
                {
                    command.CommandText = $"SELECT s.IdServicio, s.NombreServicio, s.Precio, " +
                                           $"m.NombreMecanico || ' ' || m.ApellidoMecanico " +
                                           $"FROM mecanico m JOIN servicio s ON s.IdMecanico = m.IdMecanico " +
                                           $"WHERE idServicio = '{nombre}'";
         
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Servicio servicio = Mapear(dataReader);
                        servicios.Add(servicio);
                    }
                    dataReader.Close();
                }
                return servicios;
            
        }

        public  List<Servicio> BuscarBici(string nombre)
        {
            OracleDataReader dataReader;
            List<Servicio> servicios = new List<Servicio>();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = string.Format("SELECT s.IdServicio, s.NombreServicio, s.Precio, " +
                                                    "m.NombreMecanico || ' ' || m.ApellidoMecanico " +
                                                    "FROM mecanico m JOIN serviciobicicleta s ON s.IdMecanico = m.IdMecanico " +
                                                    "WHERE idServicio = '{0}'", nombre);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Servicio servicio = Mapear(dataReader);
                    servicios.Add(servicio);
                }
                dataReader.Close();
            }
            return servicios;

        }

        public  List<Servicio> BuscarMoto(string nombre)
        {
            OracleDataReader dataReader;
            List<Servicio> servicios = new List<Servicio>();
            using (var command = _conexion.CreateCommand())
            {
                command.CommandText = string.Format("SELECT s.IdServicio, s.NombreServicio, s.Precio, " +
                                                    "m.NombreMecanico || ' ' || m.ApellidoMecanico " +
                                                    "FROM mecanico m JOIN serviciomoto s ON s.IdMecanico = m.IdMecanico " +
                                                    "WHERE idServicio = '{0}'", nombre);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Servicio servicio = Mapear(dataReader);
                    servicios.Add(servicio);
                }
                dataReader.Close();
            }
            return servicios;

        }
    }
}
