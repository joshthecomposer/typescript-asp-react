using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyApp.Models;

namespace MyApp.Controllers;
[ApiController]
[Route("api")]
public class TestController : Controller
{
    [HttpGet("data")]
    public User GetData()
    {
        return new User
        {
            Name="Meme Jordan",
            Email="mj@gmail.com"
        };
    }
    [HttpGet("moreData")]
    public User GetMoreData()
    {
        return new User
        {
            Name="Ass Cancer",
            Email="ac@gmail.com"
        };
    }
}