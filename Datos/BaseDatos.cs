using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class BaseDatos
    {
            internal OracleConnection _conexion;

            public BaseDatos(string connectionString)
            {
                _conexion = new OracleConnection(connectionString);
            }

            public void Open()
            {
                _conexion.Open();
            }

            public void Close()
            {
                _conexion.Close();
            }
        
    }
}
