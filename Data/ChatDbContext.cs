using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chat.Models;

namespace Chat.Data
{
    public class ChatDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public ChatDbContext(DbContextOptions<ChatDbContext> options) : base (options)
        {
           // Database.EnsureCreated();
        }
    }
}
