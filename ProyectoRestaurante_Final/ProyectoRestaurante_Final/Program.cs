using System;

namespace ProyectoRestaurante_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARACIONES PREVIAS
            string plato1;
            string plato2;
            string plato3;
            double precio1;
            double precio2;
            double precio3;
            Menu menu1 = new Menu();
            Pedido pedido = new Pedido("Fideos", 1.5, 20);
            Orden nuevaOrden = null;
            //CODIGO PRINCIPAL
            Console.WriteLine("\t\tBIENVENIDO/A CLIENTE!!!");
            while (true)
            {
                Console.WriteLine("\n++MENÚ PRINCIPAL++");
                Console.WriteLine("Seleccionar: ");
                Console.WriteLine("Opcion 1. Menus de Platillos");
                Console.WriteLine("Opcion 2. Orden");
                Console.WriteLine("Opcion 3. Salir");
                int teclado = int.Parse(Console.ReadLine());
                switch (teclado)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("\n++MENUS DE PLATILLOS++");
                            Console.WriteLine("Seleccionar: ");
                            Console.WriteLine("Opcion 1. Menú Desayuno");
                            Console.WriteLine("Opcion 2. Menú Almuerzo");
                            Console.WriteLine("Opcion 3. Menú Bebidas");
                            Console.WriteLine("Opcion 4. Volver");
                            int teclado1 = int.Parse(Console.ReadLine());
                            switch (teclado1)
                            {
                                case 1:
                                    Console.WriteLine("++Menú Desayuno++");
                                    plato1 = "Bolon de Queso";
                                    plato2 = "Huevos Revueltos";
                                    plato3 = "Tostadas";
                                    precio1 = 1.50;
                                    precio2 = 1.75;
                                    precio3 = 1.00;

                                    nuevaOrden = menu1.Mensaje(plato1, plato2, plato3, precio1, precio2, precio3);
                                    pedido.insertarOrden(nuevaOrden);
                                    break;

                                case 2:
                                    Console.WriteLine("++Menú Almuerzo++");
                                    plato1 = "Sopa de Queso - Arroz con Carne Apanada y Pure de Papas";
                                    plato2 = "Menestron de Carne - Ensalada de Aguacate con Filete de Pescado";
                                    plato3 = "Solo Segundo";
                                    precio1 = 3.00;
                                    precio2 = 3.00;
                                    precio3 = 1.75;

                                    nuevaOrden = menu1.Mensaje(plato1, plato2, plato3, precio1, precio2, precio3);
                                    pedido.insertarOrden(nuevaOrden);
                                    break;

                                case 3:
                                    Console.WriteLine("++Menú Bebidas++");
                                    plato1 = "Juego de Naranja o Tomate de Árbol";
                                    plato2 = "Gaseosa personal";
                                    plato3 = "Colada";
                                    precio1 = 0.35;
                                    precio2 = 0.50;
                                    precio3 = 0.75;

                                    nuevaOrden = menu1.Mensaje(plato1, plato2, plato3, precio1, precio2, precio3);
                                    pedido.insertarOrden(nuevaOrden);
                                    break;

                                case 4:

                                    break;
                            }
                            if (teclado1 <= 0 || teclado1 > 4)
                                Console.WriteLine("Por favor, seleccione una opción válida.");
                            if (teclado1 == 4)
                                break;
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("\n++ORDEN++");
                            Console.WriteLine("Seleccionar: ");
                            Console.WriteLine("Opcion 1. Revisar Orden");
                            Console.WriteLine("Opcion 2. Remover de Orden");
                            Console.WriteLine("Opcion 3. Terminar Orden");
                            Console.WriteLine("Opcion 4. Cancelar Orden");
                            Console.WriteLine("Opcion 5. Volver");
                            int teclado1 = int.Parse(Console.ReadLine());
                            switch (teclado1)
                            {
                                case 1:
                                    Console.WriteLine("++Revisar Orden++");
                                    pedido.mostrarOrden();
                                    break;
                                case 2:
                                    Console.WriteLine("++Remover de Orden++");
                                    pedido.eliminarOrden(nuevaOrden);
                                    break;
                                case 3:
                                    Console.WriteLine("++Terminar Orden++");
                                    pedido.mostrarOrden();
                                    pedido.calcularTotal();
                                    break;
                                case 4:
                                    Console.WriteLine("++Cancelar Orden++");
                                    pedido.vaciarOrden();
                                    break;
                                case 5:

                                    break;
                            }
                            if (teclado1 <= 0 || teclado1 > 5)
                                Console.WriteLine("Por favor, seleccione una opción válida.");
                            if (teclado1 == 5)
                                break;
                        }
                        break;
                    case 3:

                        break;
                }
                if (teclado <= 0 || teclado > 3)
                    Console.WriteLine("Por favor, seleccionar una opción válida.");
                if (teclado == 3)
                {
                    Console.WriteLine("\nGracias por usar el programa :D");
                    break;
                }

            }
        }
    }
}
