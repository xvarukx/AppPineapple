using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            int cantLote = 0, cantBloque, canSeccion;
            int areaLote = 0, areaBloque, areaSeccion;
            
            for (int l = 1; l < 50; l++)
            {

                DAO.Lote.insertar(new Entidades.Lote()
                {

                    IdLote = l.ToString(),
                    Fecha = default(DateTime),
                    Area = areaLote += l,
                    CantPlantas = cantLote += l,
                    Imagen = Image.FromFile("C:/Users/Luis Mora/Pictures/n.png")
                  
            });
          
                for (int b = 1; b < 8; b++)
                {

                    DAO.Bloque.insertar(new Entidades.Bloque()
                    {

                        IdLote = l.ToString(),
                        IdBloque = b.ToString(),
                        PosX = 100,
                        PosY = 100,
                        CantSecciones = 0,
                        AreaUtilizada = 0,
                        Area = cantLote + 12,
                        Detalles = ""
                       

            });
              
              
      
                for (int s = 1; s < 6; s++)
                    {
                       Entidades.Seccion seccion = new Entidades.Seccion()
                        {


                            IdBloque = b.ToString(),
                            IdLote = l.ToString(),
                            IdSeccion = s.ToString(),
                            FechaProgramada = default(DateTime),
                            FechaInicial = DateTime.Today,
                            FechaSiembra = DateTime.Today,
                            Area = s + 10,
                            NumPlantas = s + 15,
                            PosX = 150,
                            PosY = 150,
                            Posicion = -1,TipoSemilla = "", PesoSemilla = "",Paquete = "Primero"
                            
                        };
                        DAO.Seccion.insertar(seccion);
                        DAO.Seccion.editPaquete(seccion);
                    }
                    Console.WriteLine("Lote: " + l.ToString() + " Agregado");

                }
            }
        }
    }
}
