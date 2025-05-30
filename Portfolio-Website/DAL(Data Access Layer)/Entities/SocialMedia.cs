using System;

namespace Portfolio_Website.DAL_Data_Access_Layer_.Entities;

public class SocialMedia
{
    public int SocialMediaId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
}
