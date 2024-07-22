using System.Drawing;

namespace Noted
{
    public static class TestData
    {

        public static List<Note> GenerateNoteList()
        {

            var notesList = new List<Note>();

            var label_1 = new Label {
                Name = "Appointments",
                Color = Color.Red
            };

            var N1 = new Note
            {
                TimeStamps = new TimeStamps
                {
                    CreationDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AlertDate = DateTime.Now.AddDays(3)
                },
                Message = "Dentist (321 Norse Drive) on 3/27 @ 1400",
                Label = label_1
            }; 

            notesList.Add(N1);

            var N2 = new Note
            {
                TimeStamps = new TimeStamps
                {
                    CreationDate = DateTime.Now,
                    ModifiedDate = DateTime.Now.AddHours(2),
                    AlertDate = DateTime.Now.AddDays(3)
                },
                Message = "hello world"
            };

            notesList.Add(N2);

            var N3 = new Note
            {
                TimeStamps = new TimeStamps
                {
                    CreationDate = DateTime.Now,
                    ModifiedDate = DateTime.Now.AddMinutes(2),
                    AlertDate = DateTime.Now.AddMinutes(3)
                },
                Message = "Possible Locations: \nGreece\nCosta Rica\n"
            };

            notesList.Add(N3);

            return notesList;
        }
    }
}
