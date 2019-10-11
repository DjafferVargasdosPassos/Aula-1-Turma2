using CatalogoFlores.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CatalogoFlores.Controller
{
    public class FloresController
    {
        FloresContextDB contextDB = new FloresContextDB();

        public void InserirFlores(Flor item)
        {
            contextDB.Flores.Add(item);
            contextDB.SaveChanges();
        }
        public IQueryable<Flor> GetFlores()
        {
            return contextDB.Flores.Where(x => x.Id > 0);

        }
    }

}
