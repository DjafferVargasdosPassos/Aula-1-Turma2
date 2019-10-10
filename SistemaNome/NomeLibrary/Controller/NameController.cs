using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NomeLibrary.Mode;

namespace NomeLibrary.Controller
{
    public class NameController
    {
        NameContextDB contextDB = new NameContextDB();
        public void InserirNome(Name item)
        {
            contextDB.Nome.Add(item);
            contextDB.SaveChanges();
        }

        public IQueryable<Name> GetNames()
        {
            return contextDB.Nome.Where(x => x.Id > 0);
        }
    }
}
