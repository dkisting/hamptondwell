using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using EBS.HamptonDwell.Web.Logic.Extensions;
using EBS.HamptonDwell.Web.Logic.Presenters;
using EBS.HamptonDwell.Web.Logic.Services.SystemConstants;
using EBS.HamptonDwell.Web.Logic.Services.VirtualPages;
using HamptonDwell.Web.Logic.Presenters.FrontEnd;
using HamptonDwell.Web.Logic.Views.Interfaces.FrontEnd;
using SortBy = EBS.HamptonDwell.Web.Logic.Services.VirtualPages.SortBy;

namespace EBS.HamptonDwell.Web.FrontEnd
{
    public class FrontEndHomeControllerPresenter : HamptonDwellPresenter<IFrontEndHomeController>
    {
        private string htmlDirectory;
        private readonly IFrontEndHomeController _view;
        public FrontEndHomeControllerPresenter(IFrontEndHomeController view) : this(view, null) { }
        public FrontEndHomeControllerPresenter(IFrontEndHomeController view, SystemConstantService systemConstantService)
            : base(view)
        {
            _view = view;
            view.ControlLoad += new EventHandler<FrontEndHomeControllerEventArgs>(view_ControlLoad);
        }

        void view_ControlLoad(object sender, FrontEndHomeControllerEventArgs e)
        {
            htmlDirectory = e.HTMLDirectory;
            if (File.Exists(htmlDirectory + @"\" + e.PageName + ".htm") == false)
            {
                _view.Model.PageOutput = "File Not Found";
            }

            try
            {
                _view.Model.PageOutput = GetControlPageContent(e.HTMLDirectory, e.PageName);
                _view.Model.PageOutput = AddDynamicContent(_view.Model.PageOutput);


                VirtualPageResponse response = new VirtualPageResponse();
                using (VirtualPageServiceClient client = new VirtualPageServiceClient())
                {
                    response = client.GetVirtualPageByPath(new VirtualPageRequest()
                    {
                        Path = e.PageName.Replace("_", "?"),
                        SortBy = SortBy.PageName
                    });

                    if (response != null && response.VirtualPage != null)
                    {
                        _view.Model.PageKeywords = new List<string>() { (response.VirtualPage.Keywords ?? string.Empty).Replace(";", ",") };
                        _view.Model.MetaDescription = response.VirtualPage.MetaDescription;
                        _view.Model.PageTitle = response.VirtualPage.PageTitle;
                    }
                    client.Close();
                }
            }
            catch (Exception ex)
            {

                _view.Model.PageOutput = ex.Message;
            }



        }
        private string GetControlPageContent(string htmlDirectory, string pageName)
        {

            using (StreamReader sr = new StreamReader(htmlDirectory + @"\" + pageName + ".htm"))
            {
                string _output = sr.ReadToEnd();
                return AddDynamicContent(_output);

            }
            return string.Empty;
        }
        /// <summary>
        /// this will real-time insert constant values
        /// </summary>
        /// <param name="pageContent"></param>
        /// <returns></returns>
        private string AddDynamicContent(string pageContent)
        {
            string pattern = @"\[(?<myMatch>([^\]])*)\]";
            Regex r = new Regex(pattern);
            MatchCollection m = r.Matches(pageContent);

            foreach (Match match in m)
            {
                string item = match.Groups["myMatch"].Value;

                string templateType = "";
                string templateValue;

                if (item.IndexOf('.') > 0)
                {
                    templateType = item.Substring(0, item.IndexOf('.'));
                    templateValue = item.Substring(item.IndexOf('.') + 1,
                        item.Length - item.IndexOf('.') - 1);
                }
                else
                    templateValue = item;
                string queryString = "";

                if (templateValue.IndexOf('?') >= 0)
                {
                    queryString = templateValue.Substring(templateValue.IndexOf('?'));
                    templateValue = templateValue.Replace(queryString, string.Empty);
                }

                switch (templateType.ToLower())
                {
                    case "constant":
                        pageContent = pageContent.Replace("[" + item + "]", SystemConstantHelper.GetSystemConstantValueByName(templateValue));
                        break;
                    case "control":
                        pageContent= pageContent.Replace("[" + item + "]", GetControlPageContent(htmlDirectory, templateValue));
                        break;


                }
            }
            return pageContent;
        }


    }
}
