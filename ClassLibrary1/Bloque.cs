using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bloque
    {
       
        private String idBloque, idLote, detalles;
        private int posX, posY;
        private int posicion, numPlantas;
        private int cantSecciones;
        public int posSeccionEliminada = -1;
        double area, areaUtilizada;

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

        public int CantSecciones
        {
            get
            {
                return cantSecciones;
            }

            set
            {
                cantSecciones = value;
            }
        }

        public int NumPlantas
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

        public string Detalles
        {
            get
            {
                return detalles;
            }

            set
            {
                detalles = value;
            }
        }

        public double AreaUtilizada
        {
            get
            {
                return areaUtilizada;
            }

            set
            {
                areaUtilizada = value;
            }
        }
    }
}

