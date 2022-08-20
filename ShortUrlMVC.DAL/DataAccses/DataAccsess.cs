using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using ShortUrlMVC.DAL.Models;

namespace ShortUrlMVC.DAL.DataAccses
{
    public class DataAccsess : IdentityDbContext<UserEntity, RoleEntity, string>
    {
        public DataAccsess(DbContextOptions<DataAccsess> options) : base(options) { Database.EnsureCreated(); }

        public DbSet<ShortURLEntity> ShortURLs { get; set; }
    }
}
