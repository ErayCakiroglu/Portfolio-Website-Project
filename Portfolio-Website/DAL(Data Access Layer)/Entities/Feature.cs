using System;

namespace Portfolio_Website.DAL_Data_Access_Layer_.Entities;

public class Feature
{
    public int FeatureId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
