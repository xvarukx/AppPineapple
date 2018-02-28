using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete
    {
        string idPaquete, descripcion;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string IdPaquete
        {
            get
            {
                return idPaquete;
            }

            set
            {
                idPaquete = value;
            }
        }
    }
}
