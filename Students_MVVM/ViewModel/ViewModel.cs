using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_MVVM
{
    internal class ViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public ObservableCollection<Student> Students { get; set; }


        public ViewModel()
        {
            myStudents();
        }

        public void myStudents()
        {
            Students = new ObservableCollection<Student>();

            /*var s1 = new Student("Иван", "05-805");
            var s2 = new Student("Мария", "05-808");
            var s3 = new Student("Женя", "05-801");

            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);*/

            Student s = new Student() { Name = "123", Group = "456" };
            Students.Add(s);

            //return students;
        }
    }
}
