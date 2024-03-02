using System;
using System.Collections.Generic;

namespace DAL
{
    public class UserRepo : IUser
    {
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUser> GetAllEmpInfo()
        {
            throw new NotImplementedException();
        }

        public IUser GetUserInfo(string EmailId)
        {
            throw new NotImplementedException();
        }

        public void Insert(IUser userInfo)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(IUser user)
        {
            throw new NotImplementedException();
        }

        public bool ValidateUserLogin(string user, string pass)
        {
            throw new NotImplementedException();
        }
    }
}
