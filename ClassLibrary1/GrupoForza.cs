using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class GrupoForza
    {
        private string idGrupo;
        private DateTime fecha;
        private string lote;
        private string paquete;
        private DateTime periodoCosecha;
        public string IdGrupo
        {
            get
            {
                return idGrupo;
            }

            set
            {
                idGrupo = value;
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

        public string Lote
        {
            get
            {
                return lote;
            }

            set
            {
                lote = value;
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

        public DateTime PeriodoCosecha
        {
            get
            {
                return periodoCosecha;
            }

            set
            {
                periodoCosecha = value;
            }
        }
    }

 
}
