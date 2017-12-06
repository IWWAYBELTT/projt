using CF.Data;
using CF.service.commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CF.Repo.commun;
using Microsoft.Practices.Unity;
using CF.Repo;

namespace CF.service
{
    public class DepartementService : EntityService<Departement> , IDepartementService
    {

        [Dependency]
        public IDepartementRepository _departementRepository { get; set; }


        public DepartementService(IDepartementRepository departementRepository) : base(departementRepository)
        {


            _departementRepository = departementRepository;
        }


        public Departement GetById(long Id)
        {
            return _departementRepository.GetById(Id);
        }




    }
} 

 