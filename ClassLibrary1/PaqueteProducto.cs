using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaqueteProducto
    {
        private int idAplicacion;
        private double dosis;
        private string unidad, idProducto,idEtapa;

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

        public double Dosis
        {
            get
            {
                return dosis;
            }

            set
            {
                dosis = value;
            }
        }

        public string Unidad
        {
            get
            {
                return Unidad1;
            }

            set
            {
                Unidad1 = value;
            }
        }

        public string IdProducto
        {
            get
            {
                return idProducto;
            }

            set
            {
                idProducto = value;
            }
        }

        public string Unidad1
        {
            get
            {
                return unidad;
            }

            set
            {
                unidad = value;
            }
        }

        public string IdEtapa
        {
            get
            {
                return idEtapa;
            }

            set
            {
                idEtapa = value;
            }
        }
    }
}
