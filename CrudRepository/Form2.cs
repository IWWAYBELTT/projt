using CF.Data;
using CF.service;
using CrudRepository.Controller;
using CrudRepository.LanguageExtensions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudRepository
{
    public delegate void RefreshDepartmentListDelegate(); 
    public partial class Form2 : Form /*formmmmm */
    {
        public RefreshDepartmentListDelegate RefreshDepartmentList;
        private SortableBindingList<Departement> blDepartements = new SortableBindingList<Departement>();
        private BindingSource bsDepartements = new BindingSource();
        IUnityContainer container;
        IDepartementService _deptService;
        public bool Adding = true; 

        public Form2()
        {
           _deptService= Conteneur.container.Resolve<IDepartementService>();
           /*  container = Conteneur.ContainerInit(); 
            _deptService = container.Resolve<IDepartementService>();  */
            InitializeComponent();
        }


        private void InitializeDepartmentList()
        { 
            DepartementController departements = new DepartementController(_deptService);
            blDepartements = new SortableBindingList<Departement>  (departements.GetAllDepartements());
            bsDepartements.DataSource = blDepartements;
            dataGridDepartement .DataSource = bsDepartements; //pour afficher la liste des départements//
            dataGridDepartement.Columns[2].Visible = false;    
        }


      

      
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    DepartementController departements = new DepartementController(_deptService);
                    Departement departement = new Departement();
    
                    departement.Name = textBox1.Text;
                    departement.IPAddress = "exp";
                    departement.ModifiedDate = DateTime.UtcNow;
                   /* if (Adding) */
                   /* { */
                        departement.AddedDate = DateTime.UtcNow;
                        departements.AddDepartement(departement);
                        MessageBox.Show("register succes");
                    InitializeDepartmentList();
                    /* }
                     else
                     {

                         departements.UpdateDepartement(departement);
                     } */

                }
                catch (Exception ex)
                {
                    throw ex;
                }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
    {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            InitializeDepartmentList();
        }
    }
} 
