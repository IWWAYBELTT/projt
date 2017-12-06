using CF.Data;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAddNew_Click(object sender, EventArgs e)
        {
            AddNewStudent();
        }

        private void AddNewStudent()
        {
            Student student = new Student();
            EditorForm f = new EditorForm(student);
            try
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    //blProducts.Add(product);
                    //blProducts.ResetBindings();
                    //dataGridView1.Sort(dataGridView1.Columns["ProductName"], ListSortDirection.Ascending);
                }
            }
            finally
            {
                f.Dispose();
            }
        }
    }
}
