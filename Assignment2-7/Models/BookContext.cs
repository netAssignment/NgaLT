using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Assignment2_7.Models;

namespace Assignment2_7.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base("name=BookConnection") {
            //Cho phep thay doi DB
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BookContext>());
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Comment> Comments { get; set; }


        
    }
}