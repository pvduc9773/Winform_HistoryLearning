using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    class AppG2Context : DbContext
    {
        public AppG2Context() : base("Data Source=.;Initial Catalog=DB_G2;Persist Security Info=True;User ID=sa;Password=123")
        { 

        }

        public DbSet<Student> StudentsDbSet { get; set; }
        public DbSet<HistoryLearning> HistoryLearningsDbSet { get; set; }
    }
}
