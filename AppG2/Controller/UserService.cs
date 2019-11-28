using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppG2.Model;

namespace AppG2.Controller
{
    class UserService
    {
        public static User getLogin(string pathUserFileName, string user_name, string pass)
        {
            if (File.Exists(pathUserFileName))
            {
                var lines = File.ReadAllLines(pathUserFileName);
                foreach (var line in lines)
                {
                    if (!line.Equals(""))
                    {
                        var rs = line.Split(new char[] { '#' });
                        User us = new User
                        {
                            id = rs[0],
                            userName = rs[1],
                            password = rs[2]
                        };
                        if (us.userName.Equals(user_name) && us.password.Equals(pass))
                        {
                            return us;
                        }
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
