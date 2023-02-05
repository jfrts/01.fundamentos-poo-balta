namespace Balta.NotificationContext
{
    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public void Add(Notification notification)
        {
            if (notification == null) return;

            Notifications.Add(notification);
        }

        public void AddRange(IEnumerable<Notification> notifications)
        {
            if (notifications == null) return;

            Notifications.AddRange(notifications);
        }
    }
}