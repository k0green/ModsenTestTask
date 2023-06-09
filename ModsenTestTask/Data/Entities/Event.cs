﻿using System.ComponentModel.DataAnnotations;

namespace ModsenTestTask.Data.Entities;

public class Event : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Plan { get; set; }
    public string Organizer { get; set; }
    public string Speaker { get; set; }
    public DateTime Date { get; set; }
    public string Place { get; set; }
}