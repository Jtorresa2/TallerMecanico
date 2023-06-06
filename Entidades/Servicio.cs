namespace Entidades
{
    public class Servicio
    {
        public string IdServicio { get; set; }
        public string CedulaCliente { get; set; }

        public string NombreServicio { get; set; }

        public double Precio { get; set; }

        public Mecanico idMecanico { get; set; }

        public override string ToString()
        {
            return $"{IdServicio};{NombreServicio};{idMecanico.idMecanico};{Precio}";
        }
    }
}