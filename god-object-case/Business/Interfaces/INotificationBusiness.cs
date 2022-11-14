namespace God_Object.Business.Interfaces
{
    public interface INotificationBusiness
    {
        void SendNotification(string template, string to, string payload);
    }
}