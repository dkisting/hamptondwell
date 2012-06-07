using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EBS.HamptonDwell.Services.Data;
using EBS.HamptonDwell.Services.SystemConstants;

namespace EBS.HamptonDwell.Services.Extensions
{
    public class SystemConstantHelper
    {
        public static SystemConstantResponse GetSystemConstantByName(SystemConstantRequest request)
        {
            SystemConstantResponse response = new SystemConstantResponse();
            using (var context = new hamptondwellEntities())
            {
                var systemConstant = context.SystemConstants.
                    Where(u => u.Active == true && u.Name == request.Name).FirstOrDefault();
                if (systemConstant != null)
                {
                    response.SystemConstant = new SystemConstantObject()
                    {
                        SystemConstantId = systemConstant.SystemConstantID,
                        Active = systemConstant.Active,
                        ConstantValue = systemConstant.ConstantValue,
                        CreatedByUserId = systemConstant.CreatedBy_UserID,
                        ModifiedByUserId = systemConstant.ModifiedBy_UserID,
                        Name = systemConstant.Name,
                        ModifiedOn = systemConstant.ModifiedOn,
                        CreatedOn = systemConstant.CreatedOn
                    };

                }
                response.SystemConstant = response.SystemConstant ?? new SystemConstantObject();
            }
            return response;
        }
    }
}
