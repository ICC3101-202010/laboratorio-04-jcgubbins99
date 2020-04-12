using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Laboratorio4_Juan_Carlos_Gubbins
{
    class MaquinaRecepcion : Control
    {
        public string Nombre;
        public MaquinaRecepcion(string nombre)
        {
            this.Nombre = nombre;
        }
        public void Reinicio()
        {
            Console.WriteLine("La máquina de recepción ha colapsado, ya no tiene más capacidad");
            Console.WriteLine("");
            Console.WriteLine("Reiniciando máquina...");
            Thread.Sleep(1000);
            Apagado();
            Console.WriteLine("");
            Encendido();
        }
        public void Apagado()
        {
            Console.WriteLine(" ");
            Console.WriteLine(Nombre + " apagada");
        }

        public void Encendido()
        {
            Console.WriteLine(Nombre + " encendida");
            Console.WriteLine(" ");
        }
    }
}

