using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demobasedatos.MiBD
{
   public class demoEF:DbContext
    {
       public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamentos> Departamentoss  { get; set; }


}
}
