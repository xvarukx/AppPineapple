using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades 
{
    public class Producto
    {
        private string idProducto, nombre, ingredienteActivo, unidad, tipo;
        private double cantidad, maximo, minimo, costo;
        private int dias;
        private string numRegistro;
        private int periodoReingreso;
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

        public string IngredienteActivo
        {
            get
            {
                return ingredienteActivo;
            }

            set
            {
                ingredienteActivo = value;
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

        public double Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public double Maximo
        {
            get
            {
                return maximo;
            }

            set
            {
                maximo = value;
            }
        }

        public double Minimo
        {
            get
            {
                return minimo;
            }

            set
            {
                minimo = value;
            }
        }

        public double Costo
        {
            get
            {
                return costo;
            }

            set
            {
                costo = value;
            }
        }

        public int Dias
        {
            get
            {
                return dias;
            }

            set
            {
                dias = value;
            }
        }

        public string NumRegistro
        {
            get
            {
                return numRegistro;
            }

            set
            {
                numRegistro = value;
            }
        }

        public int PeriodoReingreso
        {
            get
            {
                return periodoReingreso;
            }

            set
            {
                periodoReingreso = value;
            }
        }
    }
}
