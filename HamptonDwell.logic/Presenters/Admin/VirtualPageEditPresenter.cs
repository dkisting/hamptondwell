using System;
using System.Text.RegularExpressions;
using EBS.HamptonDwell.Web.Logic.Extensions;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Presenters.Admin;
using EBS.HamptonDwell.Web.Logic.Services.VirtualPages;
using HamptonDwell.Web.Logic.Views.Interfaces.Admin;
using EBS.HamptonDwell.Web.Logic.Services.MessageQueues;
using System.Collections.Generic;
namespace EBS.HamptonDwell.Web.Admin
{
    public class VirtualPageEditPresenter : HamptonDwellPresenter<IVirtualPagesEditView>
    {
        private readonly IVirtualPagesEditView _view;
        readonly VirtualPageService _virtualPageService;
        public VirtualPageEditPresenter(IVirtualPagesEditView view) : this(view, null) { }
        public VirtualPageEditPresenter(IVirtualPagesEditView view, VirtualPageService virtualPageService)
            : base(view)
        {

            _view = view;

            _view.ControlLoad += new EventHandler<VirtualPagesEventArgs>(_view_ControlLoad);
            _view.Save += new EventHandler<VirtualPagesEventArgs>(_view_Save);



        }

        void _view_Save(object sender, VirtualPagesEventArgs e)
        {
            try
            {
                VirtualPageResponse response = new VirtualPageResponse();
                using (VirtualPageServiceClient client = new VirtualPageServiceClient())
                {
                    response = client.Save(new VirtualPageRequest()
                    {
                        VirtualPageId = e.VirtualPageId,
                        PageContent = e.PageContent,
                        MemberOf = e.MemberOf == 0 ? null : e.MemberOf,
                        PageTemplate = e.PageTemplate == 0 ? null : e.PageTemplate,
                        PageName = e.PageName,
                        Path = e.Path,
                        CreatedByUserId = GetCurrentLoggedInUserId(),
                        ModifiedByUserId = GetCurrentLoggedInUserId(),
                        Active = e.Active,
                        PageTitle = e.PageTitle,
                        MetaDescription = e.MetaDescription,
                        SortBy = SortBy.PageName,
                        IsTemplate = e.IsTemplate
                    });

                    _view.Model.VirtualPagesObject = response.VirtualPage;

                    response = client.SaveKeywords(new VirtualPageRequest()
                                                       {
                                                           VirtualPageId = response.VirtualPage.VirtualPageId,
                                                           Keywords = e.Keywords,
                                                           SortBy = SortBy.PageName,
                                                           CreatedByUserId = GetCurrentLoggedInUserId(),
                                                           ModifiedByUserId = GetCurrentLoggedInUserId()
                                                       });

                    _view.Model.VirtualPagesObject.Keywords = response.VirtualPage.Keywords;

                    if (e.Publish ?? false)
                    {
                        using (MessageQueueServiceClient messageClient = new MessageQueueServiceClient())
                        {
                            MessageQueueResponse queueResponse = new MessageQueueResponse();
                            MessageQueueRequest queueRequest = new MessageQueueRequest() {
                                MessageQueueId = 0,
                                
                                CreatedByUserId = GetCurrentLoggedInUserId(),
                                ModifiedByUserId = GetCurrentLoggedInUserId(),
                                Active = e.Active,
                                Type_MessageQueueTypeID =  -2,
                                Status_MessageQueueStatusID = -1,
                                MessageResponse = string.Empty,
                                OccurredOn =  e.PublishOn,
                                CreatedBy = string.Empty,
                                MessageBody = GenerateVirtualPage(_view.Model.VirtualPagesObject)
                                
                            };
                            queueResponse = messageClient.Save(queueRequest);


                        }

                        client.Close();
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        void _view_ControlLoad(object sender, VirtualPagesEventArgs e)
        {
            try
            {

                VirtualPageResponse response = new VirtualPageResponse();

                if (e.VirtualPageId > 0)
                {
                    using (VirtualPageServiceClient client = new VirtualPageServiceClient())
                    {
                        response = client.GetVirtualPageById(new VirtualPageRequest()
                                                                 {
                                                                     VirtualPageId = e.VirtualPageId,
                                                                     PageTemplate = e.PageTemplate,
                                                                     PageName = e.PageName,
                                                                     PageContent = e.PageContent,

                                                                     SortBy = SortBy.PageName
                                                                 });

                        _view.Model.VirtualPagesObject = response.VirtualPage;

                        response = client.GetVirtualPageParents(new VirtualPageRequest()
                        {
                            SortBy = SortBy.PageName,
                            Active = true,
                            MaximumRows = 1000
                        });

                        _view.Model.VirtualPageParents = response.VirtualPageList;

                        response = client.GetVirtualPageTemplates(new VirtualPageRequest()
                        {
                            SortBy = SortBy.PageName,
                            Active = true,
                            MaximumRows =  1000
                        });

                        _view.Model.VirtualPageTemplates = response.VirtualPageList;

                        client.Close();
                    }
                }
                _view.Model.VirtualPagesObject = _view.Model.VirtualPagesObject ?? new VirtualPageObject() { Active = true};
            }
            catch (Exception)
            {
                throw;
            }
        }

    
        private  string GenerateVirtualPage(VirtualPageObject pageObject)
        {
            string pageBody = pageObject.PageContent;
            MessageQueueList queueList = new MessageQueueList();
            
            MessageQueueEventArgs args = new MessageQueueEventArgs();
            args.PageName = pageObject.Path;
            args.ImageList = ImageList(pageObject);
            args.ConvertedMessageBody = pageBody;
            args.ServerName = SystemConstantHelper.GetSystemConstantValueByName("Server Name");
            queueList.MessageQueueEventArgsList = new List<MessageQueueEventArgs>();
            queueList.MessageQueueEventArgsList.Add(args);
            return JSONHelper.Serialize(queueList);

        }
        private List<string> ImageList(VirtualPageObject pageObject)
        {
            List<string> imageList = new List<string>();

            MatchCollection pageImages = Regex.Matches(pageObject.PageContent, "<img.+?src=[\"'](.+?)[\"'].+?>");
            foreach (Match match in pageImages)
            {
                MatchCollection imageTags = Regex.Matches(match.Value, "src=\"([^\"]+)");

                foreach (Match imageMatch in imageTags)
                {
                    imageList.Add(imageMatch.Value.Replace("src=", string.Empty));
                }
            }

            return imageList;
        }
            


    }
}
