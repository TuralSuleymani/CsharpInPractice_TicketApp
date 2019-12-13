using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemApp_P113.Infrastructure;
using TicketSystemApp_P113.Models;
using TicketSystemApp_P113.Models.ViewModels;

namespace TicketSystemApp_P113.Core
{
   public static class TicketExtensions
    {
        public static Ticket WithDefaults(this Ticket ticket)
        {
            ticket.CreatedBy = FormSession.GetInstance().Get<UserModel>("user").Id;
            ticket.CreatedDate = DateTime.Now;
            return ticket;
        }
    }
}
