using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class HistoryLearning
    {
        [Key]
        public string idHistoryLearning { set; get; }
        public int yearFrom { set; get; }
        public int yearEnd { set; get; }
        public string address { set; get; }
        public string idStudent { set; get; }

        public string period
        {
            get
            {
                return string.Format("{0} -> {1}", yearFrom, yearEnd);
            }
        }
    }
}
