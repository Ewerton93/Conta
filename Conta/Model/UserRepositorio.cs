using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conta.WebApp.Model
{
    public static class UserRepositorio
    {

        public static User Get(string email, string password) {

            var users = new List<User>();
            users.Add(new User { Id = 1, Email = "flash@flash.com", UserName = "flash", Password = "flash", Role = "gestor" });
            users.Add(new User { Id = 1, Email = "cisco@flash.com", UserName = "cisco", Password = "cisco", Role = "funcionario" });

            return users.FirstOrDefault(s => s.Email.ToLower() == email.ToLower() && s.Password.ToLower() == password.ToLower());

        }
    }
}
