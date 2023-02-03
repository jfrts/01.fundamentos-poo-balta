namespace Balta.ContentContext
{
    public class Career : Content
    {
        public IList<Course> Courses { get; set; }

        public Career(string title, string url, IList<Course> courses) : base(title, url)
        {
            Courses = courses;
        }
    }
}