using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class DetallePedido
    {
        
        double area;
        string iProducto;
        string nombre;
        double costoH;
        double dosisH;
        double dosisTotal;
        double costoTotal;
        string unidad;

       
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

        public string IProducto
        {
            get
            {
                return iProducto;
            }

            set
            {
                iProducto = value;
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

        public double CostoH
        {
            get
            {
                return costoH;
            }

            set
            {
                costoH = value;
            }
        }

        public double DosisH
        {
            get
            {
                return dosisH;
            }

            set
            {
                dosisH = value;
            }
        }

        public double DosisTotal
        {
            get
            {
                return dosisTotal;
            }

            set
            {
                dosisTotal = value;
            }
        }

        public double CostoTotal
        {
            get
            {
                return costoTotal;
            }

            set
            {
                costoTotal = value;
            }
        }

        public string Unidad
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
    }
}
