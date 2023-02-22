using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BindingToObject.Models
{
    internal class Student:INotifyPropertyChanged
    {
        public string Name { get; set; }    
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }
        private DateTime cuurentDate;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime CuurentDate { get { return cuurentDate; } set { cuurentDate= value; OnPropertyChanged("CuurentDate"); } }
        public int Age { get => (int)(CuurentDate - BirthDate).TotalDays / 365; }
        public Student()
        { CuurentDate =DateTime.Now; }
        public void OnPropertyChanged(string name)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
