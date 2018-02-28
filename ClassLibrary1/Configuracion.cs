using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Configuracion
    {
        int frecuenciaCorreos;

        public int FrecuenciaCorreos
        {
            get
            {
                return frecuenciaCorreos;
            }

            set
            {
                frecuenciaCorreos = value;
            }
        }
    }
}
