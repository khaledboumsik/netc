using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Job
{
    [Key] // Primary Key
    public int Id { get; set; }

    public string Email { get; set; } = string.Empty;
    public int Phone { get; set; }
    
    // Foreign Key to Project
    public int ProjectID { get; set; }

    // Navigation property to the related Project
    [ForeignKey("ProjectID")]
    public Project? Project { get; set; }

    public string Information { get; set; } = string.Empty;
}