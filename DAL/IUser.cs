using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUser
    {
        IEnumerable<IUser> GetAllEmpInfo();
        void Save();
        void Insert(IUser userInfo);
        void Delete(string id);
        void Update(IUser user);
        IUser GetUserInfo(string EmailId);
        bool ValidateUserLogin(string user, string pass);
    }
}
