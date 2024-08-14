using Noted;

var notes = TestData.GenerateNoteList();

foreach (var note in notes)
{
    Console.WriteLine(note);
}

var notifications = TestData.GenerateNotificationList();

foreach (var notification in notifications)
{
    if (notification.AlertDate.Date.Equals(DateTime.Now.Date) && DateTime.Compare(notification.AlertDate, DateTime.Now) > 0)
    {
        Console.WriteLine(notification);
    }
}