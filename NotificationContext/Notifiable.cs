namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }
        public bool IsValid => !(Notifications.Any());

        protected Notifiable()
        {
            Notifications = new List<Notification>();
        }

        public void AddNotification(Notification notification)
        {
            if (notification == null) return;

            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            if (notifications == null) return;

            Notifications.AddRange(notifications);
        }
    }
}