using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Final
{
    class Producto
    {

        private string nombre;
        private double precio;
        private int existencia;

        public Producto(string nombre)
        {
            this.nombre = nombre;
        }
        
        public string Nombre
        {
            get
            {
                return nombre;    
            }
            set
            {
                nombre = value;
            }
        }

        public Producto(double precio)
        {
            this.precio = precio;
        }

        public double Precio
        {
            get 
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
    
        public Producto(int existencia)
        {
            this.existencia = existencia;
        }
    
        public int Existencia
        {
            get
            {
                return existencia;
            }
            set
            {
                existencia = value;
            }
        }


    }
}
