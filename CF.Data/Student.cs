using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Data
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EnrollmentNumber { get; set; }

      /*  [ForeignKey("Departement")]
        public int depId { get; set; } */
      /*  public Departement Departement { get; set; } */
        public int depID { get; set; }

        [ForeignKey("depID")]
        public Departement Departement { get; set; }
        }
}
