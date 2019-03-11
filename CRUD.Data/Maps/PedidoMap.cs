using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data.Maps
{
    class PedidoMap : EntityTypeConfiguration<Pedido>
    {
        public PedidoMap()
        {
            ToTable("pedido");

            this.HasRequired(x => x.Empresa)
                .WithMany(y => y.Pedidos)
                .HasForeignKey(z => z.EmpresaId);
        }
    }
}
