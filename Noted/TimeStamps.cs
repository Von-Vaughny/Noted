
namespace Noted
{
    public class TimeStamps
    {
        private DateTime _creationDate;

        public required DateTime CreationDate
        { 
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        private DateTime _modifiedDate;

        public required DateTime ModifiedDate 
        { 
            get { return _modifiedDate; }   
            set { _modifiedDate = value; }  
        }

        private DateTime _alertDate;

        public required DateTime AlertDate 
        { 
            get { return _alertDate; }
            set { _alertDate = value; }
        }   
    } 
}
