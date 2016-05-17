using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClase
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Persona Per = new Persona(); /* Los objetos de las clases abstractas no se pueden instanciar.
                                         pero, todas las instancias de las clases que heredan de la abstracta pueden tomarse como
                                         instancias de la clase abstracta.*/

             List<Persona> ListaPersona = new List<Persona>();
             Alumno alum = new Alumno("333555", "pedro", 220);
             AlumnoEgresado alumEgresado = new AlumnoEgresado(2015, "331544", "Juan", 300);
             ListaPersona.Add(alum);
             ListaPersona.Add(alumEgresado);
             foreach (Persona item in ListaPersona)
             {

                 item.mostrar();

             }

            Console.ReadKey();
        }
    }
}
// Reglas de herecia : Las clases abstractas pueden implementar un metodo abstracto, pero siempre la proxima clase no abstracta tiene que implementar dicho metodo
