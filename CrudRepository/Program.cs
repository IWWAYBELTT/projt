using CF.Repo;
using CF.Repo.commun;
using CF.service;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudRepository
{
    class Program
    {
        static void Main(string[] args)
        {

            IUnityContainer Container = Conteneur.ContainerInit ();

            //renvoie ube nouvelle instance de student service//
              IStudentService std = Container.Resolve<IStudentService>(); 
            IDepartementService dep = Container.Resolve<IDepartementService>();
           

            Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(new Form1(std,dep)); 
          /* Application.Run(new Form2()); */

             /*  Application.Run(Container.Resolve<Form1>()); */

         /*   Application.Run(Container.Resolve<Form2>()); */
        }
        }
    }

