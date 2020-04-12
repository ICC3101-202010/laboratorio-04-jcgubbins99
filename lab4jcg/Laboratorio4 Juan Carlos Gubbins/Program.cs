using System;
using System.Threading;

namespace Laboratorio4_Juan_Carlos_Gubbins
{
    class Program //Este codigo funciona con numeros random, si al correrlo este se termina muy pronto probar de nuevo.
    {
        static void Main()
        {
            Console.WriteLine("El día ha comenzado");
            Console.WriteLine("=====================");
            Thread.Sleep(1000);
            MaquinaRecepcion mr = new MaquinaRecepcion("Máquina de recepción");
            MaquinaAlmacenamiento ma = new MaquinaAlmacenamiento("Máquina de almacenamiento");
            MaquinaEnsamblaje me = new MaquinaEnsamblaje("Máquina de ensamblaje");
            MaquinaVerificacion mv = new MaquinaVerificacion("Máquina de verificación");
            MaquinaEmpaque mem = new MaquinaEmpaque("Máquina de empaque");
            CentralPC c = new CentralPC(mr);
            CentralPC a = new CentralPC(ma);
            CentralPC e = new CentralPC(me);
            CentralPC v = new CentralPC(mv);
            CentralPC em = new CentralPC(mem);
            c.Operar();
            Thread.Sleep(1000);
            a.Operar();
            Thread.Sleep(1000);
            e.Operar();
            Thread.Sleep(1000);
            v.Operar();
            Thread.Sleep(1000);
            em.Operar();
            Console.WriteLine("TODAS LAS MÁQUINAS TIENEN UNA CAPACIDAD MÁXIMA DE 50 PIEZAS");
            Console.WriteLine("============================================================");
            Thread.Sleep(1500);
            Console.WriteLine("Las piezas comenzaron a recorrer las máquinas...");
            c.Revision();
            var random = new Random();
            int accion = 0;
            while (accion != 16)
            {
                Thread.Sleep(2000);
                accion = random.Next(1, 17);
                switch (accion)
                {
                    case 1:
                        c.Revision();
                        break;
                    case 2:
                        a.Revision();

                        break;
                    case 3:
                        e.Revision();
                        break;
                    case 4:
                        v.Revision();
                        break;
                    case 5:
                        em.Revision();
                        break;
                    case 6:
                        c.Revision();
                        break;

                    case 7:
                        a.Revision();
                        break;
                    case 8:
                        e.Revision();
                        break;
                    case 9:
                        v.Revision();
                        break;
                    case 10:
                        em.Revision();
                        break;
                    case 11:
                        c.Revision();
                        break;
                    case 12:
                        a.Revision();
                        break;
                    case 13:
                        e.Revision();
                        break;
                    case 14:
                        v.Revision();
                        break;
                    case 15:
                        em.Revision();
                        break;
                    case 16:
                        Console.WriteLine("===========================================");
                        Console.WriteLine("Nada más ha pasado en el día");
                        Console.WriteLine("===========================================");
                        Console.WriteLine("El día ha terminado, nos vemos mañana ;)");
                        Console.WriteLine("===========================================");

                        break;
                    default:
                        Console.WriteLine("No se ha seleccionado ninguna opción válida");
                        break;

                }

            }
            c.Terminar();
            Thread.Sleep(1000);
            a.Terminar();
            Thread.Sleep(1000);
            e.Terminar();
            Thread.Sleep(1000);
            v.Terminar();
            Thread.Sleep(1000);
            em.Terminar();
            Thread.Sleep(1000);
        }
    }
}


            













       