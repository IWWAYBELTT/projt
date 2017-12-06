using CF.Data;
using CF.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleRepository
{
    public partial class EditorForm : Form
    {
        public Student student { get; set; }
        public bool Adding { get; set; }

        private UnitOfWork unitOfWork;
        private Repository<Student> studentRepository;

        public EditorForm()
        {
            InitializeComponent();
        }

        public EditorForm(Student student)
        {
            InitializeComponent();
            this.student = student;

            if (string.IsNullOrWhiteSpace(student.FirstName))
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

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Adding)
                {
                    Student student = new Student
                    {
                        AddedDate = DateTime.UtcNow
                    };
                    student.FirstName = txtNom.Text;
                    student.LastName = txtPrenom.Text;
                    student.EnrollmentNumber = txtNumInsc.Text;
                    student.Email = txtMail.Text;
                    student.IPAddress = "exp";
                    student.ModifiedDate = DateTime.UtcNow;

                    studentRepository.Insert(student);
                }                
                else
                {
                    studentRepository.Update(student);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
