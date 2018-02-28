using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pedido
    {
     
        Entidades.Seccion seccion;
        int idAplicacion;
        string etapa;
        public Seccion Seccion
        {
            get
            {
                return seccion;
            }

            set
            {
                seccion = value;
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

        public string Etapa
        {
            get
            {
                return etapa;
            }

            set
            {
                etapa = value;
            }
        }
    }
}
