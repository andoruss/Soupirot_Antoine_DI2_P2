using Entities;
using IDAL;
using IService.Queries;

namespace Service.Queries;
public class EventQueriesService : IEventQueriesService
{
    private IEventDAL _dal;
    public EventQueriesService(IEventDAL dal)
    {
        _dal = dal;
    }

    public async Task<IEnumerable<Event>> GetEvents()
    {
        return await _dal.GetEvents();
    }
}