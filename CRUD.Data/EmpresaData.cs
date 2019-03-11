using CRUD.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class EmpresaData
    {
        public IEnumerable<Empresa> RecuperarTodas()
        {
            using (var ctx = new CRUDContext())
            {
                return ctx.Empresa.ToList();
            }
        }

        public Empresa RecuperarPorId(int id)
        {
            using (var ctx = new CRUDContext())
            {
                return ctx.Empresa.Where(x => x.Id == id).SingleOrDefault();
            }
        }

        public void Salvar(Empresa empresa)
        {
            using (var ctx = new CRUDContext())
            {
                ctx.Empresa.Add(empresa);

                ctx.SaveChanges();
            }
        }
    }
}
