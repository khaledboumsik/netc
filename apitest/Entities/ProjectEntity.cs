using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Project
{
    [Key] // This attribute specifies that Id is the primary key
    public int Id { get; set; }

    public string About { get; set; } = string.Empty; // Default initialization to avoid nulls
    public int Degree { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Price { get; set; }
    public string Demo { get; set; } = string.Empty;
    public string Picture { get; set; } = string.Empty;
}