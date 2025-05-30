using System;

namespace Portfolio_Website.DAL_Data_Access_Layer_.Entities;

public class Message
{
    public int MessageId { get; set; }
    public string NameSurname { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string MessageDetail { get; set; } = string.Empty;
    public DateTime SendMessageDateTime { get; set; }
    public bool IsRead { get; set; }
}
