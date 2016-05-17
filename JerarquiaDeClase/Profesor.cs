using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClase
{
    class Profesor:Persona
    {

       


        public override string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
               // throw new NotImplementedException();
                this._nombre = value;
            }
        }

        public override void mostrar()
        {
            Console.WriteLine(this._nombre);// throw new NotImplementedException();
        }

        public override void algovirtual()
        {
            base.algovirtual();
        }
    }
}
