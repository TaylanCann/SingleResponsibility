using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityUsingFalse
{
   
    public class AddUser
    {
        public bool addUserToDb(User user)
        {
            // Check user datas
            if (!IsUserDatasOK(user))
                return false;

            // Add
            return true;
        }

        private bool IsUserDatasOK(User user)
        {
            // Check user datas
            return true;
        }
    }

    public class User
    {
        public string Name { get; set; }
    }
}
