
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace EBS.HamptonDwell.Services.Users
{
   [DataContract(Namespace = "Services.Users")]
    public class UserResponse
    {
        [DataMember]
        public UserObject User { get; set; }
        [DataMember]
        public IList<UserObject> UserList { get; set; }

        [DataMember]
        public int ResultSetCount { get; set; }
    }

    public class UserObject
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Password { get; set; }

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
