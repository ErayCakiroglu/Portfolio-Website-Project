using System;
using System.ComponentModel.DataAnnotations;

namespace Portfolio_Website.DAL_Data_Access_Layer_.Entities;

public class Experience
{
    [Key]
    public int ExperienceId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Head { get; set; } = string.Empty;
    public string Date { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
