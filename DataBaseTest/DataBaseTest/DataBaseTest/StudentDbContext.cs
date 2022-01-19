using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DataBaseTest
{
    public class StudentDbContext
    {
        private List<Student> students;

        public List<Student> Students { get; set; }
    }
}
