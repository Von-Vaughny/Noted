namespace Noted
{
    public class Notification
    {

        private DateTime _notifyDateTime;

        public required DateTime NotifyDateTime
        {
            get { return _notifyDateTime; }
            set { _notifyDateTime = value; }
        }

        private string? _message;

        public required string Message
        {
            get { return _message!; }
            set { _message = value; }
        }

        public Notification() 
        {
           
            // Start notification in the background
            Task.Run(() => StartNotificationAsync());
        }

        private async Task StartNotificationAsync() 
        {
            
            var delay = NotifyDateTime - DateTime.Now;

            if (delay.TotalMilliseconds > 0)
            {
                // Await asynchronously until the notification time
                await Task.Delay(delay);
                Notify();
            }
            
            if (delay.TotalMilliseconds > 0)
            {
                // Alert notification has passed. Set new notification time.
            }
        }

        private void Notify()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString() // REWRITE FOR NOTIFICATION
        {

            return $"""
                This is a notification for the following message at {NotifyDateTime}:

                {Message}

                """;
        }
    }
}
