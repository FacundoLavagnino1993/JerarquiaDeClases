using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClase
{
    public abstract class SerHumano
    {
        public string FechaNacimiento;
        public abstract void mostrarFecha();

        public virtual void algovirtual()
        { 

        }
        

    }
}
