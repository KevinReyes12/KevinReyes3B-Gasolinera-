using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera.Clases
{
    public class Gasolina
    {

        public Gasolina()
        {

        }

        private String tipo;

        public String Tipo
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

        private float cant_galones;

        public float Cant_galones
        {
            get 
            { 
                return cant_galones; 
            }
            set 
            { 
                cant_galones = value; 
            }
        }

        private float precio_venta;

        public float Precio_venta
        {
            get 
            { 
                return precio_venta; 
            }
            set 
            {
               precio_venta = value;
               
            }
        }
 
        public float Subtotal
        {
            get 
            { 
                return Precio_venta*Cant_galones; 
            }
            
        }

        public float IVA
        {
            get 
            { 
                return Subtotal*0.12f; 
            }
            
        }

        public float Total
        {
            get 
            { 
                return Subtotal+IVA; 
            }
            
        }

    }
}
