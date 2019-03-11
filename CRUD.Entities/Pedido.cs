using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Funcionario { get; set; }
        public string Tamanho { get; set; }
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public DateTime Horario { get; set; }
        public bool Arroz { get; set; }
        public bool Feijao { get; set; }
        public bool Refogado { get; set; }
        public bool Proteina { get; set; }
        public bool Salada { get; set; }
    }
}
