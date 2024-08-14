namespace Noted
{
    public class Note
    {
        private TimeStamps? _accessTimes;

        public required TimeStamps AccessTimes
        {
            get { return _accessTimes!; }
            set { _accessTimes = value; }
        }

        private string? _message;

        public required string Message
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

                Creation Date: {AccessTimes.CreationDate}
                Modified Date: {AccessTimes.ModifiedDate}
                Alert Date: {AccessTimes.AlertDate}

                Message: 
                
                {Message}


                """;
        }
    }
}
