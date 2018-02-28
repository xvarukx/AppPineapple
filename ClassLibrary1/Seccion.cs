using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Seccion
    {

       
        private string idSeccion, idLote, idBloque, detalle;
        private Double area, numPlantas;
        private int posicion, posX, posY;
        private DateTime fechaSiembra, fechaProgramada, fechaInicial;
        private string grupoForza;
        private string tipoSemilla;
        private string pesoSemilla;
        private string paquete;
        private string aplicacion;
        private bool bloqueo;
        public string IdSeccion
        {
            get
            {
                return idSeccion;
            }

            set
            {
                idSeccion = value;
            }
        }

        public string IdLote
        {
            get
            {
                return idLote;
            }

            set
            {
                idLote = value;
            }
        }

        public string IdBloque
        {
            get
            {
                return idBloque;
            }

            set
            {
                idBloque = value;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public double NumPlantas
        {
            get
            {
                return numPlantas;
            }

            set
            {
                numPlantas = value;
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

        public int PosX
        {
            get
            {
                return posX;
            }

            set
            {
                posX = value;
            }
        }

        public int PosY
        {
            get
            {
                return posY;
            }

            set
            {
                posY = value;
            }
        }

        public DateTime FechaSiembra
        {
            get
            {
                return fechaSiembra;
            }

            set
            {
                fechaSiembra = value;
            }
        }

        public DateTime FechaProgramada
        {
            get
            {
                return fechaProgramada;
            }

            set
            {
                fechaProgramada = value;
            }
        }

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        public string GrupoForza
        {
            get
            {
                return grupoForza;
            }

            set
            {
                grupoForza = value;
            }
        }

        public string TipoSemilla
        {
            get
            {
                return tipoSemilla;
            }

            set
            {
                tipoSemilla = value;
            }
        }

        public string PesoSemilla
        {
            get
            {
                return pesoSemilla;
            }

            set
            {
                pesoSemilla = value;
            }
        }

        public string Paquete
        {
            get
            {
                return paquete;
            }

            set
            {
                paquete = value;
            }
        }

        public DateTime FechaInicial
        {
            get
            {
                return fechaInicial;
            }

            set
            {
                fechaInicial = value;
            }
        }

        public bool Bloqueo
        {
            get
            {
                return bloqueo;
            }

            set
            {
                bloqueo = value;
            }
        }

        public string Aplicacion
        {
            get
            {
                return aplicacion;
            }

            set
            {
                aplicacion = value;
            }
        }
    }
}
