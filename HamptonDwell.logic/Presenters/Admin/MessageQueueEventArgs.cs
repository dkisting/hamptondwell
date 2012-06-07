using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace EBS.HamptonDwell.Web.Logic.Presenters.Admin
{

    [DataContract(Namespace = "MessageQueueList")]
    public class MessageQueueList
    {

        [DataMember]
        public IList<MessageQueueEventArgs> MessageQueueEventArgsList { get; set; }

        [DataMember]
        public string UpdatedMessageQueue { get; set; }

    }
    [DataContract(Name = "MessageQueueEventArgs")]
    public class MessageQueueEventArgs
    {
        
        [DataMember]
        public string PageName { get; set; }
        [DataMember]
        public List<string> ImageList { get; set; }
        [DataMember]
        public string ConvertedMessageBody { get; set; }
        [DataMember]
        public string ServerName { get; set; }
        
    }
    [DataContract(Namespace = "Services.ContactFormMessageQueue")]
    public class ContactFormMessageQueue
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Message { get; set; }


    }

}
