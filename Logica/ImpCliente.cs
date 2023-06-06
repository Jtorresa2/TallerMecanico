using Datos;
using Entidades;
using System;

namespace Logica
{
    public class ImpCliente
    {
        private readonly BaseDatos conexion;
        RepositorioCliente repositorioCliente;
        public ImpCliente(string conecctionString)
        {
            conexion = new BaseDatos(conecctionString);
            repositorioCliente = new RepositorioCliente(conexion);
        }
        public string Insertar(Cliente cliente)
        {
            try
            {
                conexion.Open();
                repositorioCliente.InsertarCliente(cliente);
                return"Guardado exitosamente";
            }
            catch (Exception e)
            {
                return $"Aplication Error: {e.Message}";
            }
            finally { 
                
                conexion.Close(); 
            
            }
            
        }

        public int InsertarClienteBici(Cliente cliente)
        {
            int resultado = repositorioCliente.InsertarClienteBicicleta(cliente);
            return resultado;
        }

        public int InsertarClienteMoto(Cliente cliente)
        {
            int resultado = repositorioCliente.InsertarClienteMotocicleta(cliente);
            return resultado;
        }
    }
}
