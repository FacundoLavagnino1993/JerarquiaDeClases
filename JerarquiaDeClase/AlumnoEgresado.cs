using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JerarquiaDeClase
{
    class AlumnoEgresado:Alumno
    {
        public int AñoEgreso = 1990;
        public AlumnoEgresado(int AñoEgreso,string dni, string nombre, int legajo): base(dni, nombre, legajo)
        {
            this.AñoEgreso = AñoEgreso;
        }


        public override void mostrar()
        {
            base.mostrar();
            Console.WriteLine("Año de egreso : "+this.AñoEgreso);
        }

        public override void algoMasVirtual()
        {
            base.algoMasVirtual();
        }

    }
}
