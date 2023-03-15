using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ModsenTestTask.Models.EventModels;
using ModsenTestTask.Options;
using ModsenTestTask.Services.Interfaces;

namespace ModsenTestTask.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class EventController : ControllerBase
{
    private readonly IEventService _eventService;

    public EventController(IEventService eventService)
    {
        _eventService = eventService;
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAllEvents()
    {
        return Ok(await _eventService.GetAllEventsAsync());
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetEventById(long id)
    {
        if (id == null)
            return BadRequest();
        return Ok(await _eventService.GetEventByIdAsync(id));
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> AddEvent(EventCreateModel model)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _eventService.AddEventAsync(model);
        return Ok();
    }

    [Authorize]
    [HttpPut]
    public async Task<IActionResult> UpdateEvent(EventEditModel model)
    {
        if (!ModelState.IsValid)
            return BadRequest();
        await _eventService.UpdateEventAsync(model);
        return Ok();
    }

    [Authorize]
    [HttpDelete]
    public async Task<IActionResult> DeleteEvent(long id)
    {
        if (id == null)
            return BadRequest();
        await _eventService.DeleteEventByIdAsync(id);
        return Ok();
    }
}