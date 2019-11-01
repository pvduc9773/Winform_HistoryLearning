using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class Student
    {
        public string idStudent { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public GENDER gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string placeOfBirth { get; set; }

        public ICollection<HistoryLearning> historyLearnings { get; set; }
    }

    public enum GENDER
    {
        Male, Female, Other
    }
}
