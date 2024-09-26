namespace Noted
{
    public class Note
    {

        private TimeStamps? _accessTimes;

        public TimeStamps AccessTimes
        {
            get { return _accessTimes!; }
            set { _accessTimes = value; }
        }

        private string? _message;

        public string Message
        {
            get { return _message!; }
            set { _message = value; }
        }

        private Label? _label;

        public Label? Label
        {
            get { return _label; }
            set { _label = value; }
        }

        public override string ToString() // CURRENT STRING ONLY FOR TESTING
        {
            string labelName = "No Label";
            if (Label != null)
                labelName = Label.Name;

            return $"""
                {labelName}

                Creation Date: {AccessTimes.CreationDateTime}
                Last Modified Date: {AccessTimes.LastModifiedDateTime}
                Notify Date: {AccessTimes.NotifyDateTime}            

                Message: 
                
                {Message}


                """;
        }
    }
}
