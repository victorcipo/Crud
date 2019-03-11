using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Business
{
    public static class Initializer
    {
        public static void Initialize()
        {
            CRUD.Data.Initializer.Initialize();
        }
    }
}
