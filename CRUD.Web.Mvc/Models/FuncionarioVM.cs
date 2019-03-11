using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Web.Mvc.Models
{
    public class FuncionarioVM
    {
        public IEnumerable<SelectListItem> Empresas { get; set; }
        public int Id { get; set; }
        public string Funcionario { get; set; }
        public string Tamanho { get; set; }
        public int EmpresaId { get; set; }
        public DateTime Horario { get; set; }
        public bool Arroz { get; set; }
        public bool Feijao { get; set; }
        public bool Refogado { get; set; }
        public bool Proteina { get; set; }
        public bool Salada { get; set; }
    }
}