using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ServiceLayer
{
    public interface IUserService
    {
        bool IsValidUser(string emailAddress, string password);
        User GetByEmailAddress(string emailAddress);
    }

    public class UserService : IUserService
    {
        public bool IsValidUser(string emailAddress, string password)
        {
            throw new NotImplementedException();
        }
        public User GetByEmailAddress(string emailAddress) 
        {
            throw new NotImplementedException();
        }


    }
}
