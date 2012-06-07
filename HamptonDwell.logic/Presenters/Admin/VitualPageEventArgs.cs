using System;


namespace EBS.HamptonDwell.Web.Logic.Presenters.Admin
{
    public class VirtualPagesEventArgs : EventArgs
    {
        public int VirtualPageId { get; set; }
        public string PageName { get; set; }
        public string Path { get; set; }
        public string PageTitle { get; set; }
        public string MetaDescription { get; set; }
        public string Keywords { get; set; }
        public bool Active { get; set; }
        public bool IsTemplate { get; set; }
        public string PageContent { get; set; }
        public int? MemberOf { get; set; }
        public int? PageTemplate { get; set; }
        public bool? Publish { get; set; }
        public DateTime? PublishOn { get; set; }

    }
}
