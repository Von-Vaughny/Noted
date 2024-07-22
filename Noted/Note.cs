namespace Noted
{
    public class Note
    {
        private TimeStamps? _timeStamps;

        public required TimeStamps TimeStamps 
        {
            get { return _timeStamps!; }
            set { _timeStamps = value; } 
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
            return $"Creation Date: {TimeStamps.CreationDate}\nModified Date: {TimeStamps.ModifiedDate}\nAlert Date: {TimeStamps.AlertDate}\n\n" +
                $"{Message}\n\n".TrimStart();
        }

    }
}
