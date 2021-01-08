using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace FBIOperation
{
    public class Person : INotifyPropertyChanged
    {
        string name;
        string surname;
        int age;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Surname"));
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
