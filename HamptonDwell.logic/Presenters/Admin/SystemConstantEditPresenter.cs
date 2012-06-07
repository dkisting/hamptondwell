using System;
using EBS.HamptonDwell.Web.Admin;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Services.SystemConstants;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;


namespace EBS.HamptonDwell.Web.Admin
{
    public class SystemConstantEditPresenter : HamptonDwellPresenter<ISystemConstantEdit>
    {
        private readonly ISystemConstantEdit _view;
        readonly SystemConstantService _userService;
        public SystemConstantEditPresenter(ISystemConstantEdit view) : this(view, null) { }
        public SystemConstantEditPresenter(ISystemConstantEdit view, SystemConstantService userService)
            : base(view)
        {

            _view = view;
            _view.Save += new EventHandler<SystemConstantEventArgs>(_view_Save);
            _view.ControlLoad += new EventHandler<SystemConstantEventArgs>(_view_ControlLoad);
            

        }

        void _view_Save(object sender, SystemConstantEventArgs e)
        {
            try
            {
                SystemConstantResponse response = new SystemConstantResponse();
                using (SystemConstantServiceClient client = new SystemConstantServiceClient())
                {
                    response = client.Save(new SystemConstantRequest()
                    {
                        SystemConstantId = e.SystemConstantId,
                        ConstantValue = e.ConstantValue,
                        Name = e.Name,
                        Active = e.Active,
                        SortBy = SortBy.CreatedOn,
                        CreateByUserId = GetCurrentLoggedInUserId(),
                        ModifiedByUserId = GetCurrentLoggedInUserId()
                    });

                    _view.Model.SystemConstantObject = response.SystemConstant;


                    client.Close();
                }
            }
            catch (Exception ex)
            {
                
                _view.Model.ErrorMessages.Add(ex.Message);
            }
        }

        void _view_ControlLoad(object sender, SystemConstantEventArgs e)
        {
            try
            {

                SystemConstantResponse response = new SystemConstantResponse();
                using (SystemConstantServiceClient client = new SystemConstantServiceClient())
                {
                    response = client.GetSystemConstantById(new SystemConstantRequest()
                    {
                        SystemConstantId = e.SystemConstantId,
                        SortBy = SortBy.CreatedOn
                    });

                    _view.Model.SystemConstantObject = response.SystemConstant;

                    
                    client.Close();
                }
                _view.Model.SystemConstantObject = _view.Model.SystemConstantObject ?? new SystemConstantObject();
            }
            catch (Exception)
            {
                throw;
            }
        }

    
            


    }
}
