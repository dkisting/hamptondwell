using System;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Services.Users;
using HamptonDwell.Web.Logic.Views;


namespace HamptonDwell.Web.Logic.Presenters
{
    public class ForgotPasswordPresenter : HamptonDwellPresenter<IForgotPasswordView>
    {
        readonly UserService _userService;
        public ForgotPasswordPresenter(IForgotPasswordView view) : this(view, null) { }
        public ForgotPasswordPresenter(IForgotPasswordView view, UserService userService)
            : base(view)
        {

         

            view.RecoveringPassword += new EventHandler<RecoveringPasswordEventArgs>(view_RecoveringPassword);
            //_view = view;
            //_view.Load += Load;
            //_view.RecoveringPassword += RecoveringPassword;

        }

        void view_RecoveringPassword(object sender, RecoveringPasswordEventArgs e)
        {
            UserResponse response = new UserResponse();

            using (UserServiceClient client = new UserServiceClient())
            {
                response = client.GetUserById(new UserRequest()
                {
                    UserId = e.UserID
                });

                HttpContext.Response.Write(response.User.Email);
                client.Close();
            }
        }
    }
}
