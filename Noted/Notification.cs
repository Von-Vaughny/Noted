namespace Noted
{
    public class Notification
    {

        private DateTime _alertDate;

        public required DateTime AlertDate 
        {  
            get { return _alertDate; } 
            set { _alertDate = value; } 
        }

        private string? _message;

        public required string Message 
        { 
            get { return _message!; } 
            set { _message = value; } 
        }

        public override string ToString() // REWRITE FOR NOTIFICATION
        {

            return $"""
                You have a notification for the following message at {AlertDate}:

                {Message}

                """;
        }
    }
}
