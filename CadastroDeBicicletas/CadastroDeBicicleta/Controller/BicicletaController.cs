﻿using CadastroDeBicicleta.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeBicicleta.Controller
{
    public class BicicletaController
    {
        BicicletaContextDB contextDb = new BicicletaContextDB();

        public void InserirBike(Bicicleta item)
        {
            contextDb.Bicicletas.Add(item);
            contextDb.SaveChanges();
        }

        public void AtualizarBike(Bicicleta item)
        {
            var bicicleta = contextDb.Bicicletas.FirstOrDefault(x => x.Id == item.Id);
            contextDb.SaveChanges();
        }

        public bool RemoverBike(int id)
        {
           var bicicleta = contextDb.Bicicletas.FirstOrDefault(x => x.Id == id);

            if (bicicleta != null)
            {
                contextDb.Bicicletas.Remove(bicicleta);
                contextDb.SaveChanges();
                return true;
            }
            else
                return false;
        }
               
        public IQueryable<Bicicleta> GetBicicletas()
        {
            return contextDb.Bicicletas.Where(x => x.Id > 0);
        }
    
    }
}
