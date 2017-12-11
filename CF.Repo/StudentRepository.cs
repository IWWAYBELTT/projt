using CF.Repo.commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CF.Data;

namespace CF.Repo
{
 
  public    class StudentRepository : Repository<Student>, IStudentRepository

    { /* daaaa */
        public StudentRepository(CurdDbContext context) : base(context) { }

        /*public void ShowResult()
        {
            Console.WriteLine("You got first division in Engineering program.");
        } */
    }

   
    }


    