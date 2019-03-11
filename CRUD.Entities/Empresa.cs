using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}
