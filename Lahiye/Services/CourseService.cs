using Lahiye.Enum;
using Lahiye.Interface;
using Lahiye.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lahiye.Services
{
    internal class CourseService:ICourseService
    {
        public List<Group> groups = new List<Group>();
        public List<Group> Groups => groups;

        public void AllStudentList()
        {
            throw new NotImplementedException();
        }

        public void CreatedStudent()
        {
            
        }

        public void CreatGroup(Category cat, bool isonline)
        {
            throw new NotImplementedException();
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

        public void IsOnline(bool isonline, int limit)
        {
            throw new NotImplementedException();
        }

        public void NewGroup()
        {
            throw new NotImplementedException();
        }
    }
}
