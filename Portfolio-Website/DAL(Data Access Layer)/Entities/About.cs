using System;

namespace Portfolio_Website.DAL_Data_Access_Layer_.Entities;

public class About
{
    public int AboutId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string SubDescription { get; set; } = string.Empty;
    public string Details { get; set; } = string.Empty;
}
