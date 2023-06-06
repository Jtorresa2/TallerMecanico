using Datos;
using Entidades;
using System.Collections.Generic;

namespace Logica
{
    public class ImpAutomovil
    {
        private readonly BaseDatos conexion;
        RepositorioAutomovil repositorioAutomovil;
        public ImpAutomovil(string conecctionString)
        {
            conexion = new BaseDatos(conecctionString);
            repositorioAutomovil = new RepositorioAutomovil(conexion);
        }
        public int Insertar(Auto auto)
        {
            int resultado = repositorioAutomovil.InsertarVehiculo(auto);
            return resultado;
        }

        public Responce Consultar()
        {
            Responce responceAuto = new Responce();
            try
            {
                conexion.Open();
                responceAuto.autosResponce = repositorioAutomovil.Consultar();
                conexion.Close();
                if (responceAuto.autosResponce.Count > 0) responceAuto.Message = "Consulta Exitosa";
                else responceAuto.Message = "Database Empty";
                responceAuto.Error = false;
                return responceAuto;
            }
            catch (System.Exception e)
            {
                responceAuto.Error = true;
                responceAuto.Message = $"Application Error: {e.Message}";
                return responceAuto;

            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
