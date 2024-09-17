using SkiaSharp;

namespace Noted
{
    public static class TestData
    {

        public static List<Note> GenerateNoteList()
        {

            var notesList = new List<Note>();

            var label_1 = new Label {
                Name = "Appointments",
                Color = SKColors.Red,
            };

            var N1 = new Note
            {
                AccessTimes = new TimeStamps
                {
                    CreationDateTime = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now,
                    NotifyDateTime = DateTime.Now.AddDays(3)
                },
                Message = "Dentist (321 Norse Drive) on 3/27 @ 1400",
                Label = label_1
            }; 

            notesList.Add(N1);

            var N2 = new Note
            {
                AccessTimes = new TimeStamps
                {
                    CreationDateTime = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now.AddHours(2),
                    NotifyDateTime = DateTime.Now.AddSeconds(20)
                },
                Message = "hello world"
            };

            notesList.Add(N2);

            var N3 = new Note
            {
                AccessTimes = new TimeStamps
                {
                    CreationDateTime = DateTime.Now,
                    LastModifiedDateTime = DateTime.Now.AddMinutes(2),
                    NotifyDateTime = DateTime.Now.AddMinutes(3)
                },
                Message = """
                    Possible Locations: 
                    Greece
                    Costa Rica
                    """
            };

            notesList.Add(N3);

            return notesList;
        }

        public static List<Notification> GenerateNotificationList()
        { 
        
            var notes = GenerateNoteList();
            var notificationList = new List<Notification>();

            foreach (var note in notes)
            {
                var notification = new Notification
                {       
                    NotifyDateTime = note.AccessTimes.NotifyDateTime,
                    Message = note.Message
                };
                notificationList.Add(notification);
            }

            return notificationList;
        }
    }
}
