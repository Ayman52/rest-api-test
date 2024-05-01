using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.EF_CORE;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Services
{
    public class UserService
    {
        private readonly AppDbContext _appDbContext;

        public UserService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<User> GetAllUsers()
        {
            return _appDbContext.Users.Include(user => user.Profile).Include(user => user.Orders).ToList();
        }

        public void AddUser(UserModel newUser)
        {
            // first create the record 
            User user = new User
            {
                UserId = newUser.UserId,
                Name = newUser.Name,
                Email = newUser.Email,
                Profile = new Profile
                {
                    ProfileId = newUser.Profile.ProfileId,
                    Bio = newUser.Profile.Bio,
                    UserId = newUser.Profile.UserId
                },
                Orders = [
                    new Order{
                        OrderId = newUser.Orders[0].OrderId,
                        ProductName = newUser.Orders[0].ProductName = newUser.Orders[0].ProductName,
                        UserId = newUser.Orders[0].UserId
                    }
                ]
            };
            // add the record to the context 
            _appDbContext.Users.Add(user);
            // save to the database
            _appDbContext.SaveChanges();
        }

        // public async Task<List<User>> GetAllUsers()
        // {
        //     await Task.CompletedTask;
        //     return _appDbContext.Users.Include(user => user.Profile).Include(user => user.Orders).ToList();
        // }
    }
}