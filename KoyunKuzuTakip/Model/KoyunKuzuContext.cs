using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoyunKuzuTakip.Model
{
    public partial class KoyunKuzuContext : DbContext
    {
        public DbSet<Animal> ANIMAL { get; set; }


        public KoyunKuzuContext() : base("SqliteConString")
        {
        }
    }
}
