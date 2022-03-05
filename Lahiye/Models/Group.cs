using Lahiye.Enum;
using Lahiye.Student_Classi;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lahiye.Models
{
    internal class Group
    {
        public static int count = 100;
        public string No;
        public Category Cat;
        public bool IsOnline;
        public int Limit;
        public List<Student> Students ;

        public Group(Category cat, int limit, List<Student> students)
        {
            switch (cat)
            {
                case Category.Programming:
                    No = $"P-{count}";
                    break;
                case Category.Design:
                    No = $"D-{count}";
                    break;
                case Category.System_Administration:
                    No = $"SA-{count}";
                    break;
                default:
                    break;
            }
            Cat = cat;
            count++;
        }
    }
}
