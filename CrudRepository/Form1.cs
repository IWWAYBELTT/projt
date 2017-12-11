using CF.Data;
using CrudRepository.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrudRepository.LanguageExtensions;
using CrudRepository.DialogLibrary;
using CF.Repo;
using CF.service;

namespace CrudRepository
{
    //form1 v3
    public partial class Form1 : Form
    {
        private SortableBindingList<Student> blStudents = new SortableBindingList<Student>();
        private BindingSource bsStudents = new BindingSource();
        private IStudentService std;
        private IDepartementService dep; 




        public Form1()
        {
           dep = Conteneur.container.Resolve<IDepartementService>(); 
            std = Conteneur.container.Resolve<IStudentService>();
            InitializeComponent();
        }

        /*public Form1(IStudentService std , IDepartementService dep )
        {
            this.dep = dep; 
            this.std = std;
           InitializeComponent();
         } */

       

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentController students = new StudentController(std);
            blStudents = new SortableBindingList<Student>(students.GetAllStudent());
            bsStudents.DataSource = blStudents;
            dataGridView1.DataSource = bsStudents;

            SetupDataBindingsForLabels();
            PrepareDataGridViewColumns();


        }

        private void SetupDataBindingsForLabels()
        {
            lblProductIdentifier.DataBindings.Add("text", bsStudents, "Id");
            lblProductName.DataBindings.Add("text", bsStudents, "FirstName");
        }

        private void PrepareDataGridViewColumns() // pour cacher les colonnes indésirables de la table// 
        {
            List<string> hideColumns = new List<string>() { "Id", "AddedDate", "ModifiedDate", "IPAddress" };

            foreach (string colName in hideColumns)
            {
                if (dataGridView1.Columns.Contains(colName))
                {
                    dataGridView1.Columns[colName].Visible = false;
                }
            }

            dataGridView1.ExpandColumns();
        }

        private void AddNewStudent()
        {
         /*   Student student = new Student(); */
            EditorForm f = new EditorForm(std,dep);
            try
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    {
                      /*   blStudents.Add(student);
                         blStudents.ResetBindings();
                     dataGridView1.Sort(dataGridView1.Columns["Id"], ListSortDirection.Ascending); */
                    }
                }
            }
            finally
            {
                f.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewStudent();
        }

        private void cmdEditCurrent_Click(object sender, EventArgs e)
        {
            EditCurrentRow();
        }

        private void EditCurrentRow()
        {
            
            Student student = blStudents.Where(c => c.Id == bsStudents.StudentIdentifier()).AsQueryable().FirstOrDefault();

            //Student student = blStudents.FirstOrDefault(stud => stud.Id == bsStudents.StudentIdentifier());
            EditorForm f = new EditorForm( std,dep);

            try
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    bsStudents.ResetCurrentItem();
                }
            }
            finally
            {
                f.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = blStudents.FirstOrDefault(stud => stud.Id == bsStudents.StudentIdentifier());
            StudentController Students = new StudentController(std);
            Students.deleteStudent(student);
            bsStudents.RemoveCurrent();
            ActiveControl = dataGridView1;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdCompanyName_Click(object sender, EventArgs e)
        {

        }
   
    }
}
