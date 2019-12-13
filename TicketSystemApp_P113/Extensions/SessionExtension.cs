using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystemApp_P113.Core;
using TicketSystemApp_P113.Infrastructure;
using TicketSystemApp_P113.Models;
using TicketSystemApp_P113.Models.ViewModels;

namespace TicketSystemApp_P113.Extensions
{
   public static class SessionExtension
    {
        public static void AddUserToSession(this ISession session,User currentUser)
        {
            session.Set("user", new UserModel
            {
                Email = currentUser.Email,
                Name = currentUser.Name,
                Id = currentUser.Id
            });
        }

        public static UserModel GetUserFromSession(this ISession formSession)
        {
           return formSession.Get<UserModel>("user");
        }
        public static void EmptyUser(this ISession formSession)
        {
            formSession.Clear<string>("user");
        }
        public static Form GetForm(this ISession formSession)
        {
           return (formSession as FormSession).GetForm();
        }
        public static void SetForm(this ISession formSession,Form form)
        {
             (formSession as FormSession).SetForm(form);
        }
    }
}
