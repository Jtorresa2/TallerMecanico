namespace Entidades
{
    public class Vehiculo
    {
        public string Propietario { get; set; }

        public string Marca { get; set; }

        public string Color { get; set; }

        public Servicio idSer { get; set; }

        public override string ToString()
        {
            return $"{idSer.IdServicio};{Propietario};{Marca};{Color}";
        }

        

    }
}