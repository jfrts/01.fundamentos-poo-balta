namespace Balta.ContentContext
{
    public class Career : Content
    {
        public IList<CareerItem> Items { get; set; }
        public int NumberOfCourses => Items.Count;

        public Career(string title, string url, IList<CareerItem> items) : base(title, url)
        {
            Items = items;
        }
    }
}