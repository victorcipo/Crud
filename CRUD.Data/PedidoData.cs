using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class PedidoData
    {
        public void Salvar(Pedido pedido)
        {
            using (var ctx = new CRUDContext())
            {
                ctx.Pedido.Add(pedido);

                ctx.SaveChanges();
            }
        }

        public ICollection<Pedido> Recuperar(DateTime data)
        {
            using (var ctx = new CRUDContext())
            {
                return ctx.Pedido
                    .Include(x => x.Empresa)
                    .Where(x => x.Horario.Day == data.Day
                        && x.Horario.Month == data.Month
                        && x.Horario.Year == data.Year)
                    .ToList();
            }
        }
    }
}
