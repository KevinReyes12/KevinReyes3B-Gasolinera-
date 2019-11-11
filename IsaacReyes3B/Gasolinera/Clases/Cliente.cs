using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gasolinera.Clases
{
    public class Cliente
    {
        public Cliente()
        {

        }

        private String nombres;

        public String Nombres
        {
            get 
            { 
                return nombres; 
            }
            set 
            {
                if (Regex.IsMatch(value, @"\s?[a-zñA-ZÑ]"))
                {
                    //throw new Exception("Ingrese nombres");
                }
                else
                {
                    throw new Exception("Ingrese nombres");
                }
                nombres = value; 
            }
        }

        private String apellidos;

        public String Apellidos
        {
            get 
            { 
                return apellidos; 
            }
            set 
            {
                if (!Regex.IsMatch(value, @"\s?[a-zñA-ZÑ]"))
                {
                    throw new Exception("Ingrese apellidos");
                }
                apellidos = value; 
            }
        }

        private String numeroCI;

        public String Numero_CI
        {
            get 
            { 
                return numeroCI; 
            }
            set 
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    throw new Exception("Ingrese solo números");
                }
                numeroCI = value; 
            }
        }

        private String direccion;

        public String Direccion
        {
            get 
            { 
                return direccion; 
            }
            set 
            { 
                direccion = value; 
            }
        }


    }
}
