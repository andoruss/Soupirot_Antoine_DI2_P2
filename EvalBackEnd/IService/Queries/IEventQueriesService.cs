using Entities;

namespace IService.Queries;

public interface IEventQueriesService
{
    Task<IEnumerable<Event>> GetEvents();
}
