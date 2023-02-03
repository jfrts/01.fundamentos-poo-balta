namespace Balta.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }

        public Course(string title, string url, string tag, IList<Module> modules) : base(title, url)
        {
            Tag = tag;
            Modules = modules;
        }
    }
}