using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public bool IsPremium => Subscriptions.Any(subscription => subscription.IsActive);

        public Student(string name, string email, User user)
        {
            Name = name;
            Email = email;
            User = user;
            Subscriptions = new List<Subscription>();
        }
    }
}