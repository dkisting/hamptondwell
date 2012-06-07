using System.Collections.Generic;
using HamptonDwell.Web.Logic.Domain;

namespace HamptonDwell.Web.Logic.Views.Models
{
    public class BreadcrumbModel
    {
        public List<BreadcrumbValue> BreadcrumbValues { get; set; }

        public BreadcrumbModel()
        {
            BreadcrumbValues = new List<BreadcrumbValue>();
        }

    }
}
