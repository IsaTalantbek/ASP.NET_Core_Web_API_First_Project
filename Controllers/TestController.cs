using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using API_Project.DTOs;
using API_Project.Entities;
using API_Project.Filters;
using API_Project.Services;

[ApiController]
[Route("User")]
[ServiceFilter<LoggingFilter>]
public class UserController : ControllerBase
{
    private UsersService _service;

    public UserController(UsersService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<User>>> GetUsers()
    {
        var result = await _service.GetUsers();
        return result;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser([FromRoute, Required] long id)
    {
        User? user = await _service.GetUser(id);
        if (user == null)
        {
            return NotFound(id);
        }
        return user;
    }

    [HttpPost]
    public async Task<ActionResult<long>> CreateUser([FromBody, Required] UserDTO userDTO)
    {
        User result = await _service.CreateUser(userDTO);
        return CreatedAtAction(nameof(GetUser), new { id = result.Id }, result);
    }
}