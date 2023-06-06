namespace Entidades
{
    public class Persona
    {
        public Persona()
        {

        }

        public Persona(string Cedula, string Nombre, string Apellido)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }

        public override string ToString()
        {
            return $"{Cedula};{Nombre};{Apellido}";
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cedula { get; set; }
    }
}