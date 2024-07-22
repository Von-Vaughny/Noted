namespace Noted
{
    public class Note
    {

        public required TimeStamps Time_stamps { get; set; }

        public required string Message { get; set; }

        public Label? Label { get; set; }

        public override string ToString() // CURRENT STRING ONLY FOR TESTING
        {
            return $"Creation Date: {Time_stamps.Creation_date}\nModified Date: {Time_stamps.Modified_date}\nAlert Date: {Time_stamps.Alert_date}\n\n" +
                $"{Message}\n\n".TrimStart();
        }

    }
}
