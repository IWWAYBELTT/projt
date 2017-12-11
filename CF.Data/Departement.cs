using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Data
{
  public   class Departement : BaseEntity 
    {
        
            public string Name { get; set; }
        public ICollection<Student> Student { get; set; }

    }
    }

