
namespace Noted
{
    public class TimeStamps
    {
        private DateTime _creationDateTime;

        public DateTime CreationDateTime
        { 
            get { return _creationDateTime; }
            set { _creationDateTime = value; }
        }

        private DateTime _lastModifiedDateTime;

        public DateTime LastModifiedDateTime 
        { 
            get { return _lastModifiedDateTime; }   
            set { _lastModifiedDateTime = value; }  
        }

        private DateTime _notifyDateTime;

        public DateTime NotifyDateTime 
        { 
            get { return _notifyDateTime; }
            set { _notifyDateTime = value; }
        }   
    } 
}
