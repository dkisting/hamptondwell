using System;


namespace EBS.HamptonDwell.Web.Admin
{
    public class SystemConstantEventArgs : EventArgs
    {
        public int SystemConstantId { get; set; }
        public string Name { get; set; }
        public string ConstantValue { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
