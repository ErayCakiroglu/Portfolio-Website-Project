using System;

namespace Portfolio_Website.DAL_Data_Access_Layer_.Entities;

public class ToDoList
{
    public int ToDoListId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public bool Status { get; set; }
}
