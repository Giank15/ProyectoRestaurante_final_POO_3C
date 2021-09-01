using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRestaurante_Final
{
    public class Menu
    {
        
        public virtual Orden Mensaje(string plato1, string plato2, string plato3, double precio1, double precio2, double precio3)
        {
            Orden orden;
            Console.WriteLine("Plato 1. {0}--- {1}", plato1, precio1);
            Console.WriteLine("Plato 2. {0}--- {1}", plato2, precio2);
            Console.WriteLine("Plato 3. {0}--- {1}", plato3, precio3);
            int teclado2 = int.Parse(Console.ReadLine());
            switch (teclado2)
            {
                case 1:
                    Console.WriteLine("Platillo 1 Seleccionado...");
                    orden = new Orden(plato1, precio1) ;
                    return orden;

                case 2:
                    Console.WriteLine("Platillo 2 Seleccionado...");
                    orden = new Orden(plato2, precio2);
                    return orden;

                case 3:
                    Console.WriteLine("Platillo 3 Seleccionado...");
                    orden = new Orden(plato3, precio3);
                    return orden;

            }
            orden = null;
            return orden;
        }
    }
}
