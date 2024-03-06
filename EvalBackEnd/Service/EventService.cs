using Entities;
using IDAL;
using IService;

namespace Service;

public class EventService : IEventService
{
    private IEventDAL _dal ;
    public EventService(IEventDAL dal)
    {
        _dal = dal;
    }

    public Task<Event>? AddEvent(Event eventModel)
    {
        var response = _dal.AddEvent(eventModel);

        return response;
    }

    public void UpdateEvent(Event body)
    {
        _dal.UpdateEvent(body);
    }
}
