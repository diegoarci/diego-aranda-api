using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using diego_aranda_api.Models;
namespace diego_aranda_api.Controllers;

[Route("[controller]")]
[ApiController]
public class RolesController: ControllerBase
{
    private DataContext dataContext;

    public RolesController(DataContext context)
    {
        dataContext = context;
    }

    [HttpGet(Name = "GetRoles")]
    public IEnumerable<Models.Roles> Get()
    {
        return dataContext.Roles.ToList();
    }
}
