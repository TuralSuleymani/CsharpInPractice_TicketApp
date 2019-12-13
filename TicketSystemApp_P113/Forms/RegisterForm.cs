using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystemApp_P113.Core;
using TicketSystemApp_P113.Extensions;
using TicketSystemApp_P113.Infrastructure;
using TicketSystemApp_P113.Models;

namespace TicketSystemApp_P113.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly ISession _session;
        public RegisterForm()
        {
            InitializeComponent();
            _session = FormSession.GetInstance();
            //this is main Form.. Let's store it in session
            _session.SetForm(this);
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            User user = this.MapDataToModel<User>("txbx_")
                                             .WithDefaults();
            bool hasUser = true;

            if (this.IsValid(objectToValidate: user,errorsOn: lbl_error))
            {
                TicketsDbContext tdc = null;
                try
                {
                     tdc = new TicketsDbContext();
                    {
                        if (!tdc.Users.HasUser(user.Email))
                        {
                            tdc.Users.Add(user);
                            tdc.SaveChanges();
                            hasUser = false;
                        }
                    }
                    if (hasUser)
                        MessageBox.Show("This user already exists!");
                }
                catch(Exception exp)
                {
                    //TODO: write to log
                    MessageBox.Show(exp.Message);
                }
                finally
                {
                    tdc.Dispose();
                }
                
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
        }
    }
}
