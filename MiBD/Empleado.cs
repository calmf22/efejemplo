using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demobasedatos.MiBD
{
   public class Empleado
    {
        public int id { get; set; }

        public string Nombre { get; set; }

        public int Sueldo { get; set; }

        public virtual int DepartamentosId { get; set; }
}
}
