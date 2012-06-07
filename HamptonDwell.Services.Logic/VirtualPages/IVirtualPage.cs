using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;


namespace EBS.HamptonDwell.Services.VirtualPages
{

    [ServiceContract(
        Name = "VirtualPageService",
        Namespace = "urn:localhost/VirtualPages")]
    public interface IVirtualPageService
    {
        [OperationContract(
            Action = "GetVirtualPageRequest",
            ReplyAction = "GetVirtualPageResponse")]
        [FaultContract(
            typeof(VirtualPageFault),
            Name = "VirtualPageFault",
            Namespace = "VirtualPageFault",
            Action = "")]
        VirtualPageResponse GetVirtualPageById(VirtualPageRequest request);

        [OperationContract(
          Action = "GetVirtualPageByPath",
          ReplyAction = "GetVirtualPageResponse")]
        [FaultContract(
            typeof(VirtualPageFault),
            Name = "VirtualPageFault",
            Namespace = "VirtualPageFault",
            Action = "")]
        VirtualPageResponse GetVirtualPageByPath(VirtualPageRequest request);

        [OperationContract(
            Action = "GetVirtualPageList",
            ReplyAction = "GetVirtualPageResponse")]
        [FaultContract(
            typeof(VirtualPageFault),
            Name = "VirtualPageFault",
            Namespace = "VirtualPageFault",
            Action = "")]
        VirtualPageResponse GetVirtualPageList(VirtualPageRequest request);

        [OperationContract(
            Action = "GetVirtualPageTemplates",
            ReplyAction = "GetVirtualPageResponse")]
        [FaultContract(
            typeof(VirtualPageFault),
            Name = "VirtualPageFault",
            Namespace = "VirtualPageFault",
            Action = "")]
        VirtualPageResponse GetVirtualPageTemplates(VirtualPageRequest request);

        [OperationContract(
         Action = "GetVirtualPageParents",
         ReplyAction = "GetVirtualPageResponse")]
        [FaultContract(
            typeof(VirtualPageFault),
            Name = "VirtualPageFault",
            Namespace = "VirtualPageFault",
            Action = "")]
        VirtualPageResponse GetVirtualPageParents(VirtualPageRequest request);

        [OperationContract(
           Action = "SaveVirtualPage",
           ReplyAction = "SaveVirtualPage")]
        [FaultContract(
            typeof(VirtualPageFault),
            Name = "VirtualPageFault",
            Namespace = "VirtualPageFault",
            Action = "")]
        VirtualPageResponse Save(VirtualPageRequest request);

        [OperationContract(
          Action = "SaveKeywords",
          ReplyAction = "SaveKeywords")]
        [FaultContract(
            typeof(VirtualPageFault),
            Name = "VirtualPageFault",
            Namespace = "VirtualPageFault",
            Action = "")]
        VirtualPageResponse SaveKeywords(VirtualPageRequest request);
    }
}

