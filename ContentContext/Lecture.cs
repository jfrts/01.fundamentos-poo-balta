using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }

        public Lecture(int order, string title, int durationInMinutes)
        {
            Order = order;
            Title = title;
            DurationInMinutes = durationInMinutes;
        }
    }
}