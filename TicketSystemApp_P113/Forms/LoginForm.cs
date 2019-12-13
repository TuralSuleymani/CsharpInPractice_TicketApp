using System;
using System.Windows.Forms;
using TicketSystemApp_P113.Core;
using TicketSystemApp_P113.Extensions;
using TicketSystemApp_P113.Infrastructure;
using TicketSystemApp_P113.Models;
using TicketSystemApp_P113.Models.ViewModels;

namespace TicketSystemApp_P113.Forms
{
    public partial class LoginForm : Form
    {
        private readonly ISession _session;
        public LoginForm()
        {
            InitializeComponent();
            _session = FormSession.GetInstance();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoginModel lg = this.MapDataToModel<LoginModel>("txbx_");

            if (this.IsValid(lg, lbl_error))
            {
                User currentUser = null;

                using (TicketsDbContext tdc = new TicketsDbContext())
                {
                    currentUser = tdc.Users.GetUser(lg);
                }

                if (currentUser != null)
                { 
                    _session.AddUserToSession(currentUser);
                    this.RedirectTo<MainForm>();
                }
            }
        }
    }
}
