using Datos;
using Entidades;

namespace Logica
{
    public class ImpServicio
    {
        private readonly BaseDatos conexion;
        RepositorioServicio repositorioServicio;
        public ImpServicio(string conecctionString)
        {
            conexion = new BaseDatos(conecctionString);

        }
        public int Insertar(Servicio servicio)
        {
            int resultado = repositorioServicio.InsertarServicio(servicio);
            return resultado;
        }

        public int InsertarServicioBici(Servicio servicio)
        {
            int resultado = repositorioServicio.InsertarServicioBicicleta(servicio);
            return resultado;
        }

        public int InsertarServicioMoto(Servicio servicio)
        {
            int resultado = repositorioServicio.InsertarServicioMotocicleta(servicio);
            return resultado;
        }
    }
}
