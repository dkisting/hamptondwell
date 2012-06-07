

namespace EBS.HamptonDwell.Web.Logic.Views.Interfaces.FrontEnd
{
    interface INode
    {
        Node[] LoadAllFromConfig { get; }
    }
    public class Node
    {
        private string _url;
        private string _rewrite;

        public Node(string url, string rewrite)
        {
            _url = url;
            _rewrite = rewrite;
        }
        public string url
        {
            get { return _url; }
        }
        public string rewrite
        {
            get { return _rewrite; }
        }
    }
}
