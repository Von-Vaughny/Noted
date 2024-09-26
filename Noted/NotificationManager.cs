namespace Noted
{
    public class NotificationManager
    {

        private List<Notification> _notifications = []; 
  
        public void AddNotification(Notification notification) 
        { 
            _notifications.Add(notification);
        }

        public List<Notification> GetAllNotifications()
        {
            return _notifications;
        }

        public List<Notification> GetTodaysNotifications() 
        {
            return _notifications.Where(n => n.TimeStamp.Date == DateTime.Today).ToList();
        }

        public async void StartBackgroundMonitoring() 
        {
            await Task.Run(() => MonitorTodaysNotifications());
        }

        private async Task MonitorTodaysNotifications() 
        { 
            var todaysNotifications = GetTodaysNotifications();
            foreach (var notificaiton in todaysNotifications) 
            { 
                MonitorNotification(notificaiton);
            }
            await Task.Delay(TimeSpan.FromMinutes(1));
        }

        private async static void MonitorNotification(Notification notification) 
        {
            // Calculate the time until the notification's timestamp time.
            TimeSpan delay = notification.TimeStamp - DateTime.Now;

            if (delay > TimeSpan.Zero)
            {
                // Wait until the notifications timestamp time.
                await Task.Delay(delay);
            }
            TriggerNotification(notification);
        }

        private static void TriggerNotification(Notification notification) 
        {
            Console.WriteLine(notification);
            // Method to reschedule
        }

    }
}
