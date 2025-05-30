using System;

namespace Portfolio_Website.DAL_Data_Access_Layer_.Entities;

public class Portfolio
{
    public int PortfolioId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string SubTitle { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public string ImageDescription { get; set; } = string.Empty;
}
