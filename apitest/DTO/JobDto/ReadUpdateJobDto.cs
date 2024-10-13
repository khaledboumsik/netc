public record class ReadUpdateJob(
    int Id, // Id should be passed as a regular property here
    string Email,
    int Phone,
    int ProjectID,
    string Information,
    ProjectDto Project // This will hold the related ProjectDto
) : JobDto(Email, Phone, ProjectID, Information);
