namespace Entidades
{
    public class Cliente : Persona
    {
        public Cliente()
        {

        }

        public Cliente(string Cedula, string Nombre, string Apellidos, string Telefono) : base(Cedula, Nombre, Apellidos)
        {
            this.Telefono = Telefono;
        }

        public override string ToString()
        {
            return $"{Cedula};{Nombre};{Apellido};{Telefono}";
        }

        public string Telefono { get; set; }
    }
}