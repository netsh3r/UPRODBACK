using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace UProd.WebApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProjectsController : ControllerBase
{
    [EnableCors("CorsAllowAll")]
    [HttpGet]
    public List<object> List()
    {
        return new List<object>()
        {
            new
            {
                Name = "Тест 3",
                Id = 1,
                Description = "Тест"
            },
            new
            {
                Name = "Тест 2",
                Id = 1,
                Description = "Тест"
            },
            new
            {
                Name = "Тест 1",
                Id = 1,
                Description = "Тест"
            }
        };
    }
}