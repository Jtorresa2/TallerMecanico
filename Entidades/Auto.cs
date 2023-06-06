namespace Entidades
{
    public class Auto : Vehiculo
    {
        public string Placa { get; set; }

        //public Auto(Servicio idServicio, string Propietario, string Marca, string Color, string Placa) : base(idServicio, Propietario, Marca, Color)
        //{
        //    this.Placa = Placa;
        //}

        public override string ToString()
        {
            return $"{idSer.IdServicio};{Propietario};{Marca};{Color};{Placa}";
        }

        
    }
}