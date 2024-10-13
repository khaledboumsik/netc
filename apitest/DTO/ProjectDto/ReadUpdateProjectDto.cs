public record class ReadUpdateProjectDto(
    int Id,
    string About,
    int Degree,
    string Name,
    int Price,
    string Demo,
    string Picture
) : ProjectDto(About, Degree, Name, Price, Demo, Picture);