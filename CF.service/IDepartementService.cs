using CF.Data;
using CF.service.commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.service
{
   public interface  IDepartementService : IEntityService<Departement>
    {
        Departement GetById(long Id);
   
    }
} 
