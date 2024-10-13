public record class CreateJobDto(string Email, int Phone, int ProjectID, string Information) 
    : JobDto(Email, Phone, ProjectID, Information);
