using Entities;
using IDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL;

public class EventDAL : IEventDAL
{
    private AzureDbContext _context;

    public EventDAL(AzureDbContext context)
    {
        _context = context;
    }

    public async Task<Event>? AddEvent(Event evenement)
    {
        var creation =  await _context.Events.AddAsync(evenement);
        if(creation != null)
        {
            return creation.Entity;
        }
        else
        {
            return null;
        }
    }

    public async Task<IEnumerable<Event>> GetEvents()
    {
         return await _context.Events.ToListAsync();
    }

    public void UpdateEvent(Event body)
    {
       _context.Events.Update(body);
       _context.SaveChanges();
    }
    public void DeleteEvent(Event body)
    {
        _context.Events.Remove(body);
        _context.SaveChanges();
    }
}
