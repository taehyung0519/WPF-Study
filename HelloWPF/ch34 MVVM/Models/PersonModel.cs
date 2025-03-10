using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch34_MVVM.Models
{
    public class PersonModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler != null) handler(this, new PropertyChangedEventArgs(name));
        }
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value;
            OnPropertyChanged("Name");}
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
    }
}
