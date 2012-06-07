using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HamptonDwell.Web.Logic.Presenters.Admin
{
    public class UserEventArgs : EventArgs
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
