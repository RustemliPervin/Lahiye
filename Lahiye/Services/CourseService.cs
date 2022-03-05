using Lahiye.Enum;
using Lahiye.Interface;
using Lahiye.Student_Classi;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lahiye.Services
{
    class CourseService : ICourseService
    {
        private List<Group> _group = new List<Group>();
        public List<Group> Groups => _group;

        public Category Category { get; private set; }

        public void AllStudentList()
        {
            throw new NotImplementedException();
        }

        public void CreatedStudent()
        {
            throw new NotImplementedException();
        }

        public Group CreatGroup(Category cat, int limit, List<Student> students)
        {
            Category = cat;
            limit = limit;
            students = students;
        }

        public void EditGroup()
        {
            throw new NotImplementedException();
        }

        public void GroupList()
        {
            throw new NotImplementedException();
        }

        public void GroupListStudents()
        {
            throw new NotImplementedException();
        }

        public void NewGroup()
        {
            throw new NotImplementedException();
        }
    }
}
