using Entities;

namespace IDAL;

public interface IEventDAL
{
    Task<Event>? AddEvent(Event evenement);
    Task<IEnumerable<Event>> GetEvents();
    void UpdateEvent(Event body);
    void DeleteEvent(Event body);
}