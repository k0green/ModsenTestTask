using ModsenTestTask.Data;
using ModsenTestTask.Data.Entities;
using ModsenTestTask.Repositories.Interfaces;

namespace ModsenTestTask.Repositories.Implementations;

public class EventRepository : BaseRepository<Event>, IEventRepository
{
    public EventRepository(ApplicationDbContext context) : base(context)
    {
    }
}