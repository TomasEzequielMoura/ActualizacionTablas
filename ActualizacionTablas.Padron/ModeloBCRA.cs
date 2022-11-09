using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActualizacionTablas.Padron
{
    public class ModeloBCRA : DbContext
    {
        public ModeloBCRA() : base("Server=tcp:produccion-af.database.windows.net,1433;Initial Catalog=BCRA; Persist Security Info=False;User ID=actionfintech;Password=^U$bF$aNTgT9@^1tvog5*zygWO^XC9ltl*R^mHyuqxBJFl1m7#;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;") { }

        public DbSet<RegistroPadron> registrosPadron { get; set; }
    }
}
