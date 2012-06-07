
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace EBS.HamptonDwell.Services.VirtualPages
{
   [DataContract(Namespace = "Services.VirtualPages")]
    public class VirtualPageResponse
    {
        [DataMember]
        public VirtualPageObject VirtualPage { get; set; }
        [DataMember]
        public IList<VirtualPageObject> VirtualPageList { get; set; }

        [DataMember]
        public int ResultSetCount { get; set; }
    }

    public class VirtualPageObject
    {
        [DataMember]
        public int VirtualPageId { get; set; }

        [DataMember]
        public int MemberOf { get; set; }
        [DataMember]
        public int PageTemplate { get; set; }
        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public string PageContent { get; set; }
        [DataMember]
        public string MetaDescription { get; set; }
        [DataMember]
        public string PageTitle { get; set; }
        [DataMember]
        public string Keywords { get; set; }
        [DataMember]
        public string PageName { get; set; }

        [DataMember]
        public bool IsTemplate { get; set; }
        [DataMember]
        public bool Active { get; set; }

        [DataMember]
        public int CreatedByUserId { get; set; }

        [DataMember]
        public int ModifiedByUserId { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public DateTime ModifiedOn { get; set; }

    }
}
