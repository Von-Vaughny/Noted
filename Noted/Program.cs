using System.Security.Cryptography;

namespace Noted
{
    class Program
    {
        static void Main(string[] args)
        {

            var NotificationManager = new NotificationManager();

            var NotesList = TestData.GenerateNoteList();
            foreach (var note in NotesList) {
                Console.WriteLine(note);
            }

            var NotificationList = TestData.GenerateNotificationList();
            foreach (var notification in NotificationList) {
                Console.WriteLine(notification);    
                NotificationManager.AddNotification(notification);
            }
            NotificationManager.StartBackgroundMonitoring();

            while (true)
            {
                var N1 = NotesList[1];
                Console.WriteLine(N1);

                Console.WriteLine("Change note 1: ");
                var newMessage = Console.ReadLine();



            }

        }

    }
}



