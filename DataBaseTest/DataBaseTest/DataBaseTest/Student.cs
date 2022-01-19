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

        public int ID { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Group { get; set; }

        public double AvgGrade { get; set; }

        public string Email { get; set; }

        public Student()
        {

        }

    }
}
