namespace TicketSystemApp_P113.Core
{
    public interface ISession
    {
        bool Clear<T>(string key);
        T Get<T>(string key);
        void Set<T>(string key, T value);
    }
}