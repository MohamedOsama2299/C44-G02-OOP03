using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InterfaceDemo.Question_02
{
    internal class BasicAuthenticationService : Client, IAuthenticationService
    {
        private User[] users = new User[]
               {
            new User { Username = "Ahmed", Password = "12345", Role = "Admin" },
            new User { Username = "Sara",  Password = "67890", Role = "User" },
            new User { Username = "Ali",   Password = "abcde", Role = "Guest" }
               };
        void IAuthenticationService.AuthenticateUser(string username, string password)
        {
            foreach (var user in users)
            {
              
                    if (user.Username == username && user.Password == password)
                    {
                    Console.WriteLine("Acess :)"); ; 
                    }
                }
            Console.WriteLine("Not Valid :("); ;
            }
        void IAuthenticationService.AuthorizeUser(string username, string role)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Role == role)
                {
                    Console.WriteLine("Authorization Successful :)");
                }
            }
            Console.WriteLine("Authorization Failed :( ");
        }
    }
}
