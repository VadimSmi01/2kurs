using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseTest
{
    public class Student
    {
        private int id;
        private string name;
        private string lastname;
        private string group;
        private double avgGrade;
        private string email;

        public int Id { get { return id; } set { id = value; } }

        public string Name { get { return name; } set { name = value; } }

        public string LastName { get { return lastname; } set { lastname = value; } }

        public string Group { get { return group; } set { group = value; } }

        public double AvgGrade { get { return avgGrade; } set { avgGrade = value; } }

        public string Email { get { return email; } set { email = value; } }

        public Student()
        {

        }
        public Student(int ids)
        {
            id = ids;
        }

    }
}
