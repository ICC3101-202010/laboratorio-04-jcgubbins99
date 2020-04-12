using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4_Juan_Carlos_Gubbins
{
    class CentralPC
    {
        private Control control;
        public CentralPC(Control c)
        {
            control = c;
        }

        public void Operar()
        {
            control.Encendido();


        }
        public void Revision()
        {
            var contador = new Random();
            int numero = contador.Next(35, 60);
            if (numero < 50)
            {
                Console.WriteLine("...");
            }
            if (numero >= 50)
            {
                control.Reinicio();
                Console.WriteLine("===============================");
            }

        }
        public void Terminar()
        {
            control.Apagado();
        }
    }

}

