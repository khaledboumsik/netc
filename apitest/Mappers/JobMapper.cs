public static class JobMapper
{
    // From Create DTO to Job Entity
    public static Job ToJob(this CreateJobDto dto)
    {
        return new Job
        {
            Email = dto.Email,
            Phone = dto.Phone,
            ProjectID = dto.ProjectID,
            Information = dto.Information
        };
    }

    // From Job Entity to Read DTO
   public static ReadUpdateJob ToReadDto(this Job job)
{
    return new ReadUpdateJob(
        job.Id, // Map the Id
        job.Email, 
        job.Phone, 
        job.ProjectID, 
        job.Information, 
        job.Project != null ? ProjectMapper.ToReadUpdateProjectDto(job.Project) : null // Safely map the related project
    );
}
}
