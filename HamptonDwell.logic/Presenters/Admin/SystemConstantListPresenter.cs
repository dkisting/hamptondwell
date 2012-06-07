using System;
using System.Collections.Generic;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;

using EBS.HamptonDwell.Web.Logic.Services.SystemConstants;


namespace EBS.HamptonDwell.Web.Admin
{
    public class SystemConstantListPresenter : HamptonDwellPresenter<ISystemConstantList>
    {
        private readonly ISystemConstantList _view;
        readonly SystemConstantService _systemConstantService;
        public SystemConstantListPresenter(ISystemConstantList view) : this(view, null) { }
        public SystemConstantListPresenter(ISystemConstantList view, SystemConstantService systemConstantService)
            : base(view)
        {

            _view = view;
            
            _view.ControlLoad += new EventHandler<Admin.SystemConstantEventArgs>(_view_ControlLoad);
            _systemConstantService = systemConstantService;

        }

        void _view_ControlLoad(object sender, Admin.SystemConstantEventArgs e)
        {
            try
            {

                SystemConstantResponse response = new SystemConstantResponse();
                using (SystemConstantServiceClient client = new SystemConstantServiceClient())
                {
                    response = client.GetSystemConstantList(new SystemConstantRequest()
                    {
                        SystemConstantId = e.SystemConstantId,
                        MaximumRows = 100,
                        Active = true,
                        SortBy = SortBy.CreatedOn
                    });

                    _view.Model.SystemConstantList = response.SystemConstantList;

                    
                    client.Close();
                }
                _view.Model.SystemConstantList = _view.Model.SystemConstantList ?? new List<SystemConstantObject>();
            }
            catch (Exception)
            {
                throw;
            }
        }

    
            


    }
}
