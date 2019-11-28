using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class Contacts
    {
        public string idContacts { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string idUser { get; set; }
        public string key
        {
            get
            {
                var keys = "";
                if (name != null)
                    keys = name.Substring(0, 1);
                else
                    keys = "";
                return keys;
            }
        }
    }
}
