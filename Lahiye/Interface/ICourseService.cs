using Lahiye.Enum;
using Lahiye.Student_Classi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lahiye.Interface
{
    interface ICourseService
    {
        //public List<Group> Groups { get; }

        public void CreatGroup(Category cat, bool isonline);

        public void NewGroup();

        public void GroupList();

        public void EditGroup();

        public void GroupListStudents();

        public void AllStudentList();

        public void CreatedStudent();

        public void IsOnline(bool isonline, int limit);
    }
}
