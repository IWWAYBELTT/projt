using CF.Data;
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
    public  class DepartementController

    {  
            [Dependency] 
            public IDepartementService _departementService { get; set; }
     

        public List<Departement> DataSource { get; set; }
            public List<string> ColumnNames { get; set; }


            //public DepartementController()
            //{
            //    GetAllDepartements();
            //    GetColumNames();
            //}
            public DepartementController(IDepartementService idepartementservice)
            {
                _departementService = idepartementservice;
            
        }


        public string ValidationMessage { get; set; }


            public List<Departement> GetAllDepartements()
            {
               
                return _departementService.GetAll().ToList();
            }

            public List<Departement> GetAll()
            {
                return _departementService.GetAll().ToList();
            }

            public bool AddDepartement(Departement NewDept)
            {
                try
                {
                    _departementService.Create(NewDept);
                    
                    return true;
                }
                catch (Exception ex)
                {
                    ValidationMessage = ex.ToString();
                    return false;
                }
            }

            public bool UpdateDepartement(Departement DeptEdit)
            {
                try
                {
                    _departementService.Update(DeptEdit);
                 
                    return true;
                }
                catch (Exception ex)
                {
                    ValidationMessage = ex.ToString();
                    return false;
                }
            }

            public void deleteDepartement(Departement DeptDelete)
            {
                try
                {
              
                    _departementService.Delete(DeptDelete);
                    
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
