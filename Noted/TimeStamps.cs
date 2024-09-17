
namespace Noted
{
    public class TimeStamps
    {
        private DateTime _creationDateTime;

        public required DateTime CreationDateTime
        { 
            get { return _creationDateTime; }
            set { _creationDateTime = value; }
        }

        private DateTime _lastModifiedDateTime;

        public required DateTime LastModifiedDateTime 
        { 
            get { return _lastModifiedDateTime; }   
            set { _lastModifiedDateTime = value; }  
        }

        private DateTime _notifyDateTime;

        public required DateTime NotifyDateTime 
        { 
            get { return _notifyDateTime; }
            set { _notifyDateTime = value; }
        }   
    } 
}
