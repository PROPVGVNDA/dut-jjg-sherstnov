using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    delegate bool StudentPredicateDelegate(Student student);
    internal class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public static bool IsAdult(Student student)
        {
            return student.age >= 18;
        }

        public static bool FirstNameStartsWithA(Student student)
        {
            return student.firstName[0] == 'A';
        }

        public static bool LastNameGreater(Student student)
        {
            return student.lastName.Length > 3;
        }
    }
}
