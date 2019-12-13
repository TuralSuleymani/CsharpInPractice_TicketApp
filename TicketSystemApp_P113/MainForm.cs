using System;
using System.Windows.Forms;
using TicketSystemApp_P113.Core;
using TicketSystemApp_P113.Extensions;
using TicketSystemApp_P113.Infrastructure;
using TicketSystemApp_P113.Models;
using TicketSystemApp_P113.UserControls;
namespace TicketSystemApp_P113
{
    public partial class MainForm : Form
    {
        private readonly int _initialSize;
        private const string CONTROLNAME = "ct";
        private readonly ISession _session;
        public MainForm()
        {
            InitializeComponent();
            #region default initialization
            _initialSize = this.Size.Height;
            _session = FormSession.GetInstance();
            lbl_welcome.Text += _session.GetUserFromSession().Name;
            #endregion
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _session.EmptyUser();
            this.RedirectTo(_session.GetForm());
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RemoveControl(CONTROLNAME);

            CreateTicketUserControl control = this.AddUserControlToForm<CreateTicketUserControl>(CONTROLNAME);
            control.btn_createTicket.Click += Btn_createTicket_Click;

            this.ExtendHeightTo(_initialSize);
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveControl(CONTROLNAME);

            ListTicketUserControl control = this.AddUserControlToForm<ListTicketUserControl>(CONTROLNAME);
            this.ExtendHeightTo(_initialSize + 200);

            control.btn_updateTicket.Click += Btn_updateTicket_Click;
        }

        private void _RemoveControlFromForm(Control control)
        {
            if (control != null)
            {
                this.Controls.Remove(control);
                this.Refresh();
            }

        }

        private void Btn_createTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = this.MapDataToModel<Ticket>("txbx_")
                                     .WithDefaults();

            using (TicketsDbContext t = new TicketsDbContext())
            {
                t.Tickets.Add(ticket);
                t.SaveChanges();

            }

            MessageBox.Show("SuccessFully added");
        }



        private void RemoveControl(string controlName)
        {
            UserControl control = this.FindControl<UserControl>(x => x.Tag.ToString().Equals(controlName));
            
            _RemoveControlFromForm(control);
        }

        private void Btn_updateTicket_Click(object sender, EventArgs e)
        {

        }
    }
}
