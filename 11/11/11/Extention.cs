using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal static class Extention
    {
        public static List<Student> FindStudent(List<Student> students, StudentPredicateDelegate pred)
        {
            List<Student> result = new();
            foreach (Student student in students)
                if (pred(student)) result.Add(student);
            return result;
        }
    }
}
