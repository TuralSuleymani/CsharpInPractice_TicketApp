using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemApp_P113.Models;

namespace TicketSystemApp_P113.Core
{
   public static class UserExtensions
    {
        public static User WithDefaults(this User registeredUser)
        {
            registeredUser.InvalidTry = default;
            registeredUser.IsActive = true;
            registeredUser.RegisterDate = DateTime.Now;
            registeredUser.RoleType = default;
            return registeredUser;
        }
    }
}
