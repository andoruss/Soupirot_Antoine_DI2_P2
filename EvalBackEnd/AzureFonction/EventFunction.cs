using System.Net;
using Entities;
using IService;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Service;

namespace AzureFonction
{
    public class EventFunction
    {

        private readonly IEventService _service;

        public EventFunction(IEventService service)
        {
           _service = service;
        }

        [Function("AddEvent")]
        public async Task<Event> AddEvent([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
        {
            try
            {
                var reqBody = await req.ReadFromJsonAsync<Event>();

                var response = await _service.AddEvent(reqBody);

                return response;
            }
            catch (Exception)
            {
                return default;
            }
            
        }

        [Function("GetEvents")]
        public async Task<IEnumerable<Event>> GetEvents([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req)
        {
            try
            {
                var reqBody = await req.ReadFromJsonAsync<Event>();

                return await _service.GetEvents();
            }
            catch (Exception)
            {
                return default;
            }
        }
    }
}
