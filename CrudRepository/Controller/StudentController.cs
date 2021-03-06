﻿using CF.Data;
using CF.Repo;
using CF.Repo.commun;
using CF.service;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace CrudRepository.Controller
{
    public class StudentController
    {
        [Dependency]
        public  IStudentService _studentService { get; set; } 
   
    
        public List<Student> DataSource { get; set; }
        public List<string> ColumnNames { get; set; }


        public StudentController()
        {
           

            GetAllStudent();
            GetColumNames();
        }
        public StudentController(IStudentService istudentservice)
        {
            _studentService = istudentservice; 
        } 


        public string ValidationMessage { get; set; }


        public List<Student> GetAllStudent()
        {
           
            return  _studentService.GetAll().ToList();
        }

        public List<Student> GetAll()
        {
            return _studentService.GetAll().ToList();
        }

        public bool AddStudent(Student NewStudent)
        {
            try
            {
                _studentService.Create(NewStudent);
              
                return true;
            }
            catch (Exception ex)
            {
                ValidationMessage = ex.ToString();
                return false;
            }
        }

        public bool UpdateStudent(Student StudentEdit)
        {
            try
            {
                _studentService.Update(StudentEdit);
               
                return true;
            }
            catch (Exception ex)
            {
                ValidationMessage = ex.ToString();
                return false;
            }
        }

        public void deleteStudent(Student Student)
        {
            try
            {
                Student studenDelete = _studentService.GetById(Student.Id);  
                _studentService.Delete(Student);
                //Student student = studentRepository.GetById(Student.Id);
                //studentRepository.Delete(student);
            }
            catch (Exception ex)
            {
                ValidationMessage = ex.ToString();
            }
        }

        private void GetColumNames()
        {
            ColumnNames = new List<string>();
            using (CurdDbContext context = new CurdDbContext())
            {
                var objectContext = ((IObjectContextAdapter)context).ObjectContext;
                var storageMetadata = ((EntityConnection)objectContext.Connection).GetMetadataWorkspace().GetItems(DataSpace.SSpace);
                var entityProps = (from sm in storageMetadata where sm.BuiltInTypeKind == BuiltInTypeKind.EntityType select sm as EntityType);
                // For your project, open the model browser to get the name for the model, will have namespace.Store

                var metaData = typeof(Student).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();

                //var metaData = (from m in entityProps where m.FullName == "NORTHWNDModel.Store.Customers" select m.DeclaredProperties).ToList();
                foreach (var topItem in metaData)
                {
                    foreach (var item in topItem)
                    {
                        ColumnNames.Add(item.ToString());
                    }
                }
            }
        }

    }
}
