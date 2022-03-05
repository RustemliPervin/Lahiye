using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiye.Student_Classi
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public int GroupNo;
        public bool Type;

        public Student(string name, string surname, int groupno)
        {
            Name = name;
            Surname = surname;
            GroupNo = groupno;
            Type = false;
        }

    }
}
