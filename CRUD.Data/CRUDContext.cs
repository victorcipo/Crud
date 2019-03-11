using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data
{
    class CRUDContext : DbContext
    {
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

        public CRUDContext() : base("CRUD")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(typeof(CRUDContext).Assembly);
        }
    }
}
