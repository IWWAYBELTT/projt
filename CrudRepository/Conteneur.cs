using CF.Repo;
using CF.service;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudRepository
{
    public static  class Conteneur
    {
        public static IUnityContainer container; 

        public static IUnityContainer ContainerInit ()
        {
             container = new UnityContainer(); 
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            section.Containers.Default.Configure(container);

           
            container.RegisterType<IStudentRepository, StudentRepository>();
            container.RegisterType<IStudentService, StudentService>();

            container.RegisterType<IDepartementRepository, DepartementRepository>();
            container.RegisterType<IDepartementService, DepartementService>();



            //renvoie ube nouvelle instance de student service//
            //IStudentService std = container.Resolve<IStudentService>();
            //IDepartementService dep = container.Resolve<IDepartementService>();

            return (container); 

        }
    }
}
