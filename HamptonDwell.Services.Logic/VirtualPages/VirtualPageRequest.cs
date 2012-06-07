using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace EBS.HamptonDwell.Services.VirtualPages
{
    public class VirtualPageRequest
    {


        [DataMember]
        public int? MemberOf { get; set; }
        [DataMember]
        public int? PageTemplate { get; set; }
        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public string PageContent { get; set; }
        [DataMember]
        public string PageName { get; set; }

        [DataMember]
        public string PageTitle { get; set; }

        [DataMember]
        public string MetaDescription { get; set; }

        [DataMember]
        public string Keywords { get; set; }
      
        [DataMember]
        public int? CreatedByUserId { get; set; }

        [DataMember]
        public int? ModifiedByUserId { get; set; }

        [DataMember]
        public int VirtualPageId { get; set; }
        [DataMember]
        public string FirstLetter { get; set; }
        [DataMember]
        public bool Active { get; set; }
        [DataMember]
        public bool IsTemplate { get; set; }
        [DataMember]
        public SortBy SortBy { get; set; }
        [DataMember]
        public SortDirection SortDirection { get; set; }
        [DataMember]
        public int StartRowIndex { get; set; }
        [DataMember]
        public int MaximumRows { get; set; }

        public VirtualPageRequest()
        {
            SortDirection = SortDirection.NONE;
            SortBy = SortBy.PageName;
        }



    }
    [DataContract(Namespace = "Services.VirtualPages")]
    public enum SortBy
    {
        [EnumMemberAttribute]
        PageName = 1,
        [EnumMemberAttribute]
        Email = 2
    }
    [DataContract(Namespace = "Services.VirtualPages")]
    public enum SortDirection
    {
        [EnumMemberAttribute]
        ASC,
        [EnumMemberAttribute]
        DESC,
        [EnumMemberAttribute]
        NONE
    }
}
