using CRUD.Data;
using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Business
{
    public class EmpresaBusiness
    {
        public IEnumerable<Empresa> RecuperarTodas()
        {
            var data = new EmpresaData();
            return data.RecuperarTodas();
        }
    }
}
