using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityUsingTrue
{
    public class AddUser
    {
        private UserValidator userValidator = new UserValidator();

        public bool addUserToDb(User user)
        {
            // Check user datas
            if (!userValidator.IsUserDatasOK(user))
                return false;

            // Add
            return true;
        }
    }

    public class User
    {
    }
}
