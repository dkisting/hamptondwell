using System;
using System.Text.RegularExpressions;


namespace EBS.HamptonDwell.Web.Logic.Extensions
{
    public class WebHelper
    {
        public static void GetImage(string value, string destinationFileName)
        {
            value = value.Replace('\\', '/').Trim();
            value = value.Replace("''", string.Empty);

            destinationFileName = destinationFileName.Replace('/', '\\').Trim();
            System.Net.WebClient wc = new System.Net.WebClient();

            try
            {
                byte[] imageDate = wc.DownloadData(value);
                if (imageDate != null && imageDate.Length > 0)
                    wc.DownloadFile(value, destinationFileName);
            }
            catch (Exception)
            {
            }
        }
        public static bool WriteHtmlPage(string fileLocation, string pageName, string content)
        {
            string fileName = fileLocation + pageName.Replace("?", "_") + ".htm";
            if (System.IO.File.Exists(fileName))
                System.IO.File.Delete(fileName);


            using (System.IO.StreamWriter sr = new System.IO.StreamWriter(fileName))
            {
                sr.Write(content);
            }
            return true;
        }
    }
}
