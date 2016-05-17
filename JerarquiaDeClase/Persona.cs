using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClase
{
     public abstract class Persona // La clase persona, lleva el modificador public y el modificador abstract. Persona pasa a ser una clase abstracta.
    {                               //Las clases abstractas no se pueden instanciar.
                                    // 1 * Los metodos abstractos solo estan en clases abstractas.
                                    // 2 * No tienen implementacion
        public string dni;
        protected string _nombre;
        public abstract string Nombre // Propiedad abstracta.
        {
            get; // Tanto get como set, en el metodo abtsracto no lleva apertura de llaves, solo punto y come;
            set;
        }

         //1*//
        public abstract void mostrar();  // Creamos metodo abstracto mostrar. No tiene implementacion.
        public void mostrarDni() // Metodo que no es abstracto.
        {
            Console.WriteLine(this.dni);
        }

        public Persona(string dni, string nombre)
        {
            this.dni = dni;
            this._nombre = nombre;
        }

     }
}


// Si la Superclase es abstracta la clase que hereda esta obligada a implementar los metodos.
