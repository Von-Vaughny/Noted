namespace Noted
{
    public class Notification
    {

        private DateTime _timeStamp;

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private string? _message;

        public  string Message
        {
            get { return _message!; }
            set { _message = value; }
        }

        private bool _isRead;

        public bool IsRead 
        { 
            get { return _isRead; }
            set { _isRead = value; }
        }

        public NotificationType NotificationType { get; set; }

        private Note? _note;

        public Note Note 
        { 
            get { return _note!; }
            set { _note = value; }
        }

        public override string ToString() // REWRITE FOR NOTIFICATION
        {

            return $"""
                This is a notification for the following message at {TimeStamp}:

                {Message}

                """;
        }
    }
}
