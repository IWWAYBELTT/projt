using System;
using CF.Repo;
using CF.Data;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using CrudRepository.Controller;
using CF.service;
using CF.Repo.commun;

namespace Monapplication.Tests
{
   
    [TestFixture]
    public class RepositoryTest1
    {
        /*test 2*/
         
        [Test]
        public void ShouldReturnStudent()
        {
            CurdDbContext contexte = new CurdDbContext();
            IStudentRepository studentRepository = new StudentRepository(contexte);
            Student student = new Student();
            student = studentRepository.GetById(1);
            Assert.AreEqual(1, student.Id);
           /* Assert.NotNull( studentRepository.GetAll());*/
        }



        




         /*   [Test]
        public void ShouldReturnlist()
        {
            CurdDbContext contexte = new CurdDbContext();
            IStudentRepository studentRepository = new StudentRepository(contexte);
            List<Student> maliste = studentRepository.GetAll().ToList();
            List<Student> maliste2 = studentRepository.GetAll().ToList();
            NUnit.Framework.CollectionAssert.AreEquivalent(maliste, maliste2); 
}*/



            /*  NUnit.Framework.Assert.NotNull(studentRepository.GetAll());  */
            /* IQueryable resultat = studentRepository.GetAll();
             Assert.IsNotNull(student, resultat);*/
        }



    } 
    
