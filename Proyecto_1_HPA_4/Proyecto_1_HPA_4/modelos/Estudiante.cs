using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_1_HPA_4.modelos
{
    class Estudiante
    {
        public String Nombre { get; set; }
        public String Cedula { get; set; }
        public String Fecha { get; set; }

        public override string ToString()
        {
            return $"{Nombre}:{Cedula}:{Fecha}";
        }
    }
}
