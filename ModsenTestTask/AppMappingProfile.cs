using AutoMapper;
using ModsenTestTask.Data.Entities;
using ModsenTestTask.Models.EventModels;

namespace ModsenTestTask;

public class AppMappingProfile : Profile
{
    public AppMappingProfile()
    {			
        CreateMap<Event, EventCreateModel>().ReverseMap();
        CreateMap<Event, EventViewModel>().ReverseMap();
        CreateMap<Event, EventEditModel>().ReverseMap();
    }
}