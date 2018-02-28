using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CedulaIdentidad
    {


        private int idCedula;



        private double costoTotal;
        private DateTime fechaProgramada;
        private DateTime fechaReal;
        private DateTime horaInicio;
        private DateTime horaFinal;
        private string numTractor;
        private string numSpray;
        private string cultivo;
        private string clima;
        private string chofer;
        private bool justProgramacion;
        private bool justMuestreo;
        private List<DetalleProductos> productos;
        private string nombreAplicacion;
        private int posicion;
        private List<DetalleSecciones> secciones;
        private string grupoForza;
        private double ltsRequeridos;
        private double totalLtsRequeridos;
        private double totalBoonesRequeridos;
        private DateTime fechaCreacion;
        private double areaTotal;
        private string lote;
        private string etapa;
        private int idAplicacion;
        private int periodoReingreso;
        private int InterCosecha;
        private DateTime periodoCosecha;

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

        



        public DateTime FechaReal
        {
            get
            {
                return fechaReal;
            }

            set
            {
                fechaReal = value;
            }
        }

        public DateTime HoraInicio
        {
            get
            {
                return horaInicio;
            }

            set
            {
                horaInicio = value;
            }
        }

        public DateTime HoraFinal
        {
            get
            {
                return horaFinal;
            }

            set
            {
                horaFinal = value;
            }
        }

        public string NumTractor
        {
            get
            {
                return numTractor;
            }

            set
            {
                numTractor = value;
            }
        }

        public string NumSpray
        {
            get
            {
                return numSpray;
            }

            set
            {
                numSpray = value;
            }
        }

        public string Cultivo
        {
            get
            {
                return cultivo;
            }

            set
            {
                cultivo = value;
            }
        }

        public string Clima
        {
            get
            {
                return clima;
            }

            set
            {
                clima = value;
            }
        }

        public string Chofer
        {
            get
            {
                return chofer;
            }

            set
            {
                chofer = value;
            }
        }

        public bool JustProgramacion
        {
            get
            {
                return justProgramacion;
            }

            set
            {
                justProgramacion = value;
            }
        }

        public bool JustMuestreo
        {
            get
            {
                return justMuestreo;
            }

            set
            {
                justMuestreo = value;
            }
        }

        public List<DetalleProductos> Productos
        {
            get
            {
                return productos;
            }

            set
            {
                productos = value;
            }
        }

        public string NombreAplicacion
        {
            get
            {
                return nombreAplicacion;
            }

            set
            {
                nombreAplicacion = value;
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

        public List<DetalleSecciones> Secciones
        {
            get
            {
                return secciones;
            }

            set
            {
                secciones = value;
            }
        }


        public int IdCedula
        {
            get
            {
                return idCedula;
            }

            set
            {
                idCedula = value;
            }
        }

        public double LtsRequeridos
        {
            get
            {
                return ltsRequeridos;
            }

            set
            {
                ltsRequeridos = value;
            }
        }

        public double TotalLtsRequeridos
        {
            get
            {
                return totalLtsRequeridos;
            }

            set
            {
                totalLtsRequeridos = value;
            }
        }

        public double TotalBoonesRequeridos
        {
            get
            {
                return totalBoonesRequeridos;
            }

            set
            {
                totalBoonesRequeridos = value;
            }
        }

        public double AreaTotal
        {
            get
            {
                return areaTotal;
            }

            set
            {
                areaTotal = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
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

        public int InterCosecha1
        {
            get
            {
                return InterCosecha;
            }

            set
            {
                InterCosecha = value;
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
    public class DetalleProductos
    {
        private int cedula;
        private int codigo;
        private string nombreComercial;
        private string ingredienteActivo;
        private string tipo;
        private double dosisH;
        private double totalDosis;
        private double costo;
        private double costoH;
        private string UM;
        private int intervalo;
        private string numRegistro;
        private int periodoReingreso;

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string NombreComercial
        {
            get
            {
                return nombreComercial;
            }

            set
            {
                nombreComercial = value;
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

        public double TotalDosis
        {
            get
            {
                return totalDosis;
            }

            set
            {
                totalDosis = value;
            }
        }

        public int Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
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

      

        public int Intervalo
        {
            get
            {
                return intervalo;
            }

            set
            {
                intervalo = value;
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

        public string UM1
        {
            get
            {
                return UM;
            }

            set
            {
                UM = value;
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

    public class DetalleSecciones {
        private int cedula;
        private string lote;
        private string bloque;
        private string seccion;
        private double areaTotal;

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

        public double AreaTotal
        {
            get
            {
                return areaTotal;
            }

            set
            {
                areaTotal = value;
            }
        }

        public int Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }
    }


}
