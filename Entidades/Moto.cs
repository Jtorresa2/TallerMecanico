namespace Entidades
{
    public class Moto : Vehiculo
    {

        public override string ToString()
        {
            return $"{idSer};{Propietario};{Marca};{Color};{Placa}";
        }

        public string Placa { get; set; }
    }
}