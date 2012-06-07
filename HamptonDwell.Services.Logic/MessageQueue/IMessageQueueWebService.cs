using System.ServiceModel;

namespace EBS.HamptonDwell.Services.MessageQueues
{
    public interface IMessageQueueWebService
    {
        string GetSearchResults(string jsonData);
        int CreateEmailQueue(string jsonData);
        
    }
}

