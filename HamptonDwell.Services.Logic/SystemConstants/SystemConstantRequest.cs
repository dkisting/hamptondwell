using System.Runtime.Serialization;


namespace EBS.HamptonDwell.Services.SystemConstants
{
    public class SystemConstantRequest
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string ConstantValue { get; set; }
        [DataMember]
        public int? CreateByUserId { get; set; }
        [DataMember]
        public int ModifiedByUserId { get; set; }
        [DataMember]
        public int SystemConstantId { get; set; }
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

        public SystemConstantRequest()
        {
            SortDirection = SortDirection.NONE;
            SortBy = SortBy.Name;
        }



    }
    [DataContract(Namespace = "Services.SystemConstants")]
    public enum SortBy
    {
        [EnumMemberAttribute]
        Name = 1,
        [EnumMemberAttribute]
        ModifiedOn = 2,
        [EnumMemberAttribute]
        CreatedOn = 3
    }
    [DataContract(Namespace = "Services.SystemConstants")]
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
