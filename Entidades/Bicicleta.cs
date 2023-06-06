namespace Entidades
{
    public class Bicicleta : Vehiculo
    {

        public override string ToString()
        {
            return $"{idSer};{Propietario};{Marca};{Color}";
        }
    }
}