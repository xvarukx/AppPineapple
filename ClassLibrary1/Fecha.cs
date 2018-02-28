using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fecha
    {
        static public List<Fecha> fechas;
        private DateTime fechaProgramada;
        private string lote;
        private string bloque;
        private string seccion;
        private string paquete;
        private string aplicacion;
        private int idAplicacion;
        private int posicion;
        private int semana;
        private double area;
        public bool Siguiente { get; set; }
        public bool Bloqueo { get; set; }
        public string grupoForza { get; set; }
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

        public string Bloque
        {
            get
            {
                return bloque;
            }

            set
            {
                bloque = value;
            }
        }

        public string Seccion
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

        public int Semana
        {
            get
            {
                return semana;
            }

            set
            {
                semana = value;
            }
        }
        static public List<Fecha> busquedaPorLote(string lote, DateTime fechaFinal, DateTime fechaInicio,int semana) {
            IEnumerable<Fecha> enu;
            List<Entidades.Fecha> fechasPorLote;

            if(semana != -1)
                enu = fechas.Where(f => f.Lote == lote && conf.weekNumber(f.FechaProgramada)==semana);
            else
                enu = fechas.Where(f => f.Lote == lote && f.FechaProgramada >= fechaInicio && f.FechaProgramada <= fechaFinal);

            fechasPorLote = enu.ToList();
            return fechasPorLote;
        }
        static public List<Fecha> busquedaPorLoteTodos(DateTime fechaFinal, DateTime fechaInicio, int semana)
        {
            IEnumerable<Fecha> enu;
            List<Entidades.Fecha> fechasPorLote = new List<Fecha>();
            try
            {
                if (semana != -1)
                    enu = fechas.Where(f => conf.weekNumber(f.FechaProgramada) == semana);
                else
                    enu = fechas.Where(f => f.FechaProgramada >= fechaInicio && f.FechaProgramada <= fechaFinal);

                fechasPorLote = enu.ToList();
            }
            catch { }
            return fechasPorLote;
        }
        static public List<Fecha> busquedaPorMes(DateTime fechaFinal, DateTime fechaInicio)
        {
            IEnumerable<Fecha> enu;
            List<Entidades.Fecha> fechasPorMes;
            enu = fechas.Where(f => f.FechaProgramada >= fechaInicio && f.FechaProgramada <= fechaFinal);
            fechasPorMes = enu.ToList();
            return fechasPorMes;
        }
        static public List<Fecha> busquedaPorSemana(int semana,int year)
        {

            IEnumerable<Fecha> enu;
            List<Entidades.Fecha> fechasPorMes;
            enu = fechas.Where(f => Entidades.conf.weekNumber(f.FechaProgramada) == semana && f.FechaProgramada.Year ==year);
            fechasPorMes = enu.ToList();
            return fechasPorMes;
        }
        static public List<Fecha> busquedaPorDia(DateTime fecha)
        {
            IEnumerable<Fecha> enu;
            List<Entidades.Fecha> fechasPorLote;
            enu = fechas.Where(f => f.FechaProgramada == fecha);
            fechasPorLote = enu.ToList();
            return fechasPorLote;
        }
    }
   
}
