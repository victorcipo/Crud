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
        private readonly EmpresaData _data;

        public EmpresaBusiness()
        {
            _data = new EmpresaData();
        }
        public IEnumerable<Empresa> RecuperarTodas()
        {
            return _data.RecuperarTodas();
        }
    }
}
