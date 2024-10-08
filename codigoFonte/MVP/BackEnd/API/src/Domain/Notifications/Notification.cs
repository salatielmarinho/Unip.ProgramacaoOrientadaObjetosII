namespace API.Domain.Notifications
{
    public class Notification
    {
        public Notification(string propertyName, string message)
        {
            PropertyName = propertyName;
            Message = message;
        }

        public string PropertyName { get; private set; }
        public string Message { get; private set; }
    }
}