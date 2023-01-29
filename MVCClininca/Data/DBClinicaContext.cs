using Microsoft.EntityFrameworkCore;
using MVCClininca.Models;

namespace MVCClininca.Data
{
    public class DBClinicaContext: DbContext
    {
        public DBClinicaContext(DbContextOptions<DBClinicaContext> options): base (options) { }
        public DbSet<Medico> Medicos { get; set; }

    }
}
