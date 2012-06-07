using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;


namespace EBS.HamptonDwell.Services.Users
{
    public class UserRequest
    {
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public int CreatedBy { get; set; }
        [DataMember]
        public int ModifiedBy { get; set; }
        [DataMember]
        public string FirstLetter { get; set; }
        [DataMember]
        public bool Active { get; set; }
        [DataMember]
        public SortBy SortBy { get; set; }
        [DataMember]
        public SortDirection SortDirection { get; set; }
        [DataMember]
        public int StartRowIndex { get; set; }
        [DataMember]
        public int MaximumRows { get; set; }

        public UserRequest()
        {
            SortDirection = SortDirection.NONE;
            SortBy = SortBy.LastName;
        }



    }
    [DataContract(Namespace = "Services.Users")]
    public enum SortBy
    {
        [EnumMemberAttribute]
        LastName = 1,
        [EnumMemberAttribute]
        FirstName = 2,
        [EnumMemberAttribute]
        Email = 3
    }
    [DataContract(Namespace = "Services.Users")]
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
