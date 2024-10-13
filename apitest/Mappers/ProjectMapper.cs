public static class ProjectMapper
{
    // From Create DTO to Project Entity
    public static Project ToProject(this CreateProjectDto dto)
    {
        return new Project
        {
            About = dto.About,
            Degree = dto.Degree,
            Name = dto.Name,
            Price = dto.Price,
            Demo = dto.Demo,
            Picture = dto.Picture
        };
    }

    // From Project Entity to Read DTO
    public static ReadUpdateProjectDto ToReadUpdateProjectDto(this Project project)
    {
        return new ReadUpdateProjectDto(
            project.Id,
            project.About,
            project.Degree,
            project.Name,
            project.Price,
            project.Demo,
            project.Picture
        );
    }
     public static CreateProjectDto ToCreateProjectDto(this Project project)
    {
        return new CreateProjectDto(
            project.About,
            project.Degree,
            project.Name,
            project.Price,
            project.Demo,
            project.Picture
        );
    }
}
