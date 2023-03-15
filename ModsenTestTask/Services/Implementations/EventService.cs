using AutoMapper;
using ModsenTestTask.Data.Entities;
using ModsenTestTask.Models.EventModels;
using ModsenTestTask.Repositories.Interfaces;
using ModsenTestTask.Services.Interfaces;

namespace ModsenTestTask.Services.Implementations;

public class EventService : IEventService
{
    private readonly IEventRepository _eventRepository;
    private readonly IMapper _mapper;

    public EventService(IEventRepository eventRepository,
        IMapper mapper)
    {
        _eventRepository = eventRepository;
        _mapper = mapper;
    }

    public async Task AddEventAsync(EventCreateModel model)
    {
        var eventEntity = _mapper.Map<Event>(model);
        await _eventRepository.AddAsync(eventEntity);
    }

    public async Task UpdateEventAsync(EventEditModel model)
    {
        var eventEntity = _mapper.Map<Event>(model);
        await _eventRepository.UpdateAsync(eventEntity);
    }

    public async Task DeleteEventByIdAsync(long id)
        => await _eventRepository.DeleteByIdAsync(id);

    public async Task<EventViewModel> GetEventByIdAsync(long id)
        => _mapper.Map<EventViewModel>(await _eventRepository.GetByIdAsync(id));

    public async Task<List<EventViewModel>> GetAllEventsAsync()
        => _mapper.Map<List<EventViewModel>>(await _eventRepository.GetAllAsync());
}