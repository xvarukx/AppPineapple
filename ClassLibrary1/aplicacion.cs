using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades 
{
    public class Aplicacion
    {
        private int idAplicacion;
        private string nombre, nombreComercial;
        private string tipo;

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

        public string NombreComercial
        {
            get
            {
                return nombreComercial;
            }

            set
            {
                nombreComercial = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }
    }
}
