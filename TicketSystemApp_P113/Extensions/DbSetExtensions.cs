using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemApp_P113.Models;

namespace TicketSystemApp_P113.Core
{
   public static class DbSetExtensions
    {
        public static bool HasUser(this DbSet<User> usersSet, string email)
        {
            User user = usersSet
                             .Where(x => x.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                               .FirstOrDefault();

            return user == null ? false : true;
        }
        public static bool HasUser(this DbSet<User> usersSet, LoginModel lg)
        {
           User user = usersSet.Where(x => x.Email.Equals(lg.Email, StringComparison.OrdinalIgnoreCase)
                             && x.Password.Equals(lg.Password, StringComparison.OrdinalIgnoreCase))
                            .FirstOrDefault();

            return user == null ? false : true;
        }

        public static User GetUser(this DbSet<User> usersSet, LoginModel lg)
        {
            User user = usersSet.Where(x => x.Email.Equals(lg.Email, StringComparison.OrdinalIgnoreCase)
                              && x.Password.Equals(lg.Password, StringComparison.OrdinalIgnoreCase))
                             .FirstOrDefault();

            return user;
        }
    }
}
