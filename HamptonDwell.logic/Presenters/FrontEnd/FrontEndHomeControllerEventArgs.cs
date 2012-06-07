using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HamptonDwell.Web.Logic.Presenters.FrontEnd
{
    public class FrontEndHomeControllerEventArgs : EventArgs
    {
        public string PageName { get; set; }
        public string HTMLDirectory { get; set; }
    }
}
