using Datos;
using Entidades;

namespace Logica
{
    public class ImpMoto
    {
        private readonly BaseDatos conexion;
        RepositorioMoto repositorioMoto;
        public ImpMoto(string conecctionString)
        {
            conexion = new BaseDatos(conecctionString);

        }

        public int InsertarMoto(Moto moto)
        {
            int resultado = repositorioMoto.InsertarMotocicleta(moto);
            return resultado;
        }
    }
}
