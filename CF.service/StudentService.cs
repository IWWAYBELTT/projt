using CF.Data;
using CF.service.commun;
using CF.Repo.commun;
using CF.Repo;
using Microsoft.Practices.Unity; 
namespace CF.service
{
    public  class StudentService : EntityService<Student>, IStudentService
    {
        /*IUnitOfWork _unitOfWork;
        IStudentRepository _studentRepository; */


        [Dependency]
        public IStudentRepository _studentRepository { get; set; }
     
        /* public IUnitOfWork _unitOfWork { get; set; }*/


        public StudentService( IStudentRepository studentRepository) : base( studentRepository)
        {
          /*  _unitOfWork = unitOfWork; */
            _studentRepository = studentRepository;
        }

        public Student GetById(long Id)
        {
            return _studentRepository.GetById(Id);
        }

       /* public void DisplayResult()
        {
            _studentRepository.ShowResult();
        } */ 
    }
}
