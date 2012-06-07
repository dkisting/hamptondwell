using System;
using System.Web;
using System.Web.Security;
using EBS.HamptonDwell.Web.Logic.Extensions;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Services.Users;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Views.Interfaces.Admin;


namespace EBS.HamptonDwell.Web.Admin
{
    public class LoginPresenter : HamptonDwellPresenter<ILoginView>
    {
        private readonly ILoginView _view;
        readonly UserService _userService;
        public LoginPresenter(ILoginView view) : this(view, null) { }
        public LoginPresenter(ILoginView view, UserService userService)
            : base(view)
        {

            _view = view;
            _view.Login += new EventHandler<UserEventArgs>(_view_Login);
            _view.ControlLoad += new EventHandler<UserEventArgs>(_view_ControlLoad);

        

        }

        void _view_ControlLoad(object sender, UserEventArgs e)
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                Response.Redirect("Home.aspx");
        }

        void _view_Login(object sender, UserEventArgs e)
        {
            try
            {
                UserResponse response = new UserResponse();
                using (UserServiceClient client = new UserServiceClient())
                {
                    response = client.GetUser(new UserRequest()
                    {
           
                        Email = e.Email,
          
                        SortBy = SortBy.LastName
                    });

                    client.Close();

                    if (response.User != null && response.User.Password.Decrypt() == e.Password)
                    {
                        HttpCookie ck = CreateTicket(response.User.UserId.ToString(), e.Email);
                        if (null != ck)
                        {
                            Response.Cookies.Add(ck);
                            ck.Expires = DateTime.Now.AddMinutes(60);
                            HttpContext.Response.Redirect("Home.aspx");
                        }
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static HttpCookie CreateTicket(string userid, string username)
        {
            HttpCookie ck = null;

            FormsAuthenticationTicket tick = new FormsAuthenticationTicket(0, userid, DateTime.Now, DateTime.Now.AddMinutes(60), false, username, FormsAuthentication.FormsCookiePath);
            string cipherText = FormsAuthentication.Encrypt(tick);
            if (null != cipherText)
            {
                ck = new HttpCookie(FormsAuthentication.FormsCookieName, cipherText);
                ck.Path = FormsAuthentication.FormsCookiePath;
                ck.Secure = false;
            }
            return ck;
        }
    }
}
