using System;
using System.Collections.Generic;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Services.Users;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using HamptonDwell.Web.Logic.Presenters.Admin;



namespace EBS.HamptonDwell.Web.Admin
{
    public class UserListPresenter : HamptonDwellPresenter<IUserList>
    {
        private readonly IUserList _view;
        readonly UserService _userService;
        public UserListPresenter(IUserList view) : this(view, null) { }
        public UserListPresenter(IUserList view, UserService userService)
            : base(view)
        {

            _view = view;

            _view.ControlLoad += new EventHandler<UserEventArgs>(_view_ControlLoad);
            

        }

        void _view_ControlLoad(object sender, UserEventArgs e)
        {
            try
            {

                UserResponse response = new UserResponse();
                
                using (UserServiceClient client = new UserServiceClient())
                {
                    response = client.GetUserList(new UserRequest()
                    {
                        UserId = e.UserId,
                        Active = true,
                        MaximumRows = 100,
                        SortBy = SortBy.LastName
                    });

                    _view.Model.UserObjects = response.UserList;

                    
                    client.Close();
                }
                _view.Model.UserObjects = _view.Model.UserObjects ?? new List<UserObject>();
            }
            catch (Exception)
            {
                throw;
            }
        }

    
            


    }
}
