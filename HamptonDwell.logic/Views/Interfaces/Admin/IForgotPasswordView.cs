using System;
using HamptonDwell.Web.Logic.Views.Models;
using WebFormsMvp;

namespace HamptonDwell.Web.Logic.Views
{
    public interface IForgotPasswordView : IView<ForgotPasswordModel>
    {
        event EventHandler<RecoveringPasswordEventArgs> RecoveringPassword;
    }

    public class RecoveringPasswordEventArgs : EventArgs
    {
        public string Username { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
        public int UserID { get; set; }
    }
}
