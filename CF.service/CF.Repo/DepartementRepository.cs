using CF.Data;
using CF.Repo.commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Repo
{
  public   class DepartementRepository : Repository<Departement>, IDepartementRepository

    {
        public DepartementRepository (CurdDbContext context) : base(context) { }

  
    }
}
