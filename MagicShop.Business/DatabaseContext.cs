using MagicShop.Kernel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicShop.Business
{
    public class DatabaseContext : DbContext
    {

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CartItem> CardItems { get; set; }

        public DbSet<Horoscope> Horoscopes { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Contact> Contacts { get; set; }


        public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }
}
