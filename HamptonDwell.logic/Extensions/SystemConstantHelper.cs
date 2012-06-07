
using EBS.HamptonDwell.Web.Admin;
using EBS.HamptonDwell.Web.Logic.Services.SystemConstants;

namespace EBS.HamptonDwell.Web.Logic.Extensions
{
    public class SystemConstantHelper
    {
        public static string GetSystemConstantValueByName(string name)
        {
            SystemConstantResponse response = new SystemConstantResponse();
            using (SystemConstantServiceClient client = new SystemConstantServiceClient())
            {
                response = client.GetSystemConstantByName(new SystemConstantRequest()
                {
                    Name = name,
                    SortBy =  SortBy.Name

                });

                client.Close();
            }
            if (response != null && response.SystemConstant != null)
            {
                return response.SystemConstant.ConstantValue;
            }
            return string.Empty;
        }
        public static string SaveSystemConstantValueByName(SystemConstantEventArgs eventArgs)
        {
            SystemConstantResponse response = new SystemConstantResponse();
            using (SystemConstantServiceClient client = new SystemConstantServiceClient())
            {
                response = client.SaveSystemConstantByName(new SystemConstantRequest()
                {
                    Name = eventArgs.Name,
                    ConstantValue = eventArgs.ConstantValue,
                    ModifiedByUserId = SystemConstantHelper.SystemUser,
                    SortBy = SortBy.Name

                });

                
                client.Close();
            }
            if (response != null && response.SystemConstant != null)
            {
                
            }
            return string.Empty;
        }
       
        public  static int SystemUser
        {
            get { return -1;  }
        }
    }
}
