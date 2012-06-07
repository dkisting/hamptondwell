using System;
using EBS.HamptonDwell.Web.Logic.Extensions;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Services.Users;
using HamptonDwell.Web.Logic.Presenters.Admin;
using HamptonDwell.Web.Logic.Views.Interfaces.Admin;


namespace EBS.HamptonDwell.Web.Admin
{
    public class UserEditPresenter : HamptonDwellPresenter<IUserEditView>
    {
        private readonly IUserEditView _view;
        readonly UserService _userService;
        public UserEditPresenter(IUserEditView view) : this(view, null) { }
        public UserEditPresenter(IUserEditView view, UserService userService)
            : base(view)
        {

            _view = view;

            _view.ControlLoad += new EventHandler<UserEventArgs>(_view_ControlLoad);
            _view.Save += new EventHandler<UserEventArgs>(_view_Save);

        }

        void _view_Save(object sender, UserEventArgs e)
        {
            try
            {
                UserResponse response = new UserResponse();
                using (UserServiceClient client = new UserServiceClient())
                {
                    response = client.Save(new UserRequest()
                    {
                        UserId = e.UserId,
                        Email = e.Email,
                        LastName = e.LastName,
                        FirstName = e.FirstName,
                        CreatedBy = GetCurrentLoggedInUserId(),
                        ModifiedBy = GetCurrentLoggedInUserId(),
                        Active = e.Active,
                        Password = string.IsNullOrEmpty(e.Password) == false ? e.Password.Encrypt() : string.Empty,
                        SortBy = SortBy.LastName
                    });

                    _view.Model.UserObject = response.User;


                    client.Close();
                }
            }
            catch (Exception ex)
            {
                
                _view.Model.ErrorMessages.Add(ex.Message);
            }
        }

        void _view_ControlLoad(object sender, UserEventArgs e)
        {
            try
            {

                UserResponse response = new UserResponse();
                if (e.UserId > 0)
                {
                    using (UserServiceClient client = new UserServiceClient())
                    {
                        response = client.GetUserById(new UserRequest()
                                                          {
                                                              UserId = e.UserId,
                                                              SortBy = SortBy.LastName
                                                          });

                        _view.Model.UserObject = response.User;


                        client.Close();
                    }
                }
                _view.Model.UserObject = _view.Model.UserObject ?? new UserObject();
            }
            catch (Exception ex)
            {
                _view.Model.ErrorMessages.Add(ex.Message);
            }
        }

    
            


    }
}
