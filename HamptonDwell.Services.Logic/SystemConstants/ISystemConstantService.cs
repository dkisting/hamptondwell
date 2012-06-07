using System.ServiceModel;

namespace EBS.HamptonDwell.Services.SystemConstants
{

    [ServiceContract(
        Name = "SystemConstantService",
        Namespace = "urn:localhost/SystemConstants")]
    public interface ISystemConstantService
    {
        [OperationContract(
            Action = "GetSystemConstantRequest",
            ReplyAction = "GetSystemConstantResponse")]
        [FaultContract(
            typeof(SystemConstantFault),
            Name = "SystemConstantFault",
            Namespace = "SystemConstantFault",
            Action = "")]
        SystemConstantResponse GetSystemConstantById(SystemConstantRequest request);

        [OperationContract(
         Action = "GetSystemConstantByName",
         ReplyAction = "GetSystemConstantResponse")]
        [FaultContract(
            typeof(SystemConstantFault),
            Name = "SystemConstantFault",
            Namespace = "SystemConstantFault",
            Action = "")]

        SystemConstantResponse GetSystemConstantByName(SystemConstantRequest request);

        [OperationContract(
            Action = "GetSystemConstantList",
            ReplyAction = "GetSystemConstantResponse")]
        [FaultContract(
            typeof(SystemConstantFault),
            Name = "SystemConstantFault",
            Namespace = "SystemConstantFault",
            Action = "")]
        SystemConstantResponse GetSystemConstantList(SystemConstantRequest request);

        [OperationContract(
           Action = "SaveSystemConstant",
           ReplyAction = "SaveSystemConstant")]
        [FaultContract(
            typeof(SystemConstantFault),
            Name = "SystemConstantFault",
            Namespace = "SystemConstantFault",
            Action = "")]
        SystemConstantResponse Save(SystemConstantRequest request);

        [OperationContract(
         Action = "SaveSystemConstantByName",
         ReplyAction = "SaveSystemConstantByName")]
        [FaultContract(
            typeof(SystemConstantFault),
            Name = "SystemConstantFault",
            Namespace = "SystemConstantFault",
            Action = "")]
        SystemConstantResponse SaveSystemConstantByName(SystemConstantRequest request);
    }
}

