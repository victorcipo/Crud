using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class Initializer
    {
        public static void Initialize()
        {
            Database.SetInitializer<CRUDContext>(null);
        }
    }
}
