using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using diego_aranda_api.Models;
namespace diego_aranda_api.Controllers;

[Route("[controller]")]
[ApiController]
public class UsersController: ControllerBase
{
    private DataContext dataContext;

    public UsersController(DataContext context)
    {
        dataContext = context;
    }

    [HttpGet(Name = "GetUsers")]
    public IEnumerable<Models.Users> Get()
    {
        return dataContext.Users.ToList();
    }
}
