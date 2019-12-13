using System;
using System.Windows.Forms;
using TicketSystemApp_P113.Core;

namespace TicketSystemApp_P113.Infrastructure
{
    public class FormSession : InMemorySession
    {
        private Form _form;
        public void SetForm(Form form)
        {
            _form = form;
        }
        private static FormSession _formSession;
        private FormSession() { }
        public static FormSession GetInstance()
        {
            if (_formSession == null)
                _formSession = new FormSession();
            return _formSession;
        }
        public Form GetForm()
        {
            return _form;
        }

    }
}
