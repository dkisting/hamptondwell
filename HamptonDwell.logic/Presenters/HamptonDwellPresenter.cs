using WebFormsMvp;
using System.Web;

namespace EBS.HamptonDwell.Web.Logic.Presenters
{
    public class HamptonDwellPresenter<TView> : Presenter<TView> where TView : class, IView
    {
        public HamptonDwellPresenter(TView view) : base(view) { }

        public string _applicationBaseUrl;

        public string ApplicationBaseUrl
        {
            get
            {

                if (_applicationBaseUrl == null)
                    _applicationBaseUrl = string.Format("{0}://{1}{2}/", Request.Url.Scheme, Request.Url.Host, HttpRuntime.AppDomainAppVirtualPath);

                return _applicationBaseUrl;

            }
            set { _applicationBaseUrl = value; }
        }
        protected int GetCurrentLoggedInUserId()
        {
            int userId = 0;
            int.TryParse(HttpContext.User.Identity.Name, out userId);
            return userId;
        }
    }
}
