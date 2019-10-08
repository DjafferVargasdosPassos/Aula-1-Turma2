using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;

namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        CervejaContextDb contextDb = new CervejaContextDb();
        public void AddCerveja(Cerveja item)
        {
            contextDb.Cervejas.Add(item);
            contextDb.SaveChanges();
        }
    }
}
