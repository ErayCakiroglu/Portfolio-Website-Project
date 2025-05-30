using System;

namespace Portfolio_Website.DAL_Data_Access_Layer_.Entities;

public class Contact
{
    public int ContactId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string HomePhoneNumber { get; set; } = string.Empty;
    public string MobilePhoneNumber { get; set; } = string.Empty;
    public string PersonalEmail { get; set; } = string.Empty;
    public string WorkEmail { get; set; } = string.Empty;
}
