using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;


namespace EBS.HamptonDwell.Services.Users
{

    [ServiceContract(
        Name = "UserService",
        Namespace = "urn:localhost/Users")]
    public interface IUserService
    {
        [OperationContract(
            Action = "GetUserById",
            ReplyAction = "GetUserResponse")]
        [FaultContract(
            typeof(UserFault),
            Name = "UserFault",
            Namespace = "UserFault",
            Action = "")]
        UserResponse GetUserById(UserRequest request);

        [OperationContract(
      Action = "GetUser",
      ReplyAction = "GetUserResponse")]
        [FaultContract(
            typeof(UserFault),
            Name = "UserFault",
            Namespace = "UserFault",
            Action = "")]
        UserResponse GetUser(UserRequest request);

        [OperationContract(
            Action = "GetUserList",
            ReplyAction = "GetUserResponse")]
        [FaultContract(
            typeof(UserFault),
            Name = "UserFault",
            Namespace = "UserFault",
            Action = "")]
        UserResponse GetUserList(UserRequest request);

        [OperationContract(
           Action = "SaveUser",
           ReplyAction = "SaveUser")]
        [FaultContract(
            typeof(UserFault),
            Name = "UserFault",
            Namespace = "UserFault",
            Action = "")]
        UserResponse Save(UserRequest request);
    }
}

