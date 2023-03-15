using ModsenTestTask.Models.EventModels;

namespace ModsenTestTask.Services.Interfaces;

public interface IEventService
{
    public Task AddEventAsync(EventCreateModel model);

    public Task UpdateEventAsync(EventEditModel model);

    public Task DeleteEventByIdAsync(long id);

    public Task<EventViewModel> GetEventByIdAsync(long id);

    public Task<List<EventViewModel>> GetAllEventsAsync();
}