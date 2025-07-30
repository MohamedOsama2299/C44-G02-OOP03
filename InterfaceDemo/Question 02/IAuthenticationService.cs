using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Question_02
{
    internal interface IAuthenticationService
    {

        void AuthenticateUser(string username, string password);
        void AuthorizeUser(string username, string Role);
    }
}
