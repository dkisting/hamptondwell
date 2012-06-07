
using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EBS.HamptonDwell.Services.Data;

using System.ServiceModel.Web;
using EBS.HamptonDwell.Services.Extensions;
using EBS.HamptonDwell.Services.SystemConstants;
using EBS.HamptonDwell.Services.VirtualPages;

namespace EBS.HamptonDwell.Services.MessageQueues
{
    [ServiceContract(Namespace = "ebsWebServices")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class MessageQueueWebService : IMessageQueueWebService
    {
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public int CreateEmailQueue(string inputData)
        {

            MessageQueueResponse response = new MessageQueueResponse();
            using (var context = new hamptondwellEntities())
            {


                MessageQueue messageQueue = new MessageQueue();

                messageQueue.ModifiedBy_UserID = -1;
                messageQueue.Active = true;
                messageQueue.Status_MessageQueueStatusID = -1;
                messageQueue.MessageResponse = string.Empty;

                if (messageQueue.MessageQueueID == 0)
                {
                    messageQueue.CreatedOn = DateTime.UtcNow;
                    messageQueue.CreatedBy_UserID = -1;
                    messageQueue.OccurredOn = DateTime.UtcNow;
                    messageQueue.Type_MessageQueueTypeID = -1;
                    messageQueue.MessageBody = inputData;

                }
                messageQueue.ModifiedOn = DateTime.UtcNow;

                if (messageQueue.MessageQueueID == 0)
                    context.AddObject("MessageQueues", messageQueue);

                context.SaveChanges();
            }
            return 1;
        }
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        public string GetSearchResults(string inputData)
        {
            SearchResultList searchResults = new SearchResultList();
            DateTime searchBegin = DateTime.UtcNow;

            string frontEndFileLocation =
                SystemConstantHelper.GetSystemConstantByName(new SystemConstantRequest() { Name = "Front End Map Path" }).
                    SystemConstant.ConstantValue;

            TimeSpan searchDuration = (DateTime.UtcNow - searchBegin);

            searchResults.SearchDuration = (decimal)searchDuration.TotalSeconds;
            searchResults.SearchResults = new List<SearchResult>();

            SearchCriteriaObject searchCriteriaObject =
                           JSONHelper.Deserialize<SearchCriteriaObject>(inputData);

            if (searchCriteriaObject != null)
            {

                searchResults.SearchResults = GetSearchResults(searchCriteriaObject.SearchCriteria, frontEndFileLocation);
            }
            return JSONHelper.Serialize(searchResults);


        }

        private List<SearchResult> GetSearchResults(string criteria, string mapPath)
        {
            List<SearchResult> results = new List<SearchResult>();
            DirectoryInfo di = new DirectoryInfo(mapPath + "\\HTML");

            if (di.Exists == false)
                return results;

            foreach (FileInfo fi in di.GetFiles("*.htm"))
            {
                string pageText = File.ReadAllText(fi.FullName).HtmlStrip();
                pageText = pageText.ReplaceConstants();
                pageText = pageText.ReplaceControls();

                if (pageText.ToLower().IndexOf(criteria.ToLower()) >= 0 && fi.Name.IndexOf("=") > 0)
                {
                    VirtualPageResponse pageResponse = fi.Name.VirtualPage() ?? new VirtualPageResponse();
                    pageResponse.VirtualPage = pageResponse.VirtualPage ?? new VirtualPageObject();

                  
                        results.Add(new SearchResult()
                                        {
                                            BodyText = pageText,
                                            ModifiedOn = fi.LastWriteTimeUtc.ToShortDateString(),
                                            PageName = pageResponse.VirtualPage.PageName,
                                            PageTitle = pageResponse.VirtualPage.PageTitle
                                        });
                    
                }

            }

            return results;
        }
    }
}
