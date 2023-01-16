using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using UProd.Services.Projects;

namespace UProd.WebApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProjectsController : ControllerBase
{
    private readonly ProjectService projectService;

    public ProjectsController(ProjectService _projectService)
    {
        projectService = _projectService;
    }
    
    [HttpGet]
    public List<object> List()
    {
        var s = projectService.GetMessage();
        return new List<object>()
        {
            new
            {
                Name = "Тест 3",
                Id = 1,
                Description = s
            },
            new
            {
                Name = "Тест 2",
                Id = 2,
                Description = "Тест"
            },
            new
            {
                Name = "Тест 1",
                Id = 3,
                Description = "Тест"
            }
        };
    }
}