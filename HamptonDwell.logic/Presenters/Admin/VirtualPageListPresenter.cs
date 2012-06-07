using System;
using System.Collections.Generic;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Presenters.Admin;
using EBS.HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using EBS.HamptonDwell.Web.Logic.Services.VirtualPages;


namespace EBS.HamptonDwell.Web.Admin
{
    public class VirtualPageListPresenter : HamptonDwellPresenter<IVirtualPageList>
    {
        private readonly IVirtualPageList _view;
        readonly VirtualPageService _userService;
        public VirtualPageListPresenter(IVirtualPageList view) : this(view, null) { }
        public VirtualPageListPresenter(IVirtualPageList view, VirtualPageService userService)
            : base(view)
        {

            _view = view;

            _view.ControlLoad += new EventHandler<VirtualPagesEventArgs>(_view_ControlLoad);
            

        }

        void _view_ControlLoad(object sender, VirtualPagesEventArgs e)
        {
            try
            {

                VirtualPageResponse response = new VirtualPageResponse();
                using (VirtualPageServiceClient client = new VirtualPageServiceClient())
                {
                    response = client.GetVirtualPageList(new VirtualPageRequest()
                    {
                        VirtualPageId = e.VirtualPageId,
                        Active = true,
                        MaximumRows = 100,
                        SortBy = SortBy.PageName
                    });

                    _view.Model.VirtualPageObjects = response.VirtualPageList;

                    
                    client.Close();
                }
                _view.Model.VirtualPageObjects = _view.Model.VirtualPageObjects ?? new List<VirtualPageObject>();
            }
            catch (Exception)
            {
                throw;
            }
        }

    
            


    }
}
