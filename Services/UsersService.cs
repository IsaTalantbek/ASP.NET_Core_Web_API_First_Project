using Microsoft.EntityFrameworkCore;
using API_Project.Data;
using API_Project.DTOs;
using API_Project.Entities;

namespace API_Project.Services;

public class UsersService
{
    private ProjectDbContext _dbContext;

    public UsersService(ProjectDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<User>> GetUsers()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task<User?> GetUser(long id)
    {
        return await _dbContext.Users.FindAsync(id);
    }

    public async Task<User> CreateUser(UserDTO userDTO)
    {
        var user = new User(userDTO.Name);
        var result = await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }
}