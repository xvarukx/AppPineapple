using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades 
{
    public class Empleado
    {
        private string celuda, nombre, apellido, apellido2, telefono, puesto;
        DateTime fechaContratacion;

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }

            set
            {
                apellido2 = value;
            }
        }

        public string Celuda
        {
            get
            {
                return celuda;
            }

            set
            {
                celuda = value;
            }
        }

        public DateTime FechaContratacion
        {
            get
            {
                return fechaContratacion;
            }

            set
            {
                fechaContratacion = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }
    }
}
