using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClase
{
    class Alumno:Persona
    {
        public int legajo = 0;
        public Alumno(string dni, string nombre, int legajo):base(dni, nombre)
        { 
            this.legajo = legajo;
            this.Nombre = nombre;
        }

        public override void mostrar() // Para implementar la funcion llamamos con public override para sobreescribir al metodo.
                                        
        {
            Console.WriteLine("Legajo nº : "+this.legajo +"\nNombre :  "+this._nombre+"\nDni : "+this.dni);
            
        }

        public override string Nombre
        {
            get
            {
               // throw new NotImplementedException();
                return this.Nombre; // Retornamos la propiedad
            }
            set
            {
              //  throw new NotImplementedException();
                this._nombre = value; // Le ingresamos valor a la propiedad.
            }
        }
        
    }
}
