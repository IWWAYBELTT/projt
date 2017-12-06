using CF.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudRepository.LanguageExtensions
{
    public static class BindingSourceExtensions
    {
        public static Int64 StudentIdentifier(this BindingSource sender)
        {
            return ((Student)sender.Current).Id;
        }
        public static string FirstName(this BindingSource sender)
        {
            return ((Student)sender.Current).FirstName;
        }
    }
}
