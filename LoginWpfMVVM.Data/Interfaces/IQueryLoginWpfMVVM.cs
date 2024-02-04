using LoginWpfMVVM.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWpfMVVM.Data.Interfaces
{
    public interface IQueryLoginWpfMVVM
    {
        bool AddNewUser(LoginUser user);

        bool AuthenticateUser(LoginUser user);


    }
}
