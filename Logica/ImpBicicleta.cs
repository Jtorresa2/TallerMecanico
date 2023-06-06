using Datos;
using Entidades;

namespace Logica
{
    public class ImpBicicleta
    {
        private readonly BaseDatos conexion;
        RepositorioBicicleta repositorioBici;
        public ImpBicicleta(string conecctionString)
        {
            conexion = new BaseDatos(conecctionString);

        }

        public int Insertar(Bicicleta bicicleta)
        {
            int resultado = repositorioBici.InsertarBicicleta(bicicleta);
            return resultado;
        }
    }
}
