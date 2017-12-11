using CF.Data;
using CF.Repo;
using CF.Repo.commun;
using CF.service;
using CF.service.commun;
using CrudRepository.Controller;
using CrudRepository.Properties;
using System;

using System.Windows.Forms;

namespace CrudRepository
{
    public partial class EditorForm : Form    /*form1 */
    {
       public bool Adding { get; set; } 

        IStudentService _studentService;
        IDepartementService _deptService;
        

        public EditorForm()
        {
            InitializeComponent(); 
        }

        public EditorForm( IStudentService std, IDepartementService dep)
        {
            this._deptService = dep;
            this._studentService = std;
            InitializeComponent();
           

          /*  if (string.IsNullOrWhiteSpace(student.FirstName))
            {
                Adding = true;
                this.Text = "Ajout";
            }
            else
            {
                Adding = false;
                this.Text = "Modification";

                txtNom.Text = student.FirstName;
                txtPrenom.Text = student.LastName;
                txtNumInsc.Text = student.EnrollmentNumber;
                txtMail.Text = student.Email;
               
            } */
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {  
                StudentController Students = new StudentController(_studentService);
                Student student = new Student();

                student.FirstName = txtNom.Text;
                student. LastName = txtPrenom.Text;
                student. EnrollmentNumber = txtNumInsc.Text;
                student.Email = txtMail.Text;
                student.IPAddress = "exp";
                student.ModifiedDate = DateTime.UtcNow;
                 student.depID = Convert.ToInt32(comboBox1.SelectedValue);
                

                /*if (Adding)
                {*/
                student.AddedDate = DateTime.UtcNow;
                    Students.AddStudent(student);
                    MessageBox.Show("register succes");
                     
                //}
                //else
                //{
                //    //Students.UpdateStudent(student);
                //    Students.UpdateStudent(student);
                //}

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void InitializeDepartmentList()
        {
            DepartementController departements = new DepartementController(_deptService);
            comboBox1.DataSource = departements.GetAllDepartements();  
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Name";


        }

        private void EditorForm_Load(object sender, EventArgs e)
        {
            InitializeDepartmentList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
              
        {
                // Departement departement = new Departement();
                /*  Form2 f2 = new Form2();
                  f2.Show(); */
                Form2  f2 = new Form2 ()
                {
                    RefreshDepartmentList = InitializeDepartmentList
                };
                f2.Show(this);
            }
    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
