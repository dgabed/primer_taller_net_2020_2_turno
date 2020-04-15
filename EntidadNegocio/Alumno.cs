using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadNegocio
{
    class Alumno
    {
        public string brach_pp_nombre;
        public string apellido { get; set; }

        public void setNombre(string nombre)
        {
            this.brach_pp_nombre = nombre;
        }

        public string getNombre()
        {
            return this.brach_pp_nombre;
        }
    }
}
