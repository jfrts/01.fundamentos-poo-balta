using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public Plan(string title, decimal price)
        {
            Title = title;
            Price = price;
        }
    }
}