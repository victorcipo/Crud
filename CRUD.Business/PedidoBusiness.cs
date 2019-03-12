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
        private readonly PedidoData _data;

        public PedidoBusiness()
        {
            _data = new PedidoData();
        }

        public void Salvar(Pedido pedido)
        {
            _data.Salvar(pedido);
        }

        public ICollection<Pedido> Recuperar(DateTime data)
        {
            return _data.Recuperar(data);
        }
    }
}
