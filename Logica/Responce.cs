using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Responce
    {
        public List<Auto> autosResponce;
        public Auto auto;

        public string Message;
        public bool Error;

        public Responce()
        {
        }

        public Responce (List<Auto> autosResponce)
        {
            this.autosResponce = autosResponce;
            Error = false;
        }
        public Responce(Auto auto)
        {
            this.auto = auto;
            Error = false;
        }
        public Responce(string mensaje)
        {
            Error = true;
            Message = mensaje;
        }

    }
}
