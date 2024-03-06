using Entities;

namespace IService;

public interface IEventService
{
    Task<Event>? AddEvent(Event eventModel);
    void UpdateEvent(Event body);
}
