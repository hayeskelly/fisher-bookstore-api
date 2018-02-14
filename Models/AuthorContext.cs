using System;
using Microsoft.EntityFrameworkCore;

namespace Fisher.Bookstore.Api.Models
{
    public class AuthorContext : DbContext
    {
        public AuthorContext(DbContextOptions<AuthorContext> options)
            : base(options)
        {
        }   

        public DbSet<Author> Authors {get; set;}
    }
}