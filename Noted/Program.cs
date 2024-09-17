namespace Noted
{
    class Program
    {
        static void Main(string[] args)
        {
            var NotesList = TestData.GenerateNoteList();
            foreach (var note in NotesList) {
                Console.WriteLine(note);
            }

            var NotificationList = TestData.GenerateNotificationList();
            foreach (var notification in NotificationList) {
                Console.WriteLine(notification);
                }

            while (true)
            {

                Console.WriteLine("Enter note: ");
                Console.ReadLine();

            }
        
        }

    }
}



