using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Hotsite.Models
{
    public class InteresseService
    {
        public int CadastraInteresse(Interesse cad)
        {
            using(var context = new DatabaseContext())
            {
                context.Add(cad);
                context.SaveChanges();
                return cad.Id;
            }
        }
    }
}