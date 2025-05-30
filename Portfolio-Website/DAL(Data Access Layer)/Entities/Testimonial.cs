using System;

namespace Portfolio_Website.DAL_Data_Access_Layer_.Entities;

public class Testimonial
{
    public int TestimonialId { get; set; }
    public string NameSurname { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
}
