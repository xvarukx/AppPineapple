using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DetalleAplicacion
    {
        int tiempo, posicion, idAplicacion;
        string idPaquete,nombreAplicacion;

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

        public int IdAplicacion
        {
            get
            {
                return idAplicacion;
            }

            set
            {
                idAplicacion = value;
            }
        }

        public int Tiempo
        {
            get
            {
                return tiempo;
            }

            set
            {
                tiempo = value;
            }
        }

        public int Posicion
        {
            get
            {
                return posicion;
            }

            set
            {
                posicion = value;
            }
        }

        public string NombreAplicacion
        {
            get
            {
                return nombreAplicacion;
            }

            set
            {
                nombreAplicacion = value;
            }
        }
    }
}
