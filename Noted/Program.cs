using Noted;

var notes = TestData.GenerateNoteList();

foreach (var note in notes)
{
    Console.WriteLine(note);

}

var notifications = TestData.GenerateNotificationList();
var notificationsList = new List<Notification>();

int numOfNotificationsToday = 0, numOfNotificationsLeftToday = 0;

foreach (var notification in notifications) 
{ 
    if (notification.AlertDate.Date.Equals(DateTime.Now.Date))
    {
        numOfNotificationsToday++;
        if (DateTime.Compare(notification.AlertDate, DateTime.Now) > 0)
        {
            numOfNotificationsLeftToday++;
            notificationsList.Add(notification);
        }
    }
}

string notify = numOfNotificationsLeftToday > 1 ? "notification" : "notifications";

Console.WriteLine($"You have {numOfNotificationsLeftToday} {notify} remaining today.\n");

foreach (var notification in notificationsList)
{
    Console.WriteLine(notification);
}
