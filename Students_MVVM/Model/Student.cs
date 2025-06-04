using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_MVVM
{
    internal class Student: INotifyPropertyChanged
    {
        private string name;
        private string group;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Name { 
            get => name; 
            set => name = value; 
        }
        public string Group { 
            get { return group; } 
            set { group = value; } 
        }

        public Student(string name = "", string group = "")
        {
            this.name = name;
            this.group = group;
        }
    }
}
