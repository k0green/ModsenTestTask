using ModsenTestTask.Models.EventModels;

namespace ModsenTestTask.Services.Interfaces;

public interface IEventService
{
    public Task AddEventAsync(EventCreateModel model);

    public Task UpdateEventAsync(EventEditModel model);

    public Task DeleteEventByIdAsync(string id);

    public Task<EventViewModel> GetEventByIdAsync(string id);

    public Task<List<EventViewModel>> GetAllEventsAsync();
}