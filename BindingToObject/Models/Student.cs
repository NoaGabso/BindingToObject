using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToObject.Models
{
    internal class Student
    {
        public string Name { get; set; }    
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }
        private DateTime cuurentDate;
        public DateTime CuurentDate { get { return cuurentDate; } set { cuurentDate= value; } }
        public int Age { get => (int)(CuurentDate - BirthDate).TotalDays / 365; }
        public Student()
        { CuurentDate =DateTime.Now; }
        

    }
}
