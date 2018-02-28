using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades 
{
    public class SprayBoom
    {
        private string idSprayBoom, boquilla, km, marcha, metodo;
        private Double capacidad, psi, rpm;

        public string IdSprayBoom
        {
            get
            {
                return idSprayBoom;
            }

            set
            {
                idSprayBoom = value;
            }
        }

        public string Boquilla
        {
            get
            {
                return boquilla;
            }

            set
            {
                boquilla = value;
            }
        }

        public string Km
        {
            get
            {
                return km;
            }

            set
            {
                km = value;
            }
        }

        public string Marcha
        {
            get
            {
                return marcha;
            }

            set
            {
                marcha = value;
            }
        }

        public string Metodo
        {
            get
            {
                return metodo;
            }

            set
            {
                metodo = value;
            }
        }

        public double Capacidad
        {
            get
            {
                return capacidad;
            }

            set
            {
                capacidad = value;
            }
        }

        public double Psi
        {
            get
            {
                return psi;
            }

            set
            {
                psi = value;
            }
        }

        public double Rpm
        {
            get
            {
                return rpm;
            }

            set
            {
                rpm = value;
            }
        }
    }
}
