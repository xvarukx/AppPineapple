using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lote
    {
        private string idLote;
        private int ciclo;
        private double area, areaUtilizada, cantPlantas;
        private Image imagen;
        private DateTime fecha;
        private double anchoMapa;
        private double altoMapa;
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

        public int Ciclo
        {
            get
            {
                return ciclo;
            }

            set
            {
                ciclo = value;
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

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public Image Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
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

        public double CantPlantas
        {
            get
            {
                return cantPlantas;
            }

            set
            {
                cantPlantas = value;
            }
        }

        public double AnchoMapa
        {
            get
            {
                return anchoMapa;
            }

            set
            {
                anchoMapa = value;
            }
        }

        public double AltoMapa
        {
            get
            {
                return altoMapa;
            }

            set
            {
                altoMapa = value;
            }
        }
    }
}
