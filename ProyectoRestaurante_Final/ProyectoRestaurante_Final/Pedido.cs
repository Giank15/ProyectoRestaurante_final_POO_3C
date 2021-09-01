using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRestaurante_Final
{
    public class Pedido : Orden
    {
        private Orden[] OrdenPedido;
        private int limite;
        private int numUser;

        public Pedido(String plato, double precio, int limite) : base(plato, precio)
        {
            this.OrdenPedido = new Orden[limite];
            this.limite = limite;
            numUser = 0;
        }
        public void insertarOrden(Orden c)
        {
            if (c != null && numUser < OrdenPedido.Length)
            {
                OrdenPedido[numUser] = c;
                numUser++;
            }
        }
        public void mostrarOrden()
        {
            for (int i = 0; i < numUser; i++)
            {
                Console.WriteLine(OrdenPedido[i].ToString());
            }
        }
        public void calcularTotal()
        {
            double valor = 0;
            double Total = 0;
            
            for (int i = 0; i < numUser; i++)
            {
                valor = OrdenPedido[i].getPrecio();
                Total = valor + Total;
            }
            Console.WriteLine("El total de su pedido es: {0}", Total);
        }
        public void vaciarOrden()
        {
            this.OrdenPedido = new Orden[limite];
            numUser = 0;
            Console.WriteLine("Eliminando pedido");
        }
        public void eliminarOrden(Orden c)
        {
            int posicion = -1;
            for (int i = 0; i < numUser; i++)
            {
                if (c.getPlato() == OrdenPedido[i].getPlato())
                {
                    posicion = i;
                }
            }

            if (posicion == -1)
            {
                Console.WriteLine("No existe el platillo");

            }
            else
            {
                OrdenPedido[posicion] = null;
                for (int i = posicion; i < numUser; i++)
                {
                    OrdenPedido[i] = OrdenPedido[i + 1];
                    Console.WriteLine("Ultimo item de la orden eliminado...");
                }

                numUser--;
            }
        }
    }
}
