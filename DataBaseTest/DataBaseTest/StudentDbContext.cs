using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;

namespace DataBaseTest
{
    public class StudentDbContext : DbContext
    {
        private DbSet<Student> students;

        public DbSet<Student> Students {
            get { return students; }
            set { students = value; }
        }

        public StudentDbContext() : base("myDatabase")
        {

        }
    }
}
