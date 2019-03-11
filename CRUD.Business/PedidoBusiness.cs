using CRUD.Data;
using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Business
{
    public class PedidoBusiness
    {
        public void Salvar(Pedido pedido)
        {
            var pedidoData = new PedidoData();
            pedidoData.Salvar(pedido);
        }

        public ICollection<Pedido> Recuperar()
        {
            var pedidoData = new PedidoData();
            return pedidoData.Recuperar();
        }
    }
}
