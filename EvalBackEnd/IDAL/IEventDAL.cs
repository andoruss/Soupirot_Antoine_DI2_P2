using Entities;

namespace IDAL;

public interface IEventDAL
{
    Task<Event>? AddEvent(Event evenement);
}