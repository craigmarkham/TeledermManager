using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeledermModel.DataLayer
{
    class TeledermModelContext:DbContext
    {
        public DbSet<Patient> Patient { get; set; }

    }
}
