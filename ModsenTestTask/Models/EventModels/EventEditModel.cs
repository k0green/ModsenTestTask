using System.ComponentModel.DataAnnotations;

namespace ModsenTestTask.Models.EventModels;

public class EventEditModel
{
    [Required(ErrorMessage = "Id must be filled")]
    public long Id { get; set; }

    [Required(ErrorMessage = "Name must be filled")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "String length must be from 1 to 50 symbols")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Description must be filled")]
    [StringLength(500, MinimumLength = 1, ErrorMessage = "String length must be from 1 to 500 symbols")]
    public string Description { get; set; }

    [Required(ErrorMessage = "Plan must be filled")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "String length must be from 1 to 100 symbols")]
    public string Plan { get; set; }

    [Required(ErrorMessage = "Organizer must be filled")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "String length must be from 1 to 50 symbols")]
    public string Organizer { get; set; }

    [Required(ErrorMessage = "Speaker must be filled")]
    [StringLength(50, MinimumLength = 1, ErrorMessage = "String length must be from 1 to 50 symbols")]
    public string Speaker { get; set; }

    [Required(ErrorMessage = "Date must be filled")]
    [DataType(DataType.DateTime)]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Place must be filled")]
    [StringLength(100, MinimumLength = 1, ErrorMessage = "String length must be from 1 to 100 symbols")]
    public string Place { get; set; }
}