
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace EBS.HamptonDwell.Services.SystemConstants
{
   [DataContract(Namespace = "Services.SystemConstants")]
    public class SystemConstantResponse
    {
        [DataMember]
        public SystemConstantObject SystemConstant { get; set; }
        [DataMember]
        public IList<SystemConstantObject> SystemConstantList { get; set; }

        [DataMember]
        public int ResultSetCount { get; set; }
    }

    public class SystemConstantObject
    {
        [DataMember]
        public int SystemConstantId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string ConstantValue { get; set; }

        [DataMember]
        public string CreatedBy { get; set; }

        [DataMember]
        public string ModifiedBy { get; set; }

        [DataMember]
        public int CreatedByUserId { get; set; }

        [DataMember]
        public int ModifiedByUserId { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public DateTime ModifiedOn { get; set; }

        [DataMember]
        public bool Active { get; set; }

    }
}
