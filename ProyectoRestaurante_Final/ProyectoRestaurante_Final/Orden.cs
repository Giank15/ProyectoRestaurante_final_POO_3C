using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoRestaurante_Final
{
    public class Orden
    {
        private string plato;
        private double precio;
        public Orden(String plato, double precio)
        {
            this.plato = plato;
            this.precio = precio;
        }

        public String getPlato()
        {
            return plato;
        }
        public void setPlato(String plato)
        {
            this.plato = plato;
        }
        public double getPrecio()
        {
            return precio;
        }
        public void setPrecio(double precio)
        {
            this.precio = precio;
        }
        public override String ToString()
        {
            return "Platillo: " + getPlato() + "... Precio: " + getPrecio();
        }
    }
    
}
